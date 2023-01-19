using Microsoft.AspNetCore.Identity;

namespace projektowanie_oprogramowania_final_project.Data
{
    public class IdentityInitializer
    {
        public static void SeedData(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        public static void SeedUser(UserManager<IdentityUser> userManager, string name, string password, string role = null)
        {
            if (userManager.FindByNameAsync(name).Result == null)
            {
                IdentityUser user = new()
                {
                    UserName = name,
                    Email = name
                };
                IdentityResult result = userManager.CreateAsync(user, password).Result;
                if (result.Succeeded && role != null)
                {
                    userManager.AddToRoleAsync(user, role).Wait();
                }
            }
        }

        public static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            SeedUser(userManager, "anyone@localhost", "Pass1234@");
            SeedUser(userManager, "admin@localhost", "AdminPass1234@", "Admin");
            SeedUser(userManager, "employee@localhost", "EmployeePass1234@", "Employee");
        }

        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new()
                {
                    Name = "Admin",
                };
                _ = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync("Employee").Result)
            {
                IdentityRole role = new()
                {
                    Name = "Employee",
                };
                _ = roleManager.CreateAsync(role).Result;
            }

        }

    }
}
