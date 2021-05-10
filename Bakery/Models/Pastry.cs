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
        int sets= numberOfOrderedPastries/3;
        int leftovers= numberOfOrderedPastries % 3;
        int costOfSets= sets * 5;
        int costOfLeftovers= leftovers * 2;
        int PastryCost = costOfSets + costOfLeftovers; 
        return PastryCost;
      }
    }
  }
}