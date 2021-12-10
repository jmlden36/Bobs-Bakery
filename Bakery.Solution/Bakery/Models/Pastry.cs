namespace BakeryPastry.Models
{
  public class Pastry
  {
    public int RegularPrice { get; set; }
    public int PastryDealCount { get; set; }
    public double PastryDealPrice { get; set; }

    public Pastry(int regularPrice, int pastryDealCount, double pastryDealPrice)
    {
      RegularPrice = 2;
      PastryDealCount = pastryDealCount;
      PastryDealPrice = pastryDealPrice;
    }
    public int PastryCost(int input)
    {
      int cost = input * 2;
      return cost;
    }
  }
}