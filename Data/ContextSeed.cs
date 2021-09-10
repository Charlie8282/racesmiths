using Microsoft.AspNetCore.Identity;
using racesmiths.Models;
using racesmiths.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Data
{
    public enum Roles
    {
        Admin,
        ClubManager,
        Driver,
        NewUser
    }
    public class ContextSeed
    {
        public static async Task RunSeedMethods(
           RoleManager<IdentityRole> roleManager,
           UserManager<RSUser> userManager,
           ApplicationDbContext context,
           IImageService imageService)
        {
            await SeedRolesAsync(roleManager);
            await SeedDefaultUsersAsync(userManager, imageService);

        }

        private static async Task SeedRolesAsync(RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.ClubManager.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Driver.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.NewUser.ToString()));
           
        }


        private static async Task SeedDefaultUsersAsync(UserManager<RSUser> userManager, IImageService imageService)
        {
            #region Seed Admin

            var defaultAdmin = new RSUser
            {
                UserName = "zacksattention@gmail.com",
                Email = "zacksattention@gmail.com",
                Gamertag = "CatTerdCanyon82",
                //FirstName = "Charlie",
                //LastName = "Tincher",
                FileName = "defaultavatar.jpg",
                FileData = await imageService.AssignAvatarAsync("defaultavatar.jpg"),
                EmailConfirmed = true
            };
            try
            {
                var user = await userManager.FindByEmailAsync(defaultAdmin.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultAdmin, "Charlie@123");
                    await userManager.AddToRoleAsync(defaultAdmin, Roles.Admin.ToString());
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("************ ERROR ************");
                Debug.WriteLine("Error Seeding Default Admin User.");
                Debug.WriteLine("ex.Message");
                Debug.WriteLine("*******************************");

            }
            #endregion
        }
    }
}
