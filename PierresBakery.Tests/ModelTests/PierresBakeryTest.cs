using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class OrderHandlerTests
  {
    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_OrderCalc()
    {
      OrderHandler testOrder = new OrderHandler();
      Assert.AreEqual(typeof(OrderHandler), testOrder.GetType());
    }

    [TestMethod]
    public void GetOrderAmount_ReturnCorrectAmount_Int()
    {
      int _pAmount = 0;
      int _bAmount = 0;
      OrderHandler testOrder = new OrderHandler();
      Assert.AreEqual(_bAmount, testOrder.GetOrderAmount("Bread"));
      Assert.AreEqual(_pAmount, testOrder.GetOrderAmount("Pastry"));
    }

    [TestMethod]
    public void SetPurchaseAmount_SetCorrectAmount_Int()
    {
      int _pAmount = 8;
      int _bAmount = 3;
      OrderHandler testOrder = new OrderHandler();
      testOrder.SetPurchaseAmount(_bAmount, "Bread");
      testOrder.SetPurchaseAmount(_pAmount, "Pastry");
      Assert.AreEqual(_bAmount, testOrder.GetOrderAmount("Bread"));
      Assert.AreEqual(_pAmount, testOrder.GetOrderAmount("Pastry"));
    }

    [TestMethod]
    public void PushOrder_SetCorrectCost_Int()
    {
      int _pAmount = 8;
      int _bAmount = 3;
      int figuredBreadCost = 10;
      int figuredPastryCost = 14; 
      OrderHandler testOrder = new OrderHandler();
      testOrder.SetPurchaseAmount(_bAmount, "Bread");
      testOrder.SetPurchaseAmount(_pAmount, "Pastry");
      testOrder.PushOrder("Bread");
      testOrder.PushOrder("Pastry");
      Assert.AreEqual(figuredBreadCost, testOrder.GetOrderCost("Bread"));
      Assert.AreEqual(figuredPastryCost, testOrder.GetOrderCost("Pastry"));
    }

    [TestMethod]
    public void GetOrderCost_ReturnCorrectCost_Int()
    {
      int _pAmount = 8;
      int _bAmount = 3;
      int figuredBreadCost = 10;
      int figuredPastryCost = 14; 
      OrderHandler testOrder = new OrderHandler();
      testOrder.SetPurchaseAmount(_bAmount, "Bread");
      testOrder.SetPurchaseAmount(_pAmount, "Pastry");
      testOrder.PushOrder("Bread");
      testOrder.PushOrder("Pastry");
      Assert.AreEqual(figuredBreadCost, testOrder.GetOrderCost("Bread"));
      Assert.AreEqual(figuredPastryCost, testOrder.GetOrderCost("Pastry"));
    }

    [TestMethod]
    public void EmptyCart_ReturnCorrectAmount_Int()
    {
      int _pAmount = 8;
      int _bAmount = 3;
      int expectValue = 0;
      OrderHandler testOrder = new OrderHandler();
      testOrder.SetPurchaseAmount(_bAmount, "Bread");
      testOrder.SetPurchaseAmount(_pAmount, "Pastry");
      testOrder.PushOrder("Bread");
      testOrder.PushOrder("Pastry");
      testOrder.EmptyCart();
      Assert.AreEqual(expectValue, testOrder.GetOrderCost("Bread"));
      Assert.AreEqual(expectValue, testOrder.GetOrderCost("Pastry"));
      Assert.AreEqual(expectValue, testOrder.GetOrderAmount("Bread"));
      Assert.AreEqual(expectValue, testOrder.GetOrderAmount("Pastry"));
    }

    [TestMethod]
    public void CostPush_ReturnCorrectDealAmount_Int()
    {
      int _bAmount = 3;
      int _pAmount = 8;
      int bExpectValue = 10;
      int pExpectValue = 14;
      OrderHandler testOrder = new OrderHandler();
      testOrder.SetPurchaseAmount(_bAmount, "Bread");
      testOrder.SetPurchaseAmount(_pAmount, "Pastry");
      testOrder.PushOrder("Bread");
      testOrder.PushOrder("Pastry");
      Assert.AreEqual(bExpectValue, testOrder.GetOrderCost("Bread"));
      Assert.AreEqual(pExpectValue, testOrder.GetOrderCost("Pastry"));
    }
  }
}