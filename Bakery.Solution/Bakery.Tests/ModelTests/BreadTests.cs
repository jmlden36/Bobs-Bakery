using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadCost_CalculatesCostOfOneBread_True()
    {
      int breadCount = 1;
      int breadCost = Bread.BreadCost(breadCount);
      int expectedCost = 5;      
      Assert.AreEqual(breadCost, expectedCost);
    }
  }
}