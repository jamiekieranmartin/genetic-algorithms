using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System;
using Microsoft.FSharp.Collections;

namespace ScheduleUnitTests
{
    [TestClass]
    public class ScheduleNextTests
    {
        private void AssertAreEqual<T>(FSharpList<T> expected, FSharpList<T> actual)
        {
            CollectionAssert.AreEqual(ListModule.ToArray(expected), ListModule.ToArray(actual));
        }

        [TestMethod]
        public void TestScheduleNext000()
        {
            var result = Schedule.scheduleNext(TestData.scheduled0, TestData.event58);
            AssertAreEqual(TestData.scheduled1, result);
        }

        [TestMethod]
        public void TestScheduleNext001()
        {
            var result = Schedule.scheduleNext(TestData.scheduled1, TestData.event66);
            AssertAreEqual(TestData.scheduled2, result);
        }

        [TestMethod]
        public void TestScheduleNext002()
        {
            var result = Schedule.scheduleNext(TestData.scheduled2, TestData.event61);
            AssertAreEqual(TestData.scheduled3, result);
        }

        [TestMethod]
        public void TestScheduleNext003()
        {
            var result = Schedule.scheduleNext(TestData.scheduled3, TestData.event43);
            AssertAreEqual(TestData.scheduled4, result);
        }

        [TestMethod]
        public void TestScheduleNext004()
        {
            var result = Schedule.scheduleNext(TestData.scheduled4, TestData.event15);
            AssertAreEqual(TestData.scheduled5, result);
        }

        [TestMethod]
        public void TestScheduleNext005()
        {
            var result = Schedule.scheduleNext(TestData.scheduled5, TestData.event44);
            AssertAreEqual(TestData.scheduled6, result);
        }

        [TestMethod]
        public void TestScheduleNext006()
        {
            var result = Schedule.scheduleNext(TestData.scheduled6, TestData.event73);
            AssertAreEqual(TestData.scheduled7, result);
        }

        [TestMethod]
        public void TestScheduleNext007()
        {
            var result = Schedule.scheduleNext(TestData.scheduled7, TestData.event33);
            AssertAreEqual(TestData.scheduled8, result);
        }

        [TestMethod]
        public void TestScheduleNext008()
        {
            var result = Schedule.scheduleNext(TestData.scheduled8, TestData.event79);
            AssertAreEqual(TestData.scheduled9, result);
        }

        [TestMethod]
        public void TestScheduleNext009()
        {
            var result = Schedule.scheduleNext(TestData.scheduled9, TestData.event20);
            AssertAreEqual(TestData.scheduled10, result);
        }

        [TestMethod]
        public void TestScheduleNext010()
        {
            var result = Schedule.scheduleNext(TestData.scheduled10, TestData.event22);
            AssertAreEqual(TestData.scheduled11, result);
        }

        [TestMethod]
        public void TestScheduleNext011()
        {
            var result = Schedule.scheduleNext(TestData.scheduled11, TestData.event36);
            AssertAreEqual(TestData.scheduled12, result);
        }

        [TestMethod]
        public void TestScheduleNext012()
        {
            var result = Schedule.scheduleNext(TestData.scheduled12, TestData.event50);
            AssertAreEqual(TestData.scheduled13, result);
        }

        [TestMethod]
        public void TestScheduleNext013()
        {
            var result = Schedule.scheduleNext(TestData.scheduled13, TestData.event35);
            AssertAreEqual(TestData.scheduled14, result);
        }

        [TestMethod]
        public void TestScheduleNext014()
        {
            var result = Schedule.scheduleNext(TestData.scheduled14, TestData.event78);
            AssertAreEqual(TestData.scheduled15, result);
        }

        [TestMethod]
        public void TestScheduleNext015()
        {
            var result = Schedule.scheduleNext(TestData.scheduled15, TestData.event2);
            AssertAreEqual(TestData.scheduled16, result);
        }

        [TestMethod]
        public void TestScheduleNext016()
        {
            var result = Schedule.scheduleNext(TestData.scheduled16, TestData.event69);
            AssertAreEqual(TestData.scheduled17, result);
        }

        [TestMethod]
        public void TestScheduleNext017()
        {
            var result = Schedule.scheduleNext(TestData.scheduled17, TestData.event80);
            AssertAreEqual(TestData.scheduled18, result);
        }

        [TestMethod]
        public void TestScheduleNext018()
        {
            var result = Schedule.scheduleNext(TestData.scheduled18, TestData.event52);
            AssertAreEqual(TestData.scheduled19, result);
        }

