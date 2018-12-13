using FilmShare.Models.DataAccessLayer;
using FilmShare.Models.Entities;
using FilmShare.ViewModels;
using FilmShare.ViewModels.Account;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FilmShare.Models.Storage.EntityFramework
{
    public class EntityFrameworkStorage : IStorage
    {
        private readonly AppDbContext context;

        public EntityFrameworkStorage(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<User> Users => context.Users;
        public IQueryable<Profile> Profiles => context.Profiles;
        public IQueryable<Permission> Permissions => context.Permissions;
        public IQueryable<Relationship> Relationships => context.Relationships;

        public IQueryable<Actor> Actors => context.Actors;
        public IQueryable<Film> Films => context.Films;
        public IQueryable<Rank> Ranks => context.Ranks;
        public IQueryable<Review> Reviews => context.Reviews;

        public IQueryable<ActorsInFilm> ActorsInFilms => context.ActorsInFilms;
        public IQueryable<UserPermission> UserPermissions => context.UserPermissions;
        public IQueryable<UserRelationships> UserRelationships => context.UserRelationships;

        private string EncryptPassword(string password)
        {
            using (var sha512 = new SHA512Managed())
            {
                var utf8 = new UTF8Encoding();
                var data = sha512.ComputeHash(utf8.GetBytes(password));
                return Convert.ToBase64String(data);
            }
        }

        public bool IsUserAutenticationInfoCorrect(string login, string password)
        {
            var encryptedPassword = EncryptPassword(password);
            return context.Users.FirstOrDefault(u => (u.Email == login || u.Login == login) && u.Password == encryptedPassword) != null;
        }

        public bool UserExists(string login, string email)
        {
            return context.Users.FirstOrDefault(u => u.Email == email || u.Login == login) != null;
        }

        public void AddUser(RegisterModel newUser)
        {
            var encryptedPassword = EncryptPassword(newUser.Password);
            var user = new User { Email = newUser.Email, Login = newUser.Login, Password = encryptedPassword };
            context.Users.Add(user);

            // Create user profile
            var profile = new Profile() { Name = user.Login, UserId = user.UserId, User = user, DateOfBirth = newUser.DateOfBirth };
            context.Profiles.Add(profile);

            context.SaveChanges();
        }

        public ProfileModel GetProfileModelByEmailOrLogin(string userName)
        {
            var user = Users.FirstOrDefault(u => u.Login == userName || u.Email == userName);
            if (user == null) return null;

            var profile = Profiles.FirstOrDefault(p => p.UserId == user.UserId);

            return new ProfileModel(profile, user.Email);
        }

        public ProfileModel GetProfileModelById(int profileId)
        {
            var profile = Profiles.FirstOrDefault(p => p.ProfileId == profileId);
            if (profile == null) return null;

            var user = Users.FirstOrDefault(u => u.UserId == profile.UserId);

            return new ProfileModel(profile, user.Email);
        }


        public async Task<ProfileModel> UpdateProfilePhoto(string userName, IFormFile photo)
        {
            var profile = GetProfile(userName);
            if (profile == null) return null;

            var user = Users.FirstOrDefault(u => u.Login == userName || u.Email == userName);

            if (photo == null || photo.Length <= 0) return new ProfileModel(profile, user.Email);

            using (var stream = new MemoryStream())
            {
                await photo.CopyToAsync(stream);
                profile.Photo = stream.ToArray();
            }

            context.Profiles.Update(profile);

            context.SaveChanges();

            return new ProfileModel(profile, user.Email);
        }

        public (string photoPath, string name) GetCurrentUserInfo(string userName)
        {
            var profileModel = GetProfileModel(userName);
            if (profileModel == null) return (photoPath: "", name: "");

            return (photoPath: profileModel.PhotoPath, name: profileModel.Name);
        }

        public Profile GetProfile(string userName)
        {
            var user = Users.FirstOrDefault(u => u.Login == userName || u.Email == userName);
            if (user == null) return null;

            var profile = context.Profiles.FirstOrDefault(pr => pr.UserId == user.UserId);

            return profile;
        }

        public ProfileModel GetProfileModel(string userName)
        {
            var profile = GetProfile(userName);
            var user = Users.FirstOrDefault(u => u.Login == userName || u.Email == userName);

            if (profile == null) { return null; }

            var profileModel = new ProfileModel(profile, user.Email);

            return profileModel;
        }

        public void UpdateProfile(string userName, ProfileModel newProfile)
        {
            var profile = GetProfile(userName);
            if (profile == null) return;

            var user = Users.FirstOrDefault(u => u.Login == userName || u.Email == userName);

            profile.DateOfBirth = newProfile.DateOfBirth;
            profile.Name = newProfile.Name;
            user.Email = newProfile.Email;

            context.Profiles.Update(profile);
            context.Users.Update(user);
            context.SaveChanges();
        }

        private List<User> GetUserFriends(string userName)
        {
            var user = Users.FirstOrDefault(u => u.Login == userName || u.Email == userName);

            if (user == null) return null;

            var friends = context.UserRelationships.Where(ur => ur.RelationshipId == 1 && ur.DependentUserId == user.UserId).Select(ur => ur.MainUser).ToList();
            friends.AddRange(context.UserRelationships.Where(ur => ur.RelationshipId == 1 && ur.MainUserId == user.UserId).Select(ur => ur.DependentUser).ToList());

            return friends;
        }

        public List<ProfileModel> GetUserFriendsProfiles(string userName)
        {
            var friends = GetUserFriends(userName);

            var friendsProfiles = new List<ProfileModel>();
            foreach (var friend in friends)
            {
                var friendProfile = context.Profiles.FirstOrDefault(pr => pr.UserId == friend.UserId);

                if (friendProfile != null)
                    friendsProfiles.Add(new ProfileModel(friendProfile, friend.Email));
            }

            return friendsProfiles;

        }

        public List<ProfileModel> GetAllProfileModelsWithoutFriends(string userName)
        {
            var friends = GetUserFriends(userName);
            var users = context.Users.Where(u => !(u.Login == userName || u.Email == userName) && !(friends.Contains(u)));

            var profiles = new List<ProfileModel>();
            foreach (var user in users)
            {
                var profile = context.Profiles.FirstOrDefault(pr => pr.UserId == user.UserId);

                if (profile != null)
                    profiles.Add(new ProfileModel(profile, user.Email));
            }

            return profiles;

        }

        public bool AddFriend(string userName, int friendUserId)
        {
            if (!context.Users.Select(u => u.UserId).Contains(friendUserId)) return false;

            try
            {
                var user = Users.FirstOrDefault(u => u.Login == userName || u.Email == userName);
                if (user == null) return false;

                context.UserRelationships.Add(new UserRelationships() { RelationshipId = 1, MainUserId = user.UserId, DependentUserId = friendUserId });
                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveFriend(string userName, int friendUserId)
        {
            if (!context.Users.Select(u => u.UserId).Contains(friendUserId)) return false;

            try
            {
                var user = Users.FirstOrDefault(u => u.Login == userName || u.Email == userName);
                if (user == null) return false;

                var userRelationship = context.UserRelationships.FirstOrDefault(ur => ur.RelationshipId == 1 &&
                (ur.MainUserId == user.UserId && ur.DependentUserId == friendUserId) || (ur.DependentUserId == user.UserId && ur.MainUserId == friendUserId));

                if (userRelationship == null) return false; 
                
                context.UserRelationships.Remove(userRelationship);
                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<ProfileModel> GetProfileModelsWithoutFriendsWithFilter(string userName, string filter)
        {
            var friends = GetUserFriends(userName);
            var users = context.Users.Where(u => !(u.Login == userName || u.Email == userName) && !(friends.Contains(u)));
            
            var profiles = new List<ProfileModel>();
            foreach (var user in users)
            {
                var profile = context.Profiles.FirstOrDefault(pr => pr.UserId == user.UserId && pr.Name.StartsWith(filter));

                if (profile != null)
                    profiles.Add(new ProfileModel(profile, user.Email));
            }

            return profiles;
        }

        public bool IsUserAdmin(string userName)
        {
            var user = Users.FirstOrDefault(u => u.Login == userName || u.Email == userName);
            if (user == null) return false;

            var permission = context.UserPermissions.FirstOrDefault(up => up.UserId == user.UserId);

            return permission != null ? true : false;
        }

        public bool IsUserAdmin(int userId)
        {
            var user = Users.FirstOrDefault(u => u.UserId == userId);
            if (user == null) return false;

            var permission = context.UserPermissions.FirstOrDefault(up => up.UserId == user.UserId);

            return permission != null ? true : false;
        }

        public List<ProfileModel> GetAllProfiles()
        {
            var profiles = new List<ProfileModel>();
            foreach (var user in Users)
            {
                var profile = context.Profiles.FirstOrDefault(pr => pr.UserId == user.UserId);

                if (profile != null)
                    profiles.Add(new ProfileModel(profile, user.Email));
            }

            return profiles;
        }

        public List<ProfileModel> GetAllProfilesWithoutCurrentUser(string userName)
        {
            var users = context.Users.Where(u => !(u.Login == userName || u.Email == userName));

            var profiles = new List<ProfileModel>();
            foreach (var user in users)
            {
                var profile = context.Profiles.FirstOrDefault(pr => pr.UserId == user.UserId);

                if (profile != null)
                    profiles.Add(new ProfileModel(profile, user.Email));
            }

            return profiles;
        }

        public List<ProfileModel> GetAllProfilesWithFilter(string filter)
        {
            var profiles = new List<ProfileModel>();
            foreach (var user in Users)
            {
                var profile = context.Profiles.FirstOrDefault(pr => pr.UserId == user.UserId && pr.Name.StartsWith(filter));

                if (profile != null)
                    profiles.Add(new ProfileModel(profile, user.Email));
            }

            return profiles;
        }

        public List<ProfileModel> GetAllProfilesWithoutCurrentUserWithFilter(string userName, string filter)
        {
            var users = context.Users.Where(u => !(u.Login == userName || u.Email == userName));

            var profiles = new List<ProfileModel>();
            foreach (var user in users)
            {
                var profile = context.Profiles.FirstOrDefault(pr => pr.UserId == user.UserId && pr.Name.StartsWith(filter));

                if (profile != null)
                    profiles.Add(new ProfileModel(profile, user.Email));
            }

            return profiles;
        }

        public List<FilmModel> GetAllFilms()
        {
            var films = new List<FilmModel>();
            foreach (var film in context.Films)
            {
                films.Add(new FilmModel(film));
            }
            return films;
        }


        public List<FilmModel> GetAllFilmsWithFilter(string filter)
        {

            var films = new List<FilmModel>();
            foreach (var film in context.Films.Where(f => f.FilmName.StartsWith(filter)))
            {
                films.Add(new FilmModel(film));
            }
            return films;
        }

        public void CreateFilm(FilmModel filmModel, IFormFile poster)
        {
            var image = GetImageFromFile(poster);
            var film = new Film() { FilmName = filmModel.FilmName, Year = filmModel.Year, Country = filmModel.Country, Poster = image };

            context.Films.Add(film);
            context.SaveChanges();
        }

        public void UpdateFilm(FilmModel filmModel, IFormFile poster)
        {        
            var film = Films.FirstOrDefault(f => f.FilmId == filmModel.FilmId);

            if (film == null) return;

            film.FilmName = filmModel.FilmName;
            film.Country = filmModel.Country;
            film.Year = filmModel.Year;

            if (poster != null)
            {
                var image = GetImageFromFile(poster);
                film.Poster = image;
            }

            context.Films.Update(film);
            context.SaveChanges();
        }

        public bool DeleteFilm(int filmId)
        {
            var film = Films.FirstOrDefault(f => f.FilmId == filmId);

            if (film == null) return false;

            context.Films.Remove(film);
            context.SaveChanges();

            return true;
        }

        public FilmModel GetFilmById(int filmId)
        {
            var film = context.Films.FirstOrDefault(f => f.FilmId == filmId);
            if (film == null) return null;

            return new FilmModel(film);
        }

        private byte[] GetImageFromFile(IFormFile image)
        {
            if (image == null || image.Length <= 0) return null;

            using (var stream = new MemoryStream())
            {
                image.CopyTo(stream);
                return stream.ToArray();
            }
        }

        public List<ActorModel> GetAllActors()
        {
            var actors = new List<ActorModel>();
            foreach (var actor in Actors)
            {
                actors.Add(new ActorModel(actor));
            }
            return actors;
        }

        public List<ActorModel> GetAllActorsWithFilter(string filter)
        {
            var actors = new List<ActorModel>();
            foreach (var actor in Actors.Where(a => a.ActorName.StartsWith(filter)))
            {
                actors.Add(new ActorModel(actor));
            }
            return actors;
        }

        public void CreateActor(ActorModel actorModel, IFormFile poster)
        {
            var image = GetImageFromFile(poster);
            var actor = new Actor() { ActorName = actorModel.Name, DateOfBirth = actorModel.DateOfBirth, Photo = image };

            context.Actors.Add(actor);
            context.SaveChanges();
        }

        public bool DeleteActor(int actorId)
        {
            var actor = Actors.FirstOrDefault(a => a.ActorId == actorId);

            if (actor == null) return false;

            context.Actors.Remove(actor);
            context.SaveChanges();

            return true;
        }

        public List<FilmReviewViewModel> GetFilmReviews(int filmId)
        {
            var reviews = context.Reviews.Where(r => r.FilmId == filmId).OrderByDescending(r => r.ReviewDate);

            var reviewsViewModels = new List<FilmReviewViewModel>();
            foreach (var review in reviews)
            {
                var profile = context.Profiles.FirstOrDefault(p => p.UserId == review.UserId);
                if (profile == null) continue;

                var reviewViewModel = new FilmReviewViewModel(review, new ProfileModel(profile));
                reviewsViewModels.Add(reviewViewModel);
            }

            return reviewsViewModels;
        }

        public bool CheckIfUsersAreFriends(string userName, int userId)
        {
            var user = context.Users.FirstOrDefault(u => u.Login == userName || u.Email == userName);
            if (user == null) return false;

            var usersRelationship = context.UserRelationships.FirstOrDefault(ur => ((ur.MainUserId == user.UserId && ur.DependentUserId == userId)
           || (ur.DependentUserId == user.UserId && ur.MainUserId == userId)) && ur.RelationshipId == 1);

            return usersRelationship == null ? false : true;

        }

        public (bool success, FilmReviewViewModel review, float rating) AddReview(string userName, int filmId, int rating, string text)
        {
            try
            {
                var user = context.Users.FirstOrDefault(u => u.Login == userName || u.Email == userName);

                var review = new Review() { FilmId = filmId, Rating = rating, Text = text, UserId = user.UserId, ReviewDate=DateTime.Now };
                var profile = GetProfileModel(userName);
                if (profile == null) return (false, null, 0);

                var reviewViewModel = new FilmReviewViewModel(review, profile);

                var avgRating = CreateNewRank(filmId, rating, user.UserId);

                context.Reviews.Add(review);
                context.SaveChanges();

                return (true, reviewViewModel, avgRating);
            }
            catch
            {
                return (false, null, 0);
            }
        }

        private float CreateNewRank(int filmId, int rating, int userId)
        {
            var film = Films.FirstOrDefault(f => f.FilmId == filmId);
            if (film == null) return 0;

            var rank = new Rank() { FilmId = filmId, Rating = rating, UserId = userId };
            context.Ranks.Add(rank);
            context.SaveChanges();

            var filmRanks = Ranks.Where(r => r.FilmId == filmId).Select(r => r.Rating);

            film.AverageRank = filmRanks.Average();
            context.Films.Update(film);

            return film.AverageRank;
        }

        public int GetUserId(string userName)
        {
            var user = context.Users.FirstOrDefault(u => u.Login == userName || u.Email == userName);
            return user == null ? 0 : user.UserId;
        }

        public List<UserReviewViewModel> GetUserReviews(int userId)
        {
            var reviews = context.Reviews.Where(r => r.UserId == userId).OrderByDescending(r => r.ReviewDate);

            var reviewsViewModels = new List<UserReviewViewModel>();
            foreach (var review in reviews)
            {
                var film = context.Films.FirstOrDefault(f => f.FilmId == review.FilmId);
                if (film == null) continue;

                var reviewViewModel = new UserReviewViewModel(review, new FilmModel(film));
                reviewsViewModels.Add(reviewViewModel);
            }

            return reviewsViewModels;
        }

        public List<ActorModel> GetAllActorModels()
        {
            return context.Actors.Select(a => new ActorModel(a)).ToList();
        }

        public List<ActorModel> GetActorsInFilm(int filmId)
        {
            var actorsInFilmIds = context.ActorsInFilms.Where(af => af.FilmId == filmId).Select(af => af.ActorId);
            var actorsInFilm = context.Actors.Where(a => actorsInFilmIds.Contains(a.ActorId));
            
            var actorsInFilmModels = new List<ActorModel>();
            foreach (var actor in actorsInFilm)
            {
                actorsInFilmModels.Add(new ActorModel(actor) { IsInCurrentFilm = true });
            }

            return actorsInFilmModels;
        }

        public List<ActorModel> GetAllActorModelsForFilm(int filmId)
        {
            var actorsInFilm = GetActorsInFilm(filmId);
            var actorsInFilmIds = actorsInFilm.Select(a => a.ActorId);

            var actors = context.Actors.Where(a => !actorsInFilmIds.Contains(a.ActorId)).Select(a => new ActorModel(a)).ToList();

            actors.AddRange(actorsInFilm);

            return actors;
        }

        public List<ActorModel> GetNotInFilmActorsModels(int filmId)
        {
            var actorsInFilm = GetActorsInFilm(filmId);
            var actorsInFilmIds = actorsInFilm.Select(a => a.ActorId);

            var actors = context.Actors.Where(a => !actorsInFilmIds.Contains(a.ActorId)).Select(a => new ActorModel(a)).ToList();
            

            return actors;
        }

        public ActorModel GetActorById(int actorId)
        {
            var actor = context.Actors.FirstOrDefault(a => a.ActorId == actorId);
            if (actor == null) return null;

            return new ActorModel(actor);
        }

        public void UpdateActor(ActorModel actorModel, IFormFile poster)
        {
            var actor = context.Actors.FirstOrDefault(a => a.ActorId == actorModel.ActorId);
            if (actor == null) return;

            actor.ActorName = actorModel.Name;
            actor.DateOfBirth = actorModel.DateOfBirth;

            if (poster != null)
            {
                var image = GetImageFromFile(poster);
                actor.Photo = image;
            }

            context.Actors.Update(actor);
            context.SaveChanges();
        }

        public (bool success, RoleModel role) AddActorToFilm(int actorId, int filmId, string role)
        {
            var film = Films.FirstOrDefault(f => filmId == f.FilmId);
            var actor = Actors.FirstOrDefault(a => actorId == a.ActorId);
            var actorInFilm = ActorsInFilms.FirstOrDefault(af => af.ActorId == actorId && af.FilmId == filmId);

            if (film == null || actor == null || actorInFilm != null) return (success: false, role: null);

            if (role == null) role = "No information";
            actorInFilm = new ActorsInFilm() { FilmId = filmId, ActorId = actorId, Role = role };

            context.ActorsInFilms.Add(actorInFilm);
            context.SaveChanges();

            return (success: true, role: new RoleModel(new FilmModel(film), new ActorModel(actor), role));
        }

        public (bool success, RoleModel role) ChangeActorRole(int actorId, int filmId, string role)
        {
            var film = Films.FirstOrDefault(f => filmId == f.FilmId);
            var actor = Actors.FirstOrDefault(a => actorId == a.ActorId);
            var actorInFilm = ActorsInFilms.FirstOrDefault(af => af.ActorId == actorId && af.FilmId == filmId);

            if (film == null || actor == null || actorInFilm == null) return (success: false, role: null);

            if (role == null) role = "No information";
            actorInFilm.Role = role;

            context.ActorsInFilms.Update(actorInFilm);
            context.SaveChanges();

            return (success: true, role: new RoleModel(new FilmModel(film), new ActorModel(actor), role));
        }

        public bool RemoveActorFromFilm(int actorId, int filmId)
        {
            var actorInFilm = ActorsInFilms.FirstOrDefault(af => af.ActorId == actorId && af.FilmId == filmId);

            if (actorInFilm == null) return false;

            context.ActorsInFilms.Remove(actorInFilm);
            context.SaveChanges();

            return true;
        }

        public List<FilmModel> GetFilmsActorIsIn(int actorId)
        {
            var films = ActorsInFilms.Where(af => af.ActorId == actorId).Select(af => af.Film);

            var filmModels = new List<FilmModel>();
            foreach (var film in films)
            {
                filmModels.Add(new FilmModel(film));
            }
            return filmModels;
        }

        public List<RoleModel> GetActorRoles(int actorId)
        {
            var actor = GetActorById(actorId);
            if (actor == null) return null;

            var rolesInFilms = ActorsInFilms.Where(af => af.ActorId == actorId).Select(af => new { af.Film, af.Role });

            var roleModels = new List<RoleModel>();
            foreach (var roleInFilm in rolesInFilms)
            {
                var filmModel = new FilmModel(roleInFilm.Film);
                roleModels.Add(new RoleModel(filmModel, actor, roleInFilm.Role));
            }
            return roleModels;
        }

        public List<RoleModel> GetFilmRoles(int filmId)
        {
            var film = GetFilmById(filmId);
            if (film == null) return null;

            var rolesInFilms = ActorsInFilms.Where(af => af.FilmId == filmId).Select(af => new { af.Actor, af.Role });

            var roleModels = new List<RoleModel>();
            foreach (var roleInFilm in rolesInFilms)
            {
                var actorModel = new ActorModel(roleInFilm.Actor);
                roleModels.Add(new RoleModel(film, actorModel, roleInFilm.Role));
            }
            return roleModels;
        }

        public bool GiveAdminPermission(int userId, int permissionId)
        {
            try
            {
                var adminPermission = new UserPermission() { UserId = userId, PermissionId = permissionId };
                context.UserPermissions.Add(adminPermission);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveAdminPermission(int userId, int permissionId)
        {
            try
            {
                var adminPermission = UserPermissions.FirstOrDefault(up => up.UserId == userId && up.PermissionId == permissionId);
                if (adminPermission == null) return false;

                context.UserPermissions.Remove(adminPermission);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
