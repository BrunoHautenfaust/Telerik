using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppearanceCount;

namespace AppearanceCount.Tests
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCounting(int[] someArray, int number)
        {

            Assert.AreEqual(Some.AppearanceCount.CountNum(new int[] { 1, 2, 3 }, 2), "Value is different");

        }


    }
}
