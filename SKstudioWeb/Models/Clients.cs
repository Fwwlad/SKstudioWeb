using Microsoft.AspNetCore.Identity;

namespace SKstudioWeb.Models
{
    public class Clients : IdentityUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
