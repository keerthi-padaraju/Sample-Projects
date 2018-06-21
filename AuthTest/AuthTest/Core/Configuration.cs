using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;
using Microsoft.AspNet.Identity.EntityFramework;
using AuthTest.Models;
using System.Runtime.Remoting.Contexts;
using System.IdentityModel;

namespace AuthTest.Core
{
    public class Configuration : DbMigrationsConfiguration<AuthContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }
        //Seed method will pre-populate some books and reviews automatically
        protected override void Seed(AuthContext context)
        {
            context.TestAuth.AddOrUpdate(new TestAuth { ID = 1, Name = "abc", Desc = "Enjoyed book a lot!" });
            context.TestAuth.AddOrUpdate(new TestAuth { ID = 2, Name = "xyz", Desc = "Great book, bit short." });
            context.TestAuth.AddOrUpdate(new TestAuth { ID = 3, Name = "book", Desc = "Good book, wouldn't read twice." });

            string adminRoleId;
            string userRoleId;
            if (!context.Roles.Any())
            {
                adminRoleId = context.Roles.Add(new IdentityRole("Administrator")).Id;
                userRoleId = context.Roles.Add(new IdentityRole("User")).Id;
            }
            else
            {
                adminRoleId = context.Roles.First(c => c.Name == "Administrator").Id;
                userRoleId = context.Roles.First(c => c.Name == "User").Id;
            }

            context.SaveChanges();

            if (!context.Users.Any())
            {
                var administrator = context.Users.Add(new IdentityUser("administrator") { Email = "admin@abc.com", EmailConfirmed = true });
                administrator.Roles.Add(new IdentityUserRole { RoleId = adminRoleId });

                var standardUser = context.Users.Add(new IdentityUser("keerthi") { Email = "keerthi@abc.com", EmailConfirmed = true });
                standardUser.Roles.Add(new IdentityUserRole { RoleId = userRoleId });

                context.SaveChanges();

                var store = new TestUserStore();
                store.SetPasswordHashAsync(administrator, new TestUserManager().PasswordHasher.HashPassword("administrator123"));
                store.SetPasswordHashAsync(standardUser, new TestUserManager().PasswordHasher.HashPassword("user123"));
            }

            context.SaveChanges();

        }
        
    }
}