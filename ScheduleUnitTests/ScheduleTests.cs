using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System;
using Microsoft.FSharp.Collections;

namespace ScheduleUnitTests
{
    [TestClass]
    public class ScheduleTests
    {
        private void AssertAreEqual<T>(FSharpList<T> expected, FSharpList<T> actual)
        {
            CollectionAssert.AreEqual(ListModule.ToArray(expected), ListModule.ToArray(actual));
        }

        [TestMethod]
        public void TestSchedule0()
        {
            System.Diagnostics.Stopwatch time = new System.Diagnostics.Stopwatch();
            for (int i = 0; i < 100; i++)
            {
                time.Start();
                var result = Schedule.schedule(TestData.events, TestData.priorities0);
                time.Stop();
            }
            var elapsed = time.ElapsedMilliseconds;

            //AssertAreEqual(TestData.result0, result);
        }

        [TestMethod]
        public void TestSchedule1()
        {
            var result = Schedule.schedule(TestData.events, TestData.priorities1);
            AssertAreEqual(TestData.result1, result);
        }

        [TestMethod]
        public void TestSchedule2()
        {
            var result = Schedule.schedule(TestData.events, TestData.priorities2);
            AssertAreEqual(TestData.result2, result);
        }

        [TestMethod]
        public void TestSchedule3()
        {
            var result = Schedule.schedule(TestData.events, TestData.priorities3);
            AssertAreEqual(TestData.result3, result);
        }

        [TestMethod]
        public void TestSchedule4()
        {
            var result = Schedule.schedule(TestData.events, TestData.priorities4);
            AssertAreEqual(TestData.result4, result);
        }

        [TestMethod]
        public void TestSchedule5()
        {
            var result = Schedule.schedule(TestData.events, TestData.priorities5);
            AssertAreEqual(TestData.result5, result);
        }

        [TestMethod]
        public void TestSchedule6()
        {
            var result = Schedule.schedule(TestData.events, TestData.priorities6);
            AssertAreEqual(TestData.result6, result);
        }

        [TestMethod]
        public void TestSchedule7()
        {
            var result = Schedule.schedule(TestData.events, TestData.priorities7);
            AssertAreEqual(TestData.result7, result);
        }

        [TestMethod]
        public void TestSchedule8()
        {
            var result = Schedule.schedule(TestData.events, TestData.priorities8);
            AssertAreEqual(TestData.result8, result);
        }

        [TestMethod]
        public void TestSchedule9()
        {
            var result = Schedule.schedule(TestData.events, TestData.priorities9);
            AssertAreEqual(TestData.result9, result);
        }

    }
}
