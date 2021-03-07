using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class OrderCalcTests
  {
    [TestMethod]
    public void CostPush_ReturnOrderAmount_OrderCalc()
    {
      OrderSetter testOrder = new OrderSetter();
      testOrder.BreadAmount = 3;
      testOrder.PastryAmount = 3;
      testOrder.PushOrder("Bread");
      testOrder.PushOrder("Pastry");
      Assert.AreEqual(testOrder.BreadCost, 10);
      Assert.AreEqual(testOrder.PastryCost, 5);
    }
  }
}