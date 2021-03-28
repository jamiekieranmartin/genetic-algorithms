using Microsoft.VisualStudio.TestTools.UnitTesting;
using CAB402.FSharp;
using System;

namespace GeneticAlgorithmUnitTests
{
    [TestClass]
    public class ElitismSelectionTests
    {
        private void CompareIndividuals(Tuple<int[], double> expected, Tuple<int[], double> actual)
        {
            CollectionAssert.AreEqual(expected.Item1, actual.Item1);
            Assert.AreEqual(expected.Item2, actual.Item2);
        }

        private void ComparePopulations(Tuple<int[], double>[] expected, Tuple<int[], double>[] actual)
        {
            Assert.AreEqual(expected.Length, actual.Length);
            for (int i = 0; i < expected.Length; i++)
                CompareIndividuals(expected[i], actual[i]);
        }

        [TestMethod]
        public void TestElitismSelection00()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population0, TestPopulations.population0);
            ComparePopulations(PopulationsResults.result0, result);
        }

        [TestMethod]
        public void TestElitismSelection01()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population0, TestPopulations.population1);
            ComparePopulations(PopulationsResults.result1, result);
        }

        [TestMethod]
        public void TestElitismSelection02()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population0, TestPopulations.population2);
            ComparePopulations(PopulationsResults.result2, result);
        }

        [TestMethod]
        public void TestElitismSelection03()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population0, TestPopulations.population3);
            ComparePopulations(PopulationsResults.result3, result);
        }

        [TestMethod]
        public void TestElitismSelection04()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population0, TestPopulations.population4);
            ComparePopulations(PopulationsResults.result4, result);
        }

        [TestMethod]
        public void TestElitismSelection05()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population0, TestPopulations.population5);
            ComparePopulations(PopulationsResults.result5, result);
        }

        [TestMethod]
        public void TestElitismSelection06()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population0, TestPopulations.population6);
            ComparePopulations(PopulationsResults.result6, result);
        }

        [TestMethod]
        public void TestElitismSelection07()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population0, TestPopulations.population7);
            ComparePopulations(PopulationsResults.result7, result);
        }

        [TestMethod]
        public void TestElitismSelection08()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population0, TestPopulations.population8);
            ComparePopulations(PopulationsResults.result8, result);
        }

        [TestMethod]
        public void TestElitismSelection09()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population0, TestPopulations.population9);
            ComparePopulations(PopulationsResults.result9, result);
        }

        [TestMethod]
        public void TestElitismSelection10()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population1, TestPopulations.population0);
            ComparePopulations(PopulationsResults.result10, result);
        }

        [TestMethod]
        public void TestElitismSelection11()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population1, TestPopulations.population1);
            ComparePopulations(PopulationsResults.result11, result);
        }

        [TestMethod]
        public void TestElitismSelection12()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population1, TestPopulations.population2);
            ComparePopulations(PopulationsResults.result12, result);
        }

        [TestMethod]
        public void TestElitismSelection13()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population1, TestPopulations.population3);
            ComparePopulations(PopulationsResults.result13, result);
        }

        [TestMethod]
        public void TestElitismSelection14()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population1, TestPopulations.population4);
            ComparePopulations(PopulationsResults.result14, result);
        }

        [TestMethod]
        public void TestElitismSelection15()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population1, TestPopulations.population5);
            ComparePopulations(PopulationsResults.result15, result);
        }

        [TestMethod]
        public void TestElitismSelection16()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population1, TestPopulations.population6);
            ComparePopulations(PopulationsResults.result16, result);
        }

        [TestMethod]
        public void TestElitismSelection17()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population1, TestPopulations.population7);
            ComparePopulations(PopulationsResults.result17, result);
        }

        [TestMethod]
        public void TestElitismSelection18()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population1, TestPopulations.population8);
            ComparePopulations(PopulationsResults.result18, result);
        }

        [TestMethod]
        public void TestElitismSelection19()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population1, TestPopulations.population9);
            ComparePopulations(PopulationsResults.result19, result);
        }

        [TestMethod]
        public void TestElitismSelection20()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population2, TestPopulations.population0);
            ComparePopulations(PopulationsResults.result20, result);
        }

        [TestMethod]
        public void TestElitismSelection21()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population2, TestPopulations.population1);
            ComparePopulations(PopulationsResults.result21, result);
        }

        [TestMethod]
        public void TestElitismSelection22()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population2, TestPopulations.population2);
            ComparePopulations(PopulationsResults.result22, result);
        }

        [TestMethod]
        public void TestElitismSelection23()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population2, TestPopulations.population3);
            ComparePopulations(PopulationsResults.result23, result);
        }

        [TestMethod]
        public void TestElitismSelection24()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population2, TestPopulations.population4);
            ComparePopulations(PopulationsResults.result24, result);
        }

        [TestMethod]
        public void TestElitismSelection25()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population2, TestPopulations.population5);
            ComparePopulations(PopulationsResults.result25, result);
        }

        [TestMethod]
        public void TestElitismSelection26()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population2, TestPopulations.population6);
            ComparePopulations(PopulationsResults.result26, result);
        }

        [TestMethod]
        public void TestElitismSelection27()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population2, TestPopulations.population7);
            ComparePopulations(PopulationsResults.result27, result);
        }

        [TestMethod]
        public void TestElitismSelection28()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population2, TestPopulations.population8);
            ComparePopulations(PopulationsResults.result28, result);
        }

        [TestMethod]
        public void TestElitismSelection29()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population2, TestPopulations.population9);
            ComparePopulations(PopulationsResults.result29, result);
        }

        [TestMethod]
        public void TestElitismSelection30()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population3, TestPopulations.population0);
            ComparePopulations(PopulationsResults.result30, result);
        }

        [TestMethod]
        public void TestElitismSelection31()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population3, TestPopulations.population1);
            ComparePopulations(PopulationsResults.result31, result);
        }

        [TestMethod]
        public void TestElitismSelection32()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population3, TestPopulations.population2);
            ComparePopulations(PopulationsResults.result32, result);
        }

        [TestMethod]
        public void TestElitismSelection33()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population3, TestPopulations.population3);
            ComparePopulations(PopulationsResults.result33, result);
        }

        [TestMethod]
        public void TestElitismSelection34()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population3, TestPopulations.population4);
            ComparePopulations(PopulationsResults.result34, result);
        }

        [TestMethod]
        public void TestElitismSelection35()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population3, TestPopulations.population5);
            ComparePopulations(PopulationsResults.result35, result);
        }

        [TestMethod]
        public void TestElitismSelection36()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population3, TestPopulations.population6);
            ComparePopulations(PopulationsResults.result36, result);
        }

        [TestMethod]
        public void TestElitismSelection37()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population3, TestPopulations.population7);
            ComparePopulations(PopulationsResults.result37, result);
        }

        [TestMethod]
        public void TestElitismSelection38()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population3, TestPopulations.population8);
            ComparePopulations(PopulationsResults.result38, result);
        }

        [TestMethod]
        public void TestElitismSelection39()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population3, TestPopulations.population9);
            ComparePopulations(PopulationsResults.result39, result);
        }

        [TestMethod]
        public void TestElitismSelection40()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population4, TestPopulations.population0);
            ComparePopulations(PopulationsResults.result40, result);
        }

        [TestMethod]
        public void TestElitismSelection41()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population4, TestPopulations.population1);
            ComparePopulations(PopulationsResults.result41, result);
        }

        [TestMethod]
        public void TestElitismSelection42()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population4, TestPopulations.population2);
            ComparePopulations(PopulationsResults.result42, result);
        }

        [TestMethod]
        public void TestElitismSelection43()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population4, TestPopulations.population3);
            ComparePopulations(PopulationsResults.result43, result);
        }

        [TestMethod]
        public void TestElitismSelection44()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population4, TestPopulations.population4);
            ComparePopulations(PopulationsResults.result44, result);
        }

        [TestMethod]
        public void TestElitismSelection45()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population4, TestPopulations.population5);
            ComparePopulations(PopulationsResults.result45, result);
        }

        [TestMethod]
        public void TestElitismSelection46()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population4, TestPopulations.population6);
            ComparePopulations(PopulationsResults.result46, result);
        }

        [TestMethod]
        public void TestElitismSelection47()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population4, TestPopulations.population7);
            ComparePopulations(PopulationsResults.result47, result);
        }

        [TestMethod]
        public void TestElitismSelection48()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population4, TestPopulations.population8);
            ComparePopulations(PopulationsResults.result48, result);
        }

        [TestMethod]
        public void TestElitismSelection49()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population4, TestPopulations.population9);
            ComparePopulations(PopulationsResults.result49, result);
        }

        [TestMethod]
        public void TestElitismSelection50()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population5, TestPopulations.population0);
            ComparePopulations(PopulationsResults.result50, result);
        }

        [TestMethod]
        public void TestElitismSelection51()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population5, TestPopulations.population1);
            ComparePopulations(PopulationsResults.result51, result);
        }

        [TestMethod]
        public void TestElitismSelection52()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population5, TestPopulations.population2);
            ComparePopulations(PopulationsResults.result52, result);
        }

        [TestMethod]
        public void TestElitismSelection53()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population5, TestPopulations.population3);
            ComparePopulations(PopulationsResults.result53, result);
        }

        [TestMethod]
        public void TestElitismSelection54()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population5, TestPopulations.population4);
            ComparePopulations(PopulationsResults.result54, result);
        }

        [TestMethod]
        public void TestElitismSelection55()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population5, TestPopulations.population5);
            ComparePopulations(PopulationsResults.result55, result);
        }

        [TestMethod]
        public void TestElitismSelection56()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population5, TestPopulations.population6);
            ComparePopulations(PopulationsResults.result56, result);
        }

        [TestMethod]
        public void TestElitismSelection57()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population5, TestPopulations.population7);
            ComparePopulations(PopulationsResults.result57, result);
        }

        [TestMethod]
        public void TestElitismSelection58()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population5, TestPopulations.population8);
            ComparePopulations(PopulationsResults.result58, result);
        }

        [TestMethod]
        public void TestElitismSelection59()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population5, TestPopulations.population9);
            ComparePopulations(PopulationsResults.result59, result);
        }

        [TestMethod]
        public void TestElitismSelection60()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population6, TestPopulations.population0);
            ComparePopulations(PopulationsResults.result60, result);
        }

        [TestMethod]
        public void TestElitismSelection61()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population6, TestPopulations.population1);
            ComparePopulations(PopulationsResults.result61, result);
        }

        [TestMethod]
        public void TestElitismSelection62()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population6, TestPopulations.population2);
            ComparePopulations(PopulationsResults.result62, result);
        }

        [TestMethod]
        public void TestElitismSelection63()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population6, TestPopulations.population3);
            ComparePopulations(PopulationsResults.result63, result);
        }

        [TestMethod]
        public void TestElitismSelection64()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population6, TestPopulations.population4);
            ComparePopulations(PopulationsResults.result64, result);
        }

        [TestMethod]
        public void TestElitismSelection65()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population6, TestPopulations.population5);
            ComparePopulations(PopulationsResults.result65, result);
        }

        [TestMethod]
        public void TestElitismSelection66()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population6, TestPopulations.population6);
            ComparePopulations(PopulationsResults.result66, result);
        }

        [TestMethod]
        public void TestElitismSelection67()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population6, TestPopulations.population7);
            ComparePopulations(PopulationsResults.result67, result);
        }

        [TestMethod]
        public void TestElitismSelection68()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population6, TestPopulations.population8);
            ComparePopulations(PopulationsResults.result68, result);
        }

        [TestMethod]
        public void TestElitismSelection69()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population6, TestPopulations.population9);
            ComparePopulations(PopulationsResults.result69, result);
        }

        [TestMethod]
        public void TestElitismSelection70()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population7, TestPopulations.population0);
            ComparePopulations(PopulationsResults.result70, result);
        }

        [TestMethod]
        public void TestElitismSelection71()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population7, TestPopulations.population1);
            ComparePopulations(PopulationsResults.result71, result);
        }

        [TestMethod]
        public void TestElitismSelection72()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population7, TestPopulations.population2);
            ComparePopulations(PopulationsResults.result72, result);
        }

        [TestMethod]
        public void TestElitismSelection73()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population7, TestPopulations.population3);
            ComparePopulations(PopulationsResults.result73, result);
        }

        [TestMethod]
        public void TestElitismSelection74()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population7, TestPopulations.population4);
            ComparePopulations(PopulationsResults.result74, result);
        }

        [TestMethod]
        public void TestElitismSelection75()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population7, TestPopulations.population5);
            ComparePopulations(PopulationsResults.result75, result);
        }

        [TestMethod]
        public void TestElitismSelection76()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population7, TestPopulations.population6);
            ComparePopulations(PopulationsResults.result76, result);
        }

        [TestMethod]
        public void TestElitismSelection77()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population7, TestPopulations.population7);
            ComparePopulations(PopulationsResults.result77, result);
        }

        [TestMethod]
        public void TestElitismSelection78()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population7, TestPopulations.population8);
            ComparePopulations(PopulationsResults.result78, result);
        }

        [TestMethod]
        public void TestElitismSelection79()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population7, TestPopulations.population9);
            ComparePopulations(PopulationsResults.result79, result);
        }

        [TestMethod]
        public void TestElitismSelection80()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population8, TestPopulations.population0);
            ComparePopulations(PopulationsResults.result80, result);
        }

        [TestMethod]
        public void TestElitismSelection81()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population8, TestPopulations.population1);
            ComparePopulations(PopulationsResults.result81, result);
        }

        [TestMethod]
        public void TestElitismSelection82()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population8, TestPopulations.population2);
            ComparePopulations(PopulationsResults.result82, result);
        }

        [TestMethod]
        public void TestElitismSelection83()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population8, TestPopulations.population3);
            ComparePopulations(PopulationsResults.result83, result);
        }

        [TestMethod]
        public void TestElitismSelection84()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population8, TestPopulations.population4);
            ComparePopulations(PopulationsResults.result84, result);
        }

        [TestMethod]
        public void TestElitismSelection85()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population8, TestPopulations.population5);
            ComparePopulations(PopulationsResults.result85, result);
        }

        [TestMethod]
        public void TestElitismSelection86()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population8, TestPopulations.population6);
            ComparePopulations(PopulationsResults.result86, result);
        }

        [TestMethod]
        public void TestElitismSelection87()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population8, TestPopulations.population7);
            ComparePopulations(PopulationsResults.result87, result);
        }

        [TestMethod]
        public void TestElitismSelection88()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population8, TestPopulations.population8);
            ComparePopulations(PopulationsResults.result88, result);
        }

        [TestMethod]
        public void TestElitismSelection89()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population8, TestPopulations.population9);
            ComparePopulations(PopulationsResults.result89, result);
        }

        [TestMethod]
        public void TestElitismSelection90()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population9, TestPopulations.population0);
            ComparePopulations(PopulationsResults.result90, result);
        }

        [TestMethod]
        public void TestElitismSelection91()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population9, TestPopulations.population1);
            ComparePopulations(PopulationsResults.result91, result);
        }

        [TestMethod]
        public void TestElitismSelection92()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population9, TestPopulations.population2);
            ComparePopulations(PopulationsResults.result92, result);
        }

        [TestMethod]
        public void TestElitismSelection93()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population9, TestPopulations.population3);
            ComparePopulations(PopulationsResults.result93, result);
        }

        [TestMethod]
        public void TestElitismSelection94()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population9, TestPopulations.population4);
            ComparePopulations(PopulationsResults.result94, result);
        }

        [TestMethod]
        public void TestElitismSelection95()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population9, TestPopulations.population5);
            ComparePopulations(PopulationsResults.result95, result);
        }

        [TestMethod]
        public void TestElitismSelection96()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population9, TestPopulations.population6);
            ComparePopulations(PopulationsResults.result96, result);
        }

        [TestMethod]
        public void TestElitismSelection97()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population9, TestPopulations.population7);
            ComparePopulations(PopulationsResults.result97, result);
        }

        [TestMethod]
        public void TestElitismSelection98()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population9, TestPopulations.population8);
            ComparePopulations(PopulationsResults.result98, result);
        }

        [TestMethod]
        public void TestElitismSelection99()
        {
            var result = GeneticAlgorithm.elitismSelection(TestPopulations.population9, TestPopulations.population9);
            ComparePopulations(PopulationsResults.result99, result);
        }

    }
}
