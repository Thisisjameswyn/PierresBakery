namespace PierresBakery.Models
{
  public static class OrderCalc
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