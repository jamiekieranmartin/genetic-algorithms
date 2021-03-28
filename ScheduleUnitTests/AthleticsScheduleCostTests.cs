using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System;
using Microsoft.FSharp.Collections;

namespace ScheduleUnitTests
{
    [TestClass]
    public class AthleticsScheduleCostTests
    {
        [TestMethod]
        public void TestScheduleNext0()
        {
            var function = Schedule.athleticsScheduleCost(TestData.events);
            var result = function.Invoke(TestData.priorities0);
            Assert.AreEqual(-160, result);
        }

        [TestMethod]
        public void TestScheduleNext1()
        {
            var function = Schedule.athleticsScheduleCost(TestData.events);
            var result = function.Invoke(TestData.priorities1);
            Assert.AreEqual(-160, result);
        }

        [TestMethod]
        public void TestScheduleNext2()
        {
            var function = Schedule.athleticsScheduleCost(TestData.events);
            var result = function.Invoke(TestData.priorities2);
            Assert.AreEqual(-165, result);
        }

        [TestMethod]
        public void TestScheduleNext3()
        {
            var function = Schedule.athleticsScheduleCost(TestData.events);
            var result = function.Invoke(TestData.priorities3);
            Assert.AreEqual(-167, result);
        }

        [TestMethod]
        public void TestScheduleNext4()
        {
            var function = Schedule.athleticsScheduleCost(TestData.events);
            var result = function.Invoke(TestData.priorities4);
            Assert.AreEqual(-160, result);
        }

        [TestMethod]
        public void TestScheduleNext5()
        {
            var function = Schedule.athleticsScheduleCost(TestData.events);
            var result = function.Invoke(TestData.priorities5);
            Assert.AreEqual(-160, result);
        }

        [TestMethod]
        public void TestScheduleNext6()
        {
            var function = Schedule.athleticsScheduleCost(TestData.events);
            var result = function.Invoke(TestData.priorities6);
            Assert.AreEqual(-160, result);
        }

        [TestMethod]
        public void TestScheduleNext7()
        {
            var function = Schedule.athleticsScheduleCost(TestData.events);
            var result = function.Invoke(TestData.priorities7);
            Assert.AreEqual(-160, result);
        }

        [TestMethod]
        public void TestScheduleNext8()
        {
            var function = Schedule.athleticsScheduleCost(TestData.events);
            var result = function.Invoke(TestData.priorities8);
            Assert.AreEqual(-160, result);
        }

        [TestMethod]
        public void TestScheduleNext9()
        {
            var function = Schedule.athleticsScheduleCost(TestData.events);
            var result = function.Invoke(TestData.priorities9);
            Assert.AreEqual(-181, result);
        }

    }
}
