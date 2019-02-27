using ExtendIndentityTesting.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtendIndentityTesting.Data
{
    public class DummyData
    {
        public static async Task Initialize(ApplicationDbContext context, 
                                            UserManager<ApplicationUser> userManager,
                                            RoleManager<ApplicationRole> roleManager)
        {

            context.Database.EnsureCreated();

            string adminId1 ;
            string adminId2;

            string role1 = "Admin";
            string desc1 = "This is the administrator role";

            string role2 = "Member";
            string desc2 = "This is the members role";

            string password = "P@$$w0rd";

            if(await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role1, desc1, DateTime.Now));
            }

            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role2, desc2, DateTime.Now));
            }

            if(await userManager.FindByNameAsync("aa@aa.aa") == null)
            {
                var user = new ApplicationUser()
                {
                    APPUSERNAME = "aa@aa.aa",
                    FULLNAME = "Adam Aldridge",
                    APPEMAIL = "aa@aa.aa",
                    APPPHONENUM = "09-78787878",
                    PASSWORD = "1234",
                    PROFESSIONALPHOTO = "photo1.jpg",
                    PROFESSIONALNRC = "12/121212",
                    PROFESSIONALSIGN = "sign1.png"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId1 = user.Id;
            }


            if (await userManager.FindByNameAsync("bb@bb.bb") == null)
            {
                var user = new ApplicationUser()
                {
                    APPUSERNAME = "bb@bb.bb",
                    FULLNAME = "Bdam Bldridge",
                    APPEMAIL = "bb@bb.bb",
                    APPPHONENUM = "09-79797979",
                    PASSWORD = "5678",
                    PROFESSIONALPHOTO = "photo2.jpg",
                    PROFESSIONALNRC = "12/343434",
                    PROFESSIONALSIGN = "sign2.png"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
                adminId2 = user.Id;
            }


            if (await userManager.FindByNameAsync("cc@cc.cc") == null)
            {
                var user = new ApplicationUser()
                {
                    APPUSERNAME = "cc@cc.cc",
                    FULLNAME = "Cdam Cldridge",
                    APPEMAIL = "cc@cc.cc",
                    APPPHONENUM = "09-79797979",
                    PASSWORD = "5678",
                    PROFESSIONALPHOTO = "photo3.jpg",
                    PROFESSIONALNRC = "12/343434",
                    PROFESSIONALSIGN = "sign3.png"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
            }
        }
    }
}
