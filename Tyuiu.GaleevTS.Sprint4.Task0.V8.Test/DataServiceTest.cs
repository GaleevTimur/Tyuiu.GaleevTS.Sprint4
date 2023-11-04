using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GaleevTS.Sprint4.Task0.V8.Lib;
namespace Tyuiu.GaleevTS.Sprint4.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };
            int res = ds.GetMultEvenArrEl(array);
            int wait = 384;
            Assert.AreEqual(wait, res);
        }
    }
}
