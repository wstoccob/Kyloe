using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Kyloe.Models;

public class Balance
{
    public int Id { get; set; }
    public string Name { get; set; }
    [ForeignKey("User")]
    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
    public float Amount { get; set; }
    [ForeignKey("Currency")]
    public int CurrencyId { get; set; }
    public Currency Currency { get; set; }
}