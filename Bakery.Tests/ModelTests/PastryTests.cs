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
  }
}
