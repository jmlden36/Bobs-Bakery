namespace BakeryPastry.Models
{
  public class Pastry
  {
    public int RegularPrice { get; set; }
    public int PastryDealCount { get; set; }
    public int PastryDealPrice { get; set; }

    public Pastry(int regularPrice, int pastryDealCount, int pastryDealPrice)
    {
      RegularPrice = 2;
      PastryDealCount = pastryDealCount;
      PastryDealPrice = pastryDealPrice;
    }
    public int PastryCost(int input)
    {
      if (input % PastryDealCount == 0)
      {
        int cost = PastryDealPrice * (input / PastryDealCount);
        return cost;
      }
      else if(input > PastryDealCount)
      {
      int cost = (((input -(input % PastryDealCount)) / PastryDealCount) * PastryDealPrice) + ((input % PastryDealCount) * RegularPrice);
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