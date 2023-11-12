using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GaleevTS.Sprint4.Task6.V29.Lib;

namespace Tyuiu.GaleevTS.Sprint4.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var season = new string[] { "Весна", "Лето", "Осень", "Зима" };
            int res = ds.Calculate(season);
            int wait = 2;
            Assert.AreEqual(res, wait);

            
        }
    }
}
