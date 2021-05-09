using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread myBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), myBread.GetType());
    }
    [TestMethod]
    public void BreadTotal_GivesATotalForOneLoafOfBread_int()
    {
      int loavesOrdered=1;
      Bread myBread = new Bread(1);
      Assert.AreEqual(5, myBread.BreadTotal(loavesOrdered));
    }
    [TestMethod]
    public void BreadTotal_GivesATotalForTwoLoavesOfBread_int()
    {
      int loavesOrdered=2;
      Bread myBread = new Bread(2);
      Assert.AreEqual(10, myBread.BreadTotal(loavesOrdered));
    }
    [TestMethod]
    public void BreadTotal_GivesATotalForThreeLoavesOfBread_int()
    {
      int loavesOrdered=3;
      Bread myBread = new Bread(3);
      Assert.AreEqual(10, myBread.BreadTotal(loavesOrdered));
    }
  }
}