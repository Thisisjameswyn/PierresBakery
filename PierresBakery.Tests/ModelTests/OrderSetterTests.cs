using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class OrderSetterTests
  {
    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_OrderCalc()
    {
      OrderSetter testOrder = new OrderSetter();
      Assert.AreEqual(typeof(OrderSetter), testOrder.GetType());
    }

    [TestMethod]
    public void GetOrderAmount_ReturnCorrectAmount_Int()
    {
      int _bAmount = 2;
      int _pAmount = 5;
      OrderSetter testOrder = new OrderSetter();
      testOrder.BreadAmount = _bAmount;
      testOrder.PastryAmount = _pAmount;
      Assert.AreEqual(_bAmount, testOrder.BreadAmount);
      Assert.AreEqual(_pAmount, testOrder.PastryAmount);
    }

    [TestMethod]
    public void EmptyCart_ReturnCorrectAmount_Int()
    {
      int _bAmount = 3;
      int _pAmount = 8;
      int expectValue = 0;
      OrderSetter testOrder = new OrderSetter();
      testOrder.BreadAmount = _bAmount;
      testOrder.PastryAmount = _pAmount;
      testOrder.PushOrder("Bread");
      testOrder.PushOrder("Pastry");
      testOrder.EmptyCart();
      Assert.AreEqual(expectValue, testOrder.BreadCost);
      Assert.AreEqual(expectValue, testOrder.PastryCost);
      Assert.AreEqual(expectValue, testOrder.BreadAmount);
      Assert.AreEqual(expectValue, testOrder.PastryAmount);
    }
  }
}