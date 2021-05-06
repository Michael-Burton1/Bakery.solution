using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectName.Models;

namespace ProjectName.Tests
{
  [TestClass]
  public class ItemTests
  {
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item();
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }
    // Test methods will go here.

  }
}