using Microsoft.AspNetCore.Identity;
namespace EshopIdentity.Models
{
    public class User:IdentityUser
    {
        public string Fullname { get; set; }
        public DateTime birthday { get; set; }
    }
}
