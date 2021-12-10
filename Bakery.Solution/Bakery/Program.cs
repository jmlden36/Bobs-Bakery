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
    int breadNum = int.Parse(Console.ReadLine()); 
    
    Console.WriteLine("\n\n\nHow many danishes would you like?\n\nPlease enter a number");
    int pastryNum = int.Parse(Console.ReadLine());
    
    Console.WriteLine("\n\n\nHow many loaves of french bread would you like?\n\nPlease enter a number");
    int frBreadNum = int.Parse(Console.ReadLine());

    Console.WriteLine("\n\n\nDoes this order look correct?\n  " + breadNum + " loaves of sourdough bread\n  " + pastryNum + " danishes\n  " + frBreadNum + " loaves of french bread\n'Y' for yes or 'N' for no");
    string correctOrder = (Console.ReadLine()).ToLower();    
    Console.WriteLine("Your total will be: $" + CalcTotal(breadDeals.BreadCost(breadNum), (pastryDeals.PastryCost(pastryNum)), (frBreadDeals.BreadCost(frBreadNum))));
  }
}