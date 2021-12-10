using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadDealPrice { get; set; }

    public int BreadDealCount { get; set; }

    public Bread(int breadDealCount, int breadDealPrice)
    {
      BreadDealCount = breadDealCount;
      BreadDealPrice = breadDealPrice;      
    }
    public static int BreadCost(int input)
    {
      int cost = input * 5;
      return cost;
    }
  }
}