using System;
using System.Collections.Generic;

namespace BakeryBread.Models
{
  public class Bread
  {    
    public int RegularPrice { get; set; }
    public int BreadDealPrice { get; set; }
    public int BreadDealCount { get; set; }

    public Bread(int regularPrice, int breadDealCount, int breadDealPrice)
    {
      RegularPrice = 5;
      BreadDealCount = breadDealCount;
      BreadDealPrice = breadDealPrice;      
    }
    public int BreadCost(int input)
    {
      if (input % this.BreadDealCount == 0)
      {
        int cost = BreadDealPrice * (input/this.BreadDealCount);
        return cost;
      }
      else
      {
      int cost = input * this.RegularPrice;
      return cost; 
      }
    } 
  }
}