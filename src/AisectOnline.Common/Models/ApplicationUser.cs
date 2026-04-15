using Microsoft.AspNetCore.Identity;

namespace AisectOnline.Common.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public virtual ICollection<ApplicationRole> Roles { get; set; } = new List<ApplicationRole>();
    }
}
