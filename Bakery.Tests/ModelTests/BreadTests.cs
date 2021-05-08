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
      Bread myBread = new Bread();
      Assert.AreEqual(typeof(Bread), myBread.GetType());
    }
    // Test methods will go here.

  }
}