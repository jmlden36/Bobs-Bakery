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

    Console.WriteLine("test");
  }
}