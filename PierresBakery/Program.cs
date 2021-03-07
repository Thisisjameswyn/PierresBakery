using PierresBakery.Models;
using System;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello and welcome to Pierre's Bakery\n"+
      "Our specials are buy 2 loaves of bread recieve the 3rd free\n"+
      "buy pastries 1 for $2 or 3 for $5");
      UserChoice();
    }

    public static void UserChoice()
    {
      Console.WriteLine("What would you like to do today?\n"+
      "1 for Place Order\n"+
      "2 for Specials\n"+
      "3 to Exit\n");
      string userChoice = Console.ReadLine();
      if(userChoice == "1")
      {
        Console.WriteLine("OK!  Let's get your order started!");
        OrderSetter userOrder = new OrderSetter();
        Order(userOrder);
      }
      else if(userChoice == "2")
      {
        Console.WriteLine("Our specials are: \n"+
        "Bread, buy 2 get the third one free\n"+
        "and\n"+
        "Pastries, buy 1 for $2 or 3 for $5");
        UserChoice();
      }
      else
      {
        Console.WriteLine("Goodbye");
      }
    }

    public static void Order(OrderSetter _userOrder)
    {
      Console.WriteLine( "you currently have: \n"+
      _userOrder.BreadAmount + " loaves at a cost of $" + _userOrder.BreadCost+ "\n"+
      "and \n"+
      _userOrder.PastryAmount + " pastries at a cost of $" + _userOrder.PastryCost + "\n"+
      "What would you like to order?\n"+
      "Enter 1 for bread\n"+
      "Enter 2 for pastries\n"+
      "Enter 3 to checkout\n"+
      "Enter 4 to empty cart\n"+
      "Enter 5 to exit");
      string userChoice = Console.ReadLine();
      if(userChoice == "1")
      {
        Console.WriteLine("You chose Bread YUM!");
        Console.WriteLine("Enter how many loaves of bread you would like:");
        int _userChoice = int.Parse(Console.ReadLine());
        _userOrder.BreadAmount += _userChoice;
        Console.WriteLine("You have selected " + _userChoice + " loaves of bread\n"+
        "Would you like to add these to your cart?\n"+
        "Enter 1 for Yes\n"+
        "Enter 2 for No");
        userChoice = Console.ReadLine();
        if(userChoice == "1")
        {
          _userOrder.PushOrder("Bread");
          Order(_userOrder);
        }
        else if(userChoice == "2")
        {
          _userOrder.BreadAmount -= _userChoice;
          Order(_userOrder);
        }
      }
      else if(userChoice == "2")
      {
        Console.WriteLine("You chose Pastry YUM!");
        Console.WriteLine("Enter how many pastries you would like:");
        int _userChoice = int.Parse(Console.ReadLine());
        _userOrder.PastryAmount += _userChoice;
        Console.WriteLine("You have selected " + _userChoice + " pastries\n"+
        "Would you like to add these to your cart?\n"+
        "Enter 1 for Yes\n"+
        "Enter 2 for No");
        userChoice = Console.ReadLine();
        if(userChoice == "1")
        {
          _userOrder.PushOrder("Pastry");
          Order(_userOrder);
        }
        else if(userChoice == "2")
        {
          _userOrder.PastryAmount -= _userChoice;
          Order(_userOrder);
        }
        else
        {
        Console.WriteLine("Please enter a valid choice");
        UserChoice();
        }
      }
      else if(userChoice =="3")
      {
        int totalCost = _userOrder.BreadCost + _userOrder.PastryCost;
        Console.WriteLine("You choose to checkout:\n"+
        "your total is $" + totalCost);
      } 
      else if(userChoice =="4")
      {
        _userOrder.EmptyCart();
        Order(_userOrder);
      }
      else if(userChoice == "5")
      {
        UserChoice();
      } 
      else
      {
        Console.WriteLine("Please enter a valid choice");
        Order(_userOrder);
      }   
    }
  }
}
