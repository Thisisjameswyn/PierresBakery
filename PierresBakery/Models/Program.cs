//two classe Bread{$5} and Pastry{$2}
  //.Price on both static

//user should get a prompt with a welcome message and the price for both bread and pastry
  //Console.WriteLIne("Welcome to bakery we have bread for "+ Bread.price "and pastries for " + Pastry.price)
  //Console.WriteLine("What would you like to buy today?)
  //("Please choose 1 for bread and 2 for pastry")
  //get answer Console.ReadLine
  
//user should specify how many loaves of bread or pastry they want
  //if(1) -- How many loaves of bread would you like?
  //else if(2)  -- How many Pastries would you like?
  //else -- Please make a valid selection

//offer deals Bread: buy 2 get 1 free // Pastry : buy 1 for $2 or 3 for $5
//Apply Deals
  //hold amount of units to buy per type (bread/pastry)
  //foreach(int unitToBuy in amount)
    //{
      //amountPurchased ++
      //if(amountPurchased > dealThreshold)
        //{
          //Change price
          //add new price
          //amountPurchased = 0
        //}
        //price++
    //}

//return cost of order
  //return Bread.cost and Pastry.cost

using System;

namespace PierresBakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello and welcome to Pierre's Bakery");  //Greet user
      UserChoice();
    }

    public static void UserChoice()
    {
      Console.WriteLine("What would you like to do today?\n"+  //Prompt and capture userChoice for menu
      "1 for Place Order\n"+
      "2 for Specials\n"+
      "3 to Exit\n");
      string userChoice = Console.ReadLine();
      if(userChoice == "1")
      {
        Console.WriteLine("OK!  Let's get your order started!");  //Prompt and capture userChoice for item
        OrderHandler userOrder = new OrderHandler();
        Order(userOrder);
      }
    }

    public static void Order(OrderHandler _userOrder)
    {
      Console.WriteLine("What would you like to order?\n"+
      "Enter 1 for bread\n"+
      "Enter 2 for pastries");
      string userChoice = Console.ReadLine();
      if(userChoice == "1")
      {
        Console.WriteLine("You chose Bread YUM!");  //Prompt and capture userChoice for bread amount
        Console.WriteLine("Enter how many loaves of bread you would like:");
        int _userChoice = int.Parse(Console.ReadLine());  //how much we want
        _userOrder.SetPurchaseAmount(_userChoice, "Bread");
        Console.WriteLine("You have selected " + _userChoice + " loaves of bread\n"+
        "Would you like to add these to your cart?\n"+
        "Enter 1 for Yes\n"+
        "Enter 2 for No");
        userChoice = Console.ReadLine();
        if(userChoice == "1")
        {
          Console.WriteLine(_userOrder.GetOrderAmount("Bread") + " loaves.");
        }
        else if(userChoice == "2")
        {
          _userOrder.SetPurchaseAmount(0, "Bread");
          Order(_userOrder);
        }
      }
      else if(userChoice == "2")
      {
        Console.WriteLine("You chose Pastry YUM!");  //Prompt and capture userChoice for pastry amount
        Console.WriteLine("Enter how many pastries you would like:");
        int _userChoice = int.Parse(Console.ReadLine());
        _userOrder.SetPurchaseAmount(_userChoice, "Pastry");
        Console.WriteLine("You have selected " + _userChoice + " pastries\n"+
        "Would you like to add these to your cart?\n"+
        "Enter 1 for Yes\n"+
        "Enter 2 for No");
        userChoice = Console.ReadLine();
        if(userChoice == "1")
        {
          Console.WriteLine(_userOrder.GetOrderAmount("Pastry") + " pastries.");
        }
        else if(userChoice == "2")
        {
          _userOrder.SetPurchaseAmount(0, "Pastry");
          Order(_userOrder);
        }
        else
        {
        Console.WriteLine("Please enter a valid choice");  //Prompt user to enter valid choice
        UserChoice();
        }
      }     
    }
  }
}
