using Microsoft.VisualStudio.TestTools.UnitTesting;
using CAB402.FSharp;
using System;

namespace GeneticAlgorithmUnitTests
{
    [TestClass]
    public class RandomIndividualsTests
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
        public void TestRandomIndividuals0()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result100, result);
        }

        [TestMethod]
        public void TestRandomIndividuals1()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result101, result);
        }

        [TestMethod]
        public void TestRandomIndividuals2()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result102, result);
        }

        [TestMethod]
        public void TestRandomIndividuals3()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result103, result);
        }

        [TestMethod]
        public void TestRandomIndividuals4()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result104, result);
        }

        [TestMethod]
        public void TestRandomIndividuals5()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result105, result);
        }

        [TestMethod]
        public void TestRandomIndividuals6()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result106, result);
        }

        [TestMethod]
        public void TestRandomIndividuals7()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result107, result);
        }

        [TestMethod]
        public void TestRandomIndividuals8()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result108, result);
        }

        [TestMethod]
        public void TestRandomIndividuals9()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result109, result);
        }

        [TestMethod]
        public void TestRandomIndividuals10()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result110, result);
        }

        [TestMethod]
        public void TestRandomIndividuals11()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result111, result);
        }

        [TestMethod]
        public void TestRandomIndividuals12()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result112, result);
        }

        [TestMethod]
        public void TestRandomIndividuals13()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result113, result);
        }

        [TestMethod]
        public void TestRandomIndividuals14()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result114, result);
        }

        [TestMethod]
        public void TestRandomIndividuals15()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result115, result);
        }

        [TestMethod]
        public void TestRandomIndividuals16()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result116, result);
        }

        [TestMethod]
        public void TestRandomIndividuals17()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result117, result);
        }

        [TestMethod]
        public void TestRandomIndividuals18()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result118, result);
        }

        [TestMethod]
        public void TestRandomIndividuals19()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result119, result);
        }

        [TestMethod]
        public void TestRandomIndividuals20()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result120, result);
        }

        [TestMethod]
        public void TestRandomIndividuals21()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result121, result);
        }

        [TestMethod]
        public void TestRandomIndividuals22()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result122, result);
        }

        [TestMethod]
        public void TestRandomIndividuals23()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result123, result);
        }

        [TestMethod]
        public void TestRandomIndividuals24()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result124, result);
        }

        [TestMethod]
        public void TestRandomIndividuals25()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result125, result);
        }

        [TestMethod]
        public void TestRandomIndividuals26()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result126, result);
        }

        [TestMethod]
        public void TestRandomIndividuals27()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result127, result);
        }

        [TestMethod]
        public void TestRandomIndividuals28()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result128, result);
        }

        [TestMethod]
        public void TestRandomIndividuals29()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result129, result);
        }

        [TestMethod]
        public void TestRandomIndividuals30()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result130, result);
        }

        [TestMethod]
        public void TestRandomIndividuals31()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result131, result);
        }

        [TestMethod]
        public void TestRandomIndividuals32()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result132, result);
        }

        [TestMethod]
        public void TestRandomIndividuals33()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result133, result);
        }

        [TestMethod]
        public void TestRandomIndividuals34()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result134, result);
        }

        [TestMethod]
        public void TestRandomIndividuals35()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result135, result);
        }

        [TestMethod]
        public void TestRandomIndividuals36()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result136, result);
        }

        [TestMethod]
        public void TestRandomIndividuals37()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result137, result);
        }

        [TestMethod]
        public void TestRandomIndividuals38()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result138, result);
        }

        [TestMethod]
        public void TestRandomIndividuals39()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result139, result);
        }

        [TestMethod]
        public void TestRandomIndividuals40()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result140, result);
        }

        [TestMethod]
        public void TestRandomIndividuals41()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result141, result);
        }

        [TestMethod]
        public void TestRandomIndividuals42()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result142, result);
        }

        [TestMethod]
        public void TestRandomIndividuals43()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result143, result);
        }

        [TestMethod]
        public void TestRandomIndividuals44()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result144, result);
        }

        [TestMethod]
        public void TestRandomIndividuals45()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result145, result);
        }

        [TestMethod]
        public void TestRandomIndividuals46()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result146, result);
        }

        [TestMethod]
        public void TestRandomIndividuals47()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result147, result);
        }

        [TestMethod]
        public void TestRandomIndividuals48()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result148, result);
        }

        [TestMethod]
        public void TestRandomIndividuals49()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result149, result);
        }

        [TestMethod]
        public void TestRandomIndividuals50()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result150, result);
        }

        [TestMethod]
        public void TestRandomIndividuals51()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result151, result);
        }

        [TestMethod]
        public void TestRandomIndividuals52()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result152, result);
        }

        [TestMethod]
        public void TestRandomIndividuals53()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result153, result);
        }

        [TestMethod]
        public void TestRandomIndividuals54()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result154, result);
        }

        [TestMethod]
        public void TestRandomIndividuals55()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result155, result);
        }

        [TestMethod]
        public void TestRandomIndividuals56()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result156, result);
        }

        [TestMethod]
        public void TestRandomIndividuals57()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result157, result);
        }

        [TestMethod]
        public void TestRandomIndividuals58()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result158, result);
        }

        [TestMethod]
        public void TestRandomIndividuals59()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result159, result);
        }

        [TestMethod]
        public void TestRandomIndividuals60()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result160, result);
        }

        [TestMethod]
        public void TestRandomIndividuals61()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result161, result);
        }

        [TestMethod]
        public void TestRandomIndividuals62()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result162, result);
        }

        [TestMethod]
        public void TestRandomIndividuals63()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result163, result);
        }

        [TestMethod]
        public void TestRandomIndividuals64()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result164, result);
        }

        [TestMethod]
        public void TestRandomIndividuals65()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result165, result);
        }

        [TestMethod]
        public void TestRandomIndividuals66()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result166, result);
        }

        [TestMethod]
        public void TestRandomIndividuals67()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result167, result);
        }

        [TestMethod]
        public void TestRandomIndividuals68()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result168, result);
        }

        [TestMethod]
        public void TestRandomIndividuals69()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result169, result);
        }

        [TestMethod]
        public void TestRandomIndividuals70()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result170, result);
        }

        [TestMethod]
        public void TestRandomIndividuals71()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result171, result);
        }

        [TestMethod]
        public void TestRandomIndividuals72()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result172, result);
        }

        [TestMethod]
        public void TestRandomIndividuals73()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result173, result);
        }

        [TestMethod]
        public void TestRandomIndividuals74()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result174, result);
        }

        [TestMethod]
        public void TestRandomIndividuals75()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result175, result);
        }

        [TestMethod]
        public void TestRandomIndividuals76()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result176, result);
        }

        [TestMethod]
        public void TestRandomIndividuals77()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result177, result);
        }

        [TestMethod]
        public void TestRandomIndividuals78()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result178, result);
        }

        [TestMethod]
        public void TestRandomIndividuals79()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result179, result);
        }

        [TestMethod]
        public void TestRandomIndividuals80()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result180, result);
        }

        [TestMethod]
        public void TestRandomIndividuals81()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result181, result);
        }

        [TestMethod]
        public void TestRandomIndividuals82()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result182, result);
        }

        [TestMethod]
        public void TestRandomIndividuals83()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result183, result);
        }

        [TestMethod]
        public void TestRandomIndividuals84()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result184, result);
        }

        [TestMethod]
        public void TestRandomIndividuals85()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result185, result);
        }

        [TestMethod]
        public void TestRandomIndividuals86()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result186, result);
        }

        [TestMethod]
        public void TestRandomIndividuals87()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result187, result);
        }

        [TestMethod]
        public void TestRandomIndividuals88()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result188, result);
        }

        [TestMethod]
        public void TestRandomIndividuals89()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result189, result);
        }

        [TestMethod]
        public void TestRandomIndividuals90()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result190, result);
        }

        [TestMethod]
        public void TestRandomIndividuals91()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result191, result);
        }

        [TestMethod]
        public void TestRandomIndividuals92()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result192, result);
        }

        [TestMethod]
        public void TestRandomIndividuals93()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result193, result);
        }

        [TestMethod]
        public void TestRandomIndividuals94()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result194, result);
        }

        [TestMethod]
        public void TestRandomIndividuals95()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result195, result);
        }

        [TestMethod]
        public void TestRandomIndividuals96()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result196, result);
        }

        [TestMethod]
        public void TestRandomIndividuals97()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result197, result);
        }

        [TestMethod]
        public void TestRandomIndividuals98()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result198, result);
        }

        [TestMethod]
        public void TestRandomIndividuals99()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.randomIndividuals(TestFitnessFunctions.fitness10, TestFitnessFunctions.cities10.Length, 10));
            ComparePopulations(PopulationsResults.result199, result);
        }

    }
}
