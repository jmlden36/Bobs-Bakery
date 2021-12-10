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
      if (input % BreadDealCount == 0)
      {
        int cost = BreadDealPrice * (input / BreadDealCount);
        return cost;
      }
      else if(input > BreadDealCount)
      {
      int cost = (((input -(input % BreadDealCount)) / BreadDealCount) * BreadDealPrice) + ((input % BreadDealCount) * RegularPrice);
      return cost; 
      }
      else
      {
        int cost = input * RegularPrice;
        return cost;
      }
    } 
  }
}