using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AisectOnline.Data.Seeders
{
    public interface IRoleSeeder { Task SeedAsync(); }
    public class RoleSeeder : IRoleSeeder
    {
        private readonly RoleManager<IdentityRole> _roleMgr;
        public RoleSeeder(RoleManager<IdentityRole> roleMgr) => _roleMgr = roleMgr;
        public async Task SeedAsync()
        {
            var roles = new[] { "SuperAdmin", "Admin", "Kiosk", "KioskOwner" };
            foreach (var r in roles)
                if (!await _roleMgr.RoleExistsAsync(r))
                    await _roleMgr.CreateAsync(new IdentityRole(r));
        }
    }
}