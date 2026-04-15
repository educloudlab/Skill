
//DROP TABLE[_xlnm#_FilterDatabase];

using System.Threading.Tasks;
using AisectOnline.Common.Models;
using Microsoft.AspNetCore.Identity;

namespace AisectOnline.Services.Modules.Roles
{
    public class RoleSeeder : IRoleSeeder
    {
        private readonly RoleManager<ApplicationRole> _roleManager;

        public RoleSeeder(RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task SeedAsync()
        {
            // Define your roles here
            var roles = new[]
            {
                new ApplicationRole { Name = "Admin", Description = "Administrator role" },
                new ApplicationRole { Name = "Kiosk", Description = "Standard Kiosk role" }
                // Add more roles as needed
            };

            foreach (var role in roles)
            {
                //if (!string.IsNullOrWhiteSpace(role.Name) && !await _roleManager.RoleExistsAsync(role.Name))
                //{
                //    await _roleManager.CreateAsync(role);
                //}
            }
        }
    }
}

