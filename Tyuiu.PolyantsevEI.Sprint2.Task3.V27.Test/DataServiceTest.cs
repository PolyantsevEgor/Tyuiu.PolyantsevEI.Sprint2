using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint2.Task3.V27.Lib;

namespace Tyuiu.PolyantsevEI.Sprint2.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = -32;
            double res = Math.Round(ds.Calculate(x),3);
            double wait = -32798.961;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = -1;
            double res = Math.Round(ds.Calculate(x), 3);
            double wait = 4;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = Math.Round(ds.Calculate(x), 3);
            double wait = 0.25;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = Math.Round(ds.Calculate(x), 3);
            double wait = 1.491;
            Assert.AreEqual(wait, res);
        }
    }
}
