using System;
using System.Collections.Generic;
using BakeryPastry.Models;
using BakeryBread.Models;


public class Program
{
  public static void Main()
  {
    Bread breadDeals = new Bread(5, 3, 10);
    Pastry pastryDeals = new Pastry(2, 3, 5);

    Console.WriteLine("\n\n\nWelcome to Pierre's Bakery.  Today's prices are\n===============================================\n  Bread: 1 for $" + breadDeals.RegularPrice + ".\n  Today's Bread Deal: Buy 2 get 1 free!\n\n  Pastry: 1 for $" + pastryDeals.RegularPrice + ".\n  Today's Pastry Deal: Buy 2 get the third half off!");
    Console.WriteLine("\n\n\nHow many loafs of your bread would you like?\n\nPlease enter a number");
    int breadNum = int.Parse(Console.ReadLine());
    Console.WriteLine("\n\n\nHow many pastries would you like?\n\nPlease enter a number");
    int pastryNum = int.Parse(Console.ReadLine());
    Console.WriteLine("Does this order look correct?\n  " + breadNum + " loafs of bread\n  " + pastryNum + " pastries\n'Y' for yes or 'N' for no");
    string correctOrder = (Console.ReadLine()).ToLower();
    Console.WriteLine(correctOrder);
  }
}