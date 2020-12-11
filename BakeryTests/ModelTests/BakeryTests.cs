using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void BakeryCost_BreadCostsFiveDollars_True()
        {
            Bread testBread = new Bread();
            Assert.AreEqual(true, testBread.BreadCost(5));
        }

        // [TestMethod]
        // public void BakeryCost_BreadCostsFiveDollars_True()
        // {
        //     Bread testBread = new Bread();
        //     Assert.AreEqual(true, testBread.BreadCost(5));
        // }
    }
}