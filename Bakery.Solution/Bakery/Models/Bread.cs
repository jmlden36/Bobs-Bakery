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
      
      int cost = input * this.RegularPrice;
      return cost; 
    }
      
      
    
  }
}