        [TestMethod]
        public void TestScheduleNext019()
        {
            var result = Schedule.scheduleNext(TestData.scheduled19, TestData.event23);
            AssertAreEqual(TestData.scheduled20, result);
        }

        [TestMethod]
        public void TestScheduleNext020()
        {
            var result = Schedule.scheduleNext(TestData.scheduled20, TestData.event63);
            AssertAreEqual(TestData.scheduled21, result);
        }

        [TestMethod]
        public void TestScheduleNext021()
        {
            var result = Schedule.scheduleNext(TestData.scheduled21, TestData.event65);
            AssertAreEqual(TestData.scheduled22, result);
        }

        [TestMethod]
        public void TestScheduleNext022()
        {
            var result = Schedule.scheduleNext(TestData.scheduled22, TestData.event77);
            AssertAreEqual(TestData.scheduled23, result);
        }

        [TestMethod]
        public void TestScheduleNext023()
        {
            var result = Schedule.scheduleNext(TestData.scheduled23, TestData.event1);
            AssertAreEqual(TestData.scheduled24, result);
        }

        [TestMethod]
        public void TestScheduleNext024()
        {
            var result = Schedule.scheduleNext(TestData.scheduled24, TestData.event51);
            AssertAreEqual(TestData.scheduled25, result);
        }

        [TestMethod]
        public void TestScheduleNext025()
        {
            var result = Schedule.scheduleNext(TestData.scheduled25, TestData.event38);
            AssertAreEqual(TestData.scheduled26, result);
        }

        [TestMethod]
        public void TestScheduleNext026()
        {
            var result = Schedule.scheduleNext(TestData.scheduled26, TestData.event72);
            AssertAreEqual(TestData.scheduled27, result);
        }

        [TestMethod]
        public void TestScheduleNext027()
        {
            var result = Schedule.scheduleNext(TestData.scheduled27, TestData.event49);
            AssertAreEqual(TestData.scheduled28, result);
        }

        [TestMethod]
        public void TestScheduleNext028()
        {
            var result = Schedule.scheduleNext(TestData.scheduled28, TestData.event37);
            AssertAreEqual(TestData.scheduled29, result);
        }

        [TestMethod]
        public void TestScheduleNext029()
        {
            var result = Schedule.scheduleNext(TestData.scheduled29, TestData.event6);
            AssertAreEqual(TestData.scheduled30, result);
        }

        [TestMethod]
        public void TestScheduleNext030()
        {
            var result = Schedule.scheduleNext(TestData.scheduled30, TestData.event12);
            AssertAreEqual(TestData.scheduled31, result);
        }

        [TestMethod]
        public void TestScheduleNext031()
        {
            var result = Schedule.scheduleNext(TestData.scheduled31, TestData.event30);
            AssertAreEqual(TestData.scheduled32, result);
        }

        [TestMethod]
        public void TestScheduleNext032()
        {
            var result = Schedule.scheduleNext(TestData.scheduled32, TestData.event19);
            AssertAreEqual(TestData.scheduled33, result);
        }

        [TestMethod]
        public void TestScheduleNext033()
        {
            var result = Schedule.scheduleNext(TestData.scheduled33, TestData.event76);
            AssertAreEqual(TestData.scheduled34, result);
        }

        [TestMethod]
        public void TestScheduleNext034()
        {
            var result = Schedule.scheduleNext(TestData.scheduled34, TestData.event47);
            AssertAreEqual(TestData.scheduled35, result);
        }

        [TestMethod]
        public void TestScheduleNext035()
        {
            var result = Schedule.scheduleNext(TestData.scheduled35, TestData.event57);
            AssertAreEqual(TestData.scheduled36, result);
        }

        [TestMethod]
        public void TestScheduleNext036()
        {
            var result = Schedule.scheduleNext(TestData.scheduled36, TestData.event3);
            AssertAreEqual(TestData.scheduled37, result);
        }

        [TestMethod]
        public void TestScheduleNext037()
        {
            var result = Schedule.scheduleNext(TestData.scheduled37, TestData.event26);
            AssertAreEqual(TestData.scheduled38, result);
        }

        [TestMethod]
        public void TestScheduleNext038()
        {
            var result = Schedule.scheduleNext(TestData.scheduled38, TestData.event24);
            AssertAreEqual(TestData.scheduled39, result);
        }

        [TestMethod]
        public void TestScheduleNext039()
        {
            var result = Schedule.scheduleNext(TestData.scheduled39, TestData.event74);
            AssertAreEqual(TestData.scheduled40, result);
        }

