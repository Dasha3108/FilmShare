using FilmShare.Models.DataAccessLayer;
using FilmShare.Models.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace FilmShare.Models.Storage.EntityFramework
{
    public static class AddDatabaseData
    {
        public static void AddData(IApplicationBuilder applicationBuilder)
        {
            var context = applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();
            context.Database.Migrate();

            AddUsersPermissions(context);
            AddUsersRelationships(context);
            context.SaveChanges();
        }

        private static void AddUsersPermissions(AppDbContext context)
        {
            var permissions = new Permission[] { new Permission { PermissionName = "Create films" }, new Permission { PermissionName = "Edit films" },
                new Permission { PermissionName = "Delete films" } };
            var arePermissionsUpdated = permissions.Count() != context.Permissions.Count() || permissions
                .FirstOrDefault(cp => context.Permissions.Where(p => p.PermissionName == cp.PermissionName).FirstOrDefault() == null)
                != null;
            if (arePermissionsUpdated)
            {
                context.Database.ExecuteSqlCommand("DELETE FROM Permissions");
                context.Permissions.AddRange(permissions);
            }
        }

        private static void AddUsersRelationships(AppDbContext context)
        {
            var relationships = new Relationship[] { new Relationship { Name = "Friend" }, new Relationship { Name = "Follower" },
                new Relationship { Name = "Ban" } };
            var areRelationshipsUpdated = relationships.Count() != context.Relationships.Count() || relationships
                .FirstOrDefault(cp => context.Relationships.Where(p => p.Name == cp.Name).FirstOrDefault() == null)
                != null;
            if (areRelationshipsUpdated)
            {
                context.Database.ExecuteSqlCommand("DELETE FROM Relationships");
                context.Relationships.AddRange(relationships);
            }
        }
    }
}
