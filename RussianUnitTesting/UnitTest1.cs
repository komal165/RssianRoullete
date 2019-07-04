using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RssianRoullete;

namespace RussianUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        Roulleteclass unitTestobj = new Roulleteclass();

        [TestMethod]
        public void TestSpinloadedbullete()
        {
            var tac = unitTestobj.Spinloadedbullete(lodedbullete: 5);
            Assert.AreEqual(expected: 6, actual: tac);


        }
        public void TestSpinloadebullete()
        {
            var tac = unitTestobj.Spinloadedbullete(lodedbullete: 5);
            Assert.AreNotEqual(notExpected: 5, actual: tac);


        }
    }
}
