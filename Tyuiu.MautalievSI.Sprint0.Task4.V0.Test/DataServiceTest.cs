using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MautalievSI.Sprint0.Task4.V0.Lib;

namespace Tyuiu.MautalievSI.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionalValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]
        public void CheckedSubstractionValid()
        {
            Assert.AreEqual(5, DataService.Substraction(10, 5));
        }

        [TestMethod]
        public void CheckedMultiplicationValid() 
        {
            Assert.AreEqual(9, DataService.Multiplication(3, 3));
        }

        [TestMethod]
        public void CheckDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
