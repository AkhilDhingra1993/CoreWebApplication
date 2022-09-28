using Microsoft.AspNetCore.Identity;

namespace CoreWebApplication.Models
{
    public class ApplicationUser :IdentityUser
    {
        public string City { get; set; }
    }
}
