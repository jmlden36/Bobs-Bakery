using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryBread.Models;

namespace BakeryBread.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(5, 3, 10);            
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void BreadCost_CalculatesCostOfOneBread_True()
    {
      Bread newBread = new Bread(5, 3, 10);
      int breadCount = 1;
      int breadCost = newBread.BreadCost(breadCount);
      int expectedCost = 5;      
      Assert.AreEqual(breadCost, expectedCost);
    }
  }
}