using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint2.Task5.V8.Lib;

namespace Tyuiu.PolyantsevEI.Sprint2.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            Assert.AreEqual("28.2", ds.FindDateOfPreviousDay(3, 1));
            Assert.AreEqual("15.6", ds.FindDateOfPreviousDay(6, 16));
        }
    }
}
