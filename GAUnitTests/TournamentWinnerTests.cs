using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using CAB402.FSharp;

namespace GeneticAlgorithmUnitTests
{
    [TestClass]
    public class TournamentWinnerTests
    {
        [TestMethod]
        public void TestTournamentWinner0()
        {
            var result = GeneticAlgorithm.tournamentWinner(TestPopulations.population0);
            CollectionAssert.AreEqual(IndividualsResults.result2010, result);
        }

        [TestMethod]
        public void TestTournamentWinner1()
        {
            var result = GeneticAlgorithm.tournamentWinner(TestPopulations.population1);
            CollectionAssert.AreEqual(IndividualsResults.result2011, result);
        }

        [TestMethod]
        public void TestTournamentWinner2()
        {
            var result = GeneticAlgorithm.tournamentWinner(TestPopulations.population2);
            CollectionAssert.AreEqual(IndividualsResults.result2012, result);
        }

        [TestMethod]
        public void TestTournamentWinner3()
        {
            var result = GeneticAlgorithm.tournamentWinner(TestPopulations.population3);
            CollectionAssert.AreEqual(IndividualsResults.result2013, result);
        }

        [TestMethod]
        public void TestTournamentWinner4()
        {
            var result = GeneticAlgorithm.tournamentWinner(TestPopulations.population4);
            CollectionAssert.AreEqual(IndividualsResults.result2014, result);
        }

        [TestMethod]
        public void TestTournamentWinner5()
        {
            var result = GeneticAlgorithm.tournamentWinner(TestPopulations.population5);
            CollectionAssert.AreEqual(IndividualsResults.result2015, result);
        }

        [TestMethod]
        public void TestTournamentWinner6()
        {
            var result = GeneticAlgorithm.tournamentWinner(TestPopulations.population6);
            CollectionAssert.AreEqual(IndividualsResults.result2016, result);
        }

        [TestMethod]
        public void TestTournamentWinner7()
        {
            var result = GeneticAlgorithm.tournamentWinner(TestPopulations.population7);
            CollectionAssert.AreEqual(IndividualsResults.result2017, result);
        }

        [TestMethod]
        public void TestTournamentWinner8()
        {
            var result = GeneticAlgorithm.tournamentWinner(TestPopulations.population8);
            CollectionAssert.AreEqual(IndividualsResults.result2018, result);
        }

        [TestMethod]
        public void TestTournamentWinner9()
        {
            var result = GeneticAlgorithm.tournamentWinner(TestPopulations.population9);
            CollectionAssert.AreEqual(IndividualsResults.result2019, result);
        }

    }
}
