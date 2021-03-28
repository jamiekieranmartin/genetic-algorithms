using Microsoft.VisualStudio.TestTools.UnitTesting;
using CAB402.FSharp;

namespace GeneticAlgorithmUnitTests
{
    [TestClass]
    public class TournamentSelectTests
    {
        [TestMethod]
        public void TestTournamentSelect00()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2020, result);
        }

        [TestMethod]
        public void TestTournamentSelect01()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2021, result);
        }

        [TestMethod]
        public void TestTournamentSelect02()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2022, result);
        }

        [TestMethod]
        public void TestTournamentSelect03()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2023, result);
        }

        [TestMethod]
        public void TestTournamentSelect04()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2024, result);
        }

        [TestMethod]
        public void TestTournamentSelect05()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2025, result);
        }

        [TestMethod]
        public void TestTournamentSelect06()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2026, result);
        }

        [TestMethod]
        public void TestTournamentSelect07()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2027, result);
        }

        [TestMethod]
        public void TestTournamentSelect08()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2028, result);
        }

        [TestMethod]
        public void TestTournamentSelect09()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2029, result);
        }

        [TestMethod]
        public void TestTournamentSelect10()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2030, result);
        }

        [TestMethod]
        public void TestTournamentSelect11()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2031, result);
        }

        [TestMethod]
        public void TestTournamentSelect12()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2032, result);
        }

        [TestMethod]
        public void TestTournamentSelect13()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2033, result);
        }

        [TestMethod]
        public void TestTournamentSelect14()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2034, result);
        }

        [TestMethod]
        public void TestTournamentSelect15()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2035, result);
        }

        [TestMethod]
        public void TestTournamentSelect16()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2036, result);
        }

        [TestMethod]
        public void TestTournamentSelect17()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2037, result);
        }

        [TestMethod]
        public void TestTournamentSelect18()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2038, result);
        }

        [TestMethod]
        public void TestTournamentSelect19()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2039, result);
        }

        [TestMethod]
        public void TestTournamentSelect20()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2040, result);
        }

        [TestMethod]
        public void TestTournamentSelect21()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2041, result);
        }

        [TestMethod]
        public void TestTournamentSelect22()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2042, result);
        }

        [TestMethod]
        public void TestTournamentSelect23()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2043, result);
        }

        [TestMethod]
        public void TestTournamentSelect24()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2044, result);
        }

        [TestMethod]
        public void TestTournamentSelect25()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2045, result);
        }

        [TestMethod]
        public void TestTournamentSelect26()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2046, result);
        }

        [TestMethod]
        public void TestTournamentSelect27()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2047, result);
        }

        [TestMethod]
        public void TestTournamentSelect28()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2048, result);
        }

        [TestMethod]
        public void TestTournamentSelect29()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2049, result);
        }

        [TestMethod]
        public void TestTournamentSelect30()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2050, result);
        }

        [TestMethod]
        public void TestTournamentSelect31()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2051, result);
        }

        [TestMethod]
        public void TestTournamentSelect32()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2052, result);
        }

        [TestMethod]
        public void TestTournamentSelect33()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2053, result);
        }

        [TestMethod]
        public void TestTournamentSelect34()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2054, result);
        }

        [TestMethod]
        public void TestTournamentSelect35()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2055, result);
        }

        [TestMethod]
        public void TestTournamentSelect36()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2056, result);
        }

        [TestMethod]
        public void TestTournamentSelect37()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2057, result);
        }

        [TestMethod]
        public void TestTournamentSelect38()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2058, result);
        }

        [TestMethod]
        public void TestTournamentSelect39()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2059, result);
        }

        [TestMethod]
        public void TestTournamentSelect40()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2060, result);
        }

        [TestMethod]
        public void TestTournamentSelect41()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2061, result);
        }

        [TestMethod]
        public void TestTournamentSelect42()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2062, result);
        }

        [TestMethod]
        public void TestTournamentSelect43()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2063, result);
        }

        [TestMethod]
        public void TestTournamentSelect44()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2064, result);
        }

        [TestMethod]
        public void TestTournamentSelect45()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2065, result);
        }

        [TestMethod]
        public void TestTournamentSelect46()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2066, result);
        }

        [TestMethod]
        public void TestTournamentSelect47()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2067, result);
        }

        [TestMethod]
        public void TestTournamentSelect48()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2068, result);
        }

        [TestMethod]
        public void TestTournamentSelect49()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2069, result);
        }

        [TestMethod]
        public void TestTournamentSelect50()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2070, result);
        }

        [TestMethod]
        public void TestTournamentSelect51()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2071, result);
        }

        [TestMethod]
        public void TestTournamentSelect52()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2072, result);
        }

        [TestMethod]
        public void TestTournamentSelect53()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2073, result);
        }

        [TestMethod]
        public void TestTournamentSelect54()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2074, result);
        }

        [TestMethod]
        public void TestTournamentSelect55()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2075, result);
        }

        [TestMethod]
        public void TestTournamentSelect56()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2076, result);
        }

        [TestMethod]
        public void TestTournamentSelect57()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2077, result);
        }

        [TestMethod]
        public void TestTournamentSelect58()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2078, result);
        }

        [TestMethod]
        public void TestTournamentSelect59()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2079, result);
        }

        [TestMethod]
        public void TestTournamentSelect60()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2080, result);
        }

        [TestMethod]
        public void TestTournamentSelect61()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2081, result);
        }

        [TestMethod]
        public void TestTournamentSelect62()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2082, result);
        }

        [TestMethod]
        public void TestTournamentSelect63()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2083, result);
        }

        [TestMethod]
        public void TestTournamentSelect64()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2084, result);
        }

        [TestMethod]
        public void TestTournamentSelect65()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2085, result);
        }

        [TestMethod]
        public void TestTournamentSelect66()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2086, result);
        }

        [TestMethod]
        public void TestTournamentSelect67()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2087, result);
        }

        [TestMethod]
        public void TestTournamentSelect68()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2088, result);
        }

        [TestMethod]
        public void TestTournamentSelect69()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2089, result);
        }

        [TestMethod]
        public void TestTournamentSelect70()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2090, result);
        }

        [TestMethod]
        public void TestTournamentSelect71()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2091, result);
        }

        [TestMethod]
        public void TestTournamentSelect72()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2092, result);
        }

        [TestMethod]
        public void TestTournamentSelect73()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2093, result);
        }

        [TestMethod]
        public void TestTournamentSelect74()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2094, result);
        }

        [TestMethod]
        public void TestTournamentSelect75()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2095, result);
        }

        [TestMethod]
        public void TestTournamentSelect76()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2096, result);
        }

        [TestMethod]
        public void TestTournamentSelect77()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2097, result);
        }

        [TestMethod]
        public void TestTournamentSelect78()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2098, result);
        }

        [TestMethod]
        public void TestTournamentSelect79()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2099, result);
        }

        [TestMethod]
        public void TestTournamentSelect80()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2100, result);
        }

        [TestMethod]
        public void TestTournamentSelect81()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2101, result);
        }

        [TestMethod]
        public void TestTournamentSelect82()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2102, result);
        }

        [TestMethod]
        public void TestTournamentSelect83()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2103, result);
        }

        [TestMethod]
        public void TestTournamentSelect84()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2104, result);
        }

        [TestMethod]
        public void TestTournamentSelect85()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2105, result);
        }

        [TestMethod]
        public void TestTournamentSelect86()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2106, result);
        }

        [TestMethod]
        public void TestTournamentSelect87()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2107, result);
        }

        [TestMethod]
        public void TestTournamentSelect88()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2108, result);
        }

        [TestMethod]
        public void TestTournamentSelect89()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2109, result);
        }

        [TestMethod]
        public void TestTournamentSelect90()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2110, result);
        }

        [TestMethod]
        public void TestTournamentSelect91()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2111, result);
        }

        [TestMethod]
        public void TestTournamentSelect92()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2112, result);
        }

        [TestMethod]
        public void TestTournamentSelect93()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2113, result);
        }

        [TestMethod]
        public void TestTournamentSelect94()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2114, result);
        }

        [TestMethod]
        public void TestTournamentSelect95()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2115, result);
        }

        [TestMethod]
        public void TestTournamentSelect96()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2116, result);
        }

        [TestMethod]
        public void TestTournamentSelect97()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2117, result);
        }

        [TestMethod]
        public void TestTournamentSelect98()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2118, result);
        }

        [TestMethod]
        public void TestTournamentSelect99()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2119, result);
        }

        [TestMethod]
        public void TestTournamentSelect100()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2120, result);
        }

        [TestMethod]
        public void TestTournamentSelect101()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2121, result);
        }

        [TestMethod]
        public void TestTournamentSelect102()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2122, result);
        }

        [TestMethod]
        public void TestTournamentSelect103()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2123, result);
        }

        [TestMethod]
        public void TestTournamentSelect104()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2124, result);
        }

        [TestMethod]
        public void TestTournamentSelect105()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2125, result);
        }

        [TestMethod]
        public void TestTournamentSelect106()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2126, result);
        }

        [TestMethod]
        public void TestTournamentSelect107()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2127, result);
        }

        [TestMethod]
        public void TestTournamentSelect108()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2128, result);
        }

        [TestMethod]
        public void TestTournamentSelect109()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2129, result);
        }

        [TestMethod]
        public void TestTournamentSelect110()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2130, result);
        }

        [TestMethod]
        public void TestTournamentSelect111()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2131, result);
        }

        [TestMethod]
        public void TestTournamentSelect112()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2132, result);
        }

        [TestMethod]
        public void TestTournamentSelect113()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2133, result);
        }

        [TestMethod]
        public void TestTournamentSelect114()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2134, result);
        }

        [TestMethod]
        public void TestTournamentSelect115()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2135, result);
        }

        [TestMethod]
        public void TestTournamentSelect116()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2136, result);
        }

        [TestMethod]
        public void TestTournamentSelect117()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2137, result);
        }

        [TestMethod]
        public void TestTournamentSelect118()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2138, result);
        }

        [TestMethod]
        public void TestTournamentSelect119()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2139, result);
        }

        [TestMethod]
        public void TestTournamentSelect120()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2140, result);
        }

        [TestMethod]
        public void TestTournamentSelect121()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2141, result);
        }

        [TestMethod]
        public void TestTournamentSelect122()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2142, result);
        }

        [TestMethod]
        public void TestTournamentSelect123()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2143, result);
        }

        [TestMethod]
        public void TestTournamentSelect124()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2144, result);
        }

        [TestMethod]
        public void TestTournamentSelect125()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2145, result);
        }

        [TestMethod]
        public void TestTournamentSelect126()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2146, result);
        }

        [TestMethod]
        public void TestTournamentSelect127()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2147, result);
        }

        [TestMethod]
        public void TestTournamentSelect128()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2148, result);
        }

        [TestMethod]
        public void TestTournamentSelect129()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2149, result);
        }

        [TestMethod]
        public void TestTournamentSelect130()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2150, result);
        }

        [TestMethod]
        public void TestTournamentSelect131()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2151, result);
        }

        [TestMethod]
        public void TestTournamentSelect132()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2152, result);
        }

        [TestMethod]
        public void TestTournamentSelect133()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2153, result);
        }

        [TestMethod]
        public void TestTournamentSelect134()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2154, result);
        }

        [TestMethod]
        public void TestTournamentSelect135()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2155, result);
        }

        [TestMethod]
        public void TestTournamentSelect136()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2156, result);
        }

        [TestMethod]
        public void TestTournamentSelect137()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2157, result);
        }

        [TestMethod]
        public void TestTournamentSelect138()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2158, result);
        }

        [TestMethod]
        public void TestTournamentSelect139()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2159, result);
        }

        [TestMethod]
        public void TestTournamentSelect140()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2160, result);
        }

        [TestMethod]
        public void TestTournamentSelect141()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2161, result);
        }

        [TestMethod]
        public void TestTournamentSelect142()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2162, result);
        }

        [TestMethod]
        public void TestTournamentSelect143()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2163, result);
        }

        [TestMethod]
        public void TestTournamentSelect144()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2164, result);
        }

        [TestMethod]
        public void TestTournamentSelect145()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2165, result);
        }

        [TestMethod]
        public void TestTournamentSelect146()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2166, result);
        }

        [TestMethod]
        public void TestTournamentSelect147()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2167, result);
        }

        [TestMethod]
        public void TestTournamentSelect148()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2168, result);
        }

        [TestMethod]
        public void TestTournamentSelect149()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2169, result);
        }

        [TestMethod]
        public void TestTournamentSelect150()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2170, result);
        }

        [TestMethod]
        public void TestTournamentSelect151()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2171, result);
        }

        [TestMethod]
        public void TestTournamentSelect152()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2172, result);
        }

        [TestMethod]
        public void TestTournamentSelect153()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2173, result);
        }

        [TestMethod]
        public void TestTournamentSelect154()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2174, result);
        }

        [TestMethod]
        public void TestTournamentSelect155()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2175, result);
        }

        [TestMethod]
        public void TestTournamentSelect156()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2176, result);
        }

        [TestMethod]
        public void TestTournamentSelect157()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2177, result);
        }

        [TestMethod]
        public void TestTournamentSelect158()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2178, result);
        }

        [TestMethod]
        public void TestTournamentSelect159()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2179, result);
        }

        [TestMethod]
        public void TestTournamentSelect160()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2180, result);
        }

        [TestMethod]
        public void TestTournamentSelect161()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2181, result);
        }

        [TestMethod]
        public void TestTournamentSelect162()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2182, result);
        }

        [TestMethod]
        public void TestTournamentSelect163()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2183, result);
        }

        [TestMethod]
        public void TestTournamentSelect164()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2184, result);
        }

        [TestMethod]
        public void TestTournamentSelect165()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2185, result);
        }

        [TestMethod]
        public void TestTournamentSelect166()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2186, result);
        }

        [TestMethod]
        public void TestTournamentSelect167()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2187, result);
        }

        [TestMethod]
        public void TestTournamentSelect168()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2188, result);
        }

        [TestMethod]
        public void TestTournamentSelect169()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2189, result);
        }

        [TestMethod]
        public void TestTournamentSelect170()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2190, result);
        }

        [TestMethod]
        public void TestTournamentSelect171()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2191, result);
        }

        [TestMethod]
        public void TestTournamentSelect172()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2192, result);
        }

        [TestMethod]
        public void TestTournamentSelect173()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2193, result);
        }

        [TestMethod]
        public void TestTournamentSelect174()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2194, result);
        }

        [TestMethod]
        public void TestTournamentSelect175()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2195, result);
        }

        [TestMethod]
        public void TestTournamentSelect176()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2196, result);
        }

        [TestMethod]
        public void TestTournamentSelect177()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2197, result);
        }

        [TestMethod]
        public void TestTournamentSelect178()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2198, result);
        }

        [TestMethod]
        public void TestTournamentSelect179()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2199, result);
        }

        [TestMethod]
        public void TestTournamentSelect180()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2200, result);
        }

        [TestMethod]
        public void TestTournamentSelect181()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2201, result);
        }

        [TestMethod]
        public void TestTournamentSelect182()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2202, result);
        }

        [TestMethod]
        public void TestTournamentSelect183()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2203, result);
        }

        [TestMethod]
        public void TestTournamentSelect184()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2204, result);
        }

        [TestMethod]
        public void TestTournamentSelect185()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2205, result);
        }

        [TestMethod]
        public void TestTournamentSelect186()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2206, result);
        }

        [TestMethod]
        public void TestTournamentSelect187()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2207, result);
        }

        [TestMethod]
        public void TestTournamentSelect188()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2208, result);
        }

        [TestMethod]
        public void TestTournamentSelect189()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2209, result);
        }

        [TestMethod]
        public void TestTournamentSelect190()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2210, result);
        }

        [TestMethod]
        public void TestTournamentSelect191()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2211, result);
        }

        [TestMethod]
        public void TestTournamentSelect192()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2212, result);
        }

        [TestMethod]
        public void TestTournamentSelect193()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2213, result);
        }

        [TestMethod]
        public void TestTournamentSelect194()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2214, result);
        }

        [TestMethod]
        public void TestTournamentSelect195()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2215, result);
        }

        [TestMethod]
        public void TestTournamentSelect196()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2216, result);
        }

        [TestMethod]
        public void TestTournamentSelect197()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2217, result);
        }

        [TestMethod]
        public void TestTournamentSelect198()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2218, result);
        }

        [TestMethod]
        public void TestTournamentSelect199()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2219, result);
        }

        [TestMethod]
        public void TestTournamentSelect200()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2220, result);
        }

        [TestMethod]
        public void TestTournamentSelect201()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2221, result);
        }

        [TestMethod]
        public void TestTournamentSelect202()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2222, result);
        }

        [TestMethod]
        public void TestTournamentSelect203()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2223, result);
        }

        [TestMethod]
        public void TestTournamentSelect204()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2224, result);
        }

        [TestMethod]
        public void TestTournamentSelect205()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2225, result);
        }

        [TestMethod]
        public void TestTournamentSelect206()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2226, result);
        }

        [TestMethod]
        public void TestTournamentSelect207()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2227, result);
        }

        [TestMethod]
        public void TestTournamentSelect208()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2228, result);
        }

        [TestMethod]
        public void TestTournamentSelect209()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2229, result);
        }

        [TestMethod]
        public void TestTournamentSelect210()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2230, result);
        }

        [TestMethod]
        public void TestTournamentSelect211()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2231, result);
        }

        [TestMethod]
        public void TestTournamentSelect212()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2232, result);
        }

        [TestMethod]
        public void TestTournamentSelect213()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2233, result);
        }

        [TestMethod]
        public void TestTournamentSelect214()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2234, result);
        }

        [TestMethod]
        public void TestTournamentSelect215()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2235, result);
        }

        [TestMethod]
        public void TestTournamentSelect216()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2236, result);
        }

        [TestMethod]
        public void TestTournamentSelect217()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2237, result);
        }

        [TestMethod]
        public void TestTournamentSelect218()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2238, result);
        }

        [TestMethod]
        public void TestTournamentSelect219()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2239, result);
        }

        [TestMethod]
        public void TestTournamentSelect220()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2240, result);
        }

        [TestMethod]
        public void TestTournamentSelect221()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2241, result);
        }

        [TestMethod]
        public void TestTournamentSelect222()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2242, result);
        }

        [TestMethod]
        public void TestTournamentSelect223()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2243, result);
        }

        [TestMethod]
        public void TestTournamentSelect224()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2244, result);
        }

        [TestMethod]
        public void TestTournamentSelect225()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2245, result);
        }

        [TestMethod]
        public void TestTournamentSelect226()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2246, result);
        }

        [TestMethod]
        public void TestTournamentSelect227()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2247, result);
        }

        [TestMethod]
        public void TestTournamentSelect228()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2248, result);
        }

        [TestMethod]
        public void TestTournamentSelect229()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2249, result);
        }

        [TestMethod]
        public void TestTournamentSelect230()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2250, result);
        }

        [TestMethod]
        public void TestTournamentSelect231()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2251, result);
        }

        [TestMethod]
        public void TestTournamentSelect232()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2252, result);
        }

        [TestMethod]
        public void TestTournamentSelect233()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2253, result);
        }

        [TestMethod]
        public void TestTournamentSelect234()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2254, result);
        }

        [TestMethod]
        public void TestTournamentSelect235()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2255, result);
        }

        [TestMethod]
        public void TestTournamentSelect236()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2256, result);
        }

        [TestMethod]
        public void TestTournamentSelect237()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2257, result);
        }

        [TestMethod]
        public void TestTournamentSelect238()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2258, result);
        }

        [TestMethod]
        public void TestTournamentSelect239()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2259, result);
        }

        [TestMethod]
        public void TestTournamentSelect240()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2260, result);
        }

        [TestMethod]
        public void TestTournamentSelect241()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2261, result);
        }

        [TestMethod]
        public void TestTournamentSelect242()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2262, result);
        }

        [TestMethod]
        public void TestTournamentSelect243()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2263, result);
        }

        [TestMethod]
        public void TestTournamentSelect244()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2264, result);
        }

        [TestMethod]
        public void TestTournamentSelect245()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2265, result);
        }

        [TestMethod]
        public void TestTournamentSelect246()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2266, result);
        }

        [TestMethod]
        public void TestTournamentSelect247()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2267, result);
        }

        [TestMethod]
        public void TestTournamentSelect248()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2268, result);
        }

        [TestMethod]
        public void TestTournamentSelect249()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2269, result);
        }

        [TestMethod]
        public void TestTournamentSelect250()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2270, result);
        }

        [TestMethod]
        public void TestTournamentSelect251()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2271, result);
        }

        [TestMethod]
        public void TestTournamentSelect252()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2272, result);
        }

        [TestMethod]
        public void TestTournamentSelect253()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2273, result);
        }

        [TestMethod]
        public void TestTournamentSelect254()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2274, result);
        }

        [TestMethod]
        public void TestTournamentSelect255()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2275, result);
        }

        [TestMethod]
        public void TestTournamentSelect256()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2276, result);
        }

        [TestMethod]
        public void TestTournamentSelect257()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2277, result);
        }

        [TestMethod]
        public void TestTournamentSelect258()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2278, result);
        }

        [TestMethod]
        public void TestTournamentSelect259()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2279, result);
        }

        [TestMethod]
        public void TestTournamentSelect260()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2280, result);
        }

        [TestMethod]
        public void TestTournamentSelect261()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2281, result);
        }

        [TestMethod]
        public void TestTournamentSelect262()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2282, result);
        }

        [TestMethod]
        public void TestTournamentSelect263()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2283, result);
        }

        [TestMethod]
        public void TestTournamentSelect264()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2284, result);
        }

        [TestMethod]
        public void TestTournamentSelect265()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2285, result);
        }

        [TestMethod]
        public void TestTournamentSelect266()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2286, result);
        }

        [TestMethod]
        public void TestTournamentSelect267()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2287, result);
        }

        [TestMethod]
        public void TestTournamentSelect268()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2288, result);
        }

        [TestMethod]
        public void TestTournamentSelect269()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2289, result);
        }

        [TestMethod]
        public void TestTournamentSelect270()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2290, result);
        }

        [TestMethod]
        public void TestTournamentSelect271()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2291, result);
        }

        [TestMethod]
        public void TestTournamentSelect272()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2292, result);
        }

        [TestMethod]
        public void TestTournamentSelect273()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2293, result);
        }

        [TestMethod]
        public void TestTournamentSelect274()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2294, result);
        }

        [TestMethod]
        public void TestTournamentSelect275()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2295, result);
        }

        [TestMethod]
        public void TestTournamentSelect276()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2296, result);
        }

        [TestMethod]
        public void TestTournamentSelect277()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2297, result);
        }

        [TestMethod]
        public void TestTournamentSelect278()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2298, result);
        }

        [TestMethod]
        public void TestTournamentSelect279()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2299, result);
        }

        [TestMethod]
        public void TestTournamentSelect280()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2300, result);
        }

        [TestMethod]
        public void TestTournamentSelect281()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2301, result);
        }

        [TestMethod]
        public void TestTournamentSelect282()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2302, result);
        }

        [TestMethod]
        public void TestTournamentSelect283()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2303, result);
        }

        [TestMethod]
        public void TestTournamentSelect284()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2304, result);
        }

        [TestMethod]
        public void TestTournamentSelect285()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2305, result);
        }

        [TestMethod]
        public void TestTournamentSelect286()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2306, result);
        }

        [TestMethod]
        public void TestTournamentSelect287()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2307, result);
        }

        [TestMethod]
        public void TestTournamentSelect288()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2308, result);
        }

        [TestMethod]
        public void TestTournamentSelect289()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2309, result);
        }

        [TestMethod]
        public void TestTournamentSelect290()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2310, result);
        }

        [TestMethod]
        public void TestTournamentSelect291()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2311, result);
        }

        [TestMethod]
        public void TestTournamentSelect292()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2312, result);
        }

        [TestMethod]
        public void TestTournamentSelect293()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2313, result);
        }

        [TestMethod]
        public void TestTournamentSelect294()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2314, result);
        }

        [TestMethod]
        public void TestTournamentSelect295()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2315, result);
        }

        [TestMethod]
        public void TestTournamentSelect296()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2316, result);
        }

        [TestMethod]
        public void TestTournamentSelect297()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2317, result);
        }

        [TestMethod]
        public void TestTournamentSelect298()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2318, result);
        }

        [TestMethod]
        public void TestTournamentSelect299()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2319, result);
        }

        [TestMethod]
        public void TestTournamentSelect300()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2320, result);
        }

        [TestMethod]
        public void TestTournamentSelect301()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2321, result);
        }

        [TestMethod]
        public void TestTournamentSelect302()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2322, result);
        }

        [TestMethod]
        public void TestTournamentSelect303()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2323, result);
        }

        [TestMethod]
        public void TestTournamentSelect304()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2324, result);
        }

        [TestMethod]
        public void TestTournamentSelect305()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2325, result);
        }

        [TestMethod]
        public void TestTournamentSelect306()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2326, result);
        }

        [TestMethod]
        public void TestTournamentSelect307()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2327, result);
        }

        [TestMethod]
        public void TestTournamentSelect308()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2328, result);
        }

        [TestMethod]
        public void TestTournamentSelect309()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2329, result);
        }

        [TestMethod]
        public void TestTournamentSelect310()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2330, result);
        }

        [TestMethod]
        public void TestTournamentSelect311()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2331, result);
        }

        [TestMethod]
        public void TestTournamentSelect312()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2332, result);
        }

        [TestMethod]
        public void TestTournamentSelect313()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2333, result);
        }

        [TestMethod]
        public void TestTournamentSelect314()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2334, result);
        }

        [TestMethod]
        public void TestTournamentSelect315()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2335, result);
        }

        [TestMethod]
        public void TestTournamentSelect316()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2336, result);
        }

        [TestMethod]
        public void TestTournamentSelect317()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2337, result);
        }

        [TestMethod]
        public void TestTournamentSelect318()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2338, result);
        }

        [TestMethod]
        public void TestTournamentSelect319()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2339, result);
        }

        [TestMethod]
        public void TestTournamentSelect320()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2340, result);
        }

        [TestMethod]
        public void TestTournamentSelect321()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2341, result);
        }

        [TestMethod]
        public void TestTournamentSelect322()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2342, result);
        }

        [TestMethod]
        public void TestTournamentSelect323()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2343, result);
        }

        [TestMethod]
        public void TestTournamentSelect324()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2344, result);
        }

        [TestMethod]
        public void TestTournamentSelect325()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2345, result);
        }

        [TestMethod]
        public void TestTournamentSelect326()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2346, result);
        }

        [TestMethod]
        public void TestTournamentSelect327()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2347, result);
        }

        [TestMethod]
        public void TestTournamentSelect328()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2348, result);
        }

        [TestMethod]
        public void TestTournamentSelect329()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2349, result);
        }

        [TestMethod]
        public void TestTournamentSelect330()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2350, result);
        }

        [TestMethod]
        public void TestTournamentSelect331()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2351, result);
        }

        [TestMethod]
        public void TestTournamentSelect332()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2352, result);
        }

        [TestMethod]
        public void TestTournamentSelect333()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2353, result);
        }

        [TestMethod]
        public void TestTournamentSelect334()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2354, result);
        }

        [TestMethod]
        public void TestTournamentSelect335()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2355, result);
        }

        [TestMethod]
        public void TestTournamentSelect336()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2356, result);
        }

        [TestMethod]
        public void TestTournamentSelect337()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2357, result);
        }

        [TestMethod]
        public void TestTournamentSelect338()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2358, result);
        }

        [TestMethod]
        public void TestTournamentSelect339()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2359, result);
        }

        [TestMethod]
        public void TestTournamentSelect340()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2360, result);
        }

        [TestMethod]
        public void TestTournamentSelect341()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2361, result);
        }

        [TestMethod]
        public void TestTournamentSelect342()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2362, result);
        }

        [TestMethod]
        public void TestTournamentSelect343()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2363, result);
        }

        [TestMethod]
        public void TestTournamentSelect344()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2364, result);
        }

        [TestMethod]
        public void TestTournamentSelect345()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2365, result);
        }

        [TestMethod]
        public void TestTournamentSelect346()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2366, result);
        }

        [TestMethod]
        public void TestTournamentSelect347()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2367, result);
        }

        [TestMethod]
        public void TestTournamentSelect348()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2368, result);
        }

        [TestMethod]
        public void TestTournamentSelect349()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2369, result);
        }

        [TestMethod]
        public void TestTournamentSelect350()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2370, result);
        }

        [TestMethod]
        public void TestTournamentSelect351()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2371, result);
        }

        [TestMethod]
        public void TestTournamentSelect352()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2372, result);
        }

        [TestMethod]
        public void TestTournamentSelect353()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2373, result);
        }

        [TestMethod]
        public void TestTournamentSelect354()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2374, result);
        }

        [TestMethod]
        public void TestTournamentSelect355()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2375, result);
        }

        [TestMethod]
        public void TestTournamentSelect356()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2376, result);
        }

        [TestMethod]
        public void TestTournamentSelect357()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2377, result);
        }

        [TestMethod]
        public void TestTournamentSelect358()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2378, result);
        }

        [TestMethod]
        public void TestTournamentSelect359()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2379, result);
        }

        [TestMethod]
        public void TestTournamentSelect360()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2380, result);
        }

        [TestMethod]
        public void TestTournamentSelect361()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2381, result);
        }

        [TestMethod]
        public void TestTournamentSelect362()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2382, result);
        }

        [TestMethod]
        public void TestTournamentSelect363()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2383, result);
        }

        [TestMethod]
        public void TestTournamentSelect364()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2384, result);
        }

        [TestMethod]
        public void TestTournamentSelect365()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2385, result);
        }

        [TestMethod]
        public void TestTournamentSelect366()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2386, result);
        }

        [TestMethod]
        public void TestTournamentSelect367()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2387, result);
        }

        [TestMethod]
        public void TestTournamentSelect368()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2388, result);
        }

        [TestMethod]
        public void TestTournamentSelect369()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2389, result);
        }

        [TestMethod]
        public void TestTournamentSelect370()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2390, result);
        }

        [TestMethod]
        public void TestTournamentSelect371()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2391, result);
        }

        [TestMethod]
        public void TestTournamentSelect372()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2392, result);
        }

        [TestMethod]
        public void TestTournamentSelect373()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2393, result);
        }

        [TestMethod]
        public void TestTournamentSelect374()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2394, result);
        }

        [TestMethod]
        public void TestTournamentSelect375()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2395, result);
        }

        [TestMethod]
        public void TestTournamentSelect376()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2396, result);
        }

        [TestMethod]
        public void TestTournamentSelect377()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2397, result);
        }

        [TestMethod]
        public void TestTournamentSelect378()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2398, result);
        }

        [TestMethod]
        public void TestTournamentSelect379()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2399, result);
        }

        [TestMethod]
        public void TestTournamentSelect380()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2400, result);
        }

        [TestMethod]
        public void TestTournamentSelect381()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2401, result);
        }

        [TestMethod]
        public void TestTournamentSelect382()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2402, result);
        }

        [TestMethod]
        public void TestTournamentSelect383()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2403, result);
        }

        [TestMethod]
        public void TestTournamentSelect384()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2404, result);
        }

        [TestMethod]
        public void TestTournamentSelect385()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2405, result);
        }

        [TestMethod]
        public void TestTournamentSelect386()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2406, result);
        }

        [TestMethod]
        public void TestTournamentSelect387()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2407, result);
        }

        [TestMethod]
        public void TestTournamentSelect388()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2408, result);
        }

        [TestMethod]
        public void TestTournamentSelect389()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2409, result);
        }

        [TestMethod]
        public void TestTournamentSelect390()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2410, result);
        }

        [TestMethod]
        public void TestTournamentSelect391()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2411, result);
        }

        [TestMethod]
        public void TestTournamentSelect392()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2412, result);
        }

        [TestMethod]
        public void TestTournamentSelect393()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2413, result);
        }

        [TestMethod]
        public void TestTournamentSelect394()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2414, result);
        }

        [TestMethod]
        public void TestTournamentSelect395()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2415, result);
        }

        [TestMethod]
        public void TestTournamentSelect396()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2416, result);
        }

        [TestMethod]
        public void TestTournamentSelect397()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2417, result);
        }

        [TestMethod]
        public void TestTournamentSelect398()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2418, result);
        }

        [TestMethod]
        public void TestTournamentSelect399()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2419, result);
        }

        [TestMethod]
        public void TestTournamentSelect400()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2420, result);
        }

        [TestMethod]
        public void TestTournamentSelect401()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2421, result);
        }

        [TestMethod]
        public void TestTournamentSelect402()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2422, result);
        }

        [TestMethod]
        public void TestTournamentSelect403()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2423, result);
        }

        [TestMethod]
        public void TestTournamentSelect404()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2424, result);
        }

        [TestMethod]
        public void TestTournamentSelect405()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2425, result);
        }

        [TestMethod]
        public void TestTournamentSelect406()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2426, result);
        }

        [TestMethod]
        public void TestTournamentSelect407()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2427, result);
        }

        [TestMethod]
        public void TestTournamentSelect408()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2428, result);
        }

        [TestMethod]
        public void TestTournamentSelect409()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2429, result);
        }

        [TestMethod]
        public void TestTournamentSelect410()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2430, result);
        }

        [TestMethod]
        public void TestTournamentSelect411()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2431, result);
        }

        [TestMethod]
        public void TestTournamentSelect412()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2432, result);
        }

        [TestMethod]
        public void TestTournamentSelect413()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2433, result);
        }

        [TestMethod]
        public void TestTournamentSelect414()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2434, result);
        }

        [TestMethod]
        public void TestTournamentSelect415()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2435, result);
        }

        [TestMethod]
        public void TestTournamentSelect416()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2436, result);
        }

        [TestMethod]
        public void TestTournamentSelect417()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2437, result);
        }

        [TestMethod]
        public void TestTournamentSelect418()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2438, result);
        }

        [TestMethod]
        public void TestTournamentSelect419()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2439, result);
        }

        [TestMethod]
        public void TestTournamentSelect420()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2440, result);
        }

        [TestMethod]
        public void TestTournamentSelect421()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2441, result);
        }

        [TestMethod]
        public void TestTournamentSelect422()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2442, result);
        }

        [TestMethod]
        public void TestTournamentSelect423()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2443, result);
        }

        [TestMethod]
        public void TestTournamentSelect424()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2444, result);
        }

        [TestMethod]
        public void TestTournamentSelect425()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2445, result);
        }

        [TestMethod]
        public void TestTournamentSelect426()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2446, result);
        }

        [TestMethod]
        public void TestTournamentSelect427()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2447, result);
        }

        [TestMethod]
        public void TestTournamentSelect428()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2448, result);
        }

        [TestMethod]
        public void TestTournamentSelect429()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2449, result);
        }

        [TestMethod]
        public void TestTournamentSelect430()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2450, result);
        }

        [TestMethod]
        public void TestTournamentSelect431()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2451, result);
        }

        [TestMethod]
        public void TestTournamentSelect432()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2452, result);
        }

        [TestMethod]
        public void TestTournamentSelect433()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2453, result);
        }

        [TestMethod]
        public void TestTournamentSelect434()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2454, result);
        }

        [TestMethod]
        public void TestTournamentSelect435()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2455, result);
        }

        [TestMethod]
        public void TestTournamentSelect436()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2456, result);
        }

        [TestMethod]
        public void TestTournamentSelect437()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2457, result);
        }

        [TestMethod]
        public void TestTournamentSelect438()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2458, result);
        }

        [TestMethod]
        public void TestTournamentSelect439()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2459, result);
        }

        [TestMethod]
        public void TestTournamentSelect440()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2460, result);
        }

        [TestMethod]
        public void TestTournamentSelect441()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2461, result);
        }

        [TestMethod]
        public void TestTournamentSelect442()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2462, result);
        }

        [TestMethod]
        public void TestTournamentSelect443()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2463, result);
        }

        [TestMethod]
        public void TestTournamentSelect444()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2464, result);
        }

        [TestMethod]
        public void TestTournamentSelect445()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2465, result);
        }

        [TestMethod]
        public void TestTournamentSelect446()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2466, result);
        }

        [TestMethod]
        public void TestTournamentSelect447()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2467, result);
        }

        [TestMethod]
        public void TestTournamentSelect448()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2468, result);
        }

        [TestMethod]
        public void TestTournamentSelect449()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2469, result);
        }

        [TestMethod]
        public void TestTournamentSelect450()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2470, result);
        }

        [TestMethod]
        public void TestTournamentSelect451()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2471, result);
        }

        [TestMethod]
        public void TestTournamentSelect452()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2472, result);
        }

        [TestMethod]
        public void TestTournamentSelect453()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2473, result);
        }

        [TestMethod]
        public void TestTournamentSelect454()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2474, result);
        }

        [TestMethod]
        public void TestTournamentSelect455()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2475, result);
        }

        [TestMethod]
        public void TestTournamentSelect456()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2476, result);
        }

        [TestMethod]
        public void TestTournamentSelect457()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2477, result);
        }

        [TestMethod]
        public void TestTournamentSelect458()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2478, result);
        }

        [TestMethod]
        public void TestTournamentSelect459()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2479, result);
        }

        [TestMethod]
        public void TestTournamentSelect460()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2480, result);
        }

        [TestMethod]
        public void TestTournamentSelect461()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2481, result);
        }

        [TestMethod]
        public void TestTournamentSelect462()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2482, result);
        }

        [TestMethod]
        public void TestTournamentSelect463()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2483, result);
        }

        [TestMethod]
        public void TestTournamentSelect464()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2484, result);
        }

        [TestMethod]
        public void TestTournamentSelect465()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2485, result);
        }

        [TestMethod]
        public void TestTournamentSelect466()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2486, result);
        }

        [TestMethod]
        public void TestTournamentSelect467()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2487, result);
        }

        [TestMethod]
        public void TestTournamentSelect468()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2488, result);
        }

        [TestMethod]
        public void TestTournamentSelect469()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2489, result);
        }

        [TestMethod]
        public void TestTournamentSelect470()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2490, result);
        }

        [TestMethod]
        public void TestTournamentSelect471()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2491, result);
        }

        [TestMethod]
        public void TestTournamentSelect472()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2492, result);
        }

        [TestMethod]
        public void TestTournamentSelect473()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2493, result);
        }

        [TestMethod]
        public void TestTournamentSelect474()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2494, result);
        }

        [TestMethod]
        public void TestTournamentSelect475()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2495, result);
        }

        [TestMethod]
        public void TestTournamentSelect476()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2496, result);
        }

        [TestMethod]
        public void TestTournamentSelect477()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2497, result);
        }

        [TestMethod]
        public void TestTournamentSelect478()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2498, result);
        }

        [TestMethod]
        public void TestTournamentSelect479()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2499, result);
        }

        [TestMethod]
        public void TestTournamentSelect480()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2500, result);
        }

        [TestMethod]
        public void TestTournamentSelect481()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2501, result);
        }

        [TestMethod]
        public void TestTournamentSelect482()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2502, result);
        }

        [TestMethod]
        public void TestTournamentSelect483()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2503, result);
        }

        [TestMethod]
        public void TestTournamentSelect484()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2504, result);
        }

        [TestMethod]
        public void TestTournamentSelect485()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2505, result);
        }

        [TestMethod]
        public void TestTournamentSelect486()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2506, result);
        }

        [TestMethod]
        public void TestTournamentSelect487()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2507, result);
        }

        [TestMethod]
        public void TestTournamentSelect488()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2508, result);
        }

        [TestMethod]
        public void TestTournamentSelect489()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2509, result);
        }

        [TestMethod]
        public void TestTournamentSelect490()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2510, result);
        }

        [TestMethod]
        public void TestTournamentSelect491()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2511, result);
        }

        [TestMethod]
        public void TestTournamentSelect492()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2512, result);
        }

        [TestMethod]
        public void TestTournamentSelect493()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2513, result);
        }

        [TestMethod]
        public void TestTournamentSelect494()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2514, result);
        }

        [TestMethod]
        public void TestTournamentSelect495()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2515, result);
        }

        [TestMethod]
        public void TestTournamentSelect496()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2516, result);
        }

        [TestMethod]
        public void TestTournamentSelect497()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2517, result);
        }

        [TestMethod]
        public void TestTournamentSelect498()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2518, result);
        }

        [TestMethod]
        public void TestTournamentSelect499()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2519, result);
        }

        [TestMethod]
        public void TestTournamentSelect500()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2520, result);
        }

        [TestMethod]
        public void TestTournamentSelect501()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2521, result);
        }

        [TestMethod]
        public void TestTournamentSelect502()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2522, result);
        }

        [TestMethod]
        public void TestTournamentSelect503()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2523, result);
        }

        [TestMethod]
        public void TestTournamentSelect504()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2524, result);
        }

        [TestMethod]
        public void TestTournamentSelect505()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2525, result);
        }

        [TestMethod]
        public void TestTournamentSelect506()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2526, result);
        }

        [TestMethod]
        public void TestTournamentSelect507()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2527, result);
        }

        [TestMethod]
        public void TestTournamentSelect508()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2528, result);
        }

        [TestMethod]
        public void TestTournamentSelect509()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2529, result);
        }

        [TestMethod]
        public void TestTournamentSelect510()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2530, result);
        }

        [TestMethod]
        public void TestTournamentSelect511()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2531, result);
        }

        [TestMethod]
        public void TestTournamentSelect512()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2532, result);
        }

        [TestMethod]
        public void TestTournamentSelect513()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2533, result);
        }

        [TestMethod]
        public void TestTournamentSelect514()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2534, result);
        }

        [TestMethod]
        public void TestTournamentSelect515()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2535, result);
        }

        [TestMethod]
        public void TestTournamentSelect516()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2536, result);
        }

        [TestMethod]
        public void TestTournamentSelect517()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2537, result);
        }

        [TestMethod]
        public void TestTournamentSelect518()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2538, result);
        }

        [TestMethod]
        public void TestTournamentSelect519()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2539, result);
        }

        [TestMethod]
        public void TestTournamentSelect520()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2540, result);
        }

        [TestMethod]
        public void TestTournamentSelect521()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2541, result);
        }

        [TestMethod]
        public void TestTournamentSelect522()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2542, result);
        }

        [TestMethod]
        public void TestTournamentSelect523()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2543, result);
        }

        [TestMethod]
        public void TestTournamentSelect524()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2544, result);
        }

        [TestMethod]
        public void TestTournamentSelect525()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2545, result);
        }

        [TestMethod]
        public void TestTournamentSelect526()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2546, result);
        }

        [TestMethod]
        public void TestTournamentSelect527()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2547, result);
        }

        [TestMethod]
        public void TestTournamentSelect528()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2548, result);
        }

        [TestMethod]
        public void TestTournamentSelect529()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2549, result);
        }

        [TestMethod]
        public void TestTournamentSelect530()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2550, result);
        }

        [TestMethod]
        public void TestTournamentSelect531()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2551, result);
        }

        [TestMethod]
        public void TestTournamentSelect532()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2552, result);
        }

        [TestMethod]
        public void TestTournamentSelect533()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2553, result);
        }

        [TestMethod]
        public void TestTournamentSelect534()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2554, result);
        }

        [TestMethod]
        public void TestTournamentSelect535()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2555, result);
        }

        [TestMethod]
        public void TestTournamentSelect536()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2556, result);
        }

        [TestMethod]
        public void TestTournamentSelect537()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2557, result);
        }

        [TestMethod]
        public void TestTournamentSelect538()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2558, result);
        }

        [TestMethod]
        public void TestTournamentSelect539()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2559, result);
        }

        [TestMethod]
        public void TestTournamentSelect540()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2560, result);
        }

        [TestMethod]
        public void TestTournamentSelect541()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2561, result);
        }

        [TestMethod]
        public void TestTournamentSelect542()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2562, result);
        }

        [TestMethod]
        public void TestTournamentSelect543()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2563, result);
        }

        [TestMethod]
        public void TestTournamentSelect544()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2564, result);
        }

        [TestMethod]
        public void TestTournamentSelect545()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2565, result);
        }

        [TestMethod]
        public void TestTournamentSelect546()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2566, result);
        }

        [TestMethod]
        public void TestTournamentSelect547()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2567, result);
        }

        [TestMethod]
        public void TestTournamentSelect548()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2568, result);
        }

        [TestMethod]
        public void TestTournamentSelect549()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2569, result);
        }

        [TestMethod]
        public void TestTournamentSelect550()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2570, result);
        }

        [TestMethod]
        public void TestTournamentSelect551()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2571, result);
        }

        [TestMethod]
        public void TestTournamentSelect552()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2572, result);
        }

        [TestMethod]
        public void TestTournamentSelect553()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2573, result);
        }

        [TestMethod]
        public void TestTournamentSelect554()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2574, result);
        }

        [TestMethod]
        public void TestTournamentSelect555()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2575, result);
        }

        [TestMethod]
        public void TestTournamentSelect556()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2576, result);
        }

        [TestMethod]
        public void TestTournamentSelect557()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2577, result);
        }

        [TestMethod]
        public void TestTournamentSelect558()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2578, result);
        }

        [TestMethod]
        public void TestTournamentSelect559()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2579, result);
        }

        [TestMethod]
        public void TestTournamentSelect560()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2580, result);
        }

        [TestMethod]
        public void TestTournamentSelect561()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2581, result);
        }

        [TestMethod]
        public void TestTournamentSelect562()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2582, result);
        }

        [TestMethod]
        public void TestTournamentSelect563()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2583, result);
        }

        [TestMethod]
        public void TestTournamentSelect564()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2584, result);
        }

        [TestMethod]
        public void TestTournamentSelect565()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2585, result);
        }

        [TestMethod]
        public void TestTournamentSelect566()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2586, result);
        }

        [TestMethod]
        public void TestTournamentSelect567()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2587, result);
        }

        [TestMethod]
        public void TestTournamentSelect568()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2588, result);
        }

        [TestMethod]
        public void TestTournamentSelect569()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2589, result);
        }

        [TestMethod]
        public void TestTournamentSelect570()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2590, result);
        }

        [TestMethod]
        public void TestTournamentSelect571()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2591, result);
        }

        [TestMethod]
        public void TestTournamentSelect572()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2592, result);
        }

        [TestMethod]
        public void TestTournamentSelect573()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2593, result);
        }

        [TestMethod]
        public void TestTournamentSelect574()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2594, result);
        }

        [TestMethod]
        public void TestTournamentSelect575()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2595, result);
        }

        [TestMethod]
        public void TestTournamentSelect576()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2596, result);
        }

        [TestMethod]
        public void TestTournamentSelect577()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2597, result);
        }

        [TestMethod]
        public void TestTournamentSelect578()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2598, result);
        }

        [TestMethod]
        public void TestTournamentSelect579()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2599, result);
        }

        [TestMethod]
        public void TestTournamentSelect580()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2600, result);
        }

        [TestMethod]
        public void TestTournamentSelect581()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2601, result);
        }

        [TestMethod]
        public void TestTournamentSelect582()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2602, result);
        }

        [TestMethod]
        public void TestTournamentSelect583()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2603, result);
        }

        [TestMethod]
        public void TestTournamentSelect584()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2604, result);
        }

        [TestMethod]
        public void TestTournamentSelect585()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2605, result);
        }

        [TestMethod]
        public void TestTournamentSelect586()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2606, result);
        }

        [TestMethod]
        public void TestTournamentSelect587()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2607, result);
        }

        [TestMethod]
        public void TestTournamentSelect588()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2608, result);
        }

        [TestMethod]
        public void TestTournamentSelect589()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2609, result);
        }

        [TestMethod]
        public void TestTournamentSelect590()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2610, result);
        }

        [TestMethod]
        public void TestTournamentSelect591()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2611, result);
        }

        [TestMethod]
        public void TestTournamentSelect592()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2612, result);
        }

        [TestMethod]
        public void TestTournamentSelect593()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2613, result);
        }

        [TestMethod]
        public void TestTournamentSelect594()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2614, result);
        }

        [TestMethod]
        public void TestTournamentSelect595()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2615, result);
        }

        [TestMethod]
        public void TestTournamentSelect596()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2616, result);
        }

        [TestMethod]
        public void TestTournamentSelect597()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2617, result);
        }

        [TestMethod]
        public void TestTournamentSelect598()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2618, result);
        }

        [TestMethod]
        public void TestTournamentSelect599()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2619, result);
        }

        [TestMethod]
        public void TestTournamentSelect600()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2620, result);
        }

        [TestMethod]
        public void TestTournamentSelect601()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2621, result);
        }

        [TestMethod]
        public void TestTournamentSelect602()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2622, result);
        }

        [TestMethod]
        public void TestTournamentSelect603()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2623, result);
        }

        [TestMethod]
        public void TestTournamentSelect604()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2624, result);
        }

        [TestMethod]
        public void TestTournamentSelect605()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2625, result);
        }

        [TestMethod]
        public void TestTournamentSelect606()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2626, result);
        }

        [TestMethod]
        public void TestTournamentSelect607()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2627, result);
        }

        [TestMethod]
        public void TestTournamentSelect608()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2628, result);
        }

        [TestMethod]
        public void TestTournamentSelect609()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2629, result);
        }

        [TestMethod]
        public void TestTournamentSelect610()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2630, result);
        }

        [TestMethod]
        public void TestTournamentSelect611()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2631, result);
        }

        [TestMethod]
        public void TestTournamentSelect612()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2632, result);
        }

        [TestMethod]
        public void TestTournamentSelect613()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2633, result);
        }

        [TestMethod]
        public void TestTournamentSelect614()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2634, result);
        }

        [TestMethod]
        public void TestTournamentSelect615()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2635, result);
        }

        [TestMethod]
        public void TestTournamentSelect616()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2636, result);
        }

        [TestMethod]
        public void TestTournamentSelect617()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2637, result);
        }

        [TestMethod]
        public void TestTournamentSelect618()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2638, result);
        }

        [TestMethod]
        public void TestTournamentSelect619()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2639, result);
        }

        [TestMethod]
        public void TestTournamentSelect620()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2640, result);
        }

        [TestMethod]
        public void TestTournamentSelect621()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2641, result);
        }

        [TestMethod]
        public void TestTournamentSelect622()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2642, result);
        }

        [TestMethod]
        public void TestTournamentSelect623()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2643, result);
        }

        [TestMethod]
        public void TestTournamentSelect624()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2644, result);
        }

        [TestMethod]
        public void TestTournamentSelect625()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2645, result);
        }

        [TestMethod]
        public void TestTournamentSelect626()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2646, result);
        }

        [TestMethod]
        public void TestTournamentSelect627()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2647, result);
        }

        [TestMethod]
        public void TestTournamentSelect628()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2648, result);
        }

        [TestMethod]
        public void TestTournamentSelect629()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2649, result);
        }

        [TestMethod]
        public void TestTournamentSelect630()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2650, result);
        }

        [TestMethod]
        public void TestTournamentSelect631()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2651, result);
        }

        [TestMethod]
        public void TestTournamentSelect632()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2652, result);
        }

        [TestMethod]
        public void TestTournamentSelect633()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2653, result);
        }

        [TestMethod]
        public void TestTournamentSelect634()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2654, result);
        }

        [TestMethod]
        public void TestTournamentSelect635()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2655, result);
        }

        [TestMethod]
        public void TestTournamentSelect636()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2656, result);
        }

        [TestMethod]
        public void TestTournamentSelect637()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2657, result);
        }

        [TestMethod]
        public void TestTournamentSelect638()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2658, result);
        }

        [TestMethod]
        public void TestTournamentSelect639()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2659, result);
        }

        [TestMethod]
        public void TestTournamentSelect640()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2660, result);
        }

        [TestMethod]
        public void TestTournamentSelect641()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2661, result);
        }

        [TestMethod]
        public void TestTournamentSelect642()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2662, result);
        }

        [TestMethod]
        public void TestTournamentSelect643()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2663, result);
        }

        [TestMethod]
        public void TestTournamentSelect644()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2664, result);
        }

        [TestMethod]
        public void TestTournamentSelect645()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2665, result);
        }

        [TestMethod]
        public void TestTournamentSelect646()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2666, result);
        }

        [TestMethod]
        public void TestTournamentSelect647()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2667, result);
        }

        [TestMethod]
        public void TestTournamentSelect648()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2668, result);
        }

        [TestMethod]
        public void TestTournamentSelect649()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2669, result);
        }

        [TestMethod]
        public void TestTournamentSelect650()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2670, result);
        }

        [TestMethod]
        public void TestTournamentSelect651()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2671, result);
        }

        [TestMethod]
        public void TestTournamentSelect652()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2672, result);
        }

        [TestMethod]
        public void TestTournamentSelect653()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2673, result);
        }

        [TestMethod]
        public void TestTournamentSelect654()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2674, result);
        }

        [TestMethod]
        public void TestTournamentSelect655()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2675, result);
        }

        [TestMethod]
        public void TestTournamentSelect656()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2676, result);
        }

        [TestMethod]
        public void TestTournamentSelect657()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2677, result);
        }

        [TestMethod]
        public void TestTournamentSelect658()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2678, result);
        }

        [TestMethod]
        public void TestTournamentSelect659()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2679, result);
        }

        [TestMethod]
        public void TestTournamentSelect660()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2680, result);
        }

        [TestMethod]
        public void TestTournamentSelect661()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2681, result);
        }

        [TestMethod]
        public void TestTournamentSelect662()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2682, result);
        }

        [TestMethod]
        public void TestTournamentSelect663()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2683, result);
        }

        [TestMethod]
        public void TestTournamentSelect664()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2684, result);
        }

        [TestMethod]
        public void TestTournamentSelect665()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2685, result);
        }

        [TestMethod]
        public void TestTournamentSelect666()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2686, result);
        }

        [TestMethod]
        public void TestTournamentSelect667()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2687, result);
        }

        [TestMethod]
        public void TestTournamentSelect668()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2688, result);
        }

        [TestMethod]
        public void TestTournamentSelect669()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2689, result);
        }

        [TestMethod]
        public void TestTournamentSelect670()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2690, result);
        }

        [TestMethod]
        public void TestTournamentSelect671()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2691, result);
        }

        [TestMethod]
        public void TestTournamentSelect672()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2692, result);
        }

        [TestMethod]
        public void TestTournamentSelect673()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2693, result);
        }

        [TestMethod]
        public void TestTournamentSelect674()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2694, result);
        }

        [TestMethod]
        public void TestTournamentSelect675()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2695, result);
        }

        [TestMethod]
        public void TestTournamentSelect676()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2696, result);
        }

        [TestMethod]
        public void TestTournamentSelect677()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2697, result);
        }

        [TestMethod]
        public void TestTournamentSelect678()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2698, result);
        }

        [TestMethod]
        public void TestTournamentSelect679()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2699, result);
        }

        [TestMethod]
        public void TestTournamentSelect680()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2700, result);
        }

        [TestMethod]
        public void TestTournamentSelect681()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2701, result);
        }

        [TestMethod]
        public void TestTournamentSelect682()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2702, result);
        }

        [TestMethod]
        public void TestTournamentSelect683()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2703, result);
        }

        [TestMethod]
        public void TestTournamentSelect684()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2704, result);
        }

        [TestMethod]
        public void TestTournamentSelect685()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2705, result);
        }

        [TestMethod]
        public void TestTournamentSelect686()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2706, result);
        }

        [TestMethod]
        public void TestTournamentSelect687()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2707, result);
        }

        [TestMethod]
        public void TestTournamentSelect688()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2708, result);
        }

        [TestMethod]
        public void TestTournamentSelect689()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2709, result);
        }

        [TestMethod]
        public void TestTournamentSelect690()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2710, result);
        }

        [TestMethod]
        public void TestTournamentSelect691()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2711, result);
        }

        [TestMethod]
        public void TestTournamentSelect692()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2712, result);
        }

        [TestMethod]
        public void TestTournamentSelect693()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2713, result);
        }

        [TestMethod]
        public void TestTournamentSelect694()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2714, result);
        }

        [TestMethod]
        public void TestTournamentSelect695()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2715, result);
        }

        [TestMethod]
        public void TestTournamentSelect696()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2716, result);
        }

        [TestMethod]
        public void TestTournamentSelect697()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2717, result);
        }

        [TestMethod]
        public void TestTournamentSelect698()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2718, result);
        }

        [TestMethod]
        public void TestTournamentSelect699()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2719, result);
        }

        [TestMethod]
        public void TestTournamentSelect700()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2720, result);
        }

        [TestMethod]
        public void TestTournamentSelect701()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2721, result);
        }

        [TestMethod]
        public void TestTournamentSelect702()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2722, result);
        }

        [TestMethod]
        public void TestTournamentSelect703()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2723, result);
        }

        [TestMethod]
        public void TestTournamentSelect704()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2724, result);
        }

        [TestMethod]
        public void TestTournamentSelect705()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2725, result);
        }

        [TestMethod]
        public void TestTournamentSelect706()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2726, result);
        }

        [TestMethod]
        public void TestTournamentSelect707()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2727, result);
        }

        [TestMethod]
        public void TestTournamentSelect708()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2728, result);
        }

        [TestMethod]
        public void TestTournamentSelect709()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2729, result);
        }

        [TestMethod]
        public void TestTournamentSelect710()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2730, result);
        }

        [TestMethod]
        public void TestTournamentSelect711()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2731, result);
        }

        [TestMethod]
        public void TestTournamentSelect712()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2732, result);
        }

        [TestMethod]
        public void TestTournamentSelect713()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2733, result);
        }

        [TestMethod]
        public void TestTournamentSelect714()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2734, result);
        }

        [TestMethod]
        public void TestTournamentSelect715()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2735, result);
        }

        [TestMethod]
        public void TestTournamentSelect716()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2736, result);
        }

        [TestMethod]
        public void TestTournamentSelect717()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2737, result);
        }

        [TestMethod]
        public void TestTournamentSelect718()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2738, result);
        }

        [TestMethod]
        public void TestTournamentSelect719()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2739, result);
        }

        [TestMethod]
        public void TestTournamentSelect720()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2740, result);
        }

        [TestMethod]
        public void TestTournamentSelect721()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2741, result);
        }

        [TestMethod]
        public void TestTournamentSelect722()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2742, result);
        }

        [TestMethod]
        public void TestTournamentSelect723()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2743, result);
        }

        [TestMethod]
        public void TestTournamentSelect724()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2744, result);
        }

        [TestMethod]
        public void TestTournamentSelect725()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2745, result);
        }

        [TestMethod]
        public void TestTournamentSelect726()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2746, result);
        }

        [TestMethod]
        public void TestTournamentSelect727()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2747, result);
        }

        [TestMethod]
        public void TestTournamentSelect728()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2748, result);
        }

        [TestMethod]
        public void TestTournamentSelect729()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2749, result);
        }

        [TestMethod]
        public void TestTournamentSelect730()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2750, result);
        }

        [TestMethod]
        public void TestTournamentSelect731()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2751, result);
        }

        [TestMethod]
        public void TestTournamentSelect732()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2752, result);
        }

        [TestMethod]
        public void TestTournamentSelect733()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2753, result);
        }

        [TestMethod]
        public void TestTournamentSelect734()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2754, result);
        }

        [TestMethod]
        public void TestTournamentSelect735()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2755, result);
        }

        [TestMethod]
        public void TestTournamentSelect736()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2756, result);
        }

        [TestMethod]
        public void TestTournamentSelect737()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2757, result);
        }

        [TestMethod]
        public void TestTournamentSelect738()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2758, result);
        }

        [TestMethod]
        public void TestTournamentSelect739()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2759, result);
        }

        [TestMethod]
        public void TestTournamentSelect740()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2760, result);
        }

        [TestMethod]
        public void TestTournamentSelect741()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2761, result);
        }

        [TestMethod]
        public void TestTournamentSelect742()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2762, result);
        }

        [TestMethod]
        public void TestTournamentSelect743()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2763, result);
        }

        [TestMethod]
        public void TestTournamentSelect744()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2764, result);
        }

        [TestMethod]
        public void TestTournamentSelect745()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2765, result);
        }

        [TestMethod]
        public void TestTournamentSelect746()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2766, result);
        }

        [TestMethod]
        public void TestTournamentSelect747()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2767, result);
        }

        [TestMethod]
        public void TestTournamentSelect748()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2768, result);
        }

        [TestMethod]
        public void TestTournamentSelect749()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2769, result);
        }

        [TestMethod]
        public void TestTournamentSelect750()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2770, result);
        }

        [TestMethod]
        public void TestTournamentSelect751()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2771, result);
        }

        [TestMethod]
        public void TestTournamentSelect752()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2772, result);
        }

        [TestMethod]
        public void TestTournamentSelect753()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2773, result);
        }

        [TestMethod]
        public void TestTournamentSelect754()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2774, result);
        }

        [TestMethod]
        public void TestTournamentSelect755()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2775, result);
        }

        [TestMethod]
        public void TestTournamentSelect756()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2776, result);
        }

        [TestMethod]
        public void TestTournamentSelect757()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2777, result);
        }

        [TestMethod]
        public void TestTournamentSelect758()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2778, result);
        }

        [TestMethod]
        public void TestTournamentSelect759()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2779, result);
        }

        [TestMethod]
        public void TestTournamentSelect760()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2780, result);
        }

        [TestMethod]
        public void TestTournamentSelect761()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2781, result);
        }

        [TestMethod]
        public void TestTournamentSelect762()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2782, result);
        }

        [TestMethod]
        public void TestTournamentSelect763()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2783, result);
        }

        [TestMethod]
        public void TestTournamentSelect764()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2784, result);
        }

        [TestMethod]
        public void TestTournamentSelect765()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2785, result);
        }

        [TestMethod]
        public void TestTournamentSelect766()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2786, result);
        }

        [TestMethod]
        public void TestTournamentSelect767()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2787, result);
        }

        [TestMethod]
        public void TestTournamentSelect768()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2788, result);
        }

        [TestMethod]
        public void TestTournamentSelect769()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2789, result);
        }

        [TestMethod]
        public void TestTournamentSelect770()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2790, result);
        }

        [TestMethod]
        public void TestTournamentSelect771()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2791, result);
        }

        [TestMethod]
        public void TestTournamentSelect772()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2792, result);
        }

        [TestMethod]
        public void TestTournamentSelect773()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2793, result);
        }

        [TestMethod]
        public void TestTournamentSelect774()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2794, result);
        }

        [TestMethod]
        public void TestTournamentSelect775()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2795, result);
        }

        [TestMethod]
        public void TestTournamentSelect776()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2796, result);
        }

        [TestMethod]
        public void TestTournamentSelect777()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2797, result);
        }

        [TestMethod]
        public void TestTournamentSelect778()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2798, result);
        }

        [TestMethod]
        public void TestTournamentSelect779()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2799, result);
        }

        [TestMethod]
        public void TestTournamentSelect780()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2800, result);
        }

        [TestMethod]
        public void TestTournamentSelect781()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2801, result);
        }

        [TestMethod]
        public void TestTournamentSelect782()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2802, result);
        }

        [TestMethod]
        public void TestTournamentSelect783()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2803, result);
        }

        [TestMethod]
        public void TestTournamentSelect784()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2804, result);
        }

        [TestMethod]
        public void TestTournamentSelect785()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2805, result);
        }

        [TestMethod]
        public void TestTournamentSelect786()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2806, result);
        }

        [TestMethod]
        public void TestTournamentSelect787()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2807, result);
        }

        [TestMethod]
        public void TestTournamentSelect788()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2808, result);
        }

        [TestMethod]
        public void TestTournamentSelect789()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2809, result);
        }

        [TestMethod]
        public void TestTournamentSelect790()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2810, result);
        }

        [TestMethod]
        public void TestTournamentSelect791()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2811, result);
        }

        [TestMethod]
        public void TestTournamentSelect792()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2812, result);
        }

        [TestMethod]
        public void TestTournamentSelect793()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2813, result);
        }

        [TestMethod]
        public void TestTournamentSelect794()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2814, result);
        }

        [TestMethod]
        public void TestTournamentSelect795()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2815, result);
        }

        [TestMethod]
        public void TestTournamentSelect796()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2816, result);
        }

        [TestMethod]
        public void TestTournamentSelect797()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2817, result);
        }

        [TestMethod]
        public void TestTournamentSelect798()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2818, result);
        }

        [TestMethod]
        public void TestTournamentSelect799()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2819, result);
        }

        [TestMethod]
        public void TestTournamentSelect800()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2820, result);
        }

        [TestMethod]
        public void TestTournamentSelect801()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2821, result);
        }

        [TestMethod]
        public void TestTournamentSelect802()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2822, result);
        }

        [TestMethod]
        public void TestTournamentSelect803()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2823, result);
        }

        [TestMethod]
        public void TestTournamentSelect804()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2824, result);
        }

        [TestMethod]
        public void TestTournamentSelect805()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2825, result);
        }

        [TestMethod]
        public void TestTournamentSelect806()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2826, result);
        }

        [TestMethod]
        public void TestTournamentSelect807()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2827, result);
        }

        [TestMethod]
        public void TestTournamentSelect808()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2828, result);
        }

        [TestMethod]
        public void TestTournamentSelect809()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2829, result);
        }

        [TestMethod]
        public void TestTournamentSelect810()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2830, result);
        }

        [TestMethod]
        public void TestTournamentSelect811()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2831, result);
        }

        [TestMethod]
        public void TestTournamentSelect812()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2832, result);
        }

        [TestMethod]
        public void TestTournamentSelect813()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2833, result);
        }

        [TestMethod]
        public void TestTournamentSelect814()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2834, result);
        }

        [TestMethod]
        public void TestTournamentSelect815()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2835, result);
        }

        [TestMethod]
        public void TestTournamentSelect816()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2836, result);
        }

        [TestMethod]
        public void TestTournamentSelect817()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2837, result);
        }

        [TestMethod]
        public void TestTournamentSelect818()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2838, result);
        }

        [TestMethod]
        public void TestTournamentSelect819()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2839, result);
        }

        [TestMethod]
        public void TestTournamentSelect820()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2840, result);
        }

        [TestMethod]
        public void TestTournamentSelect821()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2841, result);
        }

        [TestMethod]
        public void TestTournamentSelect822()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2842, result);
        }

        [TestMethod]
        public void TestTournamentSelect823()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2843, result);
        }

        [TestMethod]
        public void TestTournamentSelect824()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2844, result);
        }

        [TestMethod]
        public void TestTournamentSelect825()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2845, result);
        }

        [TestMethod]
        public void TestTournamentSelect826()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2846, result);
        }

        [TestMethod]
        public void TestTournamentSelect827()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2847, result);
        }

        [TestMethod]
        public void TestTournamentSelect828()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2848, result);
        }

        [TestMethod]
        public void TestTournamentSelect829()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2849, result);
        }

        [TestMethod]
        public void TestTournamentSelect830()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2850, result);
        }

        [TestMethod]
        public void TestTournamentSelect831()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2851, result);
        }

        [TestMethod]
        public void TestTournamentSelect832()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2852, result);
        }

        [TestMethod]
        public void TestTournamentSelect833()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2853, result);
        }

        [TestMethod]
        public void TestTournamentSelect834()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2854, result);
        }

        [TestMethod]
        public void TestTournamentSelect835()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2855, result);
        }

        [TestMethod]
        public void TestTournamentSelect836()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2856, result);
        }

        [TestMethod]
        public void TestTournamentSelect837()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2857, result);
        }

        [TestMethod]
        public void TestTournamentSelect838()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2858, result);
        }

        [TestMethod]
        public void TestTournamentSelect839()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2859, result);
        }

        [TestMethod]
        public void TestTournamentSelect840()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2860, result);
        }

        [TestMethod]
        public void TestTournamentSelect841()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2861, result);
        }

        [TestMethod]
        public void TestTournamentSelect842()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2862, result);
        }

        [TestMethod]
        public void TestTournamentSelect843()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2863, result);
        }

        [TestMethod]
        public void TestTournamentSelect844()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2864, result);
        }

        [TestMethod]
        public void TestTournamentSelect845()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2865, result);
        }

        [TestMethod]
        public void TestTournamentSelect846()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2866, result);
        }

        [TestMethod]
        public void TestTournamentSelect847()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2867, result);
        }

        [TestMethod]
        public void TestTournamentSelect848()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2868, result);
        }

        [TestMethod]
        public void TestTournamentSelect849()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2869, result);
        }

        [TestMethod]
        public void TestTournamentSelect850()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2870, result);
        }

        [TestMethod]
        public void TestTournamentSelect851()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2871, result);
        }

        [TestMethod]
        public void TestTournamentSelect852()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2872, result);
        }

        [TestMethod]
        public void TestTournamentSelect853()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2873, result);
        }

        [TestMethod]
        public void TestTournamentSelect854()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2874, result);
        }

        [TestMethod]
        public void TestTournamentSelect855()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2875, result);
        }

        [TestMethod]
        public void TestTournamentSelect856()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2876, result);
        }

        [TestMethod]
        public void TestTournamentSelect857()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2877, result);
        }

        [TestMethod]
        public void TestTournamentSelect858()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2878, result);
        }

        [TestMethod]
        public void TestTournamentSelect859()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2879, result);
        }

        [TestMethod]
        public void TestTournamentSelect860()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2880, result);
        }

        [TestMethod]
        public void TestTournamentSelect861()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2881, result);
        }

        [TestMethod]
        public void TestTournamentSelect862()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2882, result);
        }

        [TestMethod]
        public void TestTournamentSelect863()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2883, result);
        }

        [TestMethod]
        public void TestTournamentSelect864()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2884, result);
        }

        [TestMethod]
        public void TestTournamentSelect865()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2885, result);
        }

        [TestMethod]
        public void TestTournamentSelect866()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2886, result);
        }

        [TestMethod]
        public void TestTournamentSelect867()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2887, result);
        }

        [TestMethod]
        public void TestTournamentSelect868()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2888, result);
        }

        [TestMethod]
        public void TestTournamentSelect869()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2889, result);
        }

        [TestMethod]
        public void TestTournamentSelect870()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2890, result);
        }

        [TestMethod]
        public void TestTournamentSelect871()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2891, result);
        }

        [TestMethod]
        public void TestTournamentSelect872()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2892, result);
        }

        [TestMethod]
        public void TestTournamentSelect873()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2893, result);
        }

        [TestMethod]
        public void TestTournamentSelect874()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2894, result);
        }

        [TestMethod]
        public void TestTournamentSelect875()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2895, result);
        }

        [TestMethod]
        public void TestTournamentSelect876()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2896, result);
        }

        [TestMethod]
        public void TestTournamentSelect877()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2897, result);
        }

        [TestMethod]
        public void TestTournamentSelect878()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2898, result);
        }

        [TestMethod]
        public void TestTournamentSelect879()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2899, result);
        }

        [TestMethod]
        public void TestTournamentSelect880()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2900, result);
        }

        [TestMethod]
        public void TestTournamentSelect881()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2901, result);
        }

        [TestMethod]
        public void TestTournamentSelect882()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2902, result);
        }

        [TestMethod]
        public void TestTournamentSelect883()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2903, result);
        }

        [TestMethod]
        public void TestTournamentSelect884()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2904, result);
        }

        [TestMethod]
        public void TestTournamentSelect885()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2905, result);
        }

        [TestMethod]
        public void TestTournamentSelect886()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2906, result);
        }

        [TestMethod]
        public void TestTournamentSelect887()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2907, result);
        }

        [TestMethod]
        public void TestTournamentSelect888()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2908, result);
        }

        [TestMethod]
        public void TestTournamentSelect889()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2909, result);
        }

        [TestMethod]
        public void TestTournamentSelect890()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2910, result);
        }

        [TestMethod]
        public void TestTournamentSelect891()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2911, result);
        }

        [TestMethod]
        public void TestTournamentSelect892()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2912, result);
        }

        [TestMethod]
        public void TestTournamentSelect893()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2913, result);
        }

        [TestMethod]
        public void TestTournamentSelect894()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2914, result);
        }

        [TestMethod]
        public void TestTournamentSelect895()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2915, result);
        }

        [TestMethod]
        public void TestTournamentSelect896()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2916, result);
        }

        [TestMethod]
        public void TestTournamentSelect897()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2917, result);
        }

        [TestMethod]
        public void TestTournamentSelect898()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2918, result);
        }

        [TestMethod]
        public void TestTournamentSelect899()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2919, result);
        }

        [TestMethod]
        public void TestTournamentSelect900()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2920, result);
        }

        [TestMethod]
        public void TestTournamentSelect901()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2921, result);
        }

        [TestMethod]
        public void TestTournamentSelect902()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2922, result);
        }

        [TestMethod]
        public void TestTournamentSelect903()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2923, result);
        }

        [TestMethod]
        public void TestTournamentSelect904()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2924, result);
        }

        [TestMethod]
        public void TestTournamentSelect905()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2925, result);
        }

        [TestMethod]
        public void TestTournamentSelect906()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2926, result);
        }

        [TestMethod]
        public void TestTournamentSelect907()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2927, result);
        }

        [TestMethod]
        public void TestTournamentSelect908()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2928, result);
        }

        [TestMethod]
        public void TestTournamentSelect909()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2929, result);
        }

        [TestMethod]
        public void TestTournamentSelect910()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2930, result);
        }

        [TestMethod]
        public void TestTournamentSelect911()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2931, result);
        }

        [TestMethod]
        public void TestTournamentSelect912()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2932, result);
        }

        [TestMethod]
        public void TestTournamentSelect913()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2933, result);
        }

        [TestMethod]
        public void TestTournamentSelect914()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2934, result);
        }

        [TestMethod]
        public void TestTournamentSelect915()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2935, result);
        }

        [TestMethod]
        public void TestTournamentSelect916()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2936, result);
        }

        [TestMethod]
        public void TestTournamentSelect917()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2937, result);
        }

        [TestMethod]
        public void TestTournamentSelect918()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2938, result);
        }

        [TestMethod]
        public void TestTournamentSelect919()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2939, result);
        }

        [TestMethod]
        public void TestTournamentSelect920()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2940, result);
        }

        [TestMethod]
        public void TestTournamentSelect921()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2941, result);
        }

        [TestMethod]
        public void TestTournamentSelect922()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2942, result);
        }

        [TestMethod]
        public void TestTournamentSelect923()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2943, result);
        }

        [TestMethod]
        public void TestTournamentSelect924()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2944, result);
        }

        [TestMethod]
        public void TestTournamentSelect925()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2945, result);
        }

        [TestMethod]
        public void TestTournamentSelect926()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2946, result);
        }

        [TestMethod]
        public void TestTournamentSelect927()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2947, result);
        }

        [TestMethod]
        public void TestTournamentSelect928()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2948, result);
        }

        [TestMethod]
        public void TestTournamentSelect929()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2949, result);
        }

        [TestMethod]
        public void TestTournamentSelect930()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2950, result);
        }

        [TestMethod]
        public void TestTournamentSelect931()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2951, result);
        }

        [TestMethod]
        public void TestTournamentSelect932()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2952, result);
        }

        [TestMethod]
        public void TestTournamentSelect933()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2953, result);
        }

        [TestMethod]
        public void TestTournamentSelect934()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2954, result);
        }

        [TestMethod]
        public void TestTournamentSelect935()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2955, result);
        }

        [TestMethod]
        public void TestTournamentSelect936()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2956, result);
        }

        [TestMethod]
        public void TestTournamentSelect937()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2957, result);
        }

        [TestMethod]
        public void TestTournamentSelect938()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2958, result);
        }

        [TestMethod]
        public void TestTournamentSelect939()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2959, result);
        }

        [TestMethod]
        public void TestTournamentSelect940()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2960, result);
        }

        [TestMethod]
        public void TestTournamentSelect941()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2961, result);
        }

        [TestMethod]
        public void TestTournamentSelect942()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2962, result);
        }

        [TestMethod]
        public void TestTournamentSelect943()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2963, result);
        }

        [TestMethod]
        public void TestTournamentSelect944()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2964, result);
        }

        [TestMethod]
        public void TestTournamentSelect945()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2965, result);
        }

        [TestMethod]
        public void TestTournamentSelect946()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2966, result);
        }

        [TestMethod]
        public void TestTournamentSelect947()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2967, result);
        }

        [TestMethod]
        public void TestTournamentSelect948()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2968, result);
        }

        [TestMethod]
        public void TestTournamentSelect949()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2969, result);
        }

        [TestMethod]
        public void TestTournamentSelect950()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2970, result);
        }

        [TestMethod]
        public void TestTournamentSelect951()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2971, result);
        }

        [TestMethod]
        public void TestTournamentSelect952()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2972, result);
        }

        [TestMethod]
        public void TestTournamentSelect953()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2973, result);
        }

        [TestMethod]
        public void TestTournamentSelect954()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2974, result);
        }

        [TestMethod]
        public void TestTournamentSelect955()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2975, result);
        }

        [TestMethod]
        public void TestTournamentSelect956()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2976, result);
        }

        [TestMethod]
        public void TestTournamentSelect957()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2977, result);
        }

        [TestMethod]
        public void TestTournamentSelect958()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2978, result);
        }

        [TestMethod]
        public void TestTournamentSelect959()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2979, result);
        }

        [TestMethod]
        public void TestTournamentSelect960()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2980, result);
        }

        [TestMethod]
        public void TestTournamentSelect961()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2981, result);
        }

        [TestMethod]
        public void TestTournamentSelect962()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2982, result);
        }

        [TestMethod]
        public void TestTournamentSelect963()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2983, result);
        }

        [TestMethod]
        public void TestTournamentSelect964()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2984, result);
        }

        [TestMethod]
        public void TestTournamentSelect965()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2985, result);
        }

        [TestMethod]
        public void TestTournamentSelect966()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2986, result);
        }

        [TestMethod]
        public void TestTournamentSelect967()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2987, result);
        }

        [TestMethod]
        public void TestTournamentSelect968()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2988, result);
        }

        [TestMethod]
        public void TestTournamentSelect969()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2989, result);
        }

        [TestMethod]
        public void TestTournamentSelect970()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result2990, result);
        }

        [TestMethod]
        public void TestTournamentSelect971()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result2991, result);
        }

        [TestMethod]
        public void TestTournamentSelect972()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result2992, result);
        }

        [TestMethod]
        public void TestTournamentSelect973()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result2993, result);
        }

        [TestMethod]
        public void TestTournamentSelect974()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result2994, result);
        }

        [TestMethod]
        public void TestTournamentSelect975()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result2995, result);
        }

        [TestMethod]
        public void TestTournamentSelect976()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result2996, result);
        }

        [TestMethod]
        public void TestTournamentSelect977()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result2997, result);
        }

        [TestMethod]
        public void TestTournamentSelect978()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result2998, result);
        }

        [TestMethod]
        public void TestTournamentSelect979()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result2999, result);
        }

        [TestMethod]
        public void TestTournamentSelect980()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result3000, result);
        }

        [TestMethod]
        public void TestTournamentSelect981()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result3001, result);
        }

        [TestMethod]
        public void TestTournamentSelect982()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result3002, result);
        }

        [TestMethod]
        public void TestTournamentSelect983()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result3003, result);
        }

        [TestMethod]
        public void TestTournamentSelect984()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result3004, result);
        }

        [TestMethod]
        public void TestTournamentSelect985()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result3005, result);
        }

        [TestMethod]
        public void TestTournamentSelect986()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result3006, result);
        }

        [TestMethod]
        public void TestTournamentSelect987()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result3007, result);
        }

        [TestMethod]
        public void TestTournamentSelect988()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result3008, result);
        }

        [TestMethod]
        public void TestTournamentSelect989()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result3009, result);
        }

        [TestMethod]
        public void TestTournamentSelect990()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.tournamentSelect(TestPopulations.population0));
            CollectionAssert.AreEqual(IndividualsResults.result3010, result);
        }

        [TestMethod]
        public void TestTournamentSelect991()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.tournamentSelect(TestPopulations.population1));
            CollectionAssert.AreEqual(IndividualsResults.result3011, result);
        }

        [TestMethod]
        public void TestTournamentSelect992()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.tournamentSelect(TestPopulations.population2));
            CollectionAssert.AreEqual(IndividualsResults.result3012, result);
        }

        [TestMethod]
        public void TestTournamentSelect993()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.tournamentSelect(TestPopulations.population3));
            CollectionAssert.AreEqual(IndividualsResults.result3013, result);
        }

        [TestMethod]
        public void TestTournamentSelect994()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.tournamentSelect(TestPopulations.population4));
            CollectionAssert.AreEqual(IndividualsResults.result3014, result);
        }

        [TestMethod]
        public void TestTournamentSelect995()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.tournamentSelect(TestPopulations.population5));
            CollectionAssert.AreEqual(IndividualsResults.result3015, result);
        }

        [TestMethod]
        public void TestTournamentSelect996()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.tournamentSelect(TestPopulations.population6));
            CollectionAssert.AreEqual(IndividualsResults.result3016, result);
        }

        [TestMethod]
        public void TestTournamentSelect997()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.tournamentSelect(TestPopulations.population7));
            CollectionAssert.AreEqual(IndividualsResults.result3017, result);
        }

        [TestMethod]
        public void TestTournamentSelect998()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.tournamentSelect(TestPopulations.population8));
            CollectionAssert.AreEqual(IndividualsResults.result3018, result);
        }

        [TestMethod]
        public void TestTournamentSelect999()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.tournamentSelect(TestPopulations.population9));
            CollectionAssert.AreEqual(IndividualsResults.result3019, result);
        }

    }
}
