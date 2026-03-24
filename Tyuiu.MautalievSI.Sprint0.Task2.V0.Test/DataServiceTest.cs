using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MautalievSI.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MautalievSI.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Саидамир";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Саидамир", res);
        }
    }
}
