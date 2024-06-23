namespace Kyloe.Models;

public class Currency
{
    public int Id { get; set; }
    public string Symbol { get; set; }
    public ICollection<Balance> Balances { get; set; }
}