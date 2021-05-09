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
      if (numberOfOrderedPastries < 3)
      {
        int pastryCost = numberOfOrderedPastries * 2;
        return pastryCost;
      } else {
        return -1;
      }
    }
  }
}