using Microsoft.AspNetCore.Identity;

namespace Kyloe.Models;

public class ApplicationUser : IdentityUser
{
    public ICollection<Balance> Balances { get; set; }
}