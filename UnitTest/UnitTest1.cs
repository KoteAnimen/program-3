using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tasks;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double expected = 2097153.92533714;
            Assert.AreEqual(expected, Tasks.Task1(2), .001);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(62748519.4916079, Tasks.Task1(3), .001);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(1.6896807853789595, Tasks.Task2(3), .001);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(5.0892088326460848, Tasks.Task2(4), .001);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(1.25, Tasks.Task3(2), .001);
        }

    }
}
