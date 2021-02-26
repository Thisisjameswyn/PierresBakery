using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class OrderCalc
  {
    private int _pastryAmount;
    private int _breadAmount;
    public OrderCalc(int pastryAmount, int breadAmount)
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

  public class Pastry
  {
    private int _purchaseAmount;
    public Pastry(int _pAmount)
    {
      // _purchaseAmount = _bAmount;
      int _totalPastryCost = 0;
      int _price = 5;
      int _dealThreshold = 3;
      int _dealCounter = 0;
      for (int i = 0; i < _pAmount; i++)
      {
        if(_dealCounter < _dealThreshold)
        {
          _totalPastryCost += _price;
          _dealCounter ++;
        }
        else
        {
          _dealCounter = 0;
        }
      }
    Console.WriteLine(_totalPastryCost);
    }
  }

  public class Bread
  {
    // private int _purchaseAmount;
    public Bread(int _bAmount)
    {
      // _purchaseAmount = _bAmount;
      int _totalBreadCost = 0;
      int _price = 5;
      int _dealThreshold = 2;
      int _dealCounter = 0;
      for (int i = 0; i < _bAmount; i++)
      {
        if(_dealCounter < _dealThreshold)
        {
          _totalBreadCost += _price;
          _dealCounter ++;
        }
        else
        {
          _dealCounter = 0;
        }
      }
    Console.WriteLine(_totalBreadCost);
    }
  }
}