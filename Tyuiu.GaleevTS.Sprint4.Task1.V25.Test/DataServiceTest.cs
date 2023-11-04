using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GaleevTS.Sprint4.Task1.V25.Lib;

namespace Tyuiu.GaleevTS.Sprint4.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 6, 3, 6, 4, 7, 4, 6, 5, 2, 3, 6, 3, 6, 2 };
            int res = ds.Calculate(numsArray);
            int wait = 42;
            Assert.AreEqual(wait, res);
        }
    }
}
