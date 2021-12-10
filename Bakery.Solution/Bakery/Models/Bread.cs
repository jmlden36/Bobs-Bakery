using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public static int BreadCost(int input)
    {
      int cost = input * 5;
      return cost;
    }
  }
}