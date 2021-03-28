using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CAB402.FSharp;

namespace GeneticAlgorithmUnitTests
{
    [TestClass]
    public class FitestTests
    {
        private void CompareIndividuals(Tuple<int[], double> expected, Tuple<int[], double> actual)
        {
            CollectionAssert.AreEqual(expected.Item1, actual.Item1);
            Assert.AreEqual(expected.Item2, actual.Item2);
        }

        [TestMethod]
        public void TestFitest0()
        {
            var result = GeneticAlgorithm.fitest(TestPopulations.population0);
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result2000,-3490.1978334807836), result);
        }

        [TestMethod]
        public void TestFitest1()
        {
            var result = GeneticAlgorithm.fitest(TestPopulations.population1);
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result2001,-3298.9493193162575), result);
        }

        [TestMethod]
        public void TestFitest2()
        {
            var result = GeneticAlgorithm.fitest(TestPopulations.population2);
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result2002,-3367.051407629086), result);
        }

        [TestMethod]
        public void TestFitest3()
        {
            var result = GeneticAlgorithm.fitest(TestPopulations.population3);
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result2003,-3324.5022586380474), result);
        }

        [TestMethod]
        public void TestFitest4()
        {
            var result = GeneticAlgorithm.fitest(TestPopulations.population4);
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result2004,-2980.658752414498), result);
        }

        [TestMethod]
        public void TestFitest5()
        {
            var result = GeneticAlgorithm.fitest(TestPopulations.population5);
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result2005,-3825.8669615811814), result);
        }

        [TestMethod]
        public void TestFitest6()
        {
            var result = GeneticAlgorithm.fitest(TestPopulations.population6);
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result2006,-3334.1642610208582), result);
        }

        [TestMethod]
        public void TestFitest7()
        {
            var result = GeneticAlgorithm.fitest(TestPopulations.population7);
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result2007,-3852.2122535775106), result);
        }

        [TestMethod]
        public void TestFitest8()
        {
            var result = GeneticAlgorithm.fitest(TestPopulations.population8);
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result2008,-3050.626231239329), result);
        }

        [TestMethod]
        public void TestFitest9()
        {
            var result = GeneticAlgorithm.fitest(TestPopulations.population9);
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result2009,-3482.0079746203587), result);
        }

    }
}
