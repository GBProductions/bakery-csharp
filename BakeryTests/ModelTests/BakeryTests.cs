using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
    [TestClass]
    public class BakeryTests
    {
        [TestMethod]
        public void BakeryCost_BreadCostsFiveDollars_True()
        {
            Bakery testBakery = Bakery();
            Assert.AreEqual(true, testbakeryCost.Bakery(5));
        }
    }
}