        [TestMethod]
        public void TestScheduleNext040()
        {
            var result = Schedule.scheduleNext(TestData.scheduled40, TestData.event34);
            AssertAreEqual(TestData.scheduled41, result);
        }

        [TestMethod]
        public void TestScheduleNext041()
        {
            var result = Schedule.scheduleNext(TestData.scheduled41, TestData.event54);
            AssertAreEqual(TestData.scheduled42, result);
        }

        [TestMethod]
        public void TestScheduleNext042()
        {
            var result = Schedule.scheduleNext(TestData.scheduled42, TestData.event8);
            AssertAreEqual(TestData.scheduled43, result);
        }

        [TestMethod]
        public void TestScheduleNext043()
        {
            var result = Schedule.scheduleNext(TestData.scheduled43, TestData.event17);
            AssertAreEqual(TestData.scheduled44, result);
        }

        [TestMethod]
        public void TestScheduleNext044()
        {
            var result = Schedule.scheduleNext(TestData.scheduled44, TestData.event68);
            AssertAreEqual(TestData.scheduled45, result);
        }

        [TestMethod]
        public void TestScheduleNext045()
        {
            var result = Schedule.scheduleNext(TestData.scheduled45, TestData.event59);
            AssertAreEqual(TestData.scheduled46, result);
        }

        [TestMethod]
        public void TestScheduleNext046()
        {
            var result = Schedule.scheduleNext(TestData.scheduled46, TestData.event21);
            AssertAreEqual(TestData.scheduled47, result);
        }

        [TestMethod]
        public void TestScheduleNext047()
        {
            var result = Schedule.scheduleNext(TestData.scheduled47, TestData.event31);
            AssertAreEqual(TestData.scheduled48, result);
        }

        [TestMethod]
        public void TestScheduleNext048()
        {
            var result = Schedule.scheduleNext(TestData.scheduled48, TestData.event9);
            AssertAreEqual(TestData.scheduled49, result);
        }

        [TestMethod]
        public void TestScheduleNext049()
        {
            var result = Schedule.scheduleNext(TestData.scheduled49, TestData.event14);
            AssertAreEqual(TestData.scheduled50, result);
        }

        [TestMethod]
        public void TestScheduleNext050()
        {
            var result = Schedule.scheduleNext(TestData.scheduled50, TestData.event29);
            AssertAreEqual(TestData.scheduled51, result);
        }

        [TestMethod]
        public void TestScheduleNext051()
        {
            var result = Schedule.scheduleNext(TestData.scheduled51, TestData.event55);
            AssertAreEqual(TestData.scheduled52, result);
        }

        [TestMethod]
        public void TestScheduleNext052()
        {
            var result = Schedule.scheduleNext(TestData.scheduled52, TestData.event45);
            AssertAreEqual(TestData.scheduled53, result);
        }

        [TestMethod]
        public void TestScheduleNext053()
        {
            var result = Schedule.scheduleNext(TestData.scheduled53, TestData.event39);
            AssertAreEqual(TestData.scheduled54, result);
        }

        [TestMethod]
        public void TestScheduleNext054()
        {
            var result = Schedule.scheduleNext(TestData.scheduled54, TestData.event11);
            AssertAreEqual(TestData.scheduled55, result);
        }

        [TestMethod]
        public void TestScheduleNext055()
        {
            var result = Schedule.scheduleNext(TestData.scheduled55, TestData.event67);
            AssertAreEqual(TestData.scheduled56, result);
        }

        [TestMethod]
        public void TestScheduleNext056()
        {
            var result = Schedule.scheduleNext(TestData.scheduled56, TestData.event62);
            AssertAreEqual(TestData.scheduled57, result);
        }

        [TestMethod]
        public void TestScheduleNext057()
        {
            var result = Schedule.scheduleNext(TestData.scheduled57, TestData.event53);
            AssertAreEqual(TestData.scheduled58, result);
        }

        [TestMethod]
        public void TestScheduleNext058()
        {
            var result = Schedule.scheduleNext(TestData.scheduled58, TestData.event64);
            AssertAreEqual(TestData.scheduled59, result);
        }

        [TestMethod]
        public void TestScheduleNext059()
        {
            var result = Schedule.scheduleNext(TestData.scheduled59, TestData.event42);
            AssertAreEqual(TestData.scheduled60, result);
        }

