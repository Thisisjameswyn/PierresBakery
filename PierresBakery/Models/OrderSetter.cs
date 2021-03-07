namespace PierresBakery.Models
{
  public class OrderSetter
  {
    public int BreadAmount { get; set; }
    public int PastryAmount { get; set; }
    public int BreadCost { get; set; }
    public int PastryCost { get; set; }
    public OrderSetter()
    {
      int breadAmount = BreadAmount;
      int pastryAmount = PastryAmount;
      int breadCost = BreadCost;
      int pastryCost = PastryCost;
    }

    public void PushOrder(string _type)
    {
      if(_type == "Bread")
      {
        BreadCost = OrderCalc.CostPush(BreadAmount, 2, 5, 0); 
      }
      else
      {
        PastryCost = OrderCalc.CostPush(PastryAmount, 2, 2, 1);
      }
    }

    public void EmptyCart()
    {
      BreadAmount = 0;
      PastryAmount = 0;
      BreadCost = 0;
      PastryCost = 0;
    }
  }
}