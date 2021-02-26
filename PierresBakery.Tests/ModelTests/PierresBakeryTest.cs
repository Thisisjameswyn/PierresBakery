using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry testPastry = new Pastry(0);
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }

    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread testBread = new Bread(0);
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }

    [TestMethod]
    public void PastryConstructor_ReturnAmount_Int()
    {
      int amountToBuy = 5;
      Pastry testPastry = new Pastry(amountToBuy);
      Assert.AreEqual(testPastry.PurchaseAmount, amountToBuy);
    }

    [TestMethod]
    public void BreadConstructor_ReturnAmount_Int()
    {
      int amountToBuy = 5;
      Bread testBread = new Bread(amountToBuy);
      Assert.AreEqual(testBread.PurchaseAmount, amountToBuy);
    }
  }
}