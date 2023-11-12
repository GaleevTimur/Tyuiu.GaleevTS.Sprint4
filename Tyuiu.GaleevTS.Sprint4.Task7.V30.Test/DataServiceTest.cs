using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GaleevTS.Sprint4.Task7.V30.Lib;

namespace Tyuiu.GaleevTS.Sprint4.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 5;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "684259137159648";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 73728;
            Assert.AreEqual(wait, res);


        }
    }
}
