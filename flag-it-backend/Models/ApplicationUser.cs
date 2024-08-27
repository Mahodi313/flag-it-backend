using Microsoft.AspNetCore.Identity;

namespace flag_it_backend.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<ResultModel> Results { get; set; }
    }
}
