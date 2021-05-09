namespace Bakery.Models
{
  public class Pastry
  {
    public int NumberOfOrderedPastries {get; set;}
    public Pastry(int numberOfOrderedPastries)
    {
      NumberOfOrderedPastries = numberOfOrderedPastries;
    }
    public int PastryTotal(int numberOfOrderedPastries)
    {
      int PastryCost = 1;
      return PastryCost; 
    }
  }
}