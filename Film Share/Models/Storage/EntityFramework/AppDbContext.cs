using FilmShare.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmShare.Models.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Relationship> Relationships { get; set; }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Review> Reviews { get; set; }
        
        public DbSet<ActorsInFilm> ActorsInFilms { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }
        public DbSet<UserRelationships> UserRelationships { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<UserPermission>().HasKey(up => new { up.PermissionId, up.UserId });
            modelBuilder.Entity<ActorsInFilm>().HasKey(af => new { af.ActorId, af.FilmId });

            modelBuilder.Entity<UserRelationships>().HasKey(ur => new { ur.MainUserId, ur.DependentUserId });
            modelBuilder.Entity<UserRelationships>().HasOne(ur => ur.MainUser)
                     .WithMany(mu => mu.MainUserRelationships)
                     .HasForeignKey(ur => ur.MainUserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<UserRelationships>().HasOne(ur => ur.DependentUser)
                     .WithMany(du => du.DependentUserRelationships)
                     .HasForeignKey(ur => ur.DependentUserId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
