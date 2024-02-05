using Microsoft.AspNetCore.Identity;

namespace MovieStore.Models.Data
{
    public class ApplicationUser : IdentityUser 
    {

        public string Name  { get; set; }
    }
}
