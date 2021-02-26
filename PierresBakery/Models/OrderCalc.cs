using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class OrderHandler
  {
    private int _pastryAmount;
    private int _breadAmount;
    public OrderHandler(int pastryAmount, int breadAmount)
    {
      _pastryAmount = pastryAmount;
      _breadAmount = breadAmount;
    }

    public void SetPurchaseAmount(int purchaseAmount, string itemType)
    {
      if(itemType == "Bread")
      {
        _breadAmount += purchaseAmount;
      }
      else if(itemType == "Pastry")
      {
        _pastryAmount += purchaseAmount;
      }
      // else
      // {
      //   "Something went wrong"
      // }
    }

    // public int GetOrderAmount()
    // {
    //   return 
    // }
  }

  public static class OrderSetter
  {
    public static int PricePush(int _amount, int _dealThreshold, int _price)
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
          totalCost += 1;
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