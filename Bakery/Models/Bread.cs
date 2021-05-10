namespace Bakery.Models
{
  public class Bread
  {
    public int NumberOfOrderedLoaves {get; set;}

    public Bread(int numberOfOrderedLoaves)
    {
      NumberOfOrderedLoaves = numberOfOrderedLoaves;
    }

    public int BreadTotal(int numberOfOrderedLoaves)
    {
      int numberOfFreeLoaves= numberOfOrderedLoaves/3;
      int numberOfChargedLoaves = numberOfOrderedLoaves- numberOfFreeLoaves;
      int BreadCost= numberOfChargedLoaves*5;
      return BreadCost; 
    }
  }
}