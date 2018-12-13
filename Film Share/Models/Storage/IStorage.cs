using FilmShare.Models.Entities;
using FilmShare.ViewModels;
using FilmShare.ViewModels.Account;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmShare.Models.Storage
{
    public interface IStorage
    {
        IQueryable<User> Users { get; }
        IQueryable<Profile> Profiles { get; }
        IQueryable<Permission> Permissions { get; }
        IQueryable<Relationship> Relationships { get; }

        IQueryable<Actor> Actors { get; }
        IQueryable<Film> Films { get; }
        IQueryable<Rank> Ranks { get; }
        IQueryable<Review> Reviews { get; }

        IQueryable<ActorsInFilm> ActorsInFilms { get; }
        IQueryable<UserPermission> UserPermissions { get; }
        IQueryable<UserRelationships> UserRelationships { get; }

        bool IsUserAutenticationInfoCorrect(string login, string password);
        bool UserExists(string login, string email);
        void AddUser(RegisterModel newUser);
        bool IsUserAdmin(string userName);
        bool IsUserAdmin(int userId);
        int GetUserId(string userName);

        ProfileModel GetProfileModelByEmailOrLogin(string userName);
        ProfileModel GetProfileModelById(int profileId);
        Task<ProfileModel> UpdateProfilePhoto(string userName, IFormFile photo);

        (string photoPath, string name) GetCurrentUserInfo(string userName);
        ProfileModel GetProfileModel(string userName);

        void UpdateProfile(string userName, ProfileModel newProfile);
        List<ProfileModel> GetUserFriendsProfiles(string userName);
        List<ProfileModel> GetAllProfileModelsWithoutFriends(string userName);
        List<ProfileModel> GetProfileModelsWithoutFriendsWithFilter(string userName, string filter);
        List<ProfileModel> GetAllProfiles();
        List<ProfileModel> GetAllProfilesWithoutCurrentUser(string userName);
        List<ProfileModel> GetAllProfilesWithFilter(string filter);
        List<ProfileModel> GetAllProfilesWithoutCurrentUserWithFilter(string userName, string filter);

        List<FilmModel> GetAllFilms();
        List<FilmModel> GetAllFilmsWithFilter(string filter);
        void CreateFilm(FilmModel filmModel, IFormFile poster);
        FilmModel GetFilmById(int filmId);
        void UpdateFilm(FilmModel filmModel, IFormFile poster);
        bool DeleteFilm(int filmId);
        List<RoleModel> GetFilmRoles(int filmId);

        List<ActorModel> GetAllActors();
        List<ActorModel> GetAllActorsWithFilter(string filter);
        void CreateActor(ActorModel actorModel, IFormFile poster);
        ActorModel GetActorById(int actorId);
        void UpdateActor(ActorModel actorModel, IFormFile poster);
        bool DeleteActor(int actorId);

        bool AddFriend(string userName, int friendUserId);
        bool RemoveFriend(string userName, int friendUserId);
        bool CheckIfUsersAreFriends(string userName, int userId);

        List<FilmReviewViewModel> GetFilmReviews(int filmId);
        (bool success, FilmReviewViewModel review, float rating) AddReview(string userName, int filmId, int rating, string text);
        List<UserReviewViewModel> GetUserReviews(int userId);

        List<ActorModel> GetAllActorModels();
        List<ActorModel> GetNotInFilmActorsModels(int filmId);
        List<ActorModel> GetActorsInFilm(int filmId);
        List<ActorModel> GetAllActorModelsForFilm(int filmId);
        (bool success, RoleModel role) AddActorToFilm(int actorId, int filmId, string role);
        (bool success, RoleModel role) ChangeActorRole(int actorId, int filmId, string role);
        bool RemoveActorFromFilm(int actorId, int filmId);
        List<FilmModel> GetFilmsActorIsIn(int actorId);
        List<RoleModel> GetActorRoles(int actorId);

        bool GiveAdminPermission(int userId, int permissionId);
        bool RemoveAdminPermission(int userId, int permissionId);
    }
}
