using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint2.Task4.V10.Lib;

namespace Tyuiu.PolyantsevEI.Sprint2.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 9;
            double res = ds.Calculate(x, y);
            double wait = 1.037;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 21.5;
            Assert.AreEqual(wait, res);
        }
    }
}
