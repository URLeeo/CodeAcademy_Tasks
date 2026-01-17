using Microsoft.AspNetCore.Identity;

namespace FiorelloClone.Models;

public class AppUser : IdentityUser
{
    public string Name { get; set; }
    public string Surname { get; set; }
}
