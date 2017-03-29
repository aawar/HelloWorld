using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace HelloWorldTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreateMessage()
        {
            Assert.AreEqual("Hello World", Program.CreateMessage());
        }

        [TestMethod]
        public void TestCalucalteSum()
        {
            Assert.AreEqual(5, Program.CalculateSum(3, 2));
        }

        [TestMethod]
        public void TestCalucalteDifference()
        {
            Assert.AreEqual(1, Program.CalculateDifference(3, 2));
        }
    }
}
