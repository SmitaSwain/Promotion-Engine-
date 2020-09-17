using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetTotal()
        {
            Program p = new Program();
            int total = p.CalculateTotal(1, 1, 1, 0);
            Assert.AreEqual(100, total);

        }
    }
}
