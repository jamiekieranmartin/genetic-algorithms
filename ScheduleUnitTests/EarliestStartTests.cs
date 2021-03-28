using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System;
using Microsoft.FSharp.Collections;

namespace ScheduleUnitTests
{
    [TestClass]
    public class EarliestStartTests
    {
        [TestMethod]
        public void TestEarliestStart000()
        {
            var result = Schedule.earliestStart(TestData.scheduled0, TestData.event58);
            Assert.AreEqual(new Tuple<int, int>(0, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart001()
        {
            var result = Schedule.earliestStart(TestData.scheduled1, TestData.event66);
            Assert.AreEqual(new Tuple<int, int>(0, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart002()
        {
            var result = Schedule.earliestStart(TestData.scheduled2, TestData.event61);
            Assert.AreEqual(new Tuple<int, int>(36, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart003()
        {
            var result = Schedule.earliestStart(TestData.scheduled3, TestData.event43);
            Assert.AreEqual(new Tuple<int, int>(0, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart004()
        {
            var result = Schedule.earliestStart(TestData.scheduled4, TestData.event15);
            Assert.AreEqual(new Tuple<int, int>(0, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart005()
        {
            var result = Schedule.earliestStart(TestData.scheduled5, TestData.event44);
            Assert.AreEqual(new Tuple<int, int>(36, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart006()
        {
            var result = Schedule.earliestStart(TestData.scheduled6, TestData.event73);
            Assert.AreEqual(new Tuple<int, int>(1, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart007()
        {
            var result = Schedule.earliestStart(TestData.scheduled7, TestData.event33);
            Assert.AreEqual(new Tuple<int, int>(2, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart008()
        {
            var result = Schedule.earliestStart(TestData.scheduled8, TestData.event79);
            Assert.AreEqual(new Tuple<int, int>(7, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart009()
        {
            var result = Schedule.earliestStart(TestData.scheduled9, TestData.event20);
            Assert.AreEqual(new Tuple<int, int>(0, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart010()
        {
            var result = Schedule.earliestStart(TestData.scheduled10, TestData.event22);
            Assert.AreEqual(new Tuple<int, int>(62, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart011()
        {
            var result = Schedule.earliestStart(TestData.scheduled11, TestData.event36);
            Assert.AreEqual(new Tuple<int, int>(8, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart012()
        {
            var result = Schedule.earliestStart(TestData.scheduled12, TestData.event50);
            Assert.AreEqual(new Tuple<int, int>(10, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart013()
        {
            var result = Schedule.earliestStart(TestData.scheduled13, TestData.event35);
            Assert.AreEqual(new Tuple<int, int>(10, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart014()
        {
            var result = Schedule.earliestStart(TestData.scheduled14, TestData.event78);
            Assert.AreEqual(new Tuple<int, int>(15, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart015()
        {
            var result = Schedule.earliestStart(TestData.scheduled15, TestData.event2);
            Assert.AreEqual(new Tuple<int, int>(0, 2), result);
        }

        [TestMethod]
        public void TestEarliestStart016()
        {
            var result = Schedule.earliestStart(TestData.scheduled16, TestData.event69);
            Assert.AreEqual(new Tuple<int, int>(24, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart017()
        {
            var result = Schedule.earliestStart(TestData.scheduled17, TestData.event80);
            Assert.AreEqual(new Tuple<int, int>(41, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart018()
        {
            var result = Schedule.earliestStart(TestData.scheduled18, TestData.event52);
            Assert.AreEqual(new Tuple<int, int>(16, 2), result);
        }

        [TestMethod]
        public void TestEarliestStart019()
        {
            var result = Schedule.earliestStart(TestData.scheduled19, TestData.event23);
            Assert.AreEqual(new Tuple<int, int>(0, 3), result);
        }

        [TestMethod]
        public void TestEarliestStart020()
        {
            var result = Schedule.earliestStart(TestData.scheduled20, TestData.event63);
            Assert.AreEqual(new Tuple<int, int>(16, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart021()
        {
            var result = Schedule.earliestStart(TestData.scheduled21, TestData.event65);
            Assert.AreEqual(new Tuple<int, int>(17, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart022()
        {
            var result = Schedule.earliestStart(TestData.scheduled22, TestData.event77);
            Assert.AreEqual(new Tuple<int, int>(18, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart023()
        {
            var result = Schedule.earliestStart(TestData.scheduled23, TestData.event1);
            Assert.AreEqual(new Tuple<int, int>(0, 2), result);
        }

        [TestMethod]
        public void TestEarliestStart024()
        {
            var result = Schedule.earliestStart(TestData.scheduled24, TestData.event51);
            Assert.AreEqual(new Tuple<int, int>(38, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart025()
        {
            var result = Schedule.earliestStart(TestData.scheduled25, TestData.event38);
            Assert.AreEqual(new Tuple<int, int>(69, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart026()
        {
            var result = Schedule.earliestStart(TestData.scheduled26, TestData.event72);
            Assert.AreEqual(new Tuple<int, int>(19, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart027()
        {
            var result = Schedule.earliestStart(TestData.scheduled27, TestData.event49);
            Assert.AreEqual(new Tuple<int, int>(25, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart028()
        {
            var result = Schedule.earliestStart(TestData.scheduled28, TestData.event37);
            Assert.AreEqual(new Tuple<int, int>(0, 4), result);
        }

        [TestMethod]
        public void TestEarliestStart029()
        {
            var result = Schedule.earliestStart(TestData.scheduled29, TestData.event6);
            Assert.AreEqual(new Tuple<int, int>(18, 3), result);
        }

        [TestMethod]
        public void TestEarliestStart030()
        {
            var result = Schedule.earliestStart(TestData.scheduled30, TestData.event12);
            Assert.AreEqual(new Tuple<int, int>(1, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart031()
        {
            var result = Schedule.earliestStart(TestData.scheduled31, TestData.event30);
            Assert.AreEqual(new Tuple<int, int>(20, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart032()
        {
            var result = Schedule.earliestStart(TestData.scheduled32, TestData.event19);
            Assert.AreEqual(new Tuple<int, int>(20, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart033()
        {
            var result = Schedule.earliestStart(TestData.scheduled33, TestData.event76);
            Assert.AreEqual(new Tuple<int, int>(23, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart034()
        {
            var result = Schedule.earliestStart(TestData.scheduled34, TestData.event47);
            Assert.AreEqual(new Tuple<int, int>(42, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart035()
        {
            var result = Schedule.earliestStart(TestData.scheduled35, TestData.event57);
            Assert.AreEqual(new Tuple<int, int>(42, 2), result);
        }

        [TestMethod]
        public void TestEarliestStart036()
        {
            var result = Schedule.earliestStart(TestData.scheduled36, TestData.event3);
            Assert.AreEqual(new Tuple<int, int>(34, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart037()
        {
            var result = Schedule.earliestStart(TestData.scheduled37, TestData.event26);
            Assert.AreEqual(new Tuple<int, int>(2, 2), result);
        }

        [TestMethod]
        public void TestEarliestStart038()
        {
            var result = Schedule.earliestStart(TestData.scheduled38, TestData.event24);
            Assert.AreEqual(new Tuple<int, int>(38, 2), result);
        }

        [TestMethod]
        public void TestEarliestStart039()
        {
            var result = Schedule.earliestStart(TestData.scheduled39, TestData.event74);
            Assert.AreEqual(new Tuple<int, int>(30, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart040()
        {
            var result = Schedule.earliestStart(TestData.scheduled40, TestData.event34);
            Assert.AreEqual(new Tuple<int, int>(47, 3), result);
        }

        [TestMethod]
        public void TestEarliestStart041()
        {
            var result = Schedule.earliestStart(TestData.scheduled41, TestData.event54);
            Assert.AreEqual(new Tuple<int, int>(11, 2), result);
        }

        [TestMethod]
        public void TestEarliestStart042()
        {
            var result = Schedule.earliestStart(TestData.scheduled42, TestData.event8);
            Assert.AreEqual(new Tuple<int, int>(0, 2), result);
        }

        [TestMethod]
        public void TestEarliestStart043()
        {
            var result = Schedule.earliestStart(TestData.scheduled43, TestData.event17);
            Assert.AreEqual(new Tuple<int, int>(23, 3), result);
        }

        [TestMethod]
        public void TestEarliestStart044()
        {
            var result = Schedule.earliestStart(TestData.scheduled44, TestData.event68);
            Assert.AreEqual(new Tuple<int, int>(68, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart045()
        {
            var result = Schedule.earliestStart(TestData.scheduled45, TestData.event59);
            Assert.AreEqual(new Tuple<int, int>(69, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart046()
        {
            var result = Schedule.earliestStart(TestData.scheduled46, TestData.event21);
            Assert.AreEqual(new Tuple<int, int>(67, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart047()
        {
            var result = Schedule.earliestStart(TestData.scheduled47, TestData.event31);
            Assert.AreEqual(new Tuple<int, int>(82, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart048()
        {
            var result = Schedule.earliestStart(TestData.scheduled48, TestData.event9);
            Assert.AreEqual(new Tuple<int, int>(52, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart049()
        {
            var result = Schedule.earliestStart(TestData.scheduled49, TestData.event14);
            Assert.AreEqual(new Tuple<int, int>(25, 3), result);
        }

        [TestMethod]
        public void TestEarliestStart050()
        {
            var result = Schedule.earliestStart(TestData.scheduled50, TestData.event29);
            Assert.AreEqual(new Tuple<int, int>(71, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart051()
        {
            var result = Schedule.earliestStart(TestData.scheduled51, TestData.event55);
            Assert.AreEqual(new Tuple<int, int>(102, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart052()
        {
            var result = Schedule.earliestStart(TestData.scheduled52, TestData.event45);
            Assert.AreEqual(new Tuple<int, int>(31, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart053()
        {
            var result = Schedule.earliestStart(TestData.scheduled53, TestData.event39);
            Assert.AreEqual(new Tuple<int, int>(33, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart054()
        {
            var result = Schedule.earliestStart(TestData.scheduled54, TestData.event11);
            Assert.AreEqual(new Tuple<int, int>(17, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart055()
        {
            var result = Schedule.earliestStart(TestData.scheduled55, TestData.event67);
            Assert.AreEqual(new Tuple<int, int>(67, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart056()
        {
            var result = Schedule.earliestStart(TestData.scheduled56, TestData.event62);
            Assert.AreEqual(new Tuple<int, int>(35, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart057()
        {
            var result = Schedule.earliestStart(TestData.scheduled57, TestData.event53);
            Assert.AreEqual(new Tuple<int, int>(51, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart058()
        {
            var result = Schedule.earliestStart(TestData.scheduled58, TestData.event64);
            Assert.AreEqual(new Tuple<int, int>(47, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart059()
        {
            var result = Schedule.earliestStart(TestData.scheduled59, TestData.event42);
            Assert.AreEqual(new Tuple<int, int>(48, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart060()
        {
            var result = Schedule.earliestStart(TestData.scheduled60, TestData.event41);
            Assert.AreEqual(new Tuple<int, int>(131, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart061()
        {
            var result = Schedule.earliestStart(TestData.scheduled61, TestData.event10);
            Assert.AreEqual(new Tuple<int, int>(76, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart062()
        {
            var result = Schedule.earliestStart(TestData.scheduled62, TestData.event71);
            Assert.AreEqual(new Tuple<int, int>(94, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart063()
        {
            var result = Schedule.earliestStart(TestData.scheduled63, TestData.event70);
            Assert.AreEqual(new Tuple<int, int>(53, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart064()
        {
            var result = Schedule.earliestStart(TestData.scheduled64, TestData.event4);
            Assert.AreEqual(new Tuple<int, int>(51, 3), result);
        }

        [TestMethod]
        public void TestEarliestStart065()
        {
            var result = Schedule.earliestStart(TestData.scheduled65, TestData.event56);
            Assert.AreEqual(new Tuple<int, int>(49, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart066()
        {
            var result = Schedule.earliestStart(TestData.scheduled66, TestData.event7);
            Assert.AreEqual(new Tuple<int, int>(54, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart067()
        {
            var result = Schedule.earliestStart(TestData.scheduled67, TestData.event40);
            Assert.AreEqual(new Tuple<int, int>(30, 4), result);
        }

        [TestMethod]
        public void TestEarliestStart068()
        {
            var result = Schedule.earliestStart(TestData.scheduled68, TestData.event48);
            Assert.AreEqual(new Tuple<int, int>(79, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart069()
        {
            var result = Schedule.earliestStart(TestData.scheduled69, TestData.event13);
            Assert.AreEqual(new Tuple<int, int>(57, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart070()
        {
            var result = Schedule.earliestStart(TestData.scheduled70, TestData.event75);
            Assert.AreEqual(new Tuple<int, int>(84, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart071()
        {
            var result = Schedule.earliestStart(TestData.scheduled71, TestData.event25);
            Assert.AreEqual(new Tuple<int, int>(85, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart072()
        {
            var result = Schedule.earliestStart(TestData.scheduled72, TestData.event28);
            Assert.AreEqual(new Tuple<int, int>(90, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart073()
        {
            var result = Schedule.earliestStart(TestData.scheduled73, TestData.event32);
            Assert.AreEqual(new Tuple<int, int>(112, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart074()
        {
            var result = Schedule.earliestStart(TestData.scheduled74, TestData.event46);
            Assert.AreEqual(new Tuple<int, int>(102, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart075()
        {
            var result = Schedule.earliestStart(TestData.scheduled75, TestData.event0);
            Assert.AreEqual(new Tuple<int, int>(14, 3), result);
        }

        [TestMethod]
        public void TestEarliestStart076()
        {
            var result = Schedule.earliestStart(TestData.scheduled76, TestData.event27);
            Assert.AreEqual(new Tuple<int, int>(92, 2), result);
        }

        [TestMethod]
        public void TestEarliestStart077()
        {
            var result = Schedule.earliestStart(TestData.scheduled77, TestData.event18);
            Assert.AreEqual(new Tuple<int, int>(69, 2), result);
        }

        [TestMethod]
        public void TestEarliestStart078()
        {
            var result = Schedule.earliestStart(TestData.scheduled78, TestData.event5);
            Assert.AreEqual(new Tuple<int, int>(92, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart079()
        {
            var result = Schedule.earliestStart(TestData.scheduled79, TestData.event60);
            Assert.AreEqual(new Tuple<int, int>(95, 1), result);
        }

        [TestMethod]
        public void TestEarliestStart080()
        {
            var result = Schedule.earliestStart(TestData.scheduled80, TestData.event16);
            Assert.AreEqual(new Tuple<int, int>(107, 1), result);
        }

    }
}
