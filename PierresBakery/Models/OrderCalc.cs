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












  // public class Pastry
  // {
  //   int totalPastryCost = 0;
  //   public Pastry(int _pAmount)
  //   {
  //     int _price = 2;
  //     int _dealThreshold = 2;
  //     int _dealCounter = 0;
  //     for (int i = 0; i < _pAmount; i++)
  //     {
  //       if(_dealCounter < _dealThreshold)
  //       {
  //         totalPastryCost += _price;
  //         _dealCounter ++;
  //       }
  //       else
  //       {
  //         totalPastryCost += 1;
  //         _dealCounter = 0;
  //       }
  //     }
  //   PastryPrice();
  //   }
  //   public int PastryPrice()
  //   {
  //     OrderCalc.
  //     return totalPastryCost;
  //   }
  // }

  // public class Bread
  // {
  //   int totalBreadCost = 0;
  //   public Bread(int _bAmount)
  //   {
  //     int _price = 5;
  //     int _dealThreshold = 2;
  //     int _dealCounter = 0;
  //     for (int i = 0; i < _bAmount; i++)
  //     {
  //       if(_dealCounter < _dealThreshold)
  //       {
  //         totalBreadCost += _price;
  //         _dealCounter ++;
  //       }
  //       else
  //       {
  //         _dealCounter = 0;
  //       }
  //     }
  //   }
  //   public int PastryPrice()
  //   {
  //     return totalBreadCost;
  //   }
  // }
}