using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GaleevTS.Sprint4.Task5.V19.Lib;

namespace Tyuiu.GaleevTS.Sprint4.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { -1, 2, -2, 0, -2 },
                                          { 1, -1, -2, 3, 0 },
                                          { 3, 0, 1, 3, 0 },
                                          { 2, -1, -1, -1, -1 },
                                          { 2, 1, 1, 0, 2 } };
            int res = ds.Calculate(mas2);
            int wait = 16;
            Assert.AreEqual(wait, res);
        }
    }
}
