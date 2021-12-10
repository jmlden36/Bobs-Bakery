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
  }
}