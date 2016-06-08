using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace aspnet_core_security.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        // Adding a property in this class will modify the generated Identiy schema to accommodate it.
        public string Company { get; set; }
    }
}
