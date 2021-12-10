using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryPastry.Models;

namespace BakeryPastry.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(2, 3, 5);            
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void PastryCost_CalculatesCostOfOnePastry_True()
    {
      Pastry newPastry = new Pastry(2, 3, 5);
      int pastryCount = 1;
      int pastryCost = newPastry.PastryCost(pastryCount);
      int expectedCost = 2;      
      Assert.AreEqual(pastryCost, expectedCost);
    }

    [TestMethod]
    public void PastryCost_CalculatesCostOfTwoPastry_True()
    {
      Pastry newPastry = new Pastry(2, 3, 5);
      int pastryCount = 2;
      int pastryCost = newPastry.PastryCost(pastryCount);
      int expectedCost = 4;      
      Assert.AreEqual(pastryCost, expectedCost);
    }


    [TestMethod]
    public void PastryCost_CalculatesCostOfThreePastry_True()
    {
      Pastry newPastry = new Pastry(2, 3, 5);
      int pastryCount = 3;
      int pastryCost = newPastry.PastryCost(pastryCount);
      int expectedCost = 5;      
      Assert.AreEqual(pastryCost, expectedCost);
    }


    [TestMethod]
    public void PastryCost_CalculatesCostOfFourPastry_True()
    {
      Pastry newPastry = new Pastry(2, 3, 5);
      int pastryCount = 4;
      int pastryCost = newPastry.PastryCost(pastryCount);
      int expectedCost = 7;      
      Assert.AreEqual(pastryCost, expectedCost);
    }


    [TestMethod]
    public void PastryCost_CalculatesCostOfFortyFourPastry_True()
    {
      Pastry newPastry = new Pastry(2, 3, 5);
      int pastryCount = 44;
      int pastryCost = newPastry.PastryCost(pastryCount);
      int expectedCost = 74;      
      Assert.AreEqual(pastryCost, expectedCost);
    }
  }
}