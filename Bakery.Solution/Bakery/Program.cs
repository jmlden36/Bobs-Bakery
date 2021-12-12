using System;
using BakeryPastry.Models;
using BakeryBread.Models;


public class Program
{ 
  public static int CalcTotal(int val1, int val2, int val3)
  {
    int total = val1 + val2 + val3;
    return total;
  }
  public static void Main()
  {
    Bread breadDeals = new Bread(5, 3, 10);
    Bread frBreadDeals = new Bread(4, 3, 8);
    Pastry pastryDeals = new Pastry(2, 3, 5);
    

    Console.WriteLine("\n\n\nWelcome to Pierre's Bakery.  Here are today's prices:\n=====================================================\n  Bread: 1 sourdough loaf for $" + breadDeals.RegularPrice + "\n         1 french bread loaf for $" + frBreadDeals.RegularPrice + "\n\n  -->Today's Bread Deal: Buy 2 get 1 free!\n\n  Pastry: 1 danish for $" + pastryDeals.RegularPrice + ".\n\n  -->Today's Pastry Deal: Buy 2 get the third half off!");
    
    Console.WriteLine("\n\n\nHow many loaves of sourdough bread would you like?\n\nPlease enter a number");
    var breadNumAsString = Console.ReadLine();
    int breadNum;
    while(!int.TryParse(breadNumAsString, out breadNum))
    {
      Console.WriteLine("this is not a number! Please enter a number.");
      breadNumAsString = Console.ReadLine();
    }
    
    Console.WriteLine("\n\n\nHow many danishes would you like?\n\nPlease enter a number");
    var pastryNumAsString = Console.ReadLine();
    int pastryNum;
    while(!int.TryParse(pastryNumAsString, out pastryNum))
    {
      Console.WriteLine("this is not a number! Please enter a number.");
      pastryNumAsString = Console.ReadLine();
    }

    Console.WriteLine("\n\n\nHow many loaves of french bread would you like?\n\nPlease enter a number");
    var frBreadNumAsString = Console.ReadLine();
    int frBreadNum;
    while(!int.TryParse(frBreadNumAsString, out frBreadNum))
    {
      Console.WriteLine("this is not a number! Please enter a number.");
      frBreadNumAsString = Console.ReadLine();
    }
    
    Console.WriteLine("\n\n\nDoes this order look correct?\n  " + breadNum + " loaves of sourdough bread\n  " + pastryNum + " danishes\n  " + frBreadNum + " loaves of french bread\n'Y' for yes or 'N' for no");
    string correctOrder = (Console.ReadLine()).ToLower();    
    if (correctOrder == "n" || correctOrder == "N")
    {
      Console.WriteLine("Try again");
      Main();
    }
    else if (correctOrder == "y" || correctOrder == "Y") 
    {
      Console.WriteLine("Your total will be: $" + CalcTotal(breadDeals.BreadCost(breadNum), (pastryDeals.PastryCost(pastryNum)), (frBreadDeals.BreadCost(frBreadNum))));
      Console.WriteLine("Thanks for your order!");
      Console.WriteLine("\n\n\nWould you like to make another order?\n'Y' for yes or 'N' for no");
      string againOrNot = Console.ReadLine();
      if (againOrNot == "y" || againOrNot == "Y")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Thanks for visiting.  Come again!");
      }
    }
    else
    {
      Console.WriteLine("Start over and use a valid input");
      Main();
    }
  }
}