        [TestMethod]
        public void TestScheduleNext060()
        {
            var result = Schedule.scheduleNext(TestData.scheduled60, TestData.event41);
            AssertAreEqual(TestData.scheduled61, result);
        }

        [TestMethod]
        public void TestScheduleNext061()
        {
            var result = Schedule.scheduleNext(TestData.scheduled61, TestData.event10);
            AssertAreEqual(TestData.scheduled62, result);
        }

        [TestMethod]
        public void TestScheduleNext062()
        {
            var result = Schedule.scheduleNext(TestData.scheduled62, TestData.event71);
            AssertAreEqual(TestData.scheduled63, result);
        }

        [TestMethod]
        public void TestScheduleNext063()
        {
            var result = Schedule.scheduleNext(TestData.scheduled63, TestData.event70);
            AssertAreEqual(TestData.scheduled64, result);
        }

        [TestMethod]
        public void TestScheduleNext064()
        {
            var result = Schedule.scheduleNext(TestData.scheduled64, TestData.event4);
            AssertAreEqual(TestData.scheduled65, result);
        }

        [TestMethod]
        public void TestScheduleNext065()
        {
            var result = Schedule.scheduleNext(TestData.scheduled65, TestData.event56);
            AssertAreEqual(TestData.scheduled66, result);
        }

        [TestMethod]
        public void TestScheduleNext066()
        {
            var result = Schedule.scheduleNext(TestData.scheduled66, TestData.event7);
            AssertAreEqual(TestData.scheduled67, result);
        }

        [TestMethod]
        public void TestScheduleNext067()
        {
            var result = Schedule.scheduleNext(TestData.scheduled67, TestData.event40);
            AssertAreEqual(TestData.scheduled68, result);
        }

        [TestMethod]
        public void TestScheduleNext068()
        {
            var result = Schedule.scheduleNext(TestData.scheduled68, TestData.event48);
            AssertAreEqual(TestData.scheduled69, result);
        }

        [TestMethod]
        public void TestScheduleNext069()
        {
            var result = Schedule.scheduleNext(TestData.scheduled69, TestData.event13);
            AssertAreEqual(TestData.scheduled70, result);
        }

        [TestMethod]
        public void TestScheduleNext070()
        {
            var result = Schedule.scheduleNext(TestData.scheduled70, TestData.event75);
            AssertAreEqual(TestData.scheduled71, result);
        }

        [TestMethod]
        public void TestScheduleNext071()
        {
            var result = Schedule.scheduleNext(TestData.scheduled71, TestData.event25);
            AssertAreEqual(TestData.scheduled72, result);
        }

        [TestMethod]
        public void TestScheduleNext072()
        {
            var result = Schedule.scheduleNext(TestData.scheduled72, TestData.event28);
            AssertAreEqual(TestData.scheduled73, result);
        }

        [TestMethod]
        public void TestScheduleNext073()
        {
            var result = Schedule.scheduleNext(TestData.scheduled73, TestData.event32);
            AssertAreEqual(TestData.scheduled74, result);
        }

        [TestMethod]
        public void TestScheduleNext074()
        {
            var result = Schedule.scheduleNext(TestData.scheduled74, TestData.event46);
            AssertAreEqual(TestData.scheduled75, result);
        }

        [TestMethod]
        public void TestScheduleNext075()
        {
            var result = Schedule.scheduleNext(TestData.scheduled75, TestData.event0);
            AssertAreEqual(TestData.scheduled76, result);
        }

        [TestMethod]
        public void TestScheduleNext076()
        {
            var result = Schedule.scheduleNext(TestData.scheduled76, TestData.event27);
            AssertAreEqual(TestData.scheduled77, result);
        }

        [TestMethod]
        public void TestScheduleNext077()
        {
            var result = Schedule.scheduleNext(TestData.scheduled77, TestData.event18);
            AssertAreEqual(TestData.scheduled78, result);
        }

        [TestMethod]
        public void TestScheduleNext078()
        {
            var result = Schedule.scheduleNext(TestData.scheduled78, TestData.event5);
            AssertAreEqual(TestData.scheduled79, result);
        }

        [TestMethod]
        public void TestScheduleNext079()
        {
            var result = Schedule.scheduleNext(TestData.scheduled79, TestData.event60);
            AssertAreEqual(TestData.scheduled80, result);
        }

        [TestMethod]
        public void TestScheduleNext080()
        {
            var result = Schedule.scheduleNext(TestData.scheduled80, TestData.event16);
            AssertAreEqual(TestData.scheduled81, result);
        }

    }
}
