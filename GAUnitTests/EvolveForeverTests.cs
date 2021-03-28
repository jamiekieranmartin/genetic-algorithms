using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System;
using CAB402.FSharp;

namespace GeneticAlgorithmUnitTests
{
    [TestClass]
    public class EvolveForeverTests
    {
        private void CompareIndividuals(Tuple<int[], double> expected, Tuple<int[], double> actual)
        {
            CollectionAssert.AreEqual(expected.Item1, actual.Item1);
            Assert.AreEqual(expected.Item2, actual.Item2);
        }

        [TestMethod]
        public void TestEvolveForever00()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6570, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6571, -3109.5070285513925));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6572, -3109.5070285513925));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6573, -3109.5070285513925));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6574, -3109.5070285513925));
        }

        [TestMethod]
        public void TestEvolveForever01()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6575, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6576, -3075.636694507708));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6577, -3036.386710204603));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6578, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6579, -3015.847880912715));
        }

        [TestMethod]
        public void TestEvolveForever02()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6580, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6581, -3139.5203808528127));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6582, -3139.5203808528127));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6583, -3139.5203808528127));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6584, -3081.3620558025864));
        }

        [TestMethod]
        public void TestEvolveForever03()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6585, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6586, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6587, -3324.5022586380474));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6588, -3113.9657342778187));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6589, -3113.9657342778187));
        }

        [TestMethod]
        public void TestEvolveForever04()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6590, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6591, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6592, -2973.496682966413));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6593, -2973.496682966413));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6594, -2973.496682966413));
        }

        [TestMethod]
        public void TestEvolveForever05()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6595, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6596, -3040.2888633614643));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6597, -3040.2888633614643));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6598, -2929.841843740715));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6599, -2929.841843740715));
        }

        [TestMethod]
        public void TestEvolveForever06()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6600, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6601, -2733.534971732132));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6602, -2733.534971732132));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6603, -2733.534971732132));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6604, -2733.534971732132));
        }

        [TestMethod]
        public void TestEvolveForever07()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6605, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6606, -3676.91841160557));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6607, -3621.622448209689));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6608, -3621.622448209689));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6609, -3597.276011888166));
        }

        [TestMethod]
        public void TestEvolveForever08()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6610, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6611, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6612, -2599.8700220524893));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6613, -2599.8700220524893));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6614, -2448.8541535097684));
        }

        [TestMethod]
        public void TestEvolveForever09()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6615, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6616, -3342.4815836832063));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6617, -3140.08792736775));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6618, -3140.08792736775));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6619, -3140.08792736775));
        }

        [TestMethod]
        public void TestEvolveForever10()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6620, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6621, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6622, -3351.228230545536));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6623, -3351.228230545536));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6624, -3351.228230545536));
        }

        [TestMethod]
        public void TestEvolveForever11()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6625, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6626, -3263.2885447369613));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6627, -2999.095363016954));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6628, -2732.8745797328315));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6629, -2732.8745797328315));
        }

        [TestMethod]
        public void TestEvolveForever12()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6630, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6631, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6632, -3367.051407629086));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6633, -3367.051407629086));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6634, -3257.565281131356));
        }

        [TestMethod]
        public void TestEvolveForever13()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6635, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6636, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6637, -3324.5022586380474));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6638, -3324.5022586380474));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6639, -2838.160946511937));
        }

        [TestMethod]
        public void TestEvolveForever14()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6640, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6641, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6642, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6643, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6644, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever15()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6645, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6646, -3022.844447724386));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6647, -3022.844447724386));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6648, -3022.844447724386));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6649, -2985.6044543591306));
        }

        [TestMethod]
        public void TestEvolveForever16()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6650, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6651, -3140.203623585954));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6652, -3140.203623585954));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6653, -2972.706686223677));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6654, -2972.706686223677));
        }

        [TestMethod]
        public void TestEvolveForever17()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6655, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6656, -3693.690208719645));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6657, -3483.87102920521));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6658, -3423.2710637319287));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6659, -3322.9193360826653));
        }

        [TestMethod]
        public void TestEvolveForever18()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6660, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6661, -2927.7956452766057));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6662, -2927.7956452766057));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6663, -2793.389975796982));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6664, -2793.389975796982));
        }

        [TestMethod]
        public void TestEvolveForever19()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6665, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6666, -3102.243553914709));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6667, -3102.243553914709));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6668, -3102.243553914709));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6669, -3102.243553914709));
        }

        [TestMethod]
        public void TestEvolveForever20()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6670, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6671, -3167.663099486912));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6672, -3167.663099486912));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6673, -3167.663099486912));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6674, -3167.663099486912));
        }

        [TestMethod]
        public void TestEvolveForever21()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6675, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6676, -3268.673791600699));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6677, -3268.673791600699));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6678, -3035.0033419343576));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6679, -3035.0033419343576));
        }

        [TestMethod]
        public void TestEvolveForever22()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6680, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6681, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6682, -3367.051407629086));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6683, -3367.051407629086));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6684, -3139.5203808528127));
        }

        [TestMethod]
        public void TestEvolveForever23()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6685, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6686, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6687, -3324.5022586380474));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6688, -3302.088281744507));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6689, -2892.145396338811));
        }

        [TestMethod]
        public void TestEvolveForever24()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6690, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6691, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6692, -2749.906800166622));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6693, -2749.906800166622));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6694, -2683.224076822572));
        }

        [TestMethod]
        public void TestEvolveForever25()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6695, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6696, -3356.3311165984182));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6697, -3356.3311165984182));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6698, -3240.251765722187));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6699, -3240.251765722187));
        }

        [TestMethod]
        public void TestEvolveForever26()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6700, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6701, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6702, -3334.1642610208582));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6703, -3078.312265269287));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6704, -3078.312265269287));
        }

        [TestMethod]
        public void TestEvolveForever27()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6705, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6706, -3743.6763987098097));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6707, -3341.8025228134243));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6708, -3023.1896200010433));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6709, -2882.58205670809));
        }

        [TestMethod]
        public void TestEvolveForever28()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6710, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6711, -2917.360572146742));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6712, -2917.360572146742));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6713, -2768.4546212696987));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6714, -2768.052021622166));
        }

        [TestMethod]
        public void TestEvolveForever29()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6715, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6716, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6717, -3126.230271874375));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6718, -3126.230271874375));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6719, -3086.0195162299997));
        }

        [TestMethod]
        public void TestEvolveForever30()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6720, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6721, -3267.7039234882122));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6722, -3267.7039234882122));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6723, -3267.7039234882122));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6724, -3267.7039234882122));
        }

        [TestMethod]
        public void TestEvolveForever31()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6725, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6726, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6727, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6728, -3298.9493193162575));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6729, -3041.8322895119645));
        }

        [TestMethod]
        public void TestEvolveForever32()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6730, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6731, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6732, -3146.761804173168));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6733, -3146.761804173168));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6734, -2990.9732426290816));
        }

        [TestMethod]
        public void TestEvolveForever33()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6735, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6736, -2743.204589745916));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6737, -2743.204589745916));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6738, -2743.204589745916));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6739, -2743.204589745916));
        }

        [TestMethod]
        public void TestEvolveForever34()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6740, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6741, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6742, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6743, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6744, -2878.1620815992987));
        }

        [TestMethod]
        public void TestEvolveForever35()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6745, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6746, -3136.7931919882794));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6747, -3136.7931919882794));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6748, -3056.623274648985));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6749, -3056.623274648985));
        }

        [TestMethod]
        public void TestEvolveForever36()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6750, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6751, -3045.792091993211));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6752, -2965.557481512016));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6753, -2965.557481512016));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6754, -2876.0503856792866));
        }

        [TestMethod]
        public void TestEvolveForever37()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6755, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6756, -3852.2122535775106));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6757, -3168.6527601388343));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6758, -3168.6527601388343));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6759, -3168.6527601388343));
        }

        [TestMethod]
        public void TestEvolveForever38()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6760, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6761, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6762, -3031.4540004374694));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6763, -3031.4540004374694));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6764, -3022.1660167183427));
        }

        [TestMethod]
        public void TestEvolveForever39()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6765, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6766, -3359.7360744244997));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6767, -3328.9540456739264));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6768, -3072.7735126910384));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6769, -3072.7735126910384));
        }

        [TestMethod]
        public void TestEvolveForever40()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6770, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6771, -3351.228230545536));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6772, -3351.228230545536));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6773, -3351.228230545536));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6774, -3307.9741144334407));
        }

        [TestMethod]
        public void TestEvolveForever41()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6775, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6776, -3075.636694507708));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6777, -3075.636694507708));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6778, -3075.636694507708));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6779, -3075.636694507708));
        }

        [TestMethod]
        public void TestEvolveForever42()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6780, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6781, -2931.6995790840906));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6782, -2931.6995790840906));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6783, -2931.6995790840906));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6784, -2931.6995790840906));
        }

        [TestMethod]
        public void TestEvolveForever43()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6785, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6786, -3238.72196669681));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6787, -3079.6782260669943));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6788, -3079.6782260669943));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6789, -3079.6782260669943));
        }

        [TestMethod]
        public void TestEvolveForever44()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6790, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6791, -2776.9970419352));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6792, -2438.951117350051));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6793, -2438.951117350051));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6794, -2438.951117350051));
        }

        [TestMethod]
        public void TestEvolveForever45()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6795, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6796, -3733.4922604209078));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6797, -3297.757592463544));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6798, -3297.757592463544));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6799, -3297.757592463544));
        }

        [TestMethod]
        public void TestEvolveForever46()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6800, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6801, -3205.5971121540315));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6802, -3035.9615595669998));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6803, -2975.5760373768157));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6804, -2975.5760373768157));
        }

        [TestMethod]
        public void TestEvolveForever47()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6805, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6806, -3361.4683172765));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6807, -3361.4683172765));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6808, -3166.951688314468));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6809, -3166.951688314468));
        }

        [TestMethod]
        public void TestEvolveForever48()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6810, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6811, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6812, -2962.23780552109));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6813, -2793.389975796982));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6814, -2793.389975796982));
        }

        [TestMethod]
        public void TestEvolveForever49()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6815, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6816, -3359.7360744244997));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6817, -3359.7360744244997));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6818, -2982.669111243808));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6819, -2982.669111243808));
        }

        [TestMethod]
        public void TestEvolveForever50()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6820, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6821, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6822, -3490.1978334807836));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6823, -3490.1978334807836));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6824, -3316.8098885137947));
        }

        [TestMethod]
        public void TestEvolveForever51()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6825, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6826, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6827, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6828, -3264.42890334493));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6829, -3264.42890334493));
        }

        [TestMethod]
        public void TestEvolveForever52()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6830, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6831, -3264.554736813887));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6832, -3264.554736813887));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6833, -3264.554736813887));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6834, -3264.554736813887));
        }

        [TestMethod]
        public void TestEvolveForever53()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6835, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6836, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6837, -3095.8269235014695));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6838, -3095.8269235014695));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6839, -3095.8269235014695));
        }

        [TestMethod]
        public void TestEvolveForever54()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6840, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6841, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6842, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6843, -2420.9167931061684));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6844, -2420.9167931061684));
        }

        [TestMethod]
        public void TestEvolveForever55()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6845, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6846, -3672.1449661846086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6847, -3189.7082078452095));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6848, -3189.7082078452095));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6849, -3113.250042957177));
        }

        [TestMethod]
        public void TestEvolveForever56()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6850, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6851, -3205.5971121540315));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6852, -3205.5971121540315));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6853, -3205.5971121540315));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6854, -2554.6569279557452));
        }

        [TestMethod]
        public void TestEvolveForever57()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6855, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6856, -3852.2122535775106));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6857, -3797.354078902975));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6858, -3696.210069357605));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6859, -3696.210069357605));
        }

        [TestMethod]
        public void TestEvolveForever58()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6860, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6861, -3050.6262312393287));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6862, -2599.8700220524893));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6863, -2514.6791026298806));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6864, -2514.6791026298806));
        }

        [TestMethod]
        public void TestEvolveForever59()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6865, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6866, -3398.644711857204));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6867, -3398.644711857204));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6868, -3398.644711857204));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6869, -3159.037454964686));
        }

        [TestMethod]
        public void TestEvolveForever60()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6870, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6871, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6872, -3490.1978334807836));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6873, -3451.665289095594));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6874, -3451.665289095594));
        }

        [TestMethod]
        public void TestEvolveForever61()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6875, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6876, -3149.143568284159));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6877, -3036.386710204603));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6878, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6879, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever62()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6880, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6881, -3081.3620558025864));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6882, -3081.3620558025864));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6883, -3046.4676285065198));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6884, -3046.4676285065198));
        }

        [TestMethod]
        public void TestEvolveForever63()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6885, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6886, -3104.7130695697088));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6887, -3104.7130695697088));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6888, -3104.7130695697088));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6889, -3089.9148677957446));
        }

        [TestMethod]
        public void TestEvolveForever64()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6890, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6891, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6892, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6893, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6894, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever65()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6895, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6896, -3563.8636400730716));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6897, -3258.6613360991078));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6898, -2755.0888275572465));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6899, -2755.0888275572465));
        }

        [TestMethod]
        public void TestEvolveForever66()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6900, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6901, -2716.2195667848478));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6902, -2716.2195667848478));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6903, -2716.2195667848478));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6904, -2716.2195667848478));
        }

        [TestMethod]
        public void TestEvolveForever67()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6905, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6906, -3531.1238272028313));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6907, -3531.1238272028313));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6908, -3498.720419342663));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6909, -3469.6786211905146));
        }

        [TestMethod]
        public void TestEvolveForever68()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6910, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6911, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6912, -2514.6791026298806));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6913, -2514.6791026298806));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6914, -2341.2911576628917));
        }

        [TestMethod]
        public void TestEvolveForever69()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6915, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6916, -3337.115015292258));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6917, -3030.4703060978595));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6918, -3030.4703060978595));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6919, -2982.669111243808));
        }

        [TestMethod]
        public void TestEvolveForever70()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6920, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6921, -3400.851316153914));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6922, -3400.851316153914));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6923, -3400.851316153914));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6924, -3400.851316153914));
        }

        [TestMethod]
        public void TestEvolveForever71()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6925, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6926, -2883.28657060441));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6927, -2883.28657060441));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6928, -2883.28657060441));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6929, -2847.7047489751667));
        }

        [TestMethod]
        public void TestEvolveForever72()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6930, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6931, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6932, -3185.1997607512258));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6933, -3185.1997607512258));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6934, -3185.1997607512258));
        }

        [TestMethod]
        public void TestEvolveForever73()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6935, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6936, -3316.03552656596));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6937, -3148.4526444078897));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6938, -2858.489924806687));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6939, -2633.382653548283));
        }

        [TestMethod]
        public void TestEvolveForever74()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6940, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6941, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6942, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6943, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6944, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever75()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6945, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6946, -3040.2888633614643));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6947, -2982.130538311238));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6948, -2982.130538311238));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6949, -2982.130538311238));
        }

        [TestMethod]
        public void TestEvolveForever76()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6950, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6951, -3225.930516661587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6952, -3225.930516661587));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6953, -2908.223550339717));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6954, -2908.223550339717));
        }

        [TestMethod]
        public void TestEvolveForever77()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6955, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6956, -3574.8093226209485));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6957, -3574.8093226209485));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6958, -3525.667982664373));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6959, -3449.0016237666423));
        }

        [TestMethod]
        public void TestEvolveForever78()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6960, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6961, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6962, -3015.07466839484));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6963, -3015.07466839484));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6964, -3015.07466839484));
        }

        [TestMethod]
        public void TestEvolveForever79()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6965, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6966, -3405.3416157226275));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6967, -3135.952170938497));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6968, -2856.1136549047883));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6969, -2856.1136549047883));
        }

        [TestMethod]
        public void TestEvolveForever80()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6970, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6971, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6972, -3490.1978334807836));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6973, -3490.1978334807836));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6974, -3400.8513161539145));
        }

        [TestMethod]
        public void TestEvolveForever81()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6975, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6976, -2949.6978961130285));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6977, -2949.6978961130285));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6978, -2949.6978961130285));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6979, -2949.6978961130285));
        }

        [TestMethod]
        public void TestEvolveForever82()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6980, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6981, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6982, -3367.051407629086));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6983, -3306.9059347601883));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6984, -3100.992492562466));
        }

        [TestMethod]
        public void TestEvolveForever83()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6985, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6986, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6987, -3324.5022586380474));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6988, -3324.5022586380474));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6989, -3324.5022586380474));
        }

        [TestMethod]
        public void TestEvolveForever84()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6990, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6991, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6992, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6993, -2973.496682966413));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6994, -2973.496682966413));
        }

        [TestMethod]
        public void TestEvolveForever85()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result6995, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result6996, -3743.075638402299));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result6997, -3153.3547011568357));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result6998, -3153.3547011568357));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result6999, -3153.3547011568357));
        }

        [TestMethod]
        public void TestEvolveForever86()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7000, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7001, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7002, -2892.3053965959334));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7003, -2733.534971732132));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7004, -2733.534971732132));
        }

        [TestMethod]
        public void TestEvolveForever87()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7005, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7006, -3778.762151485695));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7007, -3423.2710637319287));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7008, -3423.2710637319287));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7009, -3414.927615284447));
        }

        [TestMethod]
        public void TestEvolveForever88()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7010, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7011, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7012, -3050.626231239329));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7013, -3050.626231239329));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7014, -3050.626231239329));
        }

        [TestMethod]
        public void TestEvolveForever89()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7015, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7016, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7017, -3447.578093125308));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7018, -3306.2470586869567));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7019, -3306.2470586869567));
        }

        [TestMethod]
        public void TestEvolveForever90()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7020, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7021, -2990.4041666452626));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7022, -2990.4041666452626));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7023, -2990.4041666452626));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7024, -2946.664591807082));
        }

        [TestMethod]
        public void TestEvolveForever91()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7025, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7026, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7027, -3036.488515929193));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7028, -3036.488515929193));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7029, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever92()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7030, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7031, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7032, -3367.051407629086));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7033, -3367.051407629086));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7034, -2979.927704661807));
        }

        [TestMethod]
        public void TestEvolveForever93()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7035, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7036, -3148.1967503338774));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7037, -3148.1967503338774));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7038, -3148.1967503338774));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7039, -3148.1967503338774));
        }

        [TestMethod]
        public void TestEvolveForever94()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7040, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7041, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7042, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7043, -2971.7812479760732));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7044, -2971.7812479760732));
        }

        [TestMethod]
        public void TestEvolveForever95()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7045, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7046, -3733.4922604209078));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7047, -3256.425565564994));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7048, -2710.5483709205273));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7049, -2710.5483709205273));
        }

        [TestMethod]
        public void TestEvolveForever96()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7050, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7051, -3108.0782645554773));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7052, -3108.0782645554773));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7053, -2965.557481512016));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7054, -2689.461532381859));
        }

        [TestMethod]
        public void TestEvolveForever97()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7055, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7056, -3423.2710637319287));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7057, -3423.2710637319287));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7058, -3349.273570592934));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7059, -3349.273570592934));
        }

        [TestMethod]
        public void TestEvolveForever98()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7060, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7061, -2672.675064691813));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7062, -2671.1597898029668));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7063, -2455.94550183327));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7064, -2455.94550183327));
        }

        [TestMethod]
        public void TestEvolveForever99()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7065, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7066, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7067, -3153.0771976383894));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7068, -3013.778703202479));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7069, -3013.778703202479));
        }

        [TestMethod]
        public void TestEvolveForever100()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7070, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7071, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7072, -3490.1978334807836));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7073, -3251.8764524928692));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7074, -3251.8764524928692));
        }

        [TestMethod]
        public void TestEvolveForever101()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7075, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7076, -3036.386710204603));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7077, -3036.386710204603));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7078, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7079, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever102()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7080, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7081, -2931.6995790840906));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7082, -2931.6995790840906));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7083, -2931.6995790840906));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7084, -2931.6995790840906));
        }

        [TestMethod]
        public void TestEvolveForever103()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7085, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7086, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7087, -3300.461620646736));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7088, -3300.461620646736));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7089, -3300.461620646736));
        }

        [TestMethod]
        public void TestEvolveForever104()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7090, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7091, -2973.496682966413));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7092, -2973.496682966413));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7093, -2973.496682966413));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7094, -2973.496682966413));
        }

        [TestMethod]
        public void TestEvolveForever105()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7095, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7096, -3242.5514528960034));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7097, -3242.5514528960034));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7098, -3242.5514528960034));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7099, -3242.5514528960034));
        }

        [TestMethod]
        public void TestEvolveForever106()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7100, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7101, -3153.37328618721));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7102, -2733.534971732132));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7103, -2733.534971732132));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7104, -2733.534971732132));
        }

        [TestMethod]
        public void TestEvolveForever107()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7105, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7106, -3693.690208719645));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7107, -3693.690208719645));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7108, -3693.6902087196445));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7109, -3173.1337404074734));
        }

        [TestMethod]
        public void TestEvolveForever108()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7110, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7111, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7112, -2514.6791026298806));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7113, -2514.6791026298806));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7114, -2341.2911576628917));
        }

        [TestMethod]
        public void TestEvolveForever109()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7115, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7116, -3356.5964630602566));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7117, -3102.243553914709));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7118, -3102.243553914709));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7119, -2987.332295915919));
        }

        [TestMethod]
        public void TestEvolveForever110()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7120, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7121, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7122, -3490.1978334807836));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7123, -3328.213973472701));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7124, -3328.213973472701));
        }

        [TestMethod]
        public void TestEvolveForever111()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7125, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7126, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7127, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7128, -3095.486907040813));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7129, -3095.486907040813));
        }

        [TestMethod]
        public void TestEvolveForever112()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7130, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7131, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7132, -3367.051407629086));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7133, -2792.0473668497316));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7134, -2792.0473668497316));
        }

        [TestMethod]
        public void TestEvolveForever113()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7135, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7136, -3319.448589250055));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7137, -3002.1868697885216));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7138, -2929.4448255128564));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7139, -2929.4448255128564));
        }

        [TestMethod]
        public void TestEvolveForever114()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7140, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7141, -2870.6011817561425));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7142, -2870.6011817561425));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7143, -2870.6011817561425));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7144, -2870.6011817561425));
        }

        [TestMethod]
        public void TestEvolveForever115()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7145, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7146, -3405.9960700598326));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7147, -3192.706798774961));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7148, -3008.470794890921));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7149, -2638.9673306054365));
        }

        [TestMethod]
        public void TestEvolveForever116()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7150, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7151, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7152, -3126.1125887993594));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7153, -3126.1125887993594));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7154, -2613.722895969648));
        }

        [TestMethod]
        public void TestEvolveForever117()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7155, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7156, -3652.2859511276874));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7157, -3652.2859511276874));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7158, -3428.0868755559854));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7159, -3428.0868755559854));
        }

        [TestMethod]
        public void TestEvolveForever118()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7160, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7161, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7162, -3050.626231239329));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7163, -3050.626231239329));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7164, -3050.626231239329));
        }

        [TestMethod]
        public void TestEvolveForever119()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7165, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7166, -3342.4815836832063));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7167, -3198.167506130234));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7168, -3198.167506130234));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7169, -3198.167506130234));
        }

        [TestMethod]
        public void TestEvolveForever120()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7170, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7171, -3470.16231945914));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7172, -3087.2597023504236));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7173, -3087.2597023504236));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7174, -2944.774036133074));
        }

        [TestMethod]
        public void TestEvolveForever121()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7175, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7176, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7177, -2860.6808391615027));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7178, -2860.6808391615027));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7179, -2860.6808391615027));
        }

        [TestMethod]
        public void TestEvolveForever122()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7180, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7181, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7182, -3105.489969766105));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7183, -3081.3620558025864));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7184, -3081.3620558025864));
        }

        [TestMethod]
        public void TestEvolveForever123()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7185, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7186, -3252.9921243316417));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7187, -3104.4928795340998));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7188, -3104.4928795340998));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7189, -2877.091083759935));
        }

        [TestMethod]
        public void TestEvolveForever124()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7190, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7191, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7192, -2717.210388476754));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7193, -2717.210388476754));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7194, -2717.210388476754));
        }

        [TestMethod]
        public void TestEvolveForever125()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7195, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7196, -3136.7931919882794));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7197, -3136.7931919882794));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7198, -3136.7931919882794));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7199, -3128.4907699589357));
        }

        [TestMethod]
        public void TestEvolveForever126()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7200, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7201, -3205.5971121540315));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7202, -2554.6569279557452));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7203, -2554.6569279557452));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7204, -2554.6569279557452));
        }

        [TestMethod]
        public void TestEvolveForever127()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7205, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7206, -3698.9577726934426));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7207, -3423.2710637319287));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7208, -3423.2710637319287));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7209, -2819.586368190146));
        }

        [TestMethod]
        public void TestEvolveForever128()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7210, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7211, -2764.088733776013));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7212, -2633.382653548283));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7213, -2633.382653548283));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7214, -2633.382653548283));
        }

        [TestMethod]
        public void TestEvolveForever129()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7215, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7216, -3127.9266542955643));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7217, -3127.9266542955643));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7218, -3127.9266542955643));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7219, -3102.3478295103596));
        }

        [TestMethod]
        public void TestEvolveForever130()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7220, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7221, -2992.567642606098));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7222, -2992.567642606098));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7223, -2992.567642606098));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7224, -2992.567642606098));
        }

        [TestMethod]
        public void TestEvolveForever131()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7225, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7226, -3036.386710204603));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7227, -3036.386710204603));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7228, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7229, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever132()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7230, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7231, -3264.554736813887));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7232, -3264.554736813887));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7233, -3007.2776206323215));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7234, -2947.845297485567));
        }

        [TestMethod]
        public void TestEvolveForever133()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7235, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7236, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7237, -3226.4379914566803));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7238, -3226.4379914566803));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7239, -3226.4379914566803));
        }

        [TestMethod]
        public void TestEvolveForever134()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7240, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7241, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7242, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7243, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7244, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever135()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7245, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7246, -3050.6262312393287));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7247, -3050.6262312393287));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7248, -3050.6262312393287));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7249, -3050.6262312393287));
        }

        [TestMethod]
        public void TestEvolveForever136()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7250, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7251, -3205.5971121540315));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7252, -3205.5971121540315));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7253, -3205.5971121540315));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7254, -3205.5971121540315));
        }

        [TestMethod]
        public void TestEvolveForever137()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7255, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7256, -3695.0882446034034));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7257, -3349.273570592934));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7258, -3349.273570592934));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7259, -3349.273570592934));
        }

        [TestMethod]
        public void TestEvolveForever138()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7260, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7261, -2672.675064691813));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7262, -2672.675064691813));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7263, -2672.675064691813));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7264, -2672.675064691813));
        }

        [TestMethod]
        public void TestEvolveForever139()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7265, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7266, -2804.788693092729));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7267, -2618.209394656155));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7268, -2618.209394656155));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7269, -2618.209394656155));
        }

        [TestMethod]
        public void TestEvolveForever140()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7270, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7271, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7272, -3267.7039234882122));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7273, -3267.7039234882122));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7274, -3109.5070285513925));
        }

        [TestMethod]
        public void TestEvolveForever141()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7275, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7276, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7277, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7278, -3180.780937931996));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7279, -3138.883381019802));
        }

        [TestMethod]
        public void TestEvolveForever142()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7280, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7281, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7282, -3192.532695433198));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7283, -3015.847880912715));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7284, -3015.847880912715));
        }

        [TestMethod]
        public void TestEvolveForever143()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7285, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7286, -3095.8269235014695));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7287, -3095.8269235014695));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7288, -3095.8269235014695));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7289, -3095.8269235014695));
        }

        [TestMethod]
        public void TestEvolveForever144()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7290, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7291, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7292, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7293, -2776.9970419352));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7294, -2776.9970419352));
        }

        [TestMethod]
        public void TestEvolveForever145()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7295, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7296, -3287.3579204619386));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7297, -3287.3579204619386));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7298, -3022.844447724386));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7299, -3022.844447724386));
        }

        [TestMethod]
        public void TestEvolveForever146()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7300, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7301, -3219.643299707638));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7302, -3192.4907863238145));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7303, -2693.93844001973));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7304, -2693.93844001973));
        }

        [TestMethod]
        public void TestEvolveForever147()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7305, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7306, -3852.2122535775106));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7307, -3778.762151485695));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7308, -3330.1266386004627));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7309, -3330.1266386004627));
        }

        [TestMethod]
        public void TestEvolveForever148()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7310, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7311, -2927.7956452766057));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7312, -2927.7956452766057));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7313, -2877.2382862723402));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7314, -2341.2911576628917));
        }

        [TestMethod]
        public void TestEvolveForever149()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7315, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7316, -3438.534308506611));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7317, -3406.4199128275227));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7318, -3090.4450621002106));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7319, -3012.774981221023));
        }

        [TestMethod]
        public void TestEvolveForever150()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7320, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7321, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7322, -3351.228230545536));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7323, -3351.228230545536));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7324, -3070.608965075761));
        }

        [TestMethod]
        public void TestEvolveForever151()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7325, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7326, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7327, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7328, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7329, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever152()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7330, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7331, -3264.554736813887));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7332, -3264.554736813887));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7333, -3081.3620558025864));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7334, -3081.3620558025864));
        }

        [TestMethod]
        public void TestEvolveForever153()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7335, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7336, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7337, -3148.1967503338774));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7338, -2838.160946511937));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7339, -2838.160946511937));
        }

        [TestMethod]
        public void TestEvolveForever154()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7340, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7341, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7342, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7343, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7344, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever155()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7345, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7346, -3405.809992744463));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7347, -2767.7205285742034));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7348, -2767.7205285742034));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7349, -2767.7205285742034));
        }

        [TestMethod]
        public void TestEvolveForever156()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7350, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7351, -3205.5971121540315));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7352, -3205.5971121540315));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7353, -3205.5971121540315));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7354, -2530.452255188766));
        }

        [TestMethod]
        public void TestEvolveForever157()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7355, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7356, -3166.951688314468));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7357, -3166.951688314468));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7358, -3166.951688314468));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7359, -3166.951688314468));
        }

        [TestMethod]
        public void TestEvolveForever158()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7360, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7361, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7362, -3050.626231239329));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7363, -3050.626231239329));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7364, -3050.626231239329));
        }

        [TestMethod]
        public void TestEvolveForever159()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7365, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7366, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7367, -3028.488004836216));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7368, -2987.690113327122));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7369, -2987.690113327122));
        }

        [TestMethod]
        public void TestEvolveForever160()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7370, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7371, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7372, -3351.228230545536));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7373, -3351.228230545536));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7374, -3351.228230545536));
        }

        [TestMethod]
        public void TestEvolveForever161()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7375, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7376, -2671.1597898029668));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7377, -2671.1597898029668));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7378, -2671.1597898029668));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7379, -2671.1597898029668));
        }

        [TestMethod]
        public void TestEvolveForever162()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7380, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7381, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7382, -3367.051407629086));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7383, -3367.051407629086));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7384, -2975.207209064966));
        }

        [TestMethod]
        public void TestEvolveForever163()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7385, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7386, -3300.4616206467354));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7387, -3239.6900210644685));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7388, -3008.370124761344));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7389, -3008.370124761344));
        }

        [TestMethod]
        public void TestEvolveForever164()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7390, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7391, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7392, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7393, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7394, -2973.496682966413));
        }

        [TestMethod]
        public void TestEvolveForever165()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7395, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7396, -3441.488846752758));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7397, -3177.9099135525476));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7398, -2928.37992133506));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7399, -2928.37992133506));
        }

        [TestMethod]
        public void TestEvolveForever166()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7400, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7401, -3325.667992642501));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7402, -3325.667992642501));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7403, -3231.6428115316116));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7404, -2692.886047039988));
        }

        [TestMethod]
        public void TestEvolveForever167()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7405, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7406, -3699.903678673818));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7407, -3091.1191150340146));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7408, -3071.9536741875427));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7409, -3071.9536741875427));
        }

        [TestMethod]
        public void TestEvolveForever168()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7410, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7411, -2599.8700220524893));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7412, -2599.8700220524893));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7413, -2599.8700220524893));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7414, -2599.8700220524893));
        }

        [TestMethod]
        public void TestEvolveForever169()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7415, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7416, -3478.3405166942407));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7417, -3328.813226453493));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7418, -3141.4824427987637));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7419, -3141.4824427987637));
        }

        [TestMethod]
        public void TestEvolveForever170()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7420, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7421, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7422, -3307.9741144334403));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7423, -3109.5070285513925));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7424, -3109.5070285513925));
        }

        [TestMethod]
        public void TestEvolveForever171()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7425, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7426, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7427, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7428, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7429, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever172()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7430, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7431, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7432, -3367.051407629086));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7433, -3306.9059347601883));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7434, -3306.9059347601883));
        }

        [TestMethod]
        public void TestEvolveForever173()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7435, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7436, -3258.238054307197));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7437, -3258.238054307197));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7438, -3258.238054307197));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7439, -3099.8062218226123));
        }

        [TestMethod]
        public void TestEvolveForever174()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7440, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7441, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7442, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7443, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7444, -2870.6011817561425));
        }

        [TestMethod]
        public void TestEvolveForever175()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7445, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7446, -3628.257509746045));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7447, -3370.868190475113));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7448, -3194.83533564426));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7449, -3194.83533564426));
        }

        [TestMethod]
        public void TestEvolveForever176()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7450, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7451, -3153.37328618721));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7452, -3153.37328618721));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7453, -3146.5988574752146));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7454, -2842.3866173408337));
        }

        [TestMethod]
        public void TestEvolveForever177()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7455, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7456, -3596.1494998149733));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7457, -3596.1494998149733));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7458, -3596.1494998149733));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7459, -3423.2710637319287));
        }

        [TestMethod]
        public void TestEvolveForever178()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7460, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7461, -3011.4290580934853));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7462, -3011.4290580934853));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7463, -3011.4290580934853));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7464, -2600.56587332535));
        }

        [TestMethod]
        public void TestEvolveForever179()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7465, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7466, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7467, -3482.0079746203587));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7468, -3159.037454964686));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7469, -2982.669111243808));
        }

        [TestMethod]
        public void TestEvolveForever180()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7470, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7471, -3401.5633503921513));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7472, -3401.5633503921513));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7473, -3401.5633503921513));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7474, -3256.0744303040506));
        }

        [TestMethod]
        public void TestEvolveForever181()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7475, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7476, -3024.10785090121));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7477, -3024.10785090121));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7478, -3024.10785090121));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7479, -3024.10785090121));
        }

        [TestMethod]
        public void TestEvolveForever182()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7480, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7481, -3264.554736813887));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7482, -3264.554736813887));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7483, -2931.6995790840906));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7484, -2931.6995790840906));
        }

        [TestMethod]
        public void TestEvolveForever183()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7485, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7486, -3148.4526444078897));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7487, -3148.4526444078897));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7488, -3148.4526444078897));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7489, -3148.4526444078897));
        }

        [TestMethod]
        public void TestEvolveForever184()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7490, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7491, -2776.9970419352));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7492, -2776.9970419352));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7493, -2776.9970419352));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7494, -2776.9970419352));
        }

        [TestMethod]
        public void TestEvolveForever185()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7495, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7496, -3522.165008830186));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7497, -3436.575296073998));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7498, -3416.0101620925648));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7499, -3416.0101620925648));
        }

        [TestMethod]
        public void TestEvolveForever186()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7500, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7501, -2613.722895969648));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7502, -2613.722895969648));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7503, -2613.722895969648));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7504, -2613.722895969648));
        }

        [TestMethod]
        public void TestEvolveForever187()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7505, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7506, -3469.4149777494404));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7507, -3299.1245965626927));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7508, -3299.1245965626927));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7509, -3299.1245965626927));
        }

        [TestMethod]
        public void TestEvolveForever188()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7510, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7511, -3015.07466839484));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7512, -2956.1600716481307));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7513, -2956.1600716481307));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7514, -2599.8700220524893));
        }

        [TestMethod]
        public void TestEvolveForever189()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7515, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7516, -3013.778703202479));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7517, -3013.778703202479));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7518, -3013.778703202479));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7519, -2956.2917369178494));
        }

        [TestMethod]
        public void TestEvolveForever190()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7520, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7521, -3485.034701902325));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7522, -3436.559724097262));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7523, -3417.0399777275957));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7524, -3396.6459810019583));
        }

        [TestMethod]
        public void TestEvolveForever191()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7525, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7526, -3075.636694507708));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7527, -3036.386710204603));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7528, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7529, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever192()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7530, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7531, -3327.38485441947));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7532, -3076.1952234452087));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7533, -3076.1952234452087));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7534, -2939.3087095585074));
        }

        [TestMethod]
        public void TestEvolveForever193()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7535, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7536, -3148.4526444078897));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7537, -3148.4526444078897));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7538, -3148.4526444078897));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7539, -3148.4526444078897));
        }

        [TestMethod]
        public void TestEvolveForever194()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7540, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7541, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7542, -2420.9167931061684));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7543, -2420.9167931061684));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7544, -2420.9167931061684));
        }

        [TestMethod]
        public void TestEvolveForever195()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7545, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7546, -3542.3246576808124));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7547, -3416.5005244352374));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7548, -3370.425451346823));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7549, -3000.731136584821));
        }

        [TestMethod]
        public void TestEvolveForever196()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7550, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7551, -3205.5971121540315));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7552, -3205.5971121540315));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7553, -2864.2023921250375));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7554, -2864.2023921250375));
        }

        [TestMethod]
        public void TestEvolveForever197()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7555, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7556, -3852.2122535775106));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7557, -3681.8672124117898));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7558, -3378.2122807772284));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7559, -3169.5220316541463));
        }

        [TestMethod]
        public void TestEvolveForever198()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7560, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7561, -3015.07466839484));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7562, -3015.07466839484));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7563, -3015.07466839484));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7564, -3015.07466839484));
        }

        [TestMethod]
        public void TestEvolveForever199()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7565, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7566, -3217.620181612445));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7567, -3217.620181612445));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7568, -3132.640334435122));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7569, -3132.640334435122));
        }

        [TestMethod]
        public void TestEvolveForever200()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7570, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7571, -3307.9741144334403));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7572, -3307.9741144334403));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7573, -3307.9741144334403));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7574, -3307.9741144334403));
        }

        [TestMethod]
        public void TestEvolveForever201()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7575, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7576, -2971.384987046402));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7577, -2816.951473407116));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7578, -2811.784641049738));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7579, -2787.481259371406));
        }

        [TestMethod]
        public void TestEvolveForever202()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7580, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7581, -3306.9059347601883));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7582, -3306.9059347601883));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7583, -3306.9059347601883));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7584, -3306.9059347601883));
        }

        [TestMethod]
        public void TestEvolveForever203()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7585, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7586, -3323.7936284763973));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7587, -3323.7936284763973));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7588, -3323.7936284763973));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7589, -3214.5459182737663));
        }

        [TestMethod]
        public void TestEvolveForever204()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7590, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7591, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7592, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7593, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7594, -2819.707059291953));
        }

        [TestMethod]
        public void TestEvolveForever205()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7595, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7596, -3629.865135305279));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7597, -3397.077373356088));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7598, -3229.3853305210937));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7599, -3229.3853305210937));
        }

        [TestMethod]
        public void TestEvolveForever206()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7600, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7601, -3108.0782645554773));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7602, -3108.0782645554773));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7603, -3108.0782645554773));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7604, -3058.681051836299));
        }

        [TestMethod]
        public void TestEvolveForever207()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7605, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7606, -3789.7763130535886));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7607, -3635.086970931125));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7608, -3635.086970931125));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7609, -3635.086970931125));
        }

        [TestMethod]
        public void TestEvolveForever208()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7610, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7611, -2599.8700220524893));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7612, -2599.8700220524893));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7613, -2599.8700220524893));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7614, -2599.8700220524893));
        }

        [TestMethod]
        public void TestEvolveForever209()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7615, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7616, -2960.912519476358));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7617, -2937.33513324556));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7618, -2937.33513324556));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7619, -2720.7871931353325));
        }

        [TestMethod]
        public void TestEvolveForever210()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7620, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7621, -3109.5070285513925));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7622, -3109.5070285513925));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7623, -3109.5070285513925));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7624, -3109.5070285513925));
        }

        [TestMethod]
        public void TestEvolveForever211()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7625, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7626, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7627, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7628, -3298.9493193162575));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7629, -3298.9493193162575));
        }

        [TestMethod]
        public void TestEvolveForever212()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7630, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7631, -3264.554736813887));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7632, -3264.554736813887));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7633, -3264.554736813887));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7634, -3264.554736813887));
        }

        [TestMethod]
        public void TestEvolveForever213()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7635, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7636, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7637, -3096.826614428262));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7638, -3096.826614428262));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7639, -2961.8651591459134));
        }

        [TestMethod]
        public void TestEvolveForever214()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7640, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7641, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7642, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7643, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7644, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever215()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7645, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7646, -3771.716549298306));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7647, -3733.4922604209078));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7648, -2823.145687152813));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7649, -2823.145687152813));
        }

        [TestMethod]
        public void TestEvolveForever216()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7650, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7651, -3160.0661293301823));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7652, -3160.0661293301823));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7653, -2903.33384949758));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7654, -2903.33384949758));
        }

        [TestMethod]
        public void TestEvolveForever217()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7655, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7656, -3656.851376888526));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7657, -3166.951688314468));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7658, -3166.951688314468));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7659, -3166.951688314468));
        }

        [TestMethod]
        public void TestEvolveForever218()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7660, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7661, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7662, -3050.626231239329));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7663, -3050.626231239329));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7664, -3016.3432750351863));
        }

        [TestMethod]
        public void TestEvolveForever219()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7665, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7666, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7667, -3303.0127851523293));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7668, -3303.0127851523293));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7669, -3303.0127851523293));
        }

        [TestMethod]
        public void TestEvolveForever220()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7670, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7671, -3412.04844308724));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7672, -3412.04844308724));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7673, -3412.04844308724));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7674, -3412.04844308724));
        }

        [TestMethod]
        public void TestEvolveForever221()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7675, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7676, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7677, -3149.143568284159));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7678, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7679, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever222()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7680, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7681, -3264.554736813887));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7682, -3139.5203808528127));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7683, -2931.949780354271));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7684, -2931.949780354271));
        }

        [TestMethod]
        public void TestEvolveForever223()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7685, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7686, -3252.9921243316417));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7687, -3252.9921243316417));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7688, -3252.9921243316417));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7689, -3252.9921243316417));
        }

        [TestMethod]
        public void TestEvolveForever224()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7690, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7691, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7692, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7693, -2973.496682966413));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7694, -2973.496682966413));
        }

        [TestMethod]
        public void TestEvolveForever225()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7695, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7696, -3583.0255407114564));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7697, -3236.213213988959));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7698, -2859.254363128387));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7699, -2859.254363128387));
        }

        [TestMethod]
        public void TestEvolveForever226()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7700, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7701, -3072.757241721296));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7702, -3072.757241721296));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7703, -3072.757241721296));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7704, -3054.7229174774134));
        }

        [TestMethod]
        public void TestEvolveForever227()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7705, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7706, -3043.2359118737186));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7707, -3043.2359118737186));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7708, -3043.2359118737186));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7709, -3043.2359118737186));
        }

        [TestMethod]
        public void TestEvolveForever228()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7710, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7711, -3000.6006879159295));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7712, -3000.6006879159295));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7713, -3000.6006879159295));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7714, -3000.6006879159295));
        }

        [TestMethod]
        public void TestEvolveForever229()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7715, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7716, -3207.95058775993));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7717, -3207.95058775993));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7718, -2937.3444065007106));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7719, -2848.77528019283));
        }

        [TestMethod]
        public void TestEvolveForever230()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7720, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7721, -3489.956896175138));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7722, -3489.956896175138));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7723, -3489.956896175138));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7724, -3489.956896175138));
        }

        [TestMethod]
        public void TestEvolveForever231()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7725, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7726, -3005.5936662585627));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7727, -3005.5936662585627));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7728, -3005.5936662585627));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7729, -3005.5936662585627));
        }

        [TestMethod]
        public void TestEvolveForever232()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7730, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7731, -3306.9059347601883));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7732, -3306.9059347601883));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7733, -3278.4046717480123));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7734, -3278.4046717480123));
        }

        [TestMethod]
        public void TestEvolveForever233()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7735, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7736, -3324.502258638047));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7737, -3324.502258638047));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7738, -3159.308956172803));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7739, -3159.308956172803));
        }

        [TestMethod]
        public void TestEvolveForever234()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7740, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7741, -2890.226042185531));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7742, -2890.226042185531));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7743, -2870.6011817561425));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7744, -2870.6011817561425));
        }

        [TestMethod]
        public void TestEvolveForever235()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7745, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7746, -3362.5143715712406));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7747, -3349.357426114069));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7748, -3349.357426114069));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7749, -3136.7931919882794));
        }

        [TestMethod]
        public void TestEvolveForever236()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7750, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7751, -2995.9686422259456));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7752, -2995.9686422259456));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7753, -2697.6812368795463));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7754, -2697.6812368795463));
        }

        [TestMethod]
        public void TestEvolveForever237()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7755, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7756, -3661.701854362535));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7757, -3455.5254753094546));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7758, -3226.96548065061));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7759, -3226.96548065061));
        }

        [TestMethod]
        public void TestEvolveForever238()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7760, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7761, -2599.8700220524893));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7762, -2599.8700220524893));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7763, -2599.8700220524893));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7764, -2599.8700220524893));
        }

        [TestMethod]
        public void TestEvolveForever239()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7765, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7766, -3359.7360744244997));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7767, -3277.7214490510414));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7768, -3083.7198290561832));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7769, -3083.7198290561832));
        }

        [TestMethod]
        public void TestEvolveForever240()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7770, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7771, -3351.228230545536));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7772, -3351.228230545536));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7773, -3351.228230545536));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7774, -3351.228230545536));
        }

        [TestMethod]
        public void TestEvolveForever241()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7775, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7776, -3075.636694507708));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7777, -3075.636694507708));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7778, -3075.636694507708));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7779, -3075.636694507708));
        }

        [TestMethod]
        public void TestEvolveForever242()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7780, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7781, -2931.6995790840906));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7782, -2931.6995790840906));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7783, -2931.6995790840906));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7784, -2931.6995790840906));
        }

        [TestMethod]
        public void TestEvolveForever243()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7785, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7786, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7787, -3324.5022586380474));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7788, -3237.4910040202285));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7789, -3187.747348380699));
        }

        [TestMethod]
        public void TestEvolveForever244()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7790, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7791, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7792, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7793, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7794, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever245()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7795, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7796, -3825.8669615811814));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7797, -3629.865135305279));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7798, -3405.809992744463));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7799, -2912.6108008335887));
        }

        [TestMethod]
        public void TestEvolveForever246()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7800, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7801, -3205.5971121540315));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7802, -2975.5760373768157));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7803, -2975.5760373768157));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7804, -2645.3866694255116));
        }

        [TestMethod]
        public void TestEvolveForever247()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7805, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7806, -3852.2122535775106));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7807, -3389.082549595531));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7808, -3389.082549595531));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7809, -3389.082549595531));
        }

        [TestMethod]
        public void TestEvolveForever248()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7810, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7811, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7812, -3050.626231239329));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7813, -3050.626231239329));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7814, -3050.626231239329));
        }

        [TestMethod]
        public void TestEvolveForever249()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7815, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7816, -2892.9580731114265));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7817, -2892.9580731114265));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7818, -2892.9580731114265));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7819, -2892.9580731114265));
        }

        [TestMethod]
        public void TestEvolveForever250()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7820, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7821, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7822, -3490.0330230890545));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7823, -3490.0330230890545));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7824, -3490.0330230890545));
        }

        [TestMethod]
        public void TestEvolveForever251()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7825, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7826, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7827, -3279.3244588868693));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7828, -3279.3244588868693));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7829, -3279.3244588868693));
        }

        [TestMethod]
        public void TestEvolveForever252()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7830, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7831, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7832, -3326.5307951895766));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7833, -3139.5203808528127));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7834, -3076.1952234452087));
        }

        [TestMethod]
        public void TestEvolveForever253()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7835, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7836, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7837, -3300.461620646736));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7838, -2806.681157922662));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7839, -2806.681157922662));
        }

        [TestMethod]
        public void TestEvolveForever254()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7840, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7841, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7842, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7843, -2890.2260421855303));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7844, -2890.2260421855303));
        }

        [TestMethod]
        public void TestEvolveForever255()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7845, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7846, -3464.3017192892894));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7847, -3367.094272167599));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7848, -2823.145687152813));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7849, -2823.145687152813));
        }

        [TestMethod]
        public void TestEvolveForever256()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7850, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7851, -3045.792091993211));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7852, -3045.792091993211));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7853, -2613.722895969648));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7854, -2613.722895969648));
        }

        [TestMethod]
        public void TestEvolveForever257()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7855, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7856, -3778.762151485695));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7857, -3428.0868755559854));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7858, -3428.0868755559854));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7859, -3428.0868755559854));
        }

        [TestMethod]
        public void TestEvolveForever258()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7860, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7861, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7862, -3050.626231239329));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7863, -3050.626231239329));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7864, -3031.4540004374694));
        }

        [TestMethod]
        public void TestEvolveForever259()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7865, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7866, -3375.9270467698193));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7867, -3125.0105712411096));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7868, -3054.7391884471554));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7869, -2989.5738246197634));
        }

        [TestMethod]
        public void TestEvolveForever260()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7870, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7871, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7872, -3490.1978334807836));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7873, -3412.04844308724));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7874, -3412.04844308724));
        }

        [TestMethod]
        public void TestEvolveForever261()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7875, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7876, -3036.386710204603));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7877, -3036.386710204603));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7878, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7879, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever262()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7880, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7881, -3076.1952234452087));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7882, -3076.1952234452087));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7883, -3076.1952234452087));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7884, -3076.1952234452087));
        }

        [TestMethod]
        public void TestEvolveForever263()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7885, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7886, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7887, -3238.72196669681));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7888, -3238.72196669681));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7889, -3157.4786580616683));
        }

        [TestMethod]
        public void TestEvolveForever264()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7890, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7891, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7892, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7893, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7894, -2844.8727894533713));
        }

        [TestMethod]
        public void TestEvolveForever265()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7895, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7896, -3733.4922604209078));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7897, -2755.0888275572465));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7898, -2755.0888275572465));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7899, -2755.0888275572465));
        }

        [TestMethod]
        public void TestEvolveForever266()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7900, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7901, -2613.722895969648));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7902, -2613.722895969648));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7903, -2613.722895969648));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7904, -2613.722895969648));
        }

        [TestMethod]
        public void TestEvolveForever267()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7905, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7906, -3042.8845135867555));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7907, -3042.8845135867555));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7908, -3042.8845135867555));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7909, -3042.8845135867555));
        }

        [TestMethod]
        public void TestEvolveForever268()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7910, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7911, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7912, -3050.626231239329));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7913, -3050.626231239329));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7914, -3050.626231239329));
        }

        [TestMethod]
        public void TestEvolveForever269()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7915, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7916, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7917, -3482.0079746203587));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7918, -3204.426243686722));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7919, -3204.426243686722));
        }

        [TestMethod]
        public void TestEvolveForever270()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7920, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7921, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7922, -3490.1978334807836));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7923, -2934.5426754296473));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7924, -2934.5426754296473));
        }

        [TestMethod]
        public void TestEvolveForever271()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7925, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7926, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7927, -3281.5607760140115));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7928, -3075.636694507708));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7929, -3075.636694507708));
        }

        [TestMethod]
        public void TestEvolveForever272()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7930, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7931, -3306.9059347601883));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7932, -3306.9059347601883));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7933, -3306.9059347601883));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7934, -3306.9059347601883));
        }

        [TestMethod]
        public void TestEvolveForever273()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7935, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7936, -3300.461620646736));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7937, -3216.3662876802186));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7938, -3216.3662876802186));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7939, -3107.4539593674817));
        }

        [TestMethod]
        public void TestEvolveForever274()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7940, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7941, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7942, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7943, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7944, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever275()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7945, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7946, -2823.145687152813));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7947, -2823.145687152813));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7948, -2823.145687152813));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7949, -2823.145687152813));
        }

        [TestMethod]
        public void TestEvolveForever276()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7950, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7951, -3072.757241721296));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7952, -3072.757241721296));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7953, -3072.757241721296));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7954, -3072.757241721296));
        }

        [TestMethod]
        public void TestEvolveForever277()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7955, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7956, -3692.164886917945));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7957, -3062.0321889194784));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7958, -2990.9732426290816));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7959, -2869.31080713821));
        }

        [TestMethod]
        public void TestEvolveForever278()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7960, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7961, -2514.6791026298806));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7962, -2514.6791026298806));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7963, -2514.6791026298806));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7964, -2514.6791026298806));
        }

        [TestMethod]
        public void TestEvolveForever279()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7965, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7966, -3054.7391884471554));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7967, -3054.7391884471554));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7968, -2787.506138315676));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7969, -2787.506138315676));
        }

        [TestMethod]
        public void TestEvolveForever280()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7970, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7971, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7972, -3490.1978334807836));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7973, -3490.1978334807836));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7974, -3460.4596024186635));
        }

        [TestMethod]
        public void TestEvolveForever281()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7975, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7976, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7977, -3075.636694507708));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7978, -3075.636694507708));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7979, -3075.636694507708));
        }

        [TestMethod]
        public void TestEvolveForever282()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7980, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7981, -3329.9225853088933));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7982, -3329.9225853088933));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7983, -3004.0617786793546));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7984, -3004.0617786793546));
        }

        [TestMethod]
        public void TestEvolveForever283()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7985, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7986, -3208.1070965793065));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7987, -3208.1070965793065));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7988, -3208.1070965793065));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7989, -3208.1070965793065));
        }

        [TestMethod]
        public void TestEvolveForever284()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7990, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7991, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7992, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7993, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7994, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever285()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result7995, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result7996, -3301.7427719889733));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result7997, -3301.7427719889733));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result7998, -3255.857852840802));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result7999, -3255.857852840802));
        }

        [TestMethod]
        public void TestEvolveForever286()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8000, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8001, -3015.1344069016172));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8002, -2787.1108409366375));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8003, -2766.0430165521134));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8004, -2766.0430165521134));
        }

        [TestMethod]
        public void TestEvolveForever287()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8005, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8006, -2933.878944883013));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8007, -2933.878944883013));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8008, -2933.878944883013));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8009, -2933.878944883013));
        }

        [TestMethod]
        public void TestEvolveForever288()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8010, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8011, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8012, -2928.3799213350603));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8013, -2827.4665360038935));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8014, -2827.4665360038935));
        }

        [TestMethod]
        public void TestEvolveForever289()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8015, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8016, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8017, -2895.7614650222004));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8018, -2895.7614650222004));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8019, -2819.8709486436474));
        }

        [TestMethod]
        public void TestEvolveForever290()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8020, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8021, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8022, -3363.6186126353928));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8023, -3363.6186126353928));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8024, -3363.6186126353928));
        }

        [TestMethod]
        public void TestEvolveForever291()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8025, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8026, -3036.3867102046033));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8027, -3036.3867102046033));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8028, -3036.3867102046033));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8029, -3036.3867102046033));
        }

        [TestMethod]
        public void TestEvolveForever292()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8030, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8031, -3258.1869757885092));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8032, -3139.5203808528127));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8033, -3139.5203808528127));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8034, -3014.637464127428));
        }

        [TestMethod]
        public void TestEvolveForever293()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8035, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8036, -3316.03552656596));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8037, -3316.03552656596));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8038, -3042.4266199088115));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8039, -3042.4266199088115));
        }

        [TestMethod]
        public void TestEvolveForever294()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8040, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8041, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8042, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8043, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8044, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever295()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8045, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8046, -3548.686823986209));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8047, -3254.924192248197));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8048, -2769.3817287486163));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8049, -2713.734375710206));
        }

        [TestMethod]
        public void TestEvolveForever296()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8050, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8051, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8052, -2733.534971732132));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8053, -2733.534971732132));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8054, -2733.534971732132));
        }

        [TestMethod]
        public void TestEvolveForever297()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8055, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8056, -3493.918353816145));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8057, -3476.0774049760435));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8058, -3476.0774049760435));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8059, -3476.0774049760435));
        }

        [TestMethod]
        public void TestEvolveForever298()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8060, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8061, -2877.2382862723402));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8062, -2646.3168136117174));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8063, -2646.3168136117174));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8064, -2409.3480172584586));
        }

        [TestMethod]
        public void TestEvolveForever299()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8065, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8066, -3161.463672868243));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8067, -3161.463672868243));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8068, -3090.4450621002106));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8069, -3090.4450621002106));
        }

        [TestMethod]
        public void TestEvolveForever300()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8070, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8071, -2854.773698105342));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8072, -2854.773698105342));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8073, -2854.773698105342));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8074, -2854.773698105342));
        }

        [TestMethod]
        public void TestEvolveForever301()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8075, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8076, -3149.143568284159));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8077, -3149.143568284159));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8078, -3149.143568284159));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8079, -3149.143568284159));
        }

        [TestMethod]
        public void TestEvolveForever302()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8080, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8081, -3327.38485441947));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8082, -3327.38485441947));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8083, -3327.38485441947));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8084, -3087.4769225797218));
        }

        [TestMethod]
        public void TestEvolveForever303()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8085, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8086, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8087, -2838.160946511937));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8088, -2838.160946511937));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8089, -2838.160946511937));
        }

        [TestMethod]
        public void TestEvolveForever304()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8090, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8091, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8092, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8093, -2776.9970419352));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8094, -2571.506830758034));
        }

        [TestMethod]
        public void TestEvolveForever305()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8095, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8096, -3040.2888633614643));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8097, -2981.188588584949));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8098, -2981.1885885849483));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8099, -2863.672066489253));
        }

        [TestMethod]
        public void TestEvolveForever306()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8100, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8101, -3045.792091993211));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8102, -2840.7565792416463));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8103, -2748.534326622824));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8104, -2748.534326622824));
        }

        [TestMethod]
        public void TestEvolveForever307()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8105, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8106, -2791.9429855953813));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8107, -2694.283025908221));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8108, -2694.283025908221));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8109, -2694.283025908221));
        }

        [TestMethod]
        public void TestEvolveForever308()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8110, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8111, -2599.8700220524893));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8112, -2409.348017258459));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8113, -2409.348017258459));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8114, -2341.2911576628917));
        }

        [TestMethod]
        public void TestEvolveForever309()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8115, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8116, -3010.30106097536));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8117, -3010.30106097536));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8118, -2934.2686495487424));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8119, -2934.2686495487424));
        }

        [TestMethod]
        public void TestEvolveForever310()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8120, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8121, -3060.8920828791306));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8122, -3060.8920828791306));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8123, -2926.9766675365763));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8124, -2850.310308638845));
        }

        [TestMethod]
        public void TestEvolveForever311()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8125, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8126, -3075.636694507708));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8127, -3075.636694507708));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8128, -3075.636694507708));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8129, -3075.636694507708));
        }

        [TestMethod]
        public void TestEvolveForever312()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8130, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8131, -2931.6995790840906));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8132, -2931.6995790840906));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8133, -2931.6995790840906));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8134, -2611.8343740536607));
        }

        [TestMethod]
        public void TestEvolveForever313()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8135, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8136, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8137, -3324.5022586380474));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8138, -3257.890809643738));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8139, -3257.890809643738));
        }

        [TestMethod]
        public void TestEvolveForever314()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8140, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8141, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8142, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8143, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8144, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever315()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8145, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8146, -3431.068967471691));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8147, -3136.7931919882794));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8148, -3136.7931919882794));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8149, -3136.7931919882794));
        }

        [TestMethod]
        public void TestEvolveForever316()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8150, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8151, -3267.5876837182313));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8152, -3267.5876837182313));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8153, -2933.9171070706134));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8154, -2933.9171070706134));
        }

        [TestMethod]
        public void TestEvolveForever317()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8155, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8156, -3166.951688314468));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8157, -3166.951688314468));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8158, -3166.951688314468));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8159, -3119.8686088194977));
        }

        [TestMethod]
        public void TestEvolveForever318()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8160, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8161, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8162, -3050.626231239329));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8163, -3050.626231239329));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8164, -2940.6055774537786));
        }

        [TestMethod]
        public void TestEvolveForever319()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8165, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8166, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8167, -2962.523850667872));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8168, -2947.2862593777927));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8169, -2947.2862593777927));
        }

        [TestMethod]
        public void TestEvolveForever320()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8170, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8171, -3358.7694957320828));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8172, -3358.7694957320828));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8173, -3358.7694957320828));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8174, -3358.7694957320828));
        }

        [TestMethod]
        public void TestEvolveForever321()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8175, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8176, -3036.386710204603));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8177, -3024.10785090121));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8178, -3024.10785090121));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8179, -3024.10785090121));
        }

        [TestMethod]
        public void TestEvolveForever322()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8180, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8181, -3329.9225853088933));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8182, -3329.9225853088933));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8183, -3329.9225853088933));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8184, -3329.9225853088933));
        }

        [TestMethod]
        public void TestEvolveForever323()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8185, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8186, -3120.2638915446546));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8187, -3120.2638915446546));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8188, -3120.2638915446546));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8189, -3120.2638915446546));
        }

        [TestMethod]
        public void TestEvolveForever324()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8190, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8191, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8192, -2973.496682966413));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8193, -2973.496682966413));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8194, -2752.9223268002393));
        }

        [TestMethod]
        public void TestEvolveForever325()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8195, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8196, -3160.4129893778813));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8197, -3160.4129893778813));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8198, -3160.4129893778813));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8199, -3160.4129893778813));
        }

        [TestMethod]
        public void TestEvolveForever326()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8200, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8201, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8202, -2613.722895969648));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8203, -2613.722895969648));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8204, -2613.722895969648));
        }

        [TestMethod]
        public void TestEvolveForever327()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8205, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8206, -3681.79199917049));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8207, -3261.7213546875096));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8208, -3091.1191150340146));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8209, -2953.55774157068));
        }

        [TestMethod]
        public void TestEvolveForever328()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8210, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8211, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8212, -2715.321866560766));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8213, -2715.321866560766));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8214, -2715.321866560766));
        }

        [TestMethod]
        public void TestEvolveForever329()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8215, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8216, -2982.669111243808));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8217, -2982.669111243808));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8218, -2982.669111243808));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8219, -2982.669111243808));
        }

        [TestMethod]
        public void TestEvolveForever330()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8220, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8221, -3400.851316153914));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8222, -3400.851316153914));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8223, -3400.851316153914));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8224, -3363.6186126353923));
        }

        [TestMethod]
        public void TestEvolveForever331()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8225, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8226, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8227, -3219.643299707638));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8228, -3024.10785090121));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8229, -3024.10785090121));
        }

        [TestMethod]
        public void TestEvolveForever332()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8230, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8231, -3306.1738448787746));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8232, -3306.1738448787746));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8233, -3306.1738448787746));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8234, -3306.1738448787746));
        }

        [TestMethod]
        public void TestEvolveForever333()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8235, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8236, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8237, -3095.8269235014695));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8238, -3055.2525243671635));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8239, -3055.2525243671635));
        }

        [TestMethod]
        public void TestEvolveForever334()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8240, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8241, -2973.496682966413));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8242, -2973.496682966413));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8243, -2953.11606942372));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8244, -2953.11606942372));
        }

        [TestMethod]
        public void TestEvolveForever335()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8245, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8246, -3438.534308506611));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8247, -2869.8448207926626));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8248, -2869.8448207926626));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8249, -2869.8448207926626));
        }

        [TestMethod]
        public void TestEvolveForever336()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8250, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8251, -3146.598857475215));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8252, -3146.598857475215));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8253, -3093.8008329525387));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8254, -3093.8008329525387));
        }

        [TestMethod]
        public void TestEvolveForever337()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8255, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8256, -3586.7125568458664));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8257, -3511.0693908436174));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8258, -3511.0693908436174));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8259, -3187.5647504238395));
        }

        [TestMethod]
        public void TestEvolveForever338()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8260, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8261, -3022.1660167183427));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8262, -3022.1660167183427));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8263, -3015.07466839484));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8264, -3015.07466839484));
        }

        [TestMethod]
        public void TestEvolveForever339()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8265, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8266, -3212.1074975910815));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8267, -3177.406072969254));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8268, -2982.669111243808));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8269, -2982.669111243808));
        }

        [TestMethod]
        public void TestEvolveForever340()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8270, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8271, -3396.169601196752));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8272, -3396.169601196752));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8273, -3228.20686107248));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8274, -3228.20686107248));
        }

        [TestMethod]
        public void TestEvolveForever341()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8275, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8276, -3075.636694507708));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8277, -3075.636694507708));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8278, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8279, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever342()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8280, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8281, -3301.8939408470883));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8282, -3301.8939408470883));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8283, -3099.8062218226123));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8284, -2832.853348657077));
        }

        [TestMethod]
        public void TestEvolveForever343()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8285, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8286, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8287, -3150.3003899859286));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8288, -3148.4526444078897));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8289, -3148.4526444078897));
        }

        [TestMethod]
        public void TestEvolveForever344()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8290, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8291, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8292, -2914.7236439585104));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8293, -2914.7236439585104));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8294, -2914.7236439585104));
        }

        [TestMethod]
        public void TestEvolveForever345()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8295, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8296, -3405.809992744463));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8297, -2840.0607279687856));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8298, -2840.0607279687856));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8299, -2840.0607279687856));
        }

        [TestMethod]
        public void TestEvolveForever346()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8300, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8301, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8302, -3078.312265269287));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8303, -3078.312265269287));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8304, -2864.2023921250375));
        }

        [TestMethod]
        public void TestEvolveForever347()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8305, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8306, -3058.3031956332507));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8307, -3058.3031956332507));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8308, -3058.3031956332507));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8309, -3058.3031956332507));
        }

        [TestMethod]
        public void TestEvolveForever348()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8310, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8311, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8312, -3050.626231239329));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8313, -3050.626231239329));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8314, -2715.321866560766));
        }

        [TestMethod]
        public void TestEvolveForever349()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8315, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8316, -3375.9270467698193));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8317, -3155.959236990082));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8318, -2941.1296244066066));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8319, -2941.1296244066066));
        }

        [TestMethod]
        public void TestEvolveForever350()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8320, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8321, -3046.0443269229168));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8322, -3046.0443269229168));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8323, -3046.0443269229168));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8324, -3046.0443269229168));
        }

        [TestMethod]
        public void TestEvolveForever351()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8325, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8326, -3264.42890334493));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8327, -3001.8662942332753));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8328, -3001.8662942332753));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8329, -3001.8662942332753));
        }

        [TestMethod]
        public void TestEvolveForever352()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8330, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8331, -3287.89512896994));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8332, -2931.6995790840906));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8333, -2931.6995790840906));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8334, -2931.6995790840906));
        }

        [TestMethod]
        public void TestEvolveForever353()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8335, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8336, -2838.160946511937));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8337, -2838.160946511937));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8338, -2838.160946511937));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8339, -2838.160946511937));
        }

        [TestMethod]
        public void TestEvolveForever354()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8340, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8341, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8342, -2824.8701908704115));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8343, -2824.8701908704115));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8344, -2819.7070592919536));
        }

        [TestMethod]
        public void TestEvolveForever355()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8345, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8346, -3264.9271154106273));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8347, -2977.218234985695));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8348, -2977.218234985695));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8349, -2977.218234985695));
        }

        [TestMethod]
        public void TestEvolveForever356()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8350, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8351, -3232.2113035143816));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8352, -3232.2113035143816));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8353, -3175.1753813765304));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8354, -3146.5988574752146));
        }

        [TestMethod]
        public void TestEvolveForever357()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8355, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8356, -3493.918353816145));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8357, -2971.513670897232));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8358, -2971.513670897232));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8359, -2971.513670897232));
        }

        [TestMethod]
        public void TestEvolveForever358()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8360, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8361, -2514.6791026298806));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8362, -2514.6791026298806));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8363, -2514.6791026298806));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8364, -2341.2911576628917));
        }

        [TestMethod]
        public void TestEvolveForever359()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8365, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8366, -3198.167506130234));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8367, -3198.167506130234));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8368, -2989.5738246197634));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8369, -2989.5738246197634));
        }

        [TestMethod]
        public void TestEvolveForever360()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8370, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8371, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8372, -3490.1978334807836));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8373, -3490.1978334807836));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8374, -3042.3284513449166));
        }

        [TestMethod]
        public void TestEvolveForever361()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8375, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8376, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8377, -3242.7628965276576));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8378, -3242.7628965276576));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8379, -3242.7628965276576));
        }

        [TestMethod]
        public void TestEvolveForever362()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8380, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8381, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8382, -2834.0396193969304));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8383, -2834.0396193969304));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8384, -2474.2658324001654));
        }

        [TestMethod]
        public void TestEvolveForever363()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8385, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8386, -3120.2638915446546));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8387, -3120.2638915446546));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8388, -2892.145396338811));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8389, -2892.145396338811));
        }

        [TestMethod]
        public void TestEvolveForever364()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8390, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8391, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8392, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8393, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8394, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever365()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8395, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8396, -3658.6776877548564));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8397, -3564.3759722402556));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8398, -3564.3759722402556));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8399, -3063.1255612769933));
        }

        [TestMethod]
        public void TestEvolveForever366()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8400, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8401, -2876.0503856792866));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8402, -2876.0503856792866));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8403, -2682.0585025151995));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8404, -2682.0585025151995));
        }

        [TestMethod]
        public void TestEvolveForever367()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8405, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8406, -3413.6939395679965));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8407, -3413.6939395679965));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8408, -3210.2536432288643));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8409, -3210.2536432288643));
        }

        [TestMethod]
        public void TestEvolveForever368()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8410, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8411, -2869.5593772926904));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8412, -2869.5593772926904));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8413, -2869.5593772926904));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8414, -2717.210388476754));
        }

        [TestMethod]
        public void TestEvolveForever369()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8415, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8416, -3054.7391884471554));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8417, -2989.5738246197634));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8418, -2989.5738246197634));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8419, -2696.003252743288));
        }

        [TestMethod]
        public void TestEvolveForever370()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8420, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8421, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8422, -3490.1978334807836));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8423, -3109.5070285513925));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8424, -3109.5070285513925));
        }

        [TestMethod]
        public void TestEvolveForever371()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8425, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8426, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8427, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8428, -3064.741053602499));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8429, -3064.741053602499));
        }

        [TestMethod]
        public void TestEvolveForever372()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8430, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8431, -3297.1635770711005));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8432, -3297.1635770711005));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8433, -3139.5203808528127));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8434, -2827.4596294761704));
        }

        [TestMethod]
        public void TestEvolveForever373()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8435, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8436, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8437, -3148.4526444078897));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8438, -3111.0809894829686));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8439, -2928.7676117724263));
        }

        [TestMethod]
        public void TestEvolveForever374()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8440, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8441, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8442, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8443, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8444, -2763.3650712507842));
        }

        [TestMethod]
        public void TestEvolveForever375()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8445, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8446, -3349.357426114069));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8447, -3150.3582955784304));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8448, -2917.495394573027));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8449, -2917.495394573027));
        }

        [TestMethod]
        public void TestEvolveForever376()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8450, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8451, -3232.2113035143816));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8452, -2864.2023921250375));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8453, -2864.2023921250375));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8454, -2613.722895969648));
        }

        [TestMethod]
        public void TestEvolveForever377()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8455, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8456, -3852.2122535775106));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8457, -3437.6110882247235));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8458, -3437.6110882247235));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8459, -3423.2710637319287));
        }

        [TestMethod]
        public void TestEvolveForever378()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8460, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8461, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8462, -2715.321866560766));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8463, -2715.321866560766));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8464, -2715.321866560766));
        }

        [TestMethod]
        public void TestEvolveForever379()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8465, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8466, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8467, -3357.836783169717));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8468, -3357.836783169717));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8469, -3303.6596943579416));
        }

        [TestMethod]
        public void TestEvolveForever380()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8470, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8471, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8472, -3490.0330230890545));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8473, -3109.5070285513925));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8474, -3109.5070285513925));
        }

        [TestMethod]
        public void TestEvolveForever381()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8475, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8476, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8477, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8478, -3298.9493193162575));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8479, -3298.9493193162575));
        }

        [TestMethod]
        public void TestEvolveForever382()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8480, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8481, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8482, -3367.051407629086));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8483, -3081.3620558025864));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8484, -3081.3620558025864));
        }

        [TestMethod]
        public void TestEvolveForever383()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8485, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8486, -3208.1070965793065));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8487, -2838.160946511937));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8488, -2838.160946511937));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8489, -2741.81920792886));
        }

        [TestMethod]
        public void TestEvolveForever384()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8490, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8491, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8492, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8493, -2922.8405417081617));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8494, -2922.8405417081617));
        }

        [TestMethod]
        public void TestEvolveForever385()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8495, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8496, -3258.4993659972424));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8497, -2836.985182944029));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8498, -2836.985182944029));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8499, -2767.7205285742034));
        }

        [TestMethod]
        public void TestEvolveForever386()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8500, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8501, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8502, -3232.641354543889));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8503, -3232.641354543889));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8504, -3186.1476721391628));
        }

        [TestMethod]
        public void TestEvolveForever387()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8505, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8506, -3166.951688314468));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8507, -3166.951688314468));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8508, -3166.951688314468));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8509, -2694.283025908221));
        }

        [TestMethod]
        public void TestEvolveForever388()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8510, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8511, -3022.1660167183427));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8512, -3022.1660167183427));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8513, -2633.382653548283));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8514, -2633.382653548283));
        }

        [TestMethod]
        public void TestEvolveForever389()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8515, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8516, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8517, -3052.780596262389));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8518, -2982.669111243808));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8519, -2982.669111243808));
        }

        [TestMethod]
        public void TestEvolveForever390()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8520, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8521, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8522, -3490.1978334807836));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8523, -2954.837818029431));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8524, -2954.837818029431));
        }

        [TestMethod]
        public void TestEvolveForever391()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8525, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8526, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8527, -3036.386710204603));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8528, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8529, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever392()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8530, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8531, -3306.9059347601883));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8532, -3306.9059347601883));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8533, -3306.9059347601883));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8534, -3306.9059347601883));
        }

        [TestMethod]
        public void TestEvolveForever393()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8535, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8536, -3300.461620646736));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8537, -3085.9682432598765));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8538, -3085.9682432598765));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8539, -2717.210388476754));
        }

        [TestMethod]
        public void TestEvolveForever394()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8540, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8541, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8542, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8543, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8544, -2628.074052688325));
        }

        [TestMethod]
        public void TestEvolveForever395()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8545, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8546, -3207.95058775993));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8547, -2928.37992133506));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8548, -2928.37992133506));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8549, -2735.5501504944104));
        }

        [TestMethod]
        public void TestEvolveForever396()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8550, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8551, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8552, -3108.0782645554773));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8553, -2613.722895969648));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8554, -2613.722895969648));
        }

        [TestMethod]
        public void TestEvolveForever397()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8555, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8556, -3662.848573435312));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8557, -3630.4080409226463));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8558, -3166.951688314468));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8559, -2842.272268191341));
        }

        [TestMethod]
        public void TestEvolveForever398()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8560, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8561, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8562, -3040.3788415374056));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8563, -2686.7857458463986));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8564, -2686.7857458463986));
        }

        [TestMethod]
        public void TestEvolveForever399()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8565, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8566, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8567, -3309.9821796536307));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8568, -3309.9821796536307));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8569, -3237.563291387804));
        }

        [TestMethod]
        public void TestEvolveForever400()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8570, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8571, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8572, -3490.1978334807836));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8573, -3490.1978334807836));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8574, -3490.1978334807836));
        }

        [TestMethod]
        public void TestEvolveForever401()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8575, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8576, -2949.6978961130285));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8577, -2655.9950122105934));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8578, -2655.9950122105934));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8579, -2655.9950122105934));
        }

        [TestMethod]
        public void TestEvolveForever402()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8580, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8581, -3076.1952234452087));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8582, -3076.1952234452087));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8583, -2896.063298838497));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8584, -2896.063298838497));
        }

        [TestMethod]
        public void TestEvolveForever403()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8585, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8586, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8587, -3324.5022586380474));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8588, -3272.794811242033));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8589, -3272.794811242033));
        }

        [TestMethod]
        public void TestEvolveForever404()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8590, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8591, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8592, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8593, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8594, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever405()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8595, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8596, -3349.357426114069));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8597, -3349.357426114069));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8598, -3349.357426114069));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8599, -2949.219416340212));
        }

        [TestMethod]
        public void TestEvolveForever406()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8600, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8601, -2733.534971732132));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8602, -2733.534971732132));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8603, -2733.534971732132));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8604, -2733.534971732132));
        }

        [TestMethod]
        public void TestEvolveForever407()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8605, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8606, -3409.4312291092765));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8607, -3281.8627947327027));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8608, -3281.8627947327027));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8609, -3281.8627947327027));
        }

        [TestMethod]
        public void TestEvolveForever408()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8610, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8611, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8612, -3010.2192916189215));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8613, -3010.2192916189215));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8614, -3010.2192916189215));
        }

        [TestMethod]
        public void TestEvolveForever409()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8615, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8616, -3102.243553914709));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8617, -3102.243553914709));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8618, -3061.7529433338327));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8619, -3061.7529433338327));
        }

        [TestMethod]
        public void TestEvolveForever410()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8620, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8621, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8622, -3412.04844308724));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8623, -3412.04844308724));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8624, -3412.04844308724));
        }

        [TestMethod]
        public void TestEvolveForever411()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8625, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8626, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8627, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8628, -3005.5936662585627));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8629, -2847.496363126822));
        }

        [TestMethod]
        public void TestEvolveForever412()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8630, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8631, -3112.6966545254973));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8632, -3076.1952234452087));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8633, -2673.7582057182985));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8634, -2673.7582057182985));
        }

        [TestMethod]
        public void TestEvolveForever413()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8635, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8636, -3258.71748562652));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8637, -3120.2638915446546));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8638, -3120.2638915446546));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8639, -3120.2638915446546));
        }

        [TestMethod]
        public void TestEvolveForever414()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8640, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8641, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8642, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8643, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8644, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever415()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8645, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8646, -2910.7280535361588));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8647, -2910.7280535361588));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8648, -2910.7280535361588));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8649, -2910.7280535361588));
        }

        [TestMethod]
        public void TestEvolveForever416()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8650, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8651, -3205.5971121540315));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8652, -3205.5971121540315));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8653, -2902.9729408636));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8654, -2902.9729408636));
        }

        [TestMethod]
        public void TestEvolveForever417()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8655, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8656, -3789.4414381857073));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8657, -3563.299524409701));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8658, -3563.299524409701));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8659, -3550.885747822798));
        }

        [TestMethod]
        public void TestEvolveForever418()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8660, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8661, -3050.6262312393287));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8662, -3050.6262312393287));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8663, -3050.6262312393287));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8664, -3015.07466839484));
        }

        [TestMethod]
        public void TestEvolveForever419()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8665, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8666, -3012.774981221023));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8667, -3012.774981221023));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8668, -3012.774981221023));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8669, -3012.774981221023));
        }

        [TestMethod]
        public void TestEvolveForever420()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8670, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8671, -3396.169601196752));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8672, -3396.169601196752));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8673, -3259.5865581036646));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8674, -3247.4113649390997));
        }

        [TestMethod]
        public void TestEvolveForever421()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8675, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8676, -3230.3839305848396));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8677, -2844.189210773201));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8678, -2844.189210773201));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8679, -2830.8394960977457));
        }

        [TestMethod]
        public void TestEvolveForever422()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8680, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8681, -3306.1738448787746));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8682, -3306.1738448787746));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8683, -3306.1738448787746));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8684, -3264.554736813887));
        }

        [TestMethod]
        public void TestEvolveForever423()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8685, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8686, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8687, -3324.5022586380474));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8688, -3324.5022586380474));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8689, -3324.5022586380474));
        }

        [TestMethod]
        public void TestEvolveForever424()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8690, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8691, -2846.3758915798167));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8692, -2846.3758915798167));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8693, -2776.9970419352));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8694, -2776.9970419352));
        }

        [TestMethod]
        public void TestEvolveForever425()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8695, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8696, -2886.726538539083));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8697, -2886.726538539083));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8698, -2886.726538539083));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8699, -2886.726538539083));
        }

        [TestMethod]
        public void TestEvolveForever426()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8700, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8701, -3206.984693666932));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8702, -2921.238314262889));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8703, -2921.238314262889));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8704, -2921.238314262889));
        }

        [TestMethod]
        public void TestEvolveForever427()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8705, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8706, -3462.0155011719485));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8707, -3462.0155011719485));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8708, -3462.0155011719485));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8709, -3422.4571316471465));
        }

        [TestMethod]
        public void TestEvolveForever428()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8710, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8711, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8712, -3041.3097864927895));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8713, -2976.9851157075595));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8714, -2838.160946511937));
        }

        [TestMethod]
        public void TestEvolveForever429()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8715, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8716, -3437.6196501158242));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8717, -3089.259604418484));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8718, -3089.259604418484));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8719, -3059.597596794887));
        }

        [TestMethod]
        public void TestEvolveForever430()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8720, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8721, -2834.4310016535906));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8722, -2834.4310016535906));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8723, -2834.4310016535906));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8724, -2834.4310016535906));
        }

        [TestMethod]
        public void TestEvolveForever431()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8725, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8726, -3075.636694507708));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8727, -3075.636694507708));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8728, -3050.7930063200843));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8729, -2888.709811527755));
        }

        [TestMethod]
        public void TestEvolveForever432()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8730, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8731, -3343.578866910435));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8732, -3150.919720259091));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8733, -3150.919720259091));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8734, -2949.7014082220185));
        }

        [TestMethod]
        public void TestEvolveForever433()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8735, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8736, -3150.3003899859286));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8737, -3150.3003899859286));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8738, -3041.4814128796665));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8739, -2916.484564521476));
        }

        [TestMethod]
        public void TestEvolveForever434()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8740, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8741, -2878.1620815992987));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8742, -2878.1620815992987));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8743, -2878.1620815992987));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8744, -2878.1620815992987));
        }

        [TestMethod]
        public void TestEvolveForever435()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8745, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8746, -3431.068967471691));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8747, -3040.2888633614643));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8748, -3040.2888633614643));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8749, -2862.4032258139055));
        }

        [TestMethod]
        public void TestEvolveForever436()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8750, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8751, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8752, -2762.032602349629));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8753, -2762.032602349629));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8754, -2682.0585025151995));
        }

        [TestMethod]
        public void TestEvolveForever437()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8755, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8756, -3091.1191150340146));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8757, -3091.1191150340146));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8758, -2824.2273363242475));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8759, -2824.2273363242475));
        }

        [TestMethod]
        public void TestEvolveForever438()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8760, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8761, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8762, -3050.626231239329));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8763, -3050.626231239329));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8764, -2797.4259325268354));
        }

        [TestMethod]
        public void TestEvolveForever439()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8765, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8766, -3159.037454964686));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8767, -3159.037454964686));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8768, -3159.037454964686));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8769, -3019.866329544526));
        }

        [TestMethod]
        public void TestEvolveForever440()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8770, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8771, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8772, -3490.1978334807836));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8773, -3490.1978334807836));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8774, -3351.228230545536));
        }

        [TestMethod]
        public void TestEvolveForever441()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8775, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8776, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8777, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8778, -3298.9493193162575));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8779, -2773.953818292339));
        }

        [TestMethod]
        public void TestEvolveForever442()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8780, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8781, -3264.554736813887));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8782, -3264.554736813887));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8783, -3264.554736813887));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8784, -3264.554736813887));
        }

        [TestMethod]
        public void TestEvolveForever443()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8785, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8786, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8787, -3176.114704960018));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8788, -3176.114704960018));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8789, -2802.303502018087));
        }

        [TestMethod]
        public void TestEvolveForever444()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8790, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8791, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8792, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8793, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8794, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever445()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8795, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8796, -3292.945075208191));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8797, -3027.472416905111));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8798, -3027.472416905111));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8799, -2726.888297015197));
        }

        [TestMethod]
        public void TestEvolveForever446()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8800, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8801, -3205.5971121540315));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8802, -3205.5971121540315));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8803, -2864.2023921250375));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8804, -2817.49331264203));
        }

        [TestMethod]
        public void TestEvolveForever447()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8805, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8806, -3166.951688314468));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8807, -3166.951688314468));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8808, -3166.951688314468));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8809, -3166.951688314468));
        }

        [TestMethod]
        public void TestEvolveForever448()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8810, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8811, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8812, -3022.1660167183427));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8813, -3022.1660167183427));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8814, -3022.1660167183427));
        }

        [TestMethod]
        public void TestEvolveForever449()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8815, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8816, -3436.726125276688));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8817, -3028.488004836216));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8818, -3028.488004836216));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8819, -2982.669111243808));
        }

        [TestMethod]
        public void TestEvolveForever450()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8820, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8821, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8822, -3363.6186126353923));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8823, -3363.6186126353923));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8824, -3078.9003273498643));
        }

        [TestMethod]
        public void TestEvolveForever451()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8825, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8826, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8827, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8828, -3298.9493193162575));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8829, -3264.42890334493));
        }

        [TestMethod]
        public void TestEvolveForever452()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8830, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8831, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8832, -3264.554736813887));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8833, -3264.554736813887));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8834, -3264.554736813887));
        }

        [TestMethod]
        public void TestEvolveForever453()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8835, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8836, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8837, -2951.3233605200912));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8838, -2951.3233605200912));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8839, -2647.410129351422));
        }

        [TestMethod]
        public void TestEvolveForever454()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8840, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8841, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8842, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8843, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8844, -2870.6011817561425));
        }

        [TestMethod]
        public void TestEvolveForever455()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8845, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8846, -3362.5143715712406));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8847, -3362.5143715712406));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8848, -3298.2600182202477));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8849, -3065.7819075517473));
        }

        [TestMethod]
        public void TestEvolveForever456()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8850, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8851, -2863.7434337826285));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8852, -2863.7434337826285));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8853, -2863.7434337826285));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8854, -2815.3224853131555));
        }

        [TestMethod]
        public void TestEvolveForever457()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8855, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8856, -3526.904873075076));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8857, -3318.2101777200687));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8858, -3318.2101777200687));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8859, -3251.2627463383296));
        }

        [TestMethod]
        public void TestEvolveForever458()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8860, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8861, -2907.823128129423));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8862, -2907.823128129423));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8863, -2907.823128129423));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8864, -2323.256833419009));
        }

        [TestMethod]
        public void TestEvolveForever459()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8865, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8866, -3159.037454964686));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8867, -3159.037454964686));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8868, -3159.037454964686));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8869, -3159.037454964686));
        }

        [TestMethod]
        public void TestEvolveForever460()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8870, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8871, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8872, -3490.0330230890545));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8873, -3412.04844308724));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8874, -3319.891476698573));
        }

        [TestMethod]
        public void TestEvolveForever461()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8875, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8876, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8877, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8878, -3069.982010579394));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8879, -3069.982010579394));
        }

        [TestMethod]
        public void TestEvolveForever462()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8880, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8881, -3264.554736813887));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8882, -3264.554736813887));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8883, -3231.93691389259));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8884, -2673.087926274386));
        }

        [TestMethod]
        public void TestEvolveForever463()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8885, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8886, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8887, -3324.5022586380474));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8888, -2751.3474045047337));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8889, -2751.3474045047337));
        }

        [TestMethod]
        public void TestEvolveForever464()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8890, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8891, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8892, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8893, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8894, -2900.9702780787807));
        }

        [TestMethod]
        public void TestEvolveForever465()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8895, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8896, -3287.3579204619386));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8897, -2985.6044543591306));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8898, -2985.6044543591306));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8899, -2985.6044543591306));
        }

        [TestMethod]
        public void TestEvolveForever466()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8900, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8901, -3205.5971121540315));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8902, -3149.94877152908));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8903, -3149.94877152908));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8904, -2930.646272282381));
        }

        [TestMethod]
        public void TestEvolveForever467()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8905, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8906, -3543.9959737522704));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8907, -2967.914356361888));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8908, -2967.914356361888));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8909, -2967.914356361888));
        }

        [TestMethod]
        public void TestEvolveForever468()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8910, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8911, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8912, -2981.4035701967614));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8913, -2981.4035701967614));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8914, -2864.1476755597523));
        }

        [TestMethod]
        public void TestEvolveForever469()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8915, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8916, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8917, -3356.5964630602566));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8918, -3253.4213073152337));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8919, -3008.391222488474));
        }

        [TestMethod]
        public void TestEvolveForever470()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8920, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8921, -3351.228230545536));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8922, -3325.5085683212774));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8923, -3325.5085683212774));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8924, -2761.8141875379015));
        }

        [TestMethod]
        public void TestEvolveForever471()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8925, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8926, -3075.636694507708));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8927, -3075.636694507708));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8928, -3037.8888614086427));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8929, -3037.8888614086427));
        }

        [TestMethod]
        public void TestEvolveForever472()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8930, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8931, -2931.6995790840906));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8932, -2931.6995790840906));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8933, -2931.6995790840906));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8934, -2834.039619396931));
        }

        [TestMethod]
        public void TestEvolveForever473()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8935, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8936, -3120.2638915446546));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8937, -3120.2638915446546));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8938, -3120.2638915446546));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8939, -2769.490178591812));
        }

        [TestMethod]
        public void TestEvolveForever474()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8940, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8941, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8942, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8943, -2952.4530917351703));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8944, -2952.4530917351703));
        }

        [TestMethod]
        public void TestEvolveForever475()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8945, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8946, -3631.6915263771693));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8947, -3297.757592463544));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8948, -3170.8895468304927));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8949, -2672.6750646918135));
        }

        [TestMethod]
        public void TestEvolveForever476()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8950, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8951, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8952, -3035.9615595669998));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8953, -2897.660928032091));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8954, -2897.660928032091));
        }

        [TestMethod]
        public void TestEvolveForever477()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8955, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8956, -3469.4149777494404));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8957, -3469.4149777494404));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8958, -3469.4149777494404));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8959, -3400.5704154264427));
        }

        [TestMethod]
        public void TestEvolveForever478()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8960, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8961, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8962, -2514.6791026298806));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8963, -2514.6791026298806));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8964, -2514.6791026298806));
        }

        [TestMethod]
        public void TestEvolveForever479()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8965, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8966, -2982.669111243808));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8967, -2982.669111243808));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8968, -2982.669111243808));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8969, -2982.669111243808));
        }

        [TestMethod]
        public void TestEvolveForever480()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8970, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8971, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8972, -3460.486682139428));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8973, -3443.7323173679656));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8974, -3319.891476698573));
        }

        [TestMethod]
        public void TestEvolveForever481()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8975, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8976, -3095.486907040813));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8977, -3095.486907040813));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8978, -3095.486907040813));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8979, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever482()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8980, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8981, -3081.3620558025864));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8982, -3081.3620558025864));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8983, -3081.3620558025864));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8984, -3081.3620558025864));
        }

        [TestMethod]
        public void TestEvolveForever483()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8985, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8986, -2743.204589745916));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8987, -2743.204589745916));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8988, -2743.204589745916));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8989, -2743.204589745916));
        }

        [TestMethod]
        public void TestEvolveForever484()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8990, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8991, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8992, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8993, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8994, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever485()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result8995, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result8996, -3738.079445943678));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result8997, -3408.396608707407));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result8998, -3349.93692275584));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result8999, -2735.5501504944104));
        }

        [TestMethod]
        public void TestEvolveForever486()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9000, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9001, -3262.289902939213));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9002, -3262.289902939213));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9003, -2613.722895969648));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9004, -2613.722895969648));
        }

        [TestMethod]
        public void TestEvolveForever487()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9005, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9006, -2920.5816914327993));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9007, -2791.9429855953813));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9008, -2791.9429855953813));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9009, -2791.9429855953813));
        }

        [TestMethod]
        public void TestEvolveForever488()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9010, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9011, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9012, -3050.626231239329));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9013, -3050.626231239329));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9014, -2341.2911576628917));
        }

        [TestMethod]
        public void TestEvolveForever489()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9015, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9016, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9017, -3350.915249598334));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9018, -3350.915249598334));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9019, -3135.866184013016));
        }

        [TestMethod]
        public void TestEvolveForever490()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9020, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9021, -3351.228230545536));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9022, -3351.228230545536));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9023, -3189.6743166872902));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9024, -3150.2300573493894));
        }

        [TestMethod]
        public void TestEvolveForever491()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9025, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9026, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9027, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9028, -3298.9493193162575));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9029, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever492()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9030, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9031, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9032, -3284.704762701557));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9033, -3284.704762701557));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9034, -3284.704762701557));
        }

        [TestMethod]
        public void TestEvolveForever493()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9035, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9036, -3316.03552656596));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9037, -3209.44243514669));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9038, -3209.44243514669));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9039, -3209.44243514669));
        }

        [TestMethod]
        public void TestEvolveForever494()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9040, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9041, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9042, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9043, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9044, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever495()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9045, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9046, -3254.924192248197));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9047, -3254.924192248197));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9048, -3041.8495475738837));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9049, -2966.0874851504063));
        }

        [TestMethod]
        public void TestEvolveForever496()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9050, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9051, -3153.37328618721));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9052, -3153.37328618721));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9053, -3127.708701315357));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9054, -3127.708701315357));
        }

        [TestMethod]
        public void TestEvolveForever497()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9055, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9056, -3852.2122535775106));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9057, -3666.062633040373));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9058, -3666.062633040373));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9059, -3476.0774049760435));
        }

        [TestMethod]
        public void TestEvolveForever498()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9060, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9061, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9062, -3050.626231239329));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9063, -3050.626231239329));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9064, -3050.626231239329));
        }

        [TestMethod]
        public void TestEvolveForever499()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9065, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9066, -3127.9266542955643));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9067, -2985.677141477299));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9068, -2985.677141477299));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9069, -2985.677141477299));
        }

        [TestMethod]
        public void TestEvolveForever500()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9070, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9071, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9072, -3490.1978334807836));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9073, -3319.891476698573));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9074, -3109.507028551393));
        }

        [TestMethod]
        public void TestEvolveForever501()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9075, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9076, -2949.6978961130285));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9077, -2949.6978961130285));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9078, -2949.6978961130285));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9079, -2949.6978961130285));
        }

        [TestMethod]
        public void TestEvolveForever502()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9080, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9081, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9082, -2931.6995790840906));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9083, -2931.6995790840906));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9084, -2931.6995790840906));
        }

        [TestMethod]
        public void TestEvolveForever503()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9085, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9086, -3092.6145536926247));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9087, -3092.6145536926247));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9088, -3064.0431357467232));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9089, -3064.0431357467232));
        }

        [TestMethod]
        public void TestEvolveForever504()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9090, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9091, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9092, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9093, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9094, -2659.6607093951457));
        }

        [TestMethod]
        public void TestEvolveForever505()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9095, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9096, -3572.9329026428964));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9097, -3572.9329026428964));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9098, -3022.844447724386));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9099, -2909.8042297480524));
        }

        [TestMethod]
        public void TestEvolveForever506()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9100, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9101, -3254.764830429986));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9102, -3254.764830429986));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9103, -3120.9550959424705));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9104, -3120.9550959424705));
        }

        [TestMethod]
        public void TestEvolveForever507()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9105, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9106, -3166.951688314468));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9107, -3166.951688314468));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9108, -3058.3031956332507));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9109, -3058.3031956332507));
        }

        [TestMethod]
        public void TestEvolveForever508()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9110, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9111, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9112, -3050.6262312393287));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9113, -3050.6262312393287));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9114, -3050.6262312393287));
        }

        [TestMethod]
        public void TestEvolveForever509()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9115, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9116, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9117, -3482.0079746203587));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9118, -3119.3896448472738));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9119, -3119.3896448472738));
        }

        [TestMethod]
        public void TestEvolveForever510()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9120, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9121, -2854.773698105342));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9122, -2854.773698105342));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9123, -2854.773698105342));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9124, -2854.773698105342));
        }

        [TestMethod]
        public void TestEvolveForever511()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9125, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9126, -2970.0403767075886));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9127, -2970.0403767075886));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9128, -2970.0403767075886));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9129, -2970.0403767075886));
        }

        [TestMethod]
        public void TestEvolveForever512()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9130, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9131, -3081.362055802587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9132, -3081.362055802587));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9133, -2903.4306821113337));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9134, -2903.4306821113337));
        }

        [TestMethod]
        public void TestEvolveForever513()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9135, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9136, -3238.7219666968103));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9137, -3022.9536651870144));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9138, -3022.9536651870144));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9139, -3008.370124761344));
        }

        [TestMethod]
        public void TestEvolveForever514()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9140, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9141, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9142, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9143, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9144, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever515()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9145, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9146, -3287.3579204619386));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9147, -3287.3579204619386));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9148, -3287.3579204619386));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9149, -3287.3579204619386));
        }

        [TestMethod]
        public void TestEvolveForever516()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9150, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9151, -2738.8905031682903));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9152, -2738.8905031682903));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9153, -2738.8905031682903));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9154, -2738.8905031682903));
        }

        [TestMethod]
        public void TestEvolveForever517()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9155, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9156, -3699.903678673818));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9157, -3563.299524409701));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9158, -3496.1818689286165));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9159, -3496.1818689286165));
        }

        [TestMethod]
        public void TestEvolveForever518()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9160, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9161, -2599.8700220524893));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9162, -2599.8700220524893));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9163, -2599.8700220524893));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9164, -2599.8700220524893));
        }

        [TestMethod]
        public void TestEvolveForever519()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9165, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9166, -3226.6288391682792));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9167, -3226.6288391682792));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9168, -3226.6288391682792));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9169, -3127.9266542955643));
        }

        [TestMethod]
        public void TestEvolveForever520()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9170, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9171, -3401.5633503921513));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9172, -3401.5633503921513));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9173, -3401.5633503921513));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9174, -3319.891476698573));
        }

        [TestMethod]
        public void TestEvolveForever521()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9175, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9176, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9177, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9178, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9179, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever522()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9180, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9181, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9182, -3127.805909894222));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9183, -3127.805909894222));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9184, -3127.805909894222));
        }

        [TestMethod]
        public void TestEvolveForever523()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9185, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9186, -3095.8269235014695));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9187, -3095.8269235014695));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9188, -3095.8269235014695));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9189, -3095.8269235014695));
        }

        [TestMethod]
        public void TestEvolveForever524()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9190, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9191, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9192, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9193, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9194, -2901.093559563646));
        }

        [TestMethod]
        public void TestEvolveForever525()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9195, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9196, -3236.213213988959));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9197, -3223.4751588845165));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9198, -3064.5839970172206));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9199, -3064.5839970172206));
        }

        [TestMethod]
        public void TestEvolveForever526()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9200, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9201, -3108.0782645554773));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9202, -2864.2023921250375));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9203, -2825.425973754461));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9204, -2825.425973754461));
        }

        [TestMethod]
        public void TestEvolveForever527()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9205, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9206, -3844.52288170018));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9207, -3809.085883003956));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9208, -3506.2340091532196));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9209, -2910.143038697217));
        }

        [TestMethod]
        public void TestEvolveForever528()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9210, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9211, -2599.8700220524893));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9212, -2599.8700220524893));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9213, -2341.2911576628917));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9214, -2341.2911576628917));
        }

        [TestMethod]
        public void TestEvolveForever529()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9215, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9216, -3155.959236990082));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9217, -3155.959236990082));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9218, -3155.959236990082));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9219, -3155.959236990082));
        }

        [TestMethod]
        public void TestEvolveForever530()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9220, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9221, -3046.0443269229168));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9222, -3046.0443269229168));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9223, -3046.0443269229168));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9224, -3046.0443269229168));
        }

        [TestMethod]
        public void TestEvolveForever531()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9225, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9226, -3259.750279896928));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9227, -3259.750279896928));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9228, -3095.486907040813));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9229, -3095.486907040813));
        }

        [TestMethod]
        public void TestEvolveForever532()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9230, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9231, -3327.38485441947));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9232, -3327.38485441947));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9233, -3264.554736813887));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9234, -3264.554736813887));
        }

        [TestMethod]
        public void TestEvolveForever533()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9235, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9236, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9237, -3324.5022586380474));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9238, -3215.06730327279));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9239, -2946.365792107265));
        }

        [TestMethod]
        public void TestEvolveForever534()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9240, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9241, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9242, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9243, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9244, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever535()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9245, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9246, -3040.2888633614643));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9247, -3040.2888633614643));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9248, -2982.130538311238));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9249, -2981.188588584949));
        }

        [TestMethod]
        public void TestEvolveForever536()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9250, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9251, -3140.203623585954));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9252, -2628.1122148759255));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9253, -2628.1122148759255));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9254, -2628.1122148759255));
        }

        [TestMethod]
        public void TestEvolveForever537()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9255, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9256, -3730.013594093117));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9257, -3422.317929961185));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9258, -3422.317929961185));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9259, -3422.317929961185));
        }

        [TestMethod]
        public void TestEvolveForever538()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9260, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9261, -2341.2911576628917));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9262, -2341.2911576628917));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9263, -2341.2911576628917));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9264, -2341.2911576628917));
        }

        [TestMethod]
        public void TestEvolveForever539()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9265, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9266, -3198.167506130234));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9267, -2985.649509997697));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9268, -2985.649509997697));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9269, -2985.649509997697));
        }

        [TestMethod]
        public void TestEvolveForever540()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9270, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9271, -3351.228230545536));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9272, -3351.228230545536));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9273, -3351.228230545536));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9274, -3293.784397149497));
        }

        [TestMethod]
        public void TestEvolveForever541()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9275, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9276, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9277, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9278, -3298.9493193162575));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9279, -3031.65500801664));
        }

        [TestMethod]
        public void TestEvolveForever542()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9280, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9281, -2931.6995790840906));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9282, -2834.039619396931));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9283, -2834.039619396931));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9284, -2834.039619396931));
        }

        [TestMethod]
        public void TestEvolveForever543()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9285, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9286, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9287, -3324.5022586380474));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9288, -3006.1111844105876));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9289, -3006.1111844105876));
        }

        [TestMethod]
        public void TestEvolveForever544()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9290, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9291, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9292, -2776.9970419352));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9293, -2776.9970419352));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9294, -2776.9970419352));
        }

        [TestMethod]
        public void TestEvolveForever545()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9295, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9296, -3627.52878924599));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9297, -3627.52878924599));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9298, -3627.52878924599));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9299, -3627.52878924599));
        }

        [TestMethod]
        public void TestEvolveForever546()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9300, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9301, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9302, -3334.1642610208582));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9303, -3334.1642610208582));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9304, -3219.643299707638));
        }

        [TestMethod]
        public void TestEvolveForever547()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9305, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9306, -3166.951688314468));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9307, -3166.951688314468));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9308, -3068.8156542930215));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9309, -2932.727558974907));
        }

        [TestMethod]
        public void TestEvolveForever548()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9310, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9311, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9312, -2877.2382862723402));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9313, -2409.3480172584586));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9314, -2409.3480172584586));
        }

        [TestMethod]
        public void TestEvolveForever549()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9315, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9316, -3356.5964630602566));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9317, -3159.037454964686));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9318, -2998.681180574476));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9319, -2966.2738706495684));
        }

        [TestMethod]
        public void TestEvolveForever550()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9320, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9321, -2854.773698105342));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9322, -2854.773698105342));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9323, -2854.773698105342));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9324, -2854.773698105342));
        }

        [TestMethod]
        public void TestEvolveForever551()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9325, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9326, -3149.143568284159));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9327, -2989.0789283865934));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9328, -2989.0789283865934));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9329, -2989.0789283865934));
        }

        [TestMethod]
        public void TestEvolveForever552()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9330, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9331, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9332, -3367.051407629086));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9333, -3081.3620558025864));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9334, -3081.3620558025864));
        }

        [TestMethod]
        public void TestEvolveForever553()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9335, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9336, -3300.461620646736));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9337, -3006.1111844105876));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9338, -3006.1111844105876));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9339, -3006.1111844105876));
        }

        [TestMethod]
        public void TestEvolveForever554()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9340, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9341, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9342, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9343, -2642.3918452635658));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9344, -2642.3918452635658));
        }

        [TestMethod]
        public void TestEvolveForever555()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9345, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9346, -3287.3579204619386));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9347, -3287.3579204619386));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9348, -2985.6044543591306));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9349, -2985.6044543591306));
        }

        [TestMethod]
        public void TestEvolveForever556()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9350, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9351, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9352, -3334.1642610208582));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9353, -3334.1642610208582));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9354, -3043.7361666596526));
        }

        [TestMethod]
        public void TestEvolveForever557()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9355, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9356, -3540.116122419963));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9357, -3203.75323996297));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9358, -3203.75323996297));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9359, -3203.75323996297));
        }

        [TestMethod]
        public void TestEvolveForever558()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9360, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9361, -2599.8700220524893));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9362, -2599.8700220524893));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9363, -2496.6447783859985));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9364, -2323.256833419009));
        }

        [TestMethod]
        public void TestEvolveForever559()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9365, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9366, -3356.5990269842837));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9367, -3013.778703202479));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9368, -3013.778703202479));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9369, -3013.778703202479));
        }

        [TestMethod]
        public void TestEvolveForever560()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9370, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9371, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9372, -3490.1978334807836));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9373, -3443.601253126327));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9374, -3443.601253126327));
        }

        [TestMethod]
        public void TestEvolveForever561()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9375, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9376, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9377, -3149.143568284159));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9378, -3149.143568284159));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9379, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever562()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9380, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9381, -3287.89512896994));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9382, -3287.89512896994));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9383, -3182.8608425601556));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9384, -3182.8608425601556));
        }

        [TestMethod]
        public void TestEvolveForever563()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9385, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9386, -3238.7219666968103));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9387, -3238.7219666968103));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9388, -3238.7219666968103));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9389, -2772.334721368132));
        }

        [TestMethod]
        public void TestEvolveForever564()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9390, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9391, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9392, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9393, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9394, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever565()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9395, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9396, -3671.7063650321966));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9397, -3431.068967471691));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9398, -3431.068967471691));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9399, -3431.068967471691));
        }

        [TestMethod]
        public void TestEvolveForever566()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9400, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9401, -2864.2023921250375));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9402, -2864.2023921250375));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9403, -2864.2023921250375));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9404, -2864.2023921250375));
        }

        [TestMethod]
        public void TestEvolveForever567()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9405, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9406, -3476.0774049760435));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9407, -3261.7213546875096));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9408, -3164.439267841216));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9409, -2792.0636378194736));
        }

        [TestMethod]
        public void TestEvolveForever568()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9410, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9411, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9412, -3050.626231239329));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9413, -3050.626231239329));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9414, -3050.626231239329));
        }

        [TestMethod]
        public void TestEvolveForever569()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9415, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9416, -3051.6144687048914));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9417, -3051.6144687048914));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9418, -3051.6144687048914));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9419, -3019.866329544526));
        }

        [TestMethod]
        public void TestEvolveForever570()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9420, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9421, -3396.169601196752));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9422, -3396.169601196752));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9423, -3334.996064099286));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9424, -3332.151521322966));
        }

        [TestMethod]
        public void TestEvolveForever571()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9425, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9426, -3036.386710204603));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9427, -3036.386710204603));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9428, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9429, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever572()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9430, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9431, -3075.463133563795));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9432, -3075.463133563795));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9433, -3075.463133563795));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9434, -3075.463133563795));
        }

        [TestMethod]
        public void TestEvolveForever573()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9435, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9436, -3095.8269235014695));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9437, -3095.8269235014695));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9438, -3095.8269235014695));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9439, -2881.864579400174));
        }

        [TestMethod]
        public void TestEvolveForever574()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9440, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9441, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9442, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9443, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9444, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever575()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9445, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9446, -3542.3246576808124));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9447, -2665.7344093838947));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9448, -2665.7344093838947));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9449, -2580.543489961286));
        }

        [TestMethod]
        public void TestEvolveForever576()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9450, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9451, -3059.5343782867135));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9452, -3059.5343782867135));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9453, -2876.0503856792866));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9454, -2876.0503856792866));
        }

        [TestMethod]
        public void TestEvolveForever577()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9455, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9456, -3172.482528267699));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9457, -3172.482528267699));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9458, -3172.482528267699));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9459, -2824.40580685235));
        }

        [TestMethod]
        public void TestEvolveForever578()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9460, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9461, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9462, -3050.626231239329));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9463, -3050.626231239329));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9464, -3050.626231239329));
        }

        [TestMethod]
        public void TestEvolveForever579()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9465, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9466, -3356.5964630602566));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9467, -2983.912096029216));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9468, -2983.912096029216));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9469, -2983.912096029216));
        }

        [TestMethod]
        public void TestEvolveForever580()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9470, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9471, -3412.04844308724));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9472, -3412.04844308724));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9473, -3412.04844308724));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9474, -3412.04844308724));
        }

        [TestMethod]
        public void TestEvolveForever581()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9475, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9476, -3149.143568284159));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9477, -3036.386710204603));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9478, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9479, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever582()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9480, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9481, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9482, -3367.051407629086));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9483, -3367.051407629086));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9484, -3367.051407629086));
        }

        [TestMethod]
        public void TestEvolveForever583()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9485, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9486, -3120.2638915446546));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9487, -3120.2638915446546));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9488, -3120.2638915446546));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9489, -2845.811131998963));
        }

        [TestMethod]
        public void TestEvolveForever584()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9490, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9491, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9492, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9493, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9494, -2890.226042185531));
        }

        [TestMethod]
        public void TestEvolveForever585()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9495, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9496, -3525.519157175563));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9497, -2650.527273978595));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9498, -2650.527273978595));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9499, -2650.527273978595));
        }

        [TestMethod]
        public void TestEvolveForever586()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9500, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9501, -3192.7327725775535));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9502, -3083.5466400676864));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9503, -2633.4677463120834));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9504, -2633.4677463120834));
        }

        [TestMethod]
        public void TestEvolveForever587()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9505, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9506, -3166.951688314468));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9507, -3166.951688314468));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9508, -3166.951688314468));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9509, -3143.750531713208));
        }

        [TestMethod]
        public void TestEvolveForever588()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9510, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9511, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9512, -3050.626231239329));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9513, -2341.2911576628917));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9514, -2341.2911576628917));
        }

        [TestMethod]
        public void TestEvolveForever589()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9515, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9516, -3127.9266542955643));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9517, -3127.9266542955643));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9518, -3019.866329544526));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9519, -3019.866329544526));
        }

        [TestMethod]
        public void TestEvolveForever590()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9520, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9521, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9522, -3358.7694957320828));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9523, -3358.7694957320828));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9524, -2810.4016667151236));
        }

        [TestMethod]
        public void TestEvolveForever591()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9525, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9526, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9527, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9528, -3228.1211388771853));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9529, -3224.815660511854));
        }

        [TestMethod]
        public void TestEvolveForever592()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9530, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9531, -3228.842007177617));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9532, -3228.842007177617));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9533, -3129.504378918676));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9534, -3047.9463827481204));
        }

        [TestMethod]
        public void TestEvolveForever593()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9535, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9536, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9537, -3300.461620646736));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9538, -3300.4616206467354));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9539, -3177.7591653423765));
        }

        [TestMethod]
        public void TestEvolveForever594()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9540, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9541, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9542, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9543, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9544, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever595()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9545, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9546, -3110.572920096989));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9547, -3042.516060501422));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9548, -3042.516060501422));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9549, -3042.516060501422));
        }

        [TestMethod]
        public void TestEvolveForever596()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9550, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9551, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9552, -3334.1642610208582));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9553, -3205.5971121540315));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9554, -2864.2023921250375));
        }

        [TestMethod]
        public void TestEvolveForever597()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9555, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9556, -3696.7475261122363));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9557, -2965.6374245746556));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9558, -2965.6374245746556));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9559, -2965.6374245746556));
        }

        [TestMethod]
        public void TestEvolveForever598()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9560, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9561, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9562, -2885.5714466233594));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9563, -2735.5501504944104));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9564, -2735.5501504944104));
        }

        [TestMethod]
        public void TestEvolveForever599()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9565, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9566, -3434.3098520609683));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9567, -3434.3098520609683));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9568, -3368.795677171097));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9569, -3368.795677171097));
        }

        [TestMethod]
        public void TestEvolveForever600()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9570, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9571, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9572, -3490.1978334807836));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9573, -3330.345279449317));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9574, -3330.345279449317));
        }

        [TestMethod]
        public void TestEvolveForever601()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9575, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9576, -3075.636694507708));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9577, -2994.804289681472));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9578, -2957.2898028632103));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9579, -2957.2898028632103));
        }

        [TestMethod]
        public void TestEvolveForever602()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9580, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9581, -3081.3620558025864));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9582, -3081.3620558025864));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9583, -3081.3620558025864));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9584, -3081.3620558025864));
        }

        [TestMethod]
        public void TestEvolveForever603()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9585, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9586, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9587, -3212.947065556325));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9588, -3212.947065556325));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9589, -3148.4526444078897));
        }

        [TestMethod]
        public void TestEvolveForever604()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9590, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9591, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9592, -2755.2176387502946));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9593, -2751.220366067224));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9594, -2751.220366067224));
        }

        [TestMethod]
        public void TestEvolveForever605()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9595, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9596, -3431.068967471691));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9597, -3431.068967471691));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9598, -3234.820300139674));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9599, -3234.820300139674));
        }

        [TestMethod]
        public void TestEvolveForever606()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9600, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9601, -3149.94877152908));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9602, -3149.94877152908));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9603, -3149.94877152908));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9604, -3149.94877152908));
        }

        [TestMethod]
        public void TestEvolveForever607()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9605, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9606, -3043.2359118737186));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9607, -3043.2359118737186));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9608, -3043.2359118737186));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9609, -3043.2359118737186));
        }

        [TestMethod]
        public void TestEvolveForever608()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9610, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9611, -2885.5714466233594));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9612, -2885.5714466233594));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9613, -2885.5714466233594));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9614, -2885.5714466233594));
        }

        [TestMethod]
        public void TestEvolveForever609()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9615, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9616, -3398.644711857204));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9617, -3173.6997016313403));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9618, -3089.545047918456));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9619, -2909.8498549179626));
        }

        [TestMethod]
        public void TestEvolveForever610()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9620, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9621, -3400.851316153914));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9622, -3104.4558975983027));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9623, -3087.2597023504236));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9624, -3087.2597023504236));
        }

        [TestMethod]
        public void TestEvolveForever611()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9625, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9626, -2671.1597898029668));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9627, -2671.1597898029668));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9628, -2671.1597898029668));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9629, -2671.1597898029668));
        }

        [TestMethod]
        public void TestEvolveForever612()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9630, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9631, -3258.1869757885092));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9632, -2949.7014082220185));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9633, -2949.7014082220185));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9634, -2931.949780354271));
        }

        [TestMethod]
        public void TestEvolveForever613()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9635, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9636, -3238.7219666968103));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9637, -3238.7219666968103));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9638, -3120.2638915446546));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9639, -3120.2638915446546));
        }

        [TestMethod]
        public void TestEvolveForever614()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9640, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9641, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9642, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9643, -2624.420631362052));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9644, -2624.420631362052));
        }

        [TestMethod]
        public void TestEvolveForever615()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9645, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9646, -3192.5875454704483));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9647, -3191.855455589034));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9648, -3176.6013896075356));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9649, -3012.7839560725183));
        }

        [TestMethod]
        public void TestEvolveForever616()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9650, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9651, -3232.7307951364996));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9652, -3232.7307951364996));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9653, -3232.7307951364996));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9654, -3209.226373089337));
        }

        [TestMethod]
        public void TestEvolveForever617()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9655, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9656, -3544.6666861585836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9657, -3132.7571479665257));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9658, -3132.7571479665257));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9659, -3132.7571479665257));
        }

        [TestMethod]
        public void TestEvolveForever618()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9660, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9661, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9662, -3021.568283369958));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9663, -3015.07466839484));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9664, -3015.07466839484));
        }

        [TestMethod]
        public void TestEvolveForever619()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9665, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9666, -3012.774981221023));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9667, -3012.774981221023));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9668, -3012.774981221023));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9669, -3010.30106097536));
        }

        [TestMethod]
        public void TestEvolveForever620()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9670, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9671, -3361.630684613957));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9672, -3361.630684613957));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9673, -3361.630684613957));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9674, -3361.630684613957));
        }

        [TestMethod]
        public void TestEvolveForever621()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9675, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9676, -3177.1976362897444));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9677, -3177.1976362897444));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9678, -3177.1976362897444));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9679, -3021.4127755245772));
        }

        [TestMethod]
        public void TestEvolveForever622()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9680, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9681, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9682, -3328.8984036365437));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9683, -3159.605490158168));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9684, -3159.605490158168));
        }

        [TestMethod]
        public void TestEvolveForever623()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9685, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9686, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9687, -3324.5022586380474));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9688, -3171.1225799686863));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9689, -2838.160946511937));
        }

        [TestMethod]
        public void TestEvolveForever624()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9690, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9691, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9692, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9693, -2835.194719020476));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9694, -2835.194719020476));
        }

        [TestMethod]
        public void TestEvolveForever625()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9695, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9696, -3647.5228681875396));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9697, -3287.3579204619386));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9698, -3133.537062841832));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9699, -3133.537062841832));
        }

        [TestMethod]
        public void TestEvolveForever626()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9700, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9701, -3153.37328618721));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9702, -3153.37328618721));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9703, -2995.130083393098));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9704, -2995.130083393098));
        }

        [TestMethod]
        public void TestEvolveForever627()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9705, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9706, -3816.281992710892));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9707, -3473.3245091536414));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9708, -3119.8686088194977));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9709, -3119.8686088194977));
        }

        [TestMethod]
        public void TestEvolveForever628()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9710, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9711, -2599.8700220524893));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9712, -2599.8700220524893));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9713, -2599.8700220524893));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9714, -2341.2911576628917));
        }

        [TestMethod]
        public void TestEvolveForever629()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9715, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9716, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9717, -3450.875526887452));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9718, -2996.737981355361));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9719, -2996.737981355361));
        }

        [TestMethod]
        public void TestEvolveForever630()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9720, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9721, -3109.5070285513925));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9722, -3109.5070285513925));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9723, -3034.841022482809));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9724, -3034.841022482809));
        }

        [TestMethod]
        public void TestEvolveForever631()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9725, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9726, -3075.636694507708));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9727, -3075.636694507708));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9728, -3075.636694507708));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9729, -3075.636694507708));
        }

        [TestMethod]
        public void TestEvolveForever632()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9730, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9731, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9732, -3250.8616897543443));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9733, -3170.11667034096));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9734, -3170.11667034096));
        }

        [TestMethod]
        public void TestEvolveForever633()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9735, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9736, -3120.2638915446546));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9737, -3120.2638915446546));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9738, -2845.811131998963));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9739, -2845.811131998963));
        }

        [TestMethod]
        public void TestEvolveForever634()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9740, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9741, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9742, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9743, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9744, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever635()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9745, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9746, -3583.3179125653287));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9747, -3186.1719010395072));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9748, -3186.1719010395072));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9749, -2580.543489961286));
        }

        [TestMethod]
        public void TestEvolveForever636()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9750, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9751, -3146.598857475215));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9752, -3146.598857475215));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9753, -3146.598857475215));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9754, -3146.598857475215));
        }

        [TestMethod]
        public void TestEvolveForever637()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9755, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9756, -3563.299524409701));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9757, -3550.9031329844815));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9758, -3490.149814744737));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9759, -3413.3725291865876));
        }

        [TestMethod]
        public void TestEvolveForever638()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9760, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9761, -2869.5593772926904));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9762, -2869.5593772926904));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9763, -2692.0146882021318));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9764, -2692.0146882021318));
        }

        [TestMethod]
        public void TestEvolveForever639()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9765, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9766, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9767, -3105.8994132313524));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9768, -3043.491988461459));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9769, -3043.491988461459));
        }

        [TestMethod]
        public void TestEvolveForever640()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9770, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9771, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9772, -3471.159615811715));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9773, -3345.242029276431));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9774, -3345.242029276431));
        }

        [TestMethod]
        public void TestEvolveForever641()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9775, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9776, -3267.970189180413));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9777, -3246.527062837543));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9778, -3053.003198747773));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9779, -3053.003198747773));
        }

        [TestMethod]
        public void TestEvolveForever642()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9780, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9781, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9782, -3367.051407629086));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9783, -3159.605490158168));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9784, -3159.605490158168));
        }

        [TestMethod]
        public void TestEvolveForever643()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9785, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9786, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9787, -3324.5022586380474));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9788, -3324.5022586380474));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9789, -3225.629925580416));
        }

        [TestMethod]
        public void TestEvolveForever644()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9790, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9791, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9792, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9793, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9794, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever645()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9795, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9796, -3153.3547011568357));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9797, -2928.5684440090204));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9798, -2823.145687152813));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9799, -2755.0888275572465));
        }

        [TestMethod]
        public void TestEvolveForever646()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9800, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9801, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9802, -3191.8985635774934));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9803, -3135.3840308821777));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9804, -2713.8006213397857));
        }

        [TestMethod]
        public void TestEvolveForever647()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9805, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9806, -3809.085883003956));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9807, -3209.691816251883));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9808, -3209.691816251883));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9809, -3209.691816251883));
        }

        [TestMethod]
        public void TestEvolveForever648()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9810, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9811, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9812, -3050.626231239329));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9813, -3050.626231239329));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9814, -3050.626231239329));
        }

        [TestMethod]
        public void TestEvolveForever649()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9815, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9816, -3356.5990269842837));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9817, -2982.669111243808));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9818, -2982.669111243808));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9819, -2963.8847927043626));
        }

        [TestMethod]
        public void TestEvolveForever650()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9820, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9821, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9822, -3351.228230545536));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9823, -3024.10785090121));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9824, -3024.10785090121));
        }

        [TestMethod]
        public void TestEvolveForever651()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9825, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9826, -3264.42890334493));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9827, -3005.5936662585627));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9828, -3005.5936662585627));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9829, -3005.5936662585627));
        }

        [TestMethod]
        public void TestEvolveForever652()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9830, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9831, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9832, -3367.051407629086));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9833, -3328.8984036365437));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9834, -3328.8984036365437));
        }

        [TestMethod]
        public void TestEvolveForever653()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9835, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9836, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9837, -3202.1604043375987));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9838, -3202.1604043375987));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9839, -2896.8523141664373));
        }

        [TestMethod]
        public void TestEvolveForever654()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9840, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9841, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9842, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9843, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9844, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever655()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9845, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9846, -3236.213213988959));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9847, -3065.7819075517473));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9848, -2991.497576437361));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9849, -2991.497576437361));
        }

        [TestMethod]
        public void TestEvolveForever656()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9850, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9851, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9852, -3205.5971121540315));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9853, -2948.132132306052));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9854, -2948.132132306052));
        }

        [TestMethod]
        public void TestEvolveForever657()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9855, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9856, -3172.482528267699));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9857, -3172.482528267699));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9858, -3172.482528267699));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9859, -3172.482528267699));
        }

        [TestMethod]
        public void TestEvolveForever658()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9860, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9861, -2514.6791026298806));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9862, -2514.6791026298806));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9863, -2514.6791026298806));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9864, -2514.6791026298806));
        }

        [TestMethod]
        public void TestEvolveForever659()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9865, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9866, -3155.959236990082));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9867, -3155.959236990082));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9868, -2819.615298041671));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9869, -2819.615298041671));
        }

        [TestMethod]
        public void TestEvolveForever660()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9870, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9871, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9872, -3490.1978334807836));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9873, -3490.1978334807836));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9874, -3485.034701902325));
        }

        [TestMethod]
        public void TestEvolveForever661()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9875, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9876, -2671.1597898029668));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9877, -2671.1597898029668));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9878, -2671.1597898029668));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9879, -2497.771844835978));
        }

        [TestMethod]
        public void TestEvolveForever662()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9880, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9881, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9882, -3367.051407629086));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9883, -3076.1952234452087));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9884, -2931.6995790840906));
        }

        [TestMethod]
        public void TestEvolveForever663()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9885, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9886, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9887, -2961.8651591459134));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9888, -2926.293276739271));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9889, -2926.293276739271));
        }

        [TestMethod]
        public void TestEvolveForever664()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9890, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9891, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9892, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9893, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9894, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever665()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9895, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9896, -3040.2888633614643));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9897, -3040.2888633614643));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9898, -3040.2888633614643));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9899, -3040.2888633614643));
        }

        [TestMethod]
        public void TestEvolveForever666()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9900, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9901, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9902, -2864.2023921250375));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9903, -2768.2529574750934));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9904, -2768.2529574750934));
        }

        [TestMethod]
        public void TestEvolveForever667()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9905, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9906, -3756.7931449400885));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9907, -3626.7661393065305));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9908, -3626.7661393065305));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9909, -3626.7661393065305));
        }

        [TestMethod]
        public void TestEvolveForever668()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9910, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9911, -3022.1660167183427));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9912, -3022.1660167183427));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9913, -3022.1660167183427));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9914, -3022.1660167183427));
        }

        [TestMethod]
        public void TestEvolveForever669()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9915, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9916, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9917, -3482.0079746203587));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9918, -3427.937722331857));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9919, -3427.937722331857));
        }

        [TestMethod]
        public void TestEvolveForever670()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9920, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9921, -3485.034701902325));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9922, -3355.6141244936143));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9923, -2934.5426754296473));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9924, -2934.5426754296473));
        }

        [TestMethod]
        public void TestEvolveForever671()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9925, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9926, -3283.4259837322124));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9927, -3055.725250521753));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9928, -3055.725250521753));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9929, -2908.227049762392));
        }

        [TestMethod]
        public void TestEvolveForever672()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9930, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9931, -3081.3620558025864));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9932, -3081.3620558025864));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9933, -3081.3620558025864));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9934, -3081.3620558025864));
        }

        [TestMethod]
        public void TestEvolveForever673()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9935, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9936, -3120.2638915446546));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9937, -3092.6145536926247));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9938, -3092.6145536926247));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9939, -3092.6145536926247));
        }

        [TestMethod]
        public void TestEvolveForever674()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9940, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9941, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9942, -2973.496682966413));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9943, -2816.9130214986612));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9944, -2816.9130214986612));
        }

        [TestMethod]
        public void TestEvolveForever675()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9945, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9946, -3160.4129893778813));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9947, -2701.4395131438505));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9948, -2701.4395131438505));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9949, -2701.4395131438505));
        }

        [TestMethod]
        public void TestEvolveForever676()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9950, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9951, -3136.1275788885628));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9952, -3136.1275788885628));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9953, -2733.534971732132));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9954, -2733.534971732132));
        }

        [TestMethod]
        public void TestEvolveForever677()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9955, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9956, -3630.4080409226463));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9957, -3497.5123879077323));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9958, -3497.5123879077323));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9959, -3497.5123879077323));
        }

        [TestMethod]
        public void TestEvolveForever678()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9960, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9961, -2934.736300584524));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9962, -2797.464094714436));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9963, -2784.785301906712));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9964, -2784.785301906712));
        }

        [TestMethod]
        public void TestEvolveForever679()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9965, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9966, -2982.669111243808));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9967, -2982.669111243808));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9968, -2982.669111243808));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9969, -2982.669111243808));
        }

        [TestMethod]
        public void TestEvolveForever680()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9970, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9971, -3400.851316153914));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9972, -3400.851316153914));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9973, -3267.7039234882122));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9974, -3267.7039234882122));
        }

        [TestMethod]
        public void TestEvolveForever681()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9975, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9976, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9977, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9978, -3298.9493193162575));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9979, -3298.9493193162575));
        }

        [TestMethod]
        public void TestEvolveForever682()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9980, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9981, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9982, -3367.051407629086));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9983, -3224.569971562336));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9984, -3224.569971562336));
        }

        [TestMethod]
        public void TestEvolveForever683()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9985, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9986, -3148.1967503338774));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9987, -3083.0549159039974));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9988, -3083.0549159039974));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9989, -2858.489924806687));
        }

        [TestMethod]
        public void TestEvolveForever684()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9990, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9991, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9992, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9993, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9994, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever685()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result9995, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result9996, -3160.4129893778813));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result9997, -3160.4129893778813));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result9998, -2701.4395131438505));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result9999, -2701.4395131438505));
        }

        [TestMethod]
        public void TestEvolveForever686()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10000, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10001, -3205.5971121540315));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10002, -3072.757241721296));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10003, -3072.757241721296));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10004, -3072.757241721296));
        }

        [TestMethod]
        public void TestEvolveForever687()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10005, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10006, -3428.0868755559854));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10007, -3428.0868755559854));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10008, -3428.0868755559854));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10009, -3164.1759268063643));
        }

        [TestMethod]
        public void TestEvolveForever688()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10010, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10011, -2672.675064691813));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10012, -2599.8700220524893));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10013, -2599.8700220524893));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10014, -2599.8700220524893));
        }

        [TestMethod]
        public void TestEvolveForever689()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10015, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10016, -2982.669111243808));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10017, -2982.669111243808));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10018, -2982.669111243808));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10019, -2975.9358408669846));
        }

        [TestMethod]
        public void TestEvolveForever690()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10020, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10021, -3401.5633503921513));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10022, -3401.5633503921513));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10023, -3223.6707535945875));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10024, -3139.1367746213855));
        }

        [TestMethod]
        public void TestEvolveForever691()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10025, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10026, -3036.386710204603));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10027, -3036.386710204603));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10028, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10029, -2784.7961337489737));
        }

        [TestMethod]
        public void TestEvolveForever692()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10030, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10031, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10032, -3240.428349760951));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10033, -3076.1952234452087));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10034, -3076.1952234452087));
        }

        [TestMethod]
        public void TestEvolveForever693()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10035, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10036, -3095.8269235014695));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10037, -3095.8269235014695));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10038, -3095.8269235014695));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10039, -2885.206987073584));
        }

        [TestMethod]
        public void TestEvolveForever694()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10040, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10041, -2878.2772910767176));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10042, -2878.2772910767176));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10043, -2878.2772910767176));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10044, -2878.2772910767176));
        }

        [TestMethod]
        public void TestEvolveForever695()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10045, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10046, -3040.2888633614643));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10047, -3040.2888633614643));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10048, -3040.2888633614643));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10049, -3040.2888633614643));
        }

        [TestMethod]
        public void TestEvolveForever696()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10050, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10051, -3045.792091993211));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10052, -2766.0430165521134));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10053, -2628.1122148759255));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10054, -2628.1122148759255));
        }

        [TestMethod]
        public void TestEvolveForever697()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10055, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10056, -3058.3031956332507));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10057, -3058.3031956332507));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10058, -3058.3031956332507));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10059, -3027.5918497188236));
        }

        [TestMethod]
        public void TestEvolveForever698()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10060, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10061, -2934.736300584524));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10062, -2934.736300584524));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10063, -2844.8636662047534));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10064, -2599.8700220524893));
        }

        [TestMethod]
        public void TestEvolveForever699()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10065, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10066, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10067, -3482.0079746203587));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10068, -3400.2257368082605));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10069, -3265.9021847774357));
        }

        [TestMethod]
        public void TestEvolveForever700()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10070, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10071, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10072, -3351.409342622932));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10073, -3351.409342622932));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10074, -3351.409342622932));
        }

        [TestMethod]
        public void TestEvolveForever701()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10075, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10076, -3036.386710204603));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10077, -3036.386710204603));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10078, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10079, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever702()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10080, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10081, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10082, -3367.051407629086));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10083, -3367.051407629086));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10084, -3367.051407629086));
        }

        [TestMethod]
        public void TestEvolveForever703()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10085, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10086, -3258.238054307197));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10087, -3060.710771792601));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10088, -3037.5096151913413));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10089, -3037.5096151913413));
        }

        [TestMethod]
        public void TestEvolveForever704()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10090, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10091, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10092, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10093, -2912.8351220425225));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10094, -2323.256833419009));
        }

        [TestMethod]
        public void TestEvolveForever705()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10095, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10096, -3287.3579204619386));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10097, -3098.2606476030896));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10098, -3098.2606476030896));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10099, -2985.6044543591306));
        }

        [TestMethod]
        public void TestEvolveForever706()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10100, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10101, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10102, -2864.2023921250375));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10103, -2578.659403759457));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10104, -2578.659403759457));
        }

        [TestMethod]
        public void TestEvolveForever707()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10105, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10106, -3582.4722503510684));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10107, -3582.4722503510684));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10108, -3582.4722503510684));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10109, -3391.8523505597364));
        }

        [TestMethod]
        public void TestEvolveForever708()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10110, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10111, -2599.8700220524893));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10112, -2599.8700220524893));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10113, -2599.8700220524893));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10114, -2409.3480172584586));
        }

        [TestMethod]
        public void TestEvolveForever709()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10115, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10116, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10117, -3328.813226453493));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10118, -3286.785326207665));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10119, -3286.785326207665));
        }

        [TestMethod]
        public void TestEvolveForever710()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10120, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10121, -3319.891476698573));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10122, -3319.891476698573));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10123, -3319.891476698573));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10124, -3319.891476698573));
        }

        [TestMethod]
        public void TestEvolveForever711()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10125, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10126, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10127, -3138.883381019802));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10128, -3138.883381019802));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10129, -3138.883381019802));
        }

        [TestMethod]
        public void TestEvolveForever712()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10130, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10131, -3268.749048211427));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10132, -3268.749048211427));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10133, -3268.749048211427));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10134, -3268.749048211427));
        }

        [TestMethod]
        public void TestEvolveForever713()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10135, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10136, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10137, -3095.8269235014695));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10138, -3095.8269235014695));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10139, -2897.9236654724086));
        }

        [TestMethod]
        public void TestEvolveForever714()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10140, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10141, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10142, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10143, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10144, -2848.77528019283));
        }

        [TestMethod]
        public void TestEvolveForever715()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10145, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10146, -3349.357426114069));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10147, -3188.1703902220097));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10148, -3188.1703902220097));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10149, -3084.1418567647265));
        }

        [TestMethod]
        public void TestEvolveForever716()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10150, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10151, -3205.5971121540315));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10152, -3149.94877152908));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10153, -3127.708701315357));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10154, -2703.4708724666357));
        }

        [TestMethod]
        public void TestEvolveForever717()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10155, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10156, -3164.1759268063643));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10157, -3152.0628690626368));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10158, -3152.0628690626368));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10159, -3152.0628690626368));
        }

        [TestMethod]
        public void TestEvolveForever718()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10160, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10161, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10162, -2341.2911576628917));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10163, -2341.2911576628917));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10164, -2341.2911576628917));
        }

        [TestMethod]
        public void TestEvolveForever719()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10165, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10166, -3333.6756297424004));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10167, -3333.6756297424004));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10168, -3189.6905371309203));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10169, -3071.588449993222));
        }

        [TestMethod]
        public void TestEvolveForever720()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10170, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10171, -3400.851316153914));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10172, -3318.755033322572));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10173, -2762.720677356303));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10174, -2762.720677356303));
        }

        [TestMethod]
        public void TestEvolveForever721()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10175, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10176, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10177, -3024.10785090121));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10178, -3024.10785090121));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10179, -3024.10785090121));
        }

        [TestMethod]
        public void TestEvolveForever722()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10180, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10181, -3306.1738448787746));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10182, -3301.8939408470883));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10183, -3038.8205388210504));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10184, -3031.6275392158686));
        }

        [TestMethod]
        public void TestEvolveForever723()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10185, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10186, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10187, -3324.5022586380474));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10188, -3324.5022586380474));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10189, -3238.72196669681));
        }

        [TestMethod]
        public void TestEvolveForever724()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10190, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10191, -2973.496682966413));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10192, -2931.765685038047));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10193, -2931.765685038047));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10194, -2931.765685038047));
        }

        [TestMethod]
        public void TestEvolveForever725()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10195, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10196, -3696.145662729422));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10197, -2840.0607279687856));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10198, -2840.0607279687856));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10199, -2840.0607279687856));
        }

        [TestMethod]
        public void TestEvolveForever726()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10200, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10201, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10202, -2876.0503856792866));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10203, -2876.0503856792866));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10204, -2876.0503856792866));
        }

        [TestMethod]
        public void TestEvolveForever727()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10205, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10206, -3460.2738153613063));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10207, -3460.2738153613063));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10208, -3460.2738153613063));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10209, -3460.2738153613063));
        }

        [TestMethod]
        public void TestEvolveForever728()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10210, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10211, -3042.063553321295));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10212, -3042.063553321295));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10213, -2710.049012446015));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10214, -2341.2911576628917));
        }

        [TestMethod]
        public void TestEvolveForever729()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10215, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10216, -3398.644711857204));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10217, -3028.488004836216));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10218, -2989.5738246197634));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10219, -2982.669111243808));
        }

        [TestMethod]
        public void TestEvolveForever730()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10220, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10221, -3267.7039234882122));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10222, -3267.7039234882122));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10223, -3267.7039234882122));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10224, -2845.648617548782));
        }

        [TestMethod]
        public void TestEvolveForever731()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10225, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10226, -3036.386710204603));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10227, -3036.386710204603));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10228, -2599.870022052489));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10229, -2599.870022052489));
        }

        [TestMethod]
        public void TestEvolveForever732()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10230, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10231, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10232, -3367.051407629086));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10233, -3283.7672446529464));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10234, -2931.6995790840906));
        }

        [TestMethod]
        public void TestEvolveForever733()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10235, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10236, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10237, -3239.6900210644685));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10238, -3239.6900210644685));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10239, -3239.6900210644685));
        }

        [TestMethod]
        public void TestEvolveForever734()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10240, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10241, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10242, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10243, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10244, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever735()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10245, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10246, -3362.5143715712406));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10247, -3362.5143715712406));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10248, -2801.909042710601));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10249, -2801.909042710601));
        }

        [TestMethod]
        public void TestEvolveForever736()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10250, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10251, -2965.557481512016));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10252, -2965.557481512016));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10253, -2689.461532381859));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10254, -2689.461532381859));
        }

        [TestMethod]
        public void TestEvolveForever737()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10255, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10256, -3493.918353816145));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10257, -3348.671654659573));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10258, -3348.671654659573));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10259, -3130.9538690962813));
        }

        [TestMethod]
        public void TestEvolveForever738()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10260, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10261, -2341.2911576628917));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10262, -2341.2911576628917));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10263, -2341.2911576628917));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10264, -2341.2911576628917));
        }

        [TestMethod]
        public void TestEvolveForever739()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10265, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10266, -3198.167506130234));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10267, -3198.167506130234));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10268, -2757.6249107298863));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10269, -2757.6249107298863));
        }

        [TestMethod]
        public void TestEvolveForever740()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10270, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10271, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10272, -3351.228230545536));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10273, -3351.228230545536));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10274, -3351.228230545536));
        }

        [TestMethod]
        public void TestEvolveForever741()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10275, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10276, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10277, -3070.8265214242356));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10278, -3070.8265214242356));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10279, -2968.329850609036));
        }

        [TestMethod]
        public void TestEvolveForever742()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10280, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10281, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10282, -3311.82896069838));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10283, -3123.033473058394));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10284, -2659.6607093951457));
        }

        [TestMethod]
        public void TestEvolveForever743()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10285, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10286, -3316.03552656596));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10287, -3176.114704960018));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10288, -2858.4899248066877));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10289, -2845.811131998963));
        }

        [TestMethod]
        public void TestEvolveForever744()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10290, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10291, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10292, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10293, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10294, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever745()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10295, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10296, -3647.5228681875396));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10297, -3216.859744956022));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10298, -2982.130538311238));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10299, -2683.8404357067566));
        }

        [TestMethod]
        public void TestEvolveForever746()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10300, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10301, -3225.930516661587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10302, -3225.930516661587));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10303, -3080.73447014381));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10304, -2858.4001005724513));
        }

        [TestMethod]
        public void TestEvolveForever747()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10305, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10306, -3493.918353816145));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10307, -3493.918353816145));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10308, -3040.1994227688538));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10309, -2999.3733830464494));
        }

        [TestMethod]
        public void TestEvolveForever748()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10310, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10311, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10312, -3050.626231239329));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10313, -3050.626231239329));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10314, -3050.626231239329));
        }

        [TestMethod]
        public void TestEvolveForever749()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10315, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10316, -3303.0127851523293));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10317, -3200.3868968070997));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10318, -3092.326572056061));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10319, -3092.326572056061));
        }

        [TestMethod]
        public void TestEvolveForever750()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10320, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10321, -3367.658054368669));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10322, -3367.658054368669));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10323, -3367.658054368669));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10324, -3367.658054368669));
        }

        [TestMethod]
        public void TestEvolveForever751()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10325, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10326, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10327, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10328, -3252.4525405262284));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10329, -3036.3867102046033));
        }

        [TestMethod]
        public void TestEvolveForever752()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10330, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10331, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10332, -3280.851415291164));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10333, -3280.851415291164));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10334, -3280.851415291164));
        }

        [TestMethod]
        public void TestEvolveForever753()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10335, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10336, -3150.3003899859286));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10337, -3150.3003899859286));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10338, -3150.3003899859286));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10339, -3150.3003899859286));
        }

        [TestMethod]
        public void TestEvolveForever754()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10340, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10341, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10342, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10343, -2870.6011817561425));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10344, -2870.6011817561425));
        }

        [TestMethod]
        public void TestEvolveForever755()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10345, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10346, -3223.670753594588));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10347, -3223.670753594588));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10348, -3098.6446723354643));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10349, -3098.6446723354643));
        }

        [TestMethod]
        public void TestEvolveForever756()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10350, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10351, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10352, -3334.1642610208582));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10353, -3026.5436616512575));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10354, -3026.5436616512575));
        }

        [TestMethod]
        public void TestEvolveForever757()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10355, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10356, -3476.0774049760435));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10357, -3388.0404487973046));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10358, -3388.0404487973046));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10359, -2870.9886053849336));
        }

        [TestMethod]
        public void TestEvolveForever758()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10360, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10361, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10362, -3050.626231239329));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10363, -3050.626231239329));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10364, -2877.2382862723402));
        }

        [TestMethod]
        public void TestEvolveForever759()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10365, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10366, -3012.774981221023));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10367, -2982.669111243808));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10368, -2982.669111243808));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10369, -2787.5061383156753));
        }

        [TestMethod]
        public void TestEvolveForever760()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10370, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10371, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10372, -3490.1978334807836));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10373, -3485.034701902325));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10374, -3248.7359992385045));
        }

        [TestMethod]
        public void TestEvolveForever761()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10375, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10376, -3036.386710204603));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10377, -3036.386710204603));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10378, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10379, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever762()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10380, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10381, -3258.1869757885092));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10382, -3258.1869757885092));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10383, -3258.1869757885092));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10384, -3217.52625788356));
        }

        [TestMethod]
        public void TestEvolveForever763()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10385, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10386, -3285.5959281889654));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10387, -3285.5959281889654));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10388, -3089.9148677957446));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10389, -2993.3962584089613));
        }

        [TestMethod]
        public void TestEvolveForever764()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10390, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10391, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10392, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10393, -2890.226042185531));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10394, -2752.9223268002393));
        }

        [TestMethod]
        public void TestEvolveForever765()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10395, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10396, -3725.616364771342));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10397, -3293.1088119002693));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10398, -3293.1088119002693));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10399, -3293.1088119002693));
        }

        [TestMethod]
        public void TestEvolveForever766()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10400, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10401, -3219.643299707638));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10402, -3078.312265269287));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10403, -3045.792091993211));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10404, -2766.0430165521134));
        }

        [TestMethod]
        public void TestEvolveForever767()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10405, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10406, -3318.3425333738587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10407, -3318.3425333738587));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10408, -3180.7658178825623));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10409, -3168.6527601388343));
        }

        [TestMethod]
        public void TestEvolveForever768()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10410, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10411, -2934.736300584524));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10412, -2934.736300584524));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10413, -2934.736300584524));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10414, -2934.736300584524));
        }

        [TestMethod]
        public void TestEvolveForever769()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10415, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10416, -3366.232876734443));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10417, -3145.435344224854));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10418, -3145.435344224854));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10419, -3145.435344224854));
        }

        [TestMethod]
        public void TestEvolveForever770()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10420, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10421, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10422, -3490.1978334807836));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10423, -3351.228230545536));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10424, -3109.5070285513925));
        }

        [TestMethod]
        public void TestEvolveForever771()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10425, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10426, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10427, -3274.1926703493623));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10428, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10429, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever772()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10430, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10431, -2931.5842418072293));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10432, -2931.5842418072293));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10433, -2931.5842418072293));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10434, -2931.5842418072293));
        }

        [TestMethod]
        public void TestEvolveForever773()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10435, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10436, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10437, -3324.5022586380474));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10438, -3324.5022586380474));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10439, -3300.461620646736));
        }

        [TestMethod]
        public void TestEvolveForever774()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10440, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10441, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10442, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10443, -2776.9970419352));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10444, -2776.9970419352));
        }

        [TestMethod]
        public void TestEvolveForever775()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10445, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10446, -3386.897905316263));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10447, -3386.897905316263));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10448, -3156.239114154529));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10449, -3156.239114154529));
        }

        [TestMethod]
        public void TestEvolveForever776()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10450, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10451, -3232.2113035143816));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10452, -3205.5971121540315));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10453, -2682.0585025151995));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10454, -2682.0585025151995));
        }

        [TestMethod]
        public void TestEvolveForever777()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10455, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10456, -3467.7644906558744));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10457, -3242.0009448584615));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10458, -3242.0009448584615));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10459, -3242.0009448584615));
        }

        [TestMethod]
        public void TestEvolveForever778()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10460, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10461, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10462, -2792.305639291315));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10463, -2792.305639291315));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10464, -2792.305639291315));
        }

        [TestMethod]
        public void TestEvolveForever779()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10465, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10466, -3480.0551784121603));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10467, -3333.4019731759176));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10468, -3333.4019731759176));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10469, -3333.4019731759176));
        }

        [TestMethod]
        public void TestEvolveForever780()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10470, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10471, -3267.7039234882122));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10472, -2968.5736119375797));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10473, -2968.5736119375797));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10474, -2968.5736119375797));
        }

        [TestMethod]
        public void TestEvolveForever781()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10475, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10476, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10477, -2939.3087095585074));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10478, -2830.002314181866));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10479, -2701.3500725512395));
        }

        [TestMethod]
        public void TestEvolveForever782()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10480, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10481, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10482, -3212.2634614345325));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10483, -3212.2634614345325));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10484, -2931.6995790840906));
        }

        [TestMethod]
        public void TestEvolveForever783()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10485, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10486, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10487, -2851.4103823537102));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10488, -2851.4103823537102));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10489, -2851.4103823537102));
        }

        [TestMethod]
        public void TestEvolveForever784()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10490, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10491, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10492, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10493, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10494, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever785()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10495, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10496, -3092.9157331313254));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10497, -3092.9157331313254));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10498, -3092.9157331313254));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10499, -2765.02036453012));
        }

        [TestMethod]
        public void TestEvolveForever786()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10500, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10501, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10502, -3232.7307951364996));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10503, -3216.0440714465485));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10504, -3087.4769225797213));
        }

        [TestMethod]
        public void TestEvolveForever787()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10505, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10506, -3166.951688314468));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10507, -2985.769807185458));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10508, -2985.769807185458));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10509, -2985.769807185458));
        }

        [TestMethod]
        public void TestEvolveForever788()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10510, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10511, -2975.5685321435303));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10512, -2975.5685321435303));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10513, -2975.5685321435303));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10514, -2975.5685321435303));
        }

        [TestMethod]
        public void TestEvolveForever789()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10515, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10516, -2982.669111243808));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10517, -2982.669111243808));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10518, -2982.669111243808));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10519, -2757.8441306920795));
        }

        [TestMethod]
        public void TestEvolveForever790()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10520, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10521, -3471.2090322932017));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10522, -3471.2090322932017));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10523, -3471.2090322932017));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10524, -3351.228230545536));
        }

        [TestMethod]
        public void TestEvolveForever791()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10525, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10526, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10527, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10528, -3036.488515929193));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10529, -2945.5423617906868));
        }

        [TestMethod]
        public void TestEvolveForever792()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10530, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10531, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10532, -3268.749048211427));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10533, -3246.50608363391));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10534, -3246.50608363391));
        }

        [TestMethod]
        public void TestEvolveForever793()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10535, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10536, -3148.4526444078897));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10537, -3148.4526444078897));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10538, -3008.370124761344));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10539, -3008.370124761344));
        }

        [TestMethod]
        public void TestEvolveForever794()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10540, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10541, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10542, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10543, -2870.6011817561425));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10544, -2870.6011817561425));
        }

        [TestMethod]
        public void TestEvolveForever795()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10545, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10546, -3799.33074752537));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10547, -3245.641170617264));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10548, -2655.9734414011396));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10549, -2655.9734414011396));
        }

        [TestMethod]
        public void TestEvolveForever796()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10550, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10551, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10552, -3334.1642610208582));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10553, -2975.5760373768157));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10554, -2975.5760373768157));
        }

        [TestMethod]
        public void TestEvolveForever797()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10555, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10556, -3459.3014188796633));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10557, -3031.771387677478));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10558, -3031.771387677478));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10559, -3031.771387677478));
        }

        [TestMethod]
        public void TestEvolveForever798()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10560, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10561, -2672.675064691813));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10562, -2672.675064691813));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10563, -2672.675064691813));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10564, -2672.675064691813));
        }

        [TestMethod]
        public void TestEvolveForever799()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10565, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10566, -3333.6756297424004));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10567, -3005.750006518284));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10568, -3005.750006518284));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10569, -3005.750006518284));
        }

        [TestMethod]
        public void TestEvolveForever800()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10570, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10571, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10572, -3400.851316153914));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10573, -3400.851316153914));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10574, -3400.851316153914));
        }

        [TestMethod]
        public void TestEvolveForever801()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10575, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10576, -2671.1597898029668));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10577, -2671.1597898029668));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10578, -2671.1597898029668));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10579, -2671.1597898029668));
        }

        [TestMethod]
        public void TestEvolveForever802()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10580, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10581, -3306.9059347601883));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10582, -3306.9059347601883));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10583, -3306.9059347601883));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10584, -3264.554736813887));
        }

        [TestMethod]
        public void TestEvolveForever803()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10585, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10586, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10587, -3324.5022586380474));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10588, -3195.2143367159347));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10589, -2836.4920161544846));
        }

        [TestMethod]
        public void TestEvolveForever804()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10590, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10591, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10592, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10593, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10594, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever805()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10595, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10596, -3236.213213988959));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10597, -3236.213213988959));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10598, -3236.213213988959));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10599, -3236.213213988959));
        }

        [TestMethod]
        public void TestEvolveForever806()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10600, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10601, -3232.641354543889));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10602, -3181.90728368615));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10603, -3181.90728368615));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10604, -3181.90728368615));
        }

        [TestMethod]
        public void TestEvolveForever807()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10605, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10606, -3428.0868755559854));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10607, -3186.8703445000774));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10608, -3186.8703445000774));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10609, -3186.8703445000774));
        }

        [TestMethod]
        public void TestEvolveForever808()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10610, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10611, -2764.088733776013));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10612, -2764.088733776013));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10613, -2764.088733776013));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10614, -2764.088733776013));
        }

        [TestMethod]
        public void TestEvolveForever809()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10615, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10616, -2743.268299876403));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10617, -2743.268299876403));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10618, -2743.268299876403));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10619, -2743.268299876403));
        }

        [TestMethod]
        public void TestEvolveForever810()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10620, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10621, -3378.669075911623));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10622, -3378.669075911623));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10623, -3378.669075911623));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10624, -3257.0414810392026));
        }

        [TestMethod]
        public void TestEvolveForever811()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10625, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10626, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10627, -3075.636694507708));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10628, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10629, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever812()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10630, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10631, -3264.554736813887));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10632, -3123.41925032141));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10633, -3123.41925032141));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10634, -2834.039619396931));
        }

        [TestMethod]
        public void TestEvolveForever813()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10635, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10636, -3148.4526444078897));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10637, -3148.4526444078897));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10638, -3148.4526444078897));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10639, -3118.195381526589));
        }

        [TestMethod]
        public void TestEvolveForever814()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10640, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10641, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10642, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10643, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10644, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever815()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10645, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10646, -3799.33074752537));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10647, -3563.8636400730716));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10648, -3563.8636400730716));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10649, -3370.425451346823));
        }

        [TestMethod]
        public void TestEvolveForever816()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10650, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10651, -3267.5876837182313));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10652, -3072.757241721296));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10653, -2965.557481512016));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10654, -2760.726598710061));
        }

        [TestMethod]
        public void TestEvolveForever817()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10655, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10656, -3459.3014188796633));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10657, -3459.301418879663));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10658, -3459.301418879663));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10659, -3459.301418879663));
        }

        [TestMethod]
        public void TestEvolveForever818()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10660, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10661, -3015.07466839484));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10662, -2514.6791026298806));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10663, -2514.6791026298806));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10664, -2341.2911576628917));
        }

        [TestMethod]
        public void TestEvolveForever819()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10665, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10666, -3212.1074975910815));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10667, -3212.1074975910815));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10668, -3212.1074975910815));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10669, -3212.1074975910815));
        }

        [TestMethod]
        public void TestEvolveForever820()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10670, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10671, -3471.2090322932017));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10672, -3248.7359992385045));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10673, -3248.7359992385045));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10674, -3248.7359992385045));
        }

        [TestMethod]
        public void TestEvolveForever821()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10675, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10676, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10677, -3036.386710204603));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10678, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10679, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever822()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10680, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10681, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10682, -3268.749048211427));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10683, -3268.749048211427));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10684, -3268.749048211427));
        }

        [TestMethod]
        public void TestEvolveForever823()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10685, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10686, -3095.8269235014695));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10687, -3095.8269235014695));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10688, -3095.8269235014695));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10689, -3018.4269244853017));
        }

        [TestMethod]
        public void TestEvolveForever824()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10690, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10691, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10692, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10693, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10694, -2973.496682966413));
        }

        [TestMethod]
        public void TestEvolveForever825()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10695, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10696, -2985.6044543591306));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10697, -2985.6044543591306));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10698, -2973.586108529447));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10699, -2871.0328364109223));
        }

        [TestMethod]
        public void TestEvolveForever826()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10700, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10701, -2791.693296782358));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10702, -2751.1188976480516));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10703, -2682.6155121313036));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10704, -2682.6155121313036));
        }

        [TestMethod]
        public void TestEvolveForever827()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10705, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10706, -3058.3031956332507));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10707, -3058.3031956332507));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10708, -3058.3031956332507));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10709, -3058.3031956332507));
        }

        [TestMethod]
        public void TestEvolveForever828()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10710, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10711, -2341.2911576628917));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10712, -2341.2911576628917));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10713, -2341.2911576628917));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10714, -2341.2911576628917));
        }

        [TestMethod]
        public void TestEvolveForever829()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10715, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10716, -3160.035030891964));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10717, -3160.035030891964));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10718, -3125.0105712411096));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10719, -3018.799705285793));
        }

        [TestMethod]
        public void TestEvolveForever830()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10720, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10721, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10722, -3490.1978334807836));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10723, -3319.891476698573));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10724, -3319.891476698573));
        }

        [TestMethod]
        public void TestEvolveForever831()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10725, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10726, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10727, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10728, -3298.9493193162575));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10729, -3102.258842767269));
        }

        [TestMethod]
        public void TestEvolveForever832()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10730, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10731, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10732, -2931.6995790840906));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10733, -2931.6995790840906));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10734, -2931.6995790840906));
        }

        [TestMethod]
        public void TestEvolveForever833()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10735, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10736, -3300.4616206467354));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10737, -3300.4616206467354));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10738, -3239.6900210644685));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10739, -3163.5021767572603));
        }

        [TestMethod]
        public void TestEvolveForever834()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10740, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10741, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10742, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10743, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10744, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever835()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10745, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10746, -3022.844447724386));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10747, -2864.910763754879));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10748, -2864.910763754879));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10749, -2823.145687152813));
        }

        [TestMethod]
        public void TestEvolveForever836()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10750, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10751, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10752, -2613.722895969648));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10753, -2613.722895969648));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10754, -2613.722895969648));
        }

        [TestMethod]
        public void TestEvolveForever837()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10755, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10756, -3842.2429194893166));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10757, -3842.2429194893166));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10758, -3253.421307315234));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10759, -3253.421307315234));
        }

        [TestMethod]
        public void TestEvolveForever838()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10760, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10761, -3022.1660167183427));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10762, -3022.1660167183427));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10763, -3022.1660167183427));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10764, -3015.07466839484));
        }

        [TestMethod]
        public void TestEvolveForever839()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10765, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10766, -3212.1074975910815));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10767, -3212.1074975910815));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10768, -2982.669111243808));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10769, -2750.855826374288));
        }

        [TestMethod]
        public void TestEvolveForever840()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10770, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10771, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10772, -3060.8920828791306));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10773, -3060.8920828791306));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10774, -3060.8920828791306));
        }

        [TestMethod]
        public void TestEvolveForever841()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10775, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10776, -3036.386710204603));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10777, -3036.386710204603));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10778, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10779, -2685.1971254745076));
        }

        [TestMethod]
        public void TestEvolveForever842()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10780, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10781, -3264.554736813887));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10782, -3264.554736813887));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10783, -3264.554736813887));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10784, -3182.364468647122));
        }

        [TestMethod]
        public void TestEvolveForever843()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10785, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10786, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10787, -3324.5022586380474));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10788, -2963.912681662894));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10789, -2963.912681662894));
        }

        [TestMethod]
        public void TestEvolveForever844()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10790, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10791, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10792, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10793, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10794, -2949.0236733462743));
        }

        [TestMethod]
        public void TestEvolveForever845()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10795, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10796, -3529.9022237064223));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10797, -3236.213213988959));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10798, -3236.213213988959));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10799, -3226.8277964699164));
        }

        [TestMethod]
        public void TestEvolveForever846()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10800, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10801, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10802, -3334.1642610208582));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10803, -2864.2023921250375));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10804, -2864.2023921250375));
        }

        [TestMethod]
        public void TestEvolveForever847()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10805, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10806, -3202.675390007773));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10807, -3202.675390007773));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10808, -2779.0427301537106));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10809, -2779.0427301537106));
        }

        [TestMethod]
        public void TestEvolveForever848()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10810, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10811, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10812, -2977.156099564857));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10813, -2743.613473974551));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10814, -2341.2911576628917));
        }

        [TestMethod]
        public void TestEvolveForever849()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10815, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10816, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10817, -3482.0079746203587));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10818, -3102.243553914709));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10819, -3102.243553914709));
        }

        [TestMethod]
        public void TestEvolveForever850()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10820, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10821, -3490.0330230890545));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10822, -3287.9672494730376));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10823, -3287.9672494730376));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10824, -3287.9672494730376));
        }

        [TestMethod]
        public void TestEvolveForever851()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10825, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10826, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10827, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10828, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10829, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever852()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10830, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10831, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10832, -3081.3620558025864));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10833, -3081.3620558025864));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10834, -3081.3620558025864));
        }

        [TestMethod]
        public void TestEvolveForever853()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10835, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10836, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10837, -3238.72196669681));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10838, -3202.1604043375983));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10839, -3202.1604043375983));
        }

        [TestMethod]
        public void TestEvolveForever854()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10840, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10841, -2776.9970419352));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10842, -2776.9970419352));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10843, -2776.9970419352));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10844, -2776.9970419352));
        }

        [TestMethod]
        public void TestEvolveForever855()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10845, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10846, -3636.544638557417));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10847, -3473.2822618550085));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10848, -3218.384154473756));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10849, -3218.384154473756));
        }

        [TestMethod]
        public void TestEvolveForever856()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10850, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10851, -2613.722895969648));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10852, -2613.722895969648));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10853, -2613.722895969648));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10854, -2613.722895969648));
        }

        [TestMethod]
        public void TestEvolveForever857()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10855, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10856, -3693.690208719645));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10857, -3525.667982664373));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10858, -3449.0016237666423));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10859, -3449.0016237666423));
        }

        [TestMethod]
        public void TestEvolveForever858()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10860, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10861, -2934.736300584524));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10862, -2934.736300584524));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10863, -2514.6791026298806));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10864, -2514.6791026298806));
        }

        [TestMethod]
        public void TestEvolveForever859()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10865, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10866, -3356.5964630602566));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10867, -3292.1293182733652));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10868, -3047.104074581433));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10869, -3047.104074581433));
        }

        [TestMethod]
        public void TestEvolveForever860()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10870, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10871, -3393.573146113558));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10872, -3393.573146113558));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10873, -3351.228230545536));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10874, -3351.228230545536));
        }

        [TestMethod]
        public void TestEvolveForever861()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10875, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10876, -2949.6978961130285));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10877, -2949.6978961130285));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10878, -2949.6978961130285));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10879, -2949.6978961130285));
        }

        [TestMethod]
        public void TestEvolveForever862()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10880, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10881, -3081.3620558025864));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10882, -3081.3620558025864));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10883, -3081.3620558025864));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10884, -3081.3620558025864));
        }

        [TestMethod]
        public void TestEvolveForever863()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10885, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10886, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10887, -3324.5022586380474));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10888, -3300.4616206467354));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10889, -3107.0955538953085));
        }

        [TestMethod]
        public void TestEvolveForever864()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10890, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10891, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10892, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10893, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10894, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever865()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10895, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10896, -3160.4129893778813));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10897, -3102.254664327655));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10898, -3086.7856421514934));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10899, -3086.7856421514934));
        }

        [TestMethod]
        public void TestEvolveForever866()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10900, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10901, -3262.289902939213));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10902, -3118.835676455253));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10903, -3118.835676455253));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10904, -3118.835676455253));
        }

        [TestMethod]
        public void TestEvolveForever867()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10905, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10906, -3767.775558692167));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10907, -3651.7022986872594));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10908, -2962.9429231199074));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10909, -2962.9429231199074));
        }

        [TestMethod]
        public void TestEvolveForever868()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10910, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10911, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10912, -3050.626231239329));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10913, -2877.23828627234));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10914, -2715.321866560766));
        }

        [TestMethod]
        public void TestEvolveForever869()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10915, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10916, -2982.669111243808));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10917, -2982.669111243808));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10918, -2834.0496303068844));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10919, -2834.0496303068844));
        }

        [TestMethod]
        public void TestEvolveForever870()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10920, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10921, -3358.7694957320828));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10922, -3358.7694957320828));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10923, -3081.3378012728376));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10924, -2927.416879841092));
        }

        [TestMethod]
        public void TestEvolveForever871()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10925, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10926, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10927, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10928, -3075.636694507708));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10929, -2912.835122042523));
        }

        [TestMethod]
        public void TestEvolveForever872()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10930, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10931, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10932, -3338.4025198385907));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10933, -3338.4025198385907));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10934, -3338.4025198385907));
        }

        [TestMethod]
        public void TestEvolveForever873()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10935, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10936, -3288.930376231405));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10937, -3089.9148677957446));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10938, -3089.9148677957446));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10939, -3089.9148677957446));
        }

        [TestMethod]
        public void TestEvolveForever874()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10940, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10941, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10942, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10943, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10944, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever875()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10945, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10946, -3139.7869954870066));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10947, -3139.7869954870066));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10948, -3022.844447724386));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10949, -2877.0470483295358));
        }

        [TestMethod]
        public void TestEvolveForever876()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10950, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10951, -3072.757241721296));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10952, -3072.757241721296));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10953, -3072.757241721296));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10954, -3072.757241721296));
        }

        [TestMethod]
        public void TestEvolveForever877()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10955, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10956, -3476.0774049760435));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10957, -3476.0774049760435));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10958, -3276.077969478718));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10959, -3276.077969478718));
        }

        [TestMethod]
        public void TestEvolveForever878()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10960, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10961, -3018.7752076297447));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10962, -3018.7752076297447));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10963, -3018.7752076297447));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10964, -2514.6791026298806));
        }

        [TestMethod]
        public void TestEvolveForever879()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10965, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10966, -3127.9266542955643));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10967, -3127.9266542955643));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10968, -2982.669111243808));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10969, -2982.669111243808));
        }

        [TestMethod]
        public void TestEvolveForever880()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10970, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10971, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10972, -3485.034701902325));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10973, -3470.16231945914));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10974, -3351.228230545536));
        }

        [TestMethod]
        public void TestEvolveForever881()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10975, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10976, -3075.636694507708));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10977, -2860.6808391615027));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10978, -2860.6808391615027));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10979, -2860.6808391615027));
        }

        [TestMethod]
        public void TestEvolveForever882()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10980, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10981, -3076.1952234452087));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10982, -3076.1952234452087));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10983, -3076.1952234452087));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10984, -3061.945530471008));
        }

        [TestMethod]
        public void TestEvolveForever883()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10985, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10986, -3252.9921243316417));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10987, -3252.9921243316417));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10988, -3252.9921243316417));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10989, -2751.0338048842523));
        }

        [TestMethod]
        public void TestEvolveForever884()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10990, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10991, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10992, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10993, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10994, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever885()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result10995, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result10996, -3362.5143715712406));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result10997, -3362.5143715712406));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result10998, -2748.534326622824));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result10999, -2748.534326622824));
        }

        [TestMethod]
        public void TestEvolveForever886()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11000, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11001, -3197.454297395214));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11002, -2864.2023921250375));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11003, -2864.2023921250375));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11004, -2864.2023921250375));
        }

        [TestMethod]
        public void TestEvolveForever887()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11005, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11006, -3852.2122535775106));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11007, -3423.2710637319287));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11008, -3423.2710637319287));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11009, -3423.2710637319287));
        }

        [TestMethod]
        public void TestEvolveForever888()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11010, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11011, -2885.5714466233594));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11012, -2885.5714466233594));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11013, -2885.5714466233594));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11014, -2885.5714466233594));
        }

        [TestMethod]
        public void TestEvolveForever889()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11015, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11016, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11017, -3305.6691079983048));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11018, -2809.439699118356));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11019, -2809.439699118356));
        }

        [TestMethod]
        public void TestEvolveForever890()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11020, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11021, -3351.228230545536));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11022, -3351.228230545536));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11023, -3351.228230545536));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11024, -3351.228230545536));
        }

        [TestMethod]
        public void TestEvolveForever891()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11025, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11026, -3219.573005727655));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11027, -3051.0359997112682));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11028, -3051.0359997112682));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11029, -2859.7992187308905));
        }

        [TestMethod]
        public void TestEvolveForever892()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11030, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11031, -3287.89512896994));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11032, -2939.308709558508));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11033, -2939.308709558508));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11034, -2939.308709558508));
        }

        [TestMethod]
        public void TestEvolveForever893()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11035, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11036, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11037, -3324.5022586380474));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11038, -3324.5022586380474));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11039, -2838.160946511937));
        }

        [TestMethod]
        public void TestEvolveForever894()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11040, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11041, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11042, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11043, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11044, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever895()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11045, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11046, -3382.921080522521));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11047, -3382.921080522521));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11048, -3382.921080522521));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11049, -3351.6897417554246));
        }

        [TestMethod]
        public void TestEvolveForever896()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11050, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11051, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11052, -3297.5193265095377));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11053, -2930.6541911892705));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11054, -2930.6541911892705));
        }

        [TestMethod]
        public void TestEvolveForever897()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11055, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11056, -3783.322255512985));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11057, -3311.8089657009086));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11058, -2948.3683450387707));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11059, -2948.3683450387707));
        }

        [TestMethod]
        public void TestEvolveForever898()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11060, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11061, -2341.2911576628917));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11062, -2341.2911576628917));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11063, -2341.2911576628917));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11064, -2341.2911576628917));
        }

        [TestMethod]
        public void TestEvolveForever899()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11065, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11066, -2989.5738246197634));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11067, -2989.5738246197634));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11068, -2989.5738246197634));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11069, -2989.5738246197634));
        }

        [TestMethod]
        public void TestEvolveForever900()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11070, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11071, -2854.773698105342));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11072, -2854.773698105342));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11073, -2854.773698105342));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11074, -2854.773698105342));
        }

        [TestMethod]
        public void TestEvolveForever901()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11075, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11076, -3036.386710204603));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11077, -3036.386710204603));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11078, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11079, -2816.951473407116));
        }

        [TestMethod]
        public void TestEvolveForever902()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11080, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11081, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11082, -3367.051407629086));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11083, -3318.4651439497566));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11084, -3318.4651439497566));
        }

        [TestMethod]
        public void TestEvolveForever903()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11085, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11086, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11087, -3324.5022586380474));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11088, -3324.5022586380474));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11089, -3127.8117820890593));
        }

        [TestMethod]
        public void TestEvolveForever904()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11090, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11091, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11092, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11093, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11094, -2420.9167931061684));
        }

        [TestMethod]
        public void TestEvolveForever905()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11095, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11096, -3287.3579204619386));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11097, -2849.1514420029534));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11098, -2754.869808546177));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11099, -2754.869808546177));
        }

        [TestMethod]
        public void TestEvolveForever906()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11100, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11101, -3153.37328618721));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11102, -3153.37328618721));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11103, -3153.37328618721));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11104, -3153.37328618721));
        }

        [TestMethod]
        public void TestEvolveForever907()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11105, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11106, -3493.918353816145));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11107, -2971.513670897232));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11108, -2971.513670897232));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11109, -2971.513670897232));
        }

        [TestMethod]
        public void TestEvolveForever908()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11110, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11111, -2599.8700220524893));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11112, -2599.8700220524893));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11113, -2599.8700220524893));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11114, -2599.8700220524893));
        }

        [TestMethod]
        public void TestEvolveForever909()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11115, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11116, -3356.5990269842837));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11117, -3138.380852671788));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11118, -3138.380852671788));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11119, -2851.906544186663));
        }

        [TestMethod]
        public void TestEvolveForever910()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11120, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11121, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11122, -3109.840830215575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11123, -3034.841022482809));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11124, -3034.841022482809));
        }

        [TestMethod]
        public void TestEvolveForever911()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11125, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11126, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11127, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11128, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11129, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever912()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11130, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11131, -3139.5203808528127));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11132, -2931.6995790840906));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11133, -2931.6995790840906));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11134, -2931.6995790840906));
        }

        [TestMethod]
        public void TestEvolveForever913()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11135, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11136, -3117.4727549328427));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11137, -3117.4727549328427));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11138, -3117.4727549328427));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11139, -3117.4727549328427));
        }

        [TestMethod]
        public void TestEvolveForever914()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11140, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11141, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11142, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11143, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11144, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever915()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11145, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11146, -3040.2888633614643));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11147, -3040.2888633614643));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11148, -3040.2888633614643));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11149, -2856.9546759545706));
        }

        [TestMethod]
        public void TestEvolveForever916()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11150, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11151, -2733.534971732132));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11152, -2692.886047039988));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11153, -2692.886047039988));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11154, -2590.7907828224174));
        }

        [TestMethod]
        public void TestEvolveForever917()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11155, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11156, -3575.2535600594656));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11157, -3428.0868755559854));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11158, -3428.0868755559854));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11159, -3428.0868755559854));
        }

        [TestMethod]
        public void TestEvolveForever918()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11160, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11161, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11162, -3031.4540004374694));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11163, -2592.5504219892764));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11164, -2341.2911576628917));
        }

        [TestMethod]
        public void TestEvolveForever919()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11165, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11166, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11167, -3429.598468970669));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11168, -3040.601062579943));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11169, -3040.601062579943));
        }

        [TestMethod]
        public void TestEvolveForever920()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11170, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11171, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11172, -3365.3084677487573));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11173, -3365.3084677487573));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11174, -3264.4629639759673));
        }

        [TestMethod]
        public void TestEvolveForever921()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11175, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11176, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11177, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11178, -3298.9493193162575));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11179, -3298.9493193162575));
        }

        [TestMethod]
        public void TestEvolveForever922()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11180, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11181, -3306.1738448787746));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11182, -3306.1738448787746));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11183, -3081.3620558025864));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11184, -2889.011931899289));
        }

        [TestMethod]
        public void TestEvolveForever923()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11185, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11186, -3120.2638915446546));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11187, -3120.2638915446546));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11188, -3120.2638915446546));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11189, -2845.811131998963));
        }

        [TestMethod]
        public void TestEvolveForever924()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11190, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11191, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11192, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11193, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11194, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever925()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11195, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11196, -3464.3017192892894));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11197, -3464.3017192892894));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11198, -3050.0706648130576));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11199, -2994.076660706959));
        }

        [TestMethod]
        public void TestEvolveForever926()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11200, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11201, -3154.978624167018));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11202, -3141.717795576025));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11203, -2766.0430165521134));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11204, -2766.0430165521134));
        }

        [TestMethod]
        public void TestEvolveForever927()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11205, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11206, -3618.4633345494194));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11207, -3342.5870335911836));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11208, -3342.5870335911836));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11209, -3342.5870335911836));
        }

        [TestMethod]
        public void TestEvolveForever928()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11210, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11211, -2672.675064691813));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11212, -2672.675064691813));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11213, -2672.675064691813));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11214, -2672.675064691813));
        }

        [TestMethod]
        public void TestEvolveForever929()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11215, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11216, -3127.9266542955647));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11217, -3126.0958866712285));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11218, -3126.0958866712285));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11219, -2977.5787643025556));
        }

        [TestMethod]
        public void TestEvolveForever930()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11220, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11221, -3307.9741144334403));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11222, -3307.9741144334403));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11223, -3307.9741144334403));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11224, -3109.5070285513925));
        }

        [TestMethod]
        public void TestEvolveForever931()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11225, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11226, -3075.636694507708));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11227, -3075.636694507708));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11228, -3075.636694507708));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11229, -2709.673423131572));
        }

        [TestMethod]
        public void TestEvolveForever932()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11230, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11231, -2931.6995790840906));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11232, -2931.6995790840906));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11233, -2931.6995790840906));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11234, -2931.6995790840906));
        }

        [TestMethod]
        public void TestEvolveForever933()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11235, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11236, -2865.3131925765106));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11237, -2865.3131925765106));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11238, -2865.3131925765106));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11239, -2865.3131925765106));
        }

        [TestMethod]
        public void TestEvolveForever934()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11240, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11241, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11242, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11243, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11244, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever935()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11245, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11246, -3542.3246576808124));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11247, -2985.6044543591306));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11248, -2985.6044543591306));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11249, -2985.6044543591306));
        }

        [TestMethod]
        public void TestEvolveForever936()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11250, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11251, -3232.641354543889));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11252, -3043.736166659653));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11253, -3043.736166659653));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11254, -3043.7361666596526));
        }

        [TestMethod]
        public void TestEvolveForever937()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11255, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11256, -3844.52288170018));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11257, -3630.4080409226463));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11258, -3630.4080409226463));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11259, -3483.8950865763168));
        }

        [TestMethod]
        public void TestEvolveForever938()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11260, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11261, -3031.4540004374694));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11262, -3031.4540004374694));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11263, -3031.4540004374694));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11264, -3031.4540004374694));
        }

        [TestMethod]
        public void TestEvolveForever939()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11265, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11266, -3155.959236990082));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11267, -3155.959236990082));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11268, -3155.959236990082));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11269, -3155.959236990082));
        }

        [TestMethod]
        public void TestEvolveForever940()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11270, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11271, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11272, -3293.784397149497));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11273, -3293.784397149497));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11274, -3293.784397149497));
        }

        [TestMethod]
        public void TestEvolveForever941()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11275, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11276, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11277, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11278, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11279, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever942()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11280, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11281, -3112.6966545254973));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11282, -3112.6966545254973));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11283, -2995.850106442652));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11284, -2995.850106442652));
        }

        [TestMethod]
        public void TestEvolveForever943()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11285, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11286, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11287, -3055.2525243671635));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11288, -2682.6699392914193));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11289, -2682.6699392914193));
        }

        [TestMethod]
        public void TestEvolveForever944()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11290, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11291, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11292, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11293, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11294, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever945()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11295, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11296, -3223.670753594588));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11297, -2767.7205285742034));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11298, -2767.7205285742034));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11299, -2767.7205285742034));
        }

        [TestMethod]
        public void TestEvolveForever946()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11300, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11301, -3205.5971121540315));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11302, -2995.9686422259456));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11303, -2613.722895969648));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11304, -2613.722895969648));
        }

        [TestMethod]
        public void TestEvolveForever947()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11305, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11306, -3852.2122535775106));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11307, -3729.888737493357));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11308, -3502.6306073056744));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11309, -3502.6306073056744));
        }

        [TestMethod]
        public void TestEvolveForever948()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11310, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11311, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11312, -3050.626231239329));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11313, -3050.626231239329));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11314, -2341.2911576628917));
        }

        [TestMethod]
        public void TestEvolveForever949()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11315, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11316, -3012.774981221023));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11317, -2982.669111243808));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11318, -2982.669111243808));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11319, -2982.669111243808));
        }

        [TestMethod]
        public void TestEvolveForever950()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11320, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11321, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11322, -3490.1978334807836));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11323, -3490.1978334807836));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11324, -3180.3321331230627));
        }

        [TestMethod]
        public void TestEvolveForever951()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11325, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11326, -3036.386710204603));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11327, -3036.386710204603));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11328, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11329, -3036.386710204603));
        }

        [TestMethod]
        public void TestEvolveForever952()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11330, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11331, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11332, -3287.3330446448886));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11333, -3264.554736813887));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11334, -3139.5203808528127));
        }

        [TestMethod]
        public void TestEvolveForever953()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11335, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11336, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11337, -3316.03552656596));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11338, -3282.006484821393));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11339, -3282.006484821393));
        }

        [TestMethod]
        public void TestEvolveForever954()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11340, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11341, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11342, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11343, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11344, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever955()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11345, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11346, -3825.8669615811814));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11347, -3287.3579204619386));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11348, -3287.3579204619386));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11349, -2717.819034445372));
        }

        [TestMethod]
        public void TestEvolveForever956()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11350, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11351, -3149.94877152908));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11352, -3149.94877152908));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11353, -2750.6076196125755));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11354, -2750.6076196125755));
        }

        [TestMethod]
        public void TestEvolveForever957()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11355, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11356, -3716.865507856901));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11357, -3172.482528267699));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11358, -3115.6467741228444));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11359, -3115.6467741228444));
        }

        [TestMethod]
        public void TestEvolveForever958()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11360, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11361, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11362, -3050.626231239329));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11363, -2599.8700220524893));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11364, -2599.8700220524893));
        }

        [TestMethod]
        public void TestEvolveForever959()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11365, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11366, -2989.5738246197634));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11367, -2989.5738246197634));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11368, -2989.5738246197634));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11369, -2989.5738246197634));
        }

        [TestMethod]
        public void TestEvolveForever960()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11370, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11371, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11372, -3485.034701902325));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11373, -3485.034701902325));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11374, -3485.034701902325));
        }

        [TestMethod]
        public void TestEvolveForever961()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11375, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11376, -3095.486907040813));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11377, -3036.386710204603));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11378, -3036.386710204603));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11379, -2803.3103183916214));
        }

        [TestMethod]
        public void TestEvolveForever962()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11380, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11381, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11382, -3318.852637686499));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11383, -3306.9059347601883));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11384, -3264.554736813887));
        }

        [TestMethod]
        public void TestEvolveForever963()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11385, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11386, -3120.2638915446546));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11387, -3120.2638915446546));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11388, -2845.811131998963));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11389, -2845.811131998963));
        }

        [TestMethod]
        public void TestEvolveForever964()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11390, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11391, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11392, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11393, -2973.496682966413));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11394, -2973.496682966413));
        }

        [TestMethod]
        public void TestEvolveForever965()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11395, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11396, -3110.572920096989));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11397, -3110.572920096989));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11398, -3049.358125931289));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11399, -2629.34777014175));
        }

        [TestMethod]
        public void TestEvolveForever966()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11400, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11401, -2692.886047039988));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11402, -2692.886047039988));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11403, -2692.886047039988));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11404, -2692.886047039988));
        }

        [TestMethod]
        public void TestEvolveForever967()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11405, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11406, -2791.9429855953813));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11407, -2791.9429855953813));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11408, -2791.9429855953813));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11409, -2791.9429855953813));
        }

        [TestMethod]
        public void TestEvolveForever968()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11410, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11411, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11412, -2599.8700220524893));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11413, -2341.2911576628917));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11414, -2341.2911576628917));
        }

        [TestMethod]
        public void TestEvolveForever969()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11415, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11416, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11417, -2989.5738246197634));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11418, -2989.5738246197634));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11419, -2989.5738246197634));
        }

        [TestMethod]
        public void TestEvolveForever970()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11420, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11421, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11422, -3490.1978334807836));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11423, -3490.1978334807836));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11424, -3293.784397149497));
        }

        [TestMethod]
        public void TestEvolveForever971()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11425, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11426, -3095.486907040813));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11427, -2660.7267143985564));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11428, -2660.7267143985564));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11429, -2660.7267143985564));
        }

        [TestMethod]
        public void TestEvolveForever972()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11430, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11431, -3367.051407629086));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11432, -3327.38485441947));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11433, -3195.181430842796));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11434, -3195.181430842796));
        }

        [TestMethod]
        public void TestEvolveForever973()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11435, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11436, -3324.5022586380474));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11437, -3324.5022586380474));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11438, -3324.5022586380474));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11439, -3079.521100578259));
        }

        [TestMethod]
        public void TestEvolveForever974()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11440, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11441, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11442, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11443, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11444, -2953.11606942372));
        }

        [TestMethod]
        public void TestEvolveForever975()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11445, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11446, -3529.9022237064223));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11447, -3464.3017192892894));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11448, -2666.151037482842));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11449, -2666.151037482842));
        }

        [TestMethod]
        public void TestEvolveForever976()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11450, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11451, -3191.8985635774934));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11452, -3191.8985635774934));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11453, -3126.1125887993594));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11454, -2971.513670897232));
        }

        [TestMethod]
        public void TestEvolveForever977()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11455, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11456, -3661.742956933046));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11457, -3428.0868755559854));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11458, -3428.0868755559854));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11459, -3428.0868755559854));
        }

        [TestMethod]
        public void TestEvolveForever978()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11460, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11461, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11462, -3050.626231239329));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11463, -2599.8700220524893));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11464, -2599.8700220524893));
        }

        [TestMethod]
        public void TestEvolveForever979()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11465, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11466, -3366.232876734443));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11467, -3253.9704412382052));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11468, -3236.0408123589477));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11469, -3236.0408123589477));
        }

        [TestMethod]
        public void TestEvolveForever980()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11470, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11471, -3436.4191499681447));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11472, -3436.4191499681447));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11473, -3436.4191499681447));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11474, -3351.228230545536));
        }

        [TestMethod]
        public void TestEvolveForever981()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11475, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11476, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11477, -2600.5658733253495));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11478, -2600.5658733253495));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11479, -2600.5658733253495));
        }

        [TestMethod]
        public void TestEvolveForever982()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11480, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11481, -3231.93691389259));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11482, -3231.93691389259));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11483, -3231.93691389259));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11484, -3231.93691389259));
        }

        [TestMethod]
        public void TestEvolveForever983()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11485, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11486, -3272.47845515056));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11487, -2862.9470181429547));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11488, -2824.8701908704115));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11489, -2750.7267988869867));
        }

        [TestMethod]
        public void TestEvolveForever984()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11490, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11491, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11492, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11493, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11494, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever985()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11495, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11496, -2906.4685185727117));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11497, -2906.4685185727117));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11498, -2906.4685185727117));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11499, -2722.562137512048));
        }

        [TestMethod]
        public void TestEvolveForever986()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11500, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11501, -3100.5341226002124));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11502, -3100.5341226002124));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11503, -3100.5341226002124));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11504, -3072.757241721296));
        }

        [TestMethod]
        public void TestEvolveForever987()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11505, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11506, -3043.2359118737186));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11507, -2953.9545090177317));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11508, -2953.9545090177317));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11509, -2953.9545090177317));
        }

        [TestMethod]
        public void TestEvolveForever988()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11510, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11511, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11512, -3050.626231239329));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11513, -2669.651686019357));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11514, -2669.651686019357));
        }

        [TestMethod]
        public void TestEvolveForever989()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11515, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11516, -3482.0079746203587));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11517, -3482.0079746203587));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11518, -3482.0079746203587));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11519, -2877.265091307543));
        }

        [TestMethod]
        public void TestEvolveForever990()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population0, TestPopulations.population0.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11520, -3490.1978334807836));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11521, -3490.1978334807836));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11522, -3490.1978334807836));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11523, -3324.9183593682556));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11524, -3324.9183593682556));
        }

        [TestMethod]
        public void TestEvolveForever991()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population1, TestPopulations.population1.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11525, -3298.9493193162575));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11526, -3298.9493193162575));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11527, -3298.9493193162575));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11528, -3107.7824793049963));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11529, -3107.7824793049963));
        }

        [TestMethod]
        public void TestEvolveForever992()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population2, TestPopulations.population2.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11530, -3367.051407629086));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11531, -2949.7014082220185));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11532, -2949.7014082220185));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11533, -2949.7014082220185));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11534, -2949.7014082220185));
        }

        [TestMethod]
        public void TestEvolveForever993()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population3, TestPopulations.population3.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11535, -3324.5022586380474));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11536, -3300.461620646736));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11537, -3300.461620646736));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11538, -3300.461620646736));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11539, -3239.6900210644685));
        }

        [TestMethod]
        public void TestEvolveForever994()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population4, TestPopulations.population4.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11540, -2980.658752414498));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11541, -2980.658752414498));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11542, -2980.658752414498));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11543, -2980.658752414498));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11544, -2980.658752414498));
        }

        [TestMethod]
        public void TestEvolveForever995()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population5, TestPopulations.population5.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11545, -3825.8669615811814));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11546, -3287.3579204619386));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11547, -3287.3579204619386));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11548, -3180.0971411032315));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11549, -3173.7349747978346));
        }

        [TestMethod]
        public void TestEvolveForever996()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population6, TestPopulations.population6.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11550, -3334.1642610208582));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11551, -3334.1642610208582));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11552, -2975.5760373768157));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11553, -2975.5760373768157));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11554, -2877.916077689656));
        }

        [TestMethod]
        public void TestEvolveForever997()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population7, TestPopulations.population7.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11555, -3852.2122535775106));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11556, -3203.270977303691));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11557, -3087.9856422429198));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11558, -3087.9856422429198));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11559, -3087.9856422429198));
        }

        [TestMethod]
        public void TestEvolveForever998()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population8, TestPopulations.population8.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11560, -3050.626231239329));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11561, -3050.626231239329));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11562, -3050.626231239329));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11563, -2671.1597898029668));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11564, -2465.9882133368096));
        }

        [TestMethod]
        public void TestEvolveForever999()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.evolveForever(TestFitnessFunctions.fitness10, TestPopulations.population9, TestPopulations.population9.Length));
            var list = result.Take(5).ToList();
            CompareIndividuals(list[0], new Tuple<int[],double>(IndividualsResults.result11565, -3482.0079746203587));
            CompareIndividuals(list[1], new Tuple<int[],double>(IndividualsResults.result11566, -3333.6756297424004));
            CompareIndividuals(list[2], new Tuple<int[],double>(IndividualsResults.result11567, -3333.6756297424004));
            CompareIndividuals(list[3], new Tuple<int[],double>(IndividualsResults.result11568, -3198.167506130234));
            CompareIndividuals(list[4], new Tuple<int[],double>(IndividualsResults.result11569, -3092.7447492740275));
        }

    }
}
