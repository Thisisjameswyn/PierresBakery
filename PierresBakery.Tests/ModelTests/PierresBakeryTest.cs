using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_OrderCalc()
    {
      OrderCalc testOrder = new OrderCalc(0,0);
      Assert.AreEqual(typeof(OrderCalc), testOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_ReturnAmount_OrderCalc()
    {
      int _pAmount = 5;
      int _bAmount = 5;
      OrderCalc testOrder = new OrderCalc(_pAmount,_bAmount);
      Assert.AreEqual(_bAmount, testOrder.BreadAmount);
      Assert.AreEqual(_pAmount, testOrder.PastryAmount);
    }

    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry testPastry = new Pastry(0);
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }

    [TestMethod]
    public void PastryConstructor_ReturnAmount_Int()
    {
      int amountToBuy = 5;
      Pastry testPastry = new Pastry(amountToBuy);
      Assert.AreEqual(testPastry.PurchaseAmount, amountToBuy);
    }

    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread testBread = new Bread(0);
      Assert.AreEqual(typeof(Bread), testBread.GetType());
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