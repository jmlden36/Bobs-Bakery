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
      if (input % this.PastryDealCount == 0)
      {
        int cost = this.PastryDealPrice * (input/this.PastryDealCount);
        return cost;
      }
      else
      {
        int cost = this.RegularPrice * input;
        return cost;
      }
    }
  }
}