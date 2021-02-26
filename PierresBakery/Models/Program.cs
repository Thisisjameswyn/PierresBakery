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
      Console.WriteLine("Hello and welcome to Pierre's Bakery");
      UserChoice();
    }

    public static void UserChoice()
    {
      Console.WriteLine("What would you like to do today?");
      Console.WriteLine("1 for Place Order");
      Console.WriteLine("2 for Specials");
      Console.WriteLine("3 to Exit");
      string userChoice = Console.ReadLine();
      if(userChoice == "1")
      {
        Console.WriteLine("OK!  Let's get your order started!");
        OrderCalc userOrder = new OrderCalc(0,0);
        Console.WriteLine("What would you like to order?");
        Console.WriteLine("Enter 1 for bread");
        Console.WriteLine("Enter 2 for pastries");
        userChoice = Console.ReadLine();
        if(userChoice == "1")
        {
          Console.WriteLine("You chose Bread YUM!");
          Console.WriteLine("Enter how many loaves of bread you would like:");
          int _userChoice = int.Parse(Console.ReadLine());
          Bread breadOrder = new Bread(_userChoice);
          Console.WriteLine("You want " + _userChoice + " loaves of bread");
        }
        else if(userChoice == "2")
        {
          Console.WriteLine("You chose Pastry YUM!");
          Console.WriteLine("Enter how many pastries you would like:");
          int _userChoice = int.Parse(Console.ReadLine());
          Pastry pastryOrder = new Pastry(_userChoice);
          Console.WriteLine("You want " + _userChoice + " pastries!");
        }
        else
        {
          Console.WriteLine("Please enter a valid choice");
          UserChoice();
        }
      }
    }
  }
} 
