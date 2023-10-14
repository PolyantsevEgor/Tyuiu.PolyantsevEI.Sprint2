using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint2.Task7.V3.Lib;

namespace Tyuiu.PolyantsevEI.Sprint2.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0.25, 0.5));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(0, -0.25));
        }
    }
}
