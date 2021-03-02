namespace PierresBakery.Models
{
  public class OrderHandler
  {
    private int breadAmount;
    private int pastryAmount;
    private int breadCost;
    private int pastryCost;
    public OrderHandler()
    {
      int _breadAmount = breadAmount;
      int _pastryAmount = pastryAmount;
      int _breadCost = breadCost;
      int _pastryCost = pastryCost;
    }
    public int GetOrderAmount(string _type)
    {
      if(_type == "Bread")
      {
        return breadAmount;
      }
      else
      {
        return pastryAmount;
      }
    }

    public void SetPurchaseAmount(int purchaseAmount, string itemType)
    {
      if(itemType == "Bread")
      {
        breadAmount += purchaseAmount;
      }
      else if(itemType == "Pastry")
      {
        pastryAmount += purchaseAmount;
      }
    }

    public void PushOrder(string _type)
    {
      if(_type == "Bread")
      {
        breadCost = OrderSetter.CostPush(breadAmount, 2, 5, 0); 
      }
      else
      {
        pastryCost = OrderSetter.CostPush(pastryAmount, 2, 2, 1);
      }
    }

    public int GetOrderCost(string _type)
    {
      if(_type == "Bread")
      {
        return breadCost;
      }
      else
      {
        return pastryCost;
      }
    }

    public void EmptyCart()
    {
      breadAmount = 0;
      pastryAmount = 0;
      breadCost = 0;
      pastryCost = 0;
    }
  }

  public static class OrderSetter
  {
    public static int CostPush(int _amount, int _dealThreshold, int _price, int _dealPrice)
    {
      int totalCost = 0;
      int _dealCounter = 0;
      for (int i = 0; i < _amount; i++)
      {
        if(_dealCounter < _dealThreshold)
        {
          totalCost += _price;
          _dealCounter ++;
        }
        else
        {
          totalCost += _dealPrice;
          _dealCounter = 0;
        }
      }
      return totalCost;
    }
  }
}