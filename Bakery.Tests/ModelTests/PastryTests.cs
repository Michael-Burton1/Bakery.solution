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
      Pastry myPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), myPastry.GetType());
    }
    
  }
}
