using Microsoft.EntityFrameworkCore;

namespace Kyloe.ViewModels;

public class UserViewModel
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public IList<string> Roles { get; set; }
}