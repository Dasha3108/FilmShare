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
        List<ProfileModel> GetAllProfiles(string userName);
        List<ProfileModel> GetAllProfilesWithFilter(string userName, string filter);

        List<FilmModel> GetAllFilms();
        void CreateFilm(FilmModel filmModel, IFormFile poster);
        FilmModel GetFilmById(int filmId);

        List<ActorModel> GetAllActors();
        void CreateActor(ActorModel actorModel, IFormFile poster);

        bool AddFriend(string userName, int friendUserId);
        bool RemoveFriend(string userName, int friendUserId);
        bool CheckIfUsersAreFriends(string userName, int userId);

        List<FilmReviewViewModel> GetFilmReviews(int filmId);
        bool AddReview(string userName, int filmId, int rating, string text);
        List<UserReviewViewModel> GetUserReviews(int userId);

        List<ActorModel> GetAllActorModels();
    }
}
