using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;


namespace Bakery.Tests
{
  [TestClass]
  public class PasteryTests 
  {
    // public void Dispose()
    // {
    //   Pastery.ClearAll(); 
    // }
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry myPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), myPastry.GetType());
    }
    [TestMethod]
    public void PastryTotal_GivesATotalForOnePastry_int()
    {
      int pastriesOrdered=1;
      Pastry myPastry = new Pastry(1);
      Assert.AreEqual(2, myPastry.PastryTotal(pastriesOrdered));
    }
    [TestMethod]
    public void PastryTotal_GivesATotalForTwoPastries_int()
    {
      int pastriesOrdered=2;
      Pastry myPastry = new Pastry(2);
      Assert.AreEqual(4, myPastry.PastryTotal(pastriesOrdered));
    }
    [TestMethod]
    public void PastryTotal_GivesATotalForThreePastries_int()
    {
      int pastriesOrdered=3;
      Pastry myPastry = new Pastry(3);
      Assert.AreEqual(5, myPastry.PastryTotal(pastriesOrdered));
    }
    [TestMethod]
    public void PastryTotal_GivesATotalForFivePastries_int()
    {
      int pastriesOrdered=5;
      Pastry myPastry = new Pastry(5);
      Assert.AreEqual(9, myPastry.PastryTotal(pastriesOrdered));
    }
    [TestMethod]
    public void PastryTotal_GivesATotalForSixPastries_int()
    {
      int pastriesOrdered=6;
      Pastry myPastry = new Pastry(6);
      Assert.AreEqual(10, myPastry.PastryTotal(pastriesOrdered));
    }
  }
}
