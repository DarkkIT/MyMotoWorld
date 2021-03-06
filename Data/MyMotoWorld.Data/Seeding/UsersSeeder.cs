﻿namespace MyMotoWorld.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;
    using MyMotoWorld.Common;
    using MyMotoWorld.Data.Models;

    public class UsersSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            await SeedUserAsync(userManager, "darkk334582@yahoo.com");
            await SeedUserAsync(userManager, "darkk33@yahoo.com");
        }

        private static async Task SeedUserAsync(UserManager<ApplicationUser> userManager, string username)
        {
            var user = await userManager.FindByNameAsync(username);
            if (user == null)
            {
                var appUser = new ApplicationUser();
                appUser.UserName = username;
                appUser.Email = username;
                appUser.PhoneNumber = "0888999999";

                IdentityResult result = new IdentityResult();

                if (username == "darkk334582@yahoo.com")
                {
                    result = userManager.CreateAsync(appUser, "darkk334582").Result;
                    appUser.PhoneNumber = "0888654321";
                }
                else if (username == "darkk33@yahoo.com")
                {
                    result = userManager.CreateAsync(appUser, "darkk33").Result;
                    appUser.PhoneNumber = "0888123456";
                }

                if (result.Succeeded)
                {
                    if (username == "darkk334582@yahoo.com")
                    {
                        userManager.AddToRoleAsync(appUser, GlobalConstants.MasterRoleName).Wait();
                    }
                    else if (username == "darkk33@yahoo.com")
                    {
                        userManager.AddToRoleAsync(appUser, GlobalConstants.AdministratorRoleName).Wait();
                    }
                }
            }
        }
    }
}
