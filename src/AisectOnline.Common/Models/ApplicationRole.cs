using Microsoft.AspNetCore.Identity;

namespace AisectOnline.Common.Models
{
    public class ApplicationRole : IdentityRole
    {
        public string? Description { get; set; }
    }
}
