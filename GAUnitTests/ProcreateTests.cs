using Microsoft.VisualStudio.TestTools.UnitTesting;
using CAB402.FSharp;
using System;

namespace GeneticAlgorithmUnitTests
{
    [TestClass]
    public class ProcreateTests
    {
        private void CompareIndividuals(Tuple<int[], double> expected, Tuple<int[], double> actual)
        {
            CollectionAssert.AreEqual(expected.Item1, actual.Item1);
            Assert.AreEqual(expected.Item2, actual.Item2);
        }


        [TestMethod]
        public void TestProcreate00()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5570,-3528.591485517745), result);
        }

        [TestMethod]
        public void TestProcreate01()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5571,-3702.917694885148), result);
        }

        [TestMethod]
        public void TestProcreate02()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5572,-3367.051407629086), result);
        }

        [TestMethod]
        public void TestProcreate03()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5573,-4461.824726651392), result);
        }

        [TestMethod]
        public void TestProcreate04()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5574,-3702.9010224556946), result);
        }

        [TestMethod]
        public void TestProcreate05()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5575,-3040.2888633614643), result);
        }

        [TestMethod]
        public void TestProcreate06()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5576,-3334.1642610208582), result);
        }

        [TestMethod]
        public void TestProcreate07()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5577,-3676.91841160557), result);
        }

        [TestMethod]
        public void TestProcreate08()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5578,-3834.3270046485977), result);
        }

        [TestMethod]
        public void TestProcreate09()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5579,-3767.3960453660325), result);
        }

        [TestMethod]
        public void TestProcreate10()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5580,-3740.4208648471354), result);
        }

        [TestMethod]
        public void TestProcreate11()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5581,-3550.653161323891), result);
        }

        [TestMethod]
        public void TestProcreate12()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5582,-3802.494569279937), result);
        }

        [TestMethod]
        public void TestProcreate13()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5583,-3819.18015419889), result);
        }

        [TestMethod]
        public void TestProcreate14()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5584,-3743.7449878515736), result);
        }

        [TestMethod]
        public void TestProcreate15()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5585,-3636.544638557417), result);
        }

        [TestMethod]
        public void TestProcreate16()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5586,-3626.0769164736985), result);
        }

        [TestMethod]
        public void TestProcreate17()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5587,-4202.999980334416), result);
        }

        [TestMethod]
        public void TestProcreate18()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5588,-2927.7956452766057), result);
        }

        [TestMethod]
        public void TestProcreate19()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5589,-3375.9270467698193), result);
        }

        [TestMethod]
        public void TestProcreate20()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5590,-3951.821904923824), result);
        }

        [TestMethod]
        public void TestProcreate21()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5591,-3674.8825826256852), result);
        }

        [TestMethod]
        public void TestProcreate22()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5592,-3855.912002346547), result);
        }

        [TestMethod]
        public void TestProcreate23()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5593,-4117.914132187205), result);
        }

        [TestMethod]
        public void TestProcreate24()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5594,-3615.0208988153054), result);
        }

        [TestMethod]
        public void TestProcreate25()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5595,-4033.324632191552), result);
        }

        [TestMethod]
        public void TestProcreate26()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5596,-3836.1116053087057), result);
        }

        [TestMethod]
        public void TestProcreate27()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5597,-3994.214190826742), result);
        }

        [TestMethod]
        public void TestProcreate28()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5598,-4116.799602198566), result);
        }

        [TestMethod]
        public void TestProcreate29()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5599,-3637.6265509574605), result);
        }

        [TestMethod]
        public void TestProcreate30()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5600,-3874.6149178149144), result);
        }

        [TestMethod]
        public void TestProcreate31()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5601,-3581.8020598327566), result);
        }

        [TestMethod]
        public void TestProcreate32()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5602,-3725.6013765827793), result);
        }

        [TestMethod]
        public void TestProcreate33()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5603,-3272.47845515056), result);
        }

        [TestMethod]
        public void TestProcreate34()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5604,-3589.9673767942054), result);
        }

        [TestMethod]
        public void TestProcreate35()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5605,-3136.7931919882794), result);
        }

        [TestMethod]
        public void TestProcreate36()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5606,-4004.1465290327037), result);
        }

        [TestMethod]
        public void TestProcreate37()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5607,-4174.191805981744), result);
        }

        [TestMethod]
        public void TestProcreate38()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5608,-3239.464470026659), result);
        }

        [TestMethod]
        public void TestProcreate39()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5609,-4077.671081527163), result);
        }

        [TestMethod]
        public void TestProcreate40()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5610,-3711.188581432146), result);
        }

        [TestMethod]
        public void TestProcreate41()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5611,-3951.7028871354382), result);
        }

        [TestMethod]
        public void TestProcreate42()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5612,-3372.5341899625046), result);
        }

        [TestMethod]
        public void TestProcreate43()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5613,-4234.841609597067), result);
        }

        [TestMethod]
        public void TestProcreate44()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5614,-3961.9546103258344), result);
        }

        [TestMethod]
        public void TestProcreate45()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5615,-4160.757370693635), result);
        }

        [TestMethod]
        public void TestProcreate46()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5616,-3434.5318519684984), result);
        }

        [TestMethod]
        public void TestProcreate47()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5617,-3361.4683172765), result);
        }

        [TestMethod]
        public void TestProcreate48()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5618,-3393.4622832008467), result);
        }

        [TestMethod]
        public void TestProcreate49()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5619,-3632.7826230439564), result);
        }

        [TestMethod]
        public void TestProcreate50()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5620,-4248.9663577209985), result);
        }

        [TestMethod]
        public void TestProcreate51()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5621,-3298.9493193162575), result);
        }

        [TestMethod]
        public void TestProcreate52()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5622,-3550.720117818482), result);
        }

        [TestMethod]
        public void TestProcreate53()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5623,-3324.5022586380474), result);
        }

        [TestMethod]
        public void TestProcreate54()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5624,-3876.441685279331), result);
        }

        [TestMethod]
        public void TestProcreate55()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5625,-4156.272467266336), result);
        }

        [TestMethod]
        public void TestProcreate56()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5626,-3490.0778412733657), result);
        }

        [TestMethod]
        public void TestProcreate57()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5627,-3960.585214106583), result);
        }

        [TestMethod]
        public void TestProcreate58()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5628,-3050.626231239329), result);
        }

        [TestMethod]
        public void TestProcreate59()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5629,-3774.8419662058127), result);
        }

        [TestMethod]
        public void TestProcreate60()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5630,-3721.316407466423), result);
        }

        [TestMethod]
        public void TestProcreate61()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5631,-3408.4441063303734), result);
        }

        [TestMethod]
        public void TestProcreate62()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5632,-3881.496894572245), result);
        }

        [TestMethod]
        public void TestProcreate63()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5633,-4003.9946461563713), result);
        }

        [TestMethod]
        public void TestProcreate64()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5634,-3429.825322538015), result);
        }

        [TestMethod]
        public void TestProcreate65()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5635,-3945.3158985839113), result);
        }

        [TestMethod]
        public void TestProcreate66()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5636,-3660.4985184160787), result);
        }

        [TestMethod]
        public void TestProcreate67()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5637,-4165.963770276487), result);
        }

        [TestMethod]
        public void TestProcreate68()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5638,-3378.7468390810627), result);
        }

        [TestMethod]
        public void TestProcreate69()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5639,-3482.0079746203587), result);
        }

        [TestMethod]
        public void TestProcreate70()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5640,-4153.202874787264), result);
        }

        [TestMethod]
        public void TestProcreate71()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5641,-3903.78202906267), result);
        }

        [TestMethod]
        public void TestProcreate72()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5642,-4202.609806980721), result);
        }

        [TestMethod]
        public void TestProcreate73()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5643,-3316.03552656596), result);
        }

        [TestMethod]
        public void TestProcreate74()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5644,-3951.534516384026), result);
        }

        [TestMethod]
        public void TestProcreate75()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5645,-4013.4545557695265), result);
        }

        [TestMethod]
        public void TestProcreate76()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5646,-3225.930516661587), result);
        }

        [TestMethod]
        public void TestProcreate77()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5647,-3783.322255512985), result);
        }

        [TestMethod]
        public void TestProcreate78()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5648,-3228.725542952114), result);
        }

        [TestMethod]
        public void TestProcreate79()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5649,-3434.3098520609683), result);
        }

        [TestMethod]
        public void TestProcreate80()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5650,-4035.0925457047074), result);
        }

        [TestMethod]
        public void TestProcreate81()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5651,-3674.8825826256852), result);
        }

        [TestMethod]
        public void TestProcreate82()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5652,-4317.728081034705), result);
        }

        [TestMethod]
        public void TestProcreate83()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5653,-3720.0454862469933), result);
        }

        [TestMethod]
        public void TestProcreate84()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5654,-3262.2963497715837), result);
        }

        [TestMethod]
        public void TestProcreate85()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5655,-3915.867299608913), result);
        }

        [TestMethod]
        public void TestProcreate86()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5656,-3799.877080312456), result);
        }

        [TestMethod]
        public void TestProcreate87()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5657,-3852.8644240168073), result);
        }

        [TestMethod]
        public void TestProcreate88()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5658,-4057.515221905365), result);
        }

        [TestMethod]
        public void TestProcreate89()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5659,-4018.3824928993627), result);
        }

        [TestMethod]
        public void TestProcreate90()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5660,-2990.4041666452626), result);
        }

        [TestMethod]
        public void TestProcreate91()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5661,-3575.8089926793346), result);
        }

        [TestMethod]
        public void TestProcreate92()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5662,-3689.0574736106028), result);
        }

        [TestMethod]
        public void TestProcreate93()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5663,-4301.616318969938), result);
        }

        [TestMethod]
        public void TestProcreate94()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5664,-3609.3536705589822), result);
        }

        [TestMethod]
        public void TestProcreate95()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5665,-4216.492755887659), result);
        }

        [TestMethod]
        public void TestProcreate96()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5666,-3589.3882489736466), result);
        }

        [TestMethod]
        public void TestProcreate97()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5667,-4783.431839229416), result);
        }

        [TestMethod]
        public void TestProcreate98()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5668,-3504.195045680656), result);
        }

        [TestMethod]
        public void TestProcreate99()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5669,-3951.7648706963364), result);
        }

        [TestMethod]
        public void TestProcreate100()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5670,-3868.0587745965895), result);
        }

        [TestMethod]
        public void TestProcreate101()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5671,-4320.354428603567), result);
        }

        [TestMethod]
        public void TestProcreate102()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5672,-3367.051407629086), result);
        }

        [TestMethod]
        public void TestProcreate103()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5673,-4153.239037614689), result);
        }

        [TestMethod]
        public void TestProcreate104()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5674,-3373.4572451889326), result);
        }

        [TestMethod]
        public void TestProcreate105()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5675,-3696.145662729422), result);
        }

        [TestMethod]
        public void TestProcreate106()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5676,-3334.1642610208582), result);
        }

        [TestMethod]
        public void TestProcreate107()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5677,-4330.506721112122), result);
        }

        [TestMethod]
        public void TestProcreate108()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5678,-4133.3154465164425), result);
        }

        [TestMethod]
        public void TestProcreate109()
        {
            var result = RandomMonad.evaluateWith(new System.Random(10), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5679,-3718.321760117984), result);
        }

        [TestMethod]
        public void TestProcreate110()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5680,-4128.672915435703), result);
        }

        [TestMethod]
        public void TestProcreate111()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5681,-3852.9114957267766), result);
        }

        [TestMethod]
        public void TestProcreate112()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5682,-3689.0574736106028), result);
        }

        [TestMethod]
        public void TestProcreate113()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5683,-4160.855894611294), result);
        }

        [TestMethod]
        public void TestProcreate114()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5684,-3285.2154260873267), result);
        }

        [TestMethod]
        public void TestProcreate115()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5685,-4033.324632191552), result);
        }

        [TestMethod]
        public void TestProcreate116()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5686,-3589.3882489736466), result);
        }

        [TestMethod]
        public void TestProcreate117()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5687,-3808.189155472278), result);
        }

        [TestMethod]
        public void TestProcreate118()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5688,-3644.8135961849753), result);
        }

        [TestMethod]
        public void TestProcreate119()
        {
            var result = RandomMonad.evaluateWith(new System.Random(11), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5689,-3951.7648706963364), result);
        }

        [TestMethod]
        public void TestProcreate120()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5690,-4035.2996688464436), result);
        }

        [TestMethod]
        public void TestProcreate121()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5691,-3858.632377724186), result);
        }

        [TestMethod]
        public void TestProcreate122()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5692,-4056.9428156659014), result);
        }

        [TestMethod]
        public void TestProcreate123()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5693,-3496.9925614749804), result);
        }

        [TestMethod]
        public void TestProcreate124()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5694,-3648.3550789938477), result);
        }

        [TestMethod]
        public void TestProcreate125()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5695,-4278.747865086934), result);
        }

        [TestMethod]
        public void TestProcreate126()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5696,-3904.3913999442725), result);
        }

        [TestMethod]
        public void TestProcreate127()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5697,-4496.448929657333), result);
        }

        [TestMethod]
        public void TestProcreate128()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5698,-3628.9513246572474), result);
        }

        [TestMethod]
        public void TestProcreate129()
        {
            var result = RandomMonad.evaluateWith(new System.Random(12), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5699,-3894.3751568358475), result);
        }

        [TestMethod]
        public void TestProcreate130()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5700,-4281.465487003345), result);
        }

        [TestMethod]
        public void TestProcreate131()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5701,-3534.431349846838), result);
        }

        [TestMethod]
        public void TestProcreate132()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5702,-4223.148868493842), result);
        }

        [TestMethod]
        public void TestProcreate133()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5703,-3696.2768305561763), result);
        }

        [TestMethod]
        public void TestProcreate134()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5704,-4014.792193891607), result);
        }

        [TestMethod]
        public void TestProcreate135()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5705,-3884.544299001644), result);
        }

        [TestMethod]
        public void TestProcreate136()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5706,-3628.332700987491), result);
        }

        [TestMethod]
        public void TestProcreate137()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5707,-4165.963770276487), result);
        }

        [TestMethod]
        public void TestProcreate138()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5708,-2885.5714466233594), result);
        }

        [TestMethod]
        public void TestProcreate139()
        {
            var result = RandomMonad.evaluateWith(new System.Random(13), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5709,-3803.6767446103945), result);
        }

        [TestMethod]
        public void TestProcreate140()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5710,-4676.410874214457), result);
        }

        [TestMethod]
        public void TestProcreate141()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5711,-4461.327505369124), result);
        }

        [TestMethod]
        public void TestProcreate142()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5712,-3988.831139431121), result);
        }

        [TestMethod]
        public void TestProcreate143()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5713,-4126.563921399904), result);
        }

        [TestMethod]
        public void TestProcreate144()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5714,-3259.8552558065094), result);
        }

        [TestMethod]
        public void TestProcreate145()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5715,-3627.52878924599), result);
        }

        [TestMethod]
        public void TestProcreate146()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5716,-3766.1383335830624), result);
        }

        [TestMethod]
        public void TestProcreate147()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5717,-4185.495208057629), result);
        }

        [TestMethod]
        public void TestProcreate148()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5718,-3433.1047324622136), result);
        }

        [TestMethod]
        public void TestProcreate149()
        {
            var result = RandomMonad.evaluateWith(new System.Random(14), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5719,-3898.3567026273527), result);
        }

        [TestMethod]
        public void TestProcreate150()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5720,-4151.6709377826655), result);
        }

        [TestMethod]
        public void TestProcreate151()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5721,-3298.9493193162575), result);
        }

        [TestMethod]
        public void TestProcreate152()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5722,-4025.551042140282), result);
        }

        [TestMethod]
        public void TestProcreate153()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5723,-3324.5022586380474), result);
        }

        [TestMethod]
        public void TestProcreate154()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5724,-3429.825322538015), result);
        }

        [TestMethod]
        public void TestProcreate155()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5725,-4156.272467266336), result);
        }

        [TestMethod]
        public void TestProcreate156()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5726,-3490.0778412733657), result);
        }

        [TestMethod]
        public void TestProcreate157()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5727,-4213.209567935317), result);
        }

        [TestMethod]
        public void TestProcreate158()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5728,-3050.626231239329), result);
        }

        [TestMethod]
        public void TestProcreate159()
        {
            var result = RandomMonad.evaluateWith(new System.Random(15), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5729,-3683.143297897421), result);
        }

        [TestMethod]
        public void TestProcreate160()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5730,-4003.1288356291197), result);
        }

        [TestMethod]
        public void TestProcreate161()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5731,-2671.1597898029668), result);
        }

        [TestMethod]
        public void TestProcreate162()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5732,-3664.149184731466), result);
        }

        [TestMethod]
        public void TestProcreate163()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5733,-4301.224761507009), result);
        }

        [TestMethod]
        public void TestProcreate164()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5734,-3556.184238568299), result);
        }

        [TestMethod]
        public void TestProcreate165()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5735,-4158.262455197329), result);
        }

        [TestMethod]
        public void TestProcreate166()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5736,-3325.667992642501), result);
        }

        [TestMethod]
        public void TestProcreate167()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5737,-3898.371408054822), result);
        }

        [TestMethod]
        public void TestProcreate168()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5738,-3526.581559525909), result);
        }

        [TestMethod]
        public void TestProcreate169()
        {
            var result = RandomMonad.evaluateWith(new System.Random(16), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5739,-3786.542786038059), result);
        }

        [TestMethod]
        public void TestProcreate170()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5740,-3490.1978334807836), result);
        }

        [TestMethod]
        public void TestProcreate171()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5741,-4009.6377609331585), result);
        }

        [TestMethod]
        public void TestProcreate172()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5742,-3776.9729131344575), result);
        }

        [TestMethod]
        public void TestProcreate173()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5743,-4003.9946461563713), result);
        }

        [TestMethod]
        public void TestProcreate174()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5744,-3745.526948432362), result);
        }

        [TestMethod]
        public void TestProcreate175()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5745,-3945.3158985839113), result);
        }

        [TestMethod]
        public void TestProcreate176()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5746,-4187.295718813082), result);
        }

        [TestMethod]
        public void TestProcreate177()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5747,-3852.2122535775106), result);
        }

        [TestMethod]
        public void TestProcreate178()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5748,-3433.737121205706), result);
        }

        [TestMethod]
        public void TestProcreate179()
        {
            var result = RandomMonad.evaluateWith(new System.Random(17), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5749,-3482.0079746203587), result);
        }

        [TestMethod]
        public void TestProcreate180()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5750,-4156.086477091974), result);
        }

        [TestMethod]
        public void TestProcreate181()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5751,-3925.7153602007), result);
        }

        [TestMethod]
        public void TestProcreate182()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5752,-3862.681946744531), result);
        }

        [TestMethod]
        public void TestProcreate183()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5753,-3856.9577413464635), result);
        }

        [TestMethod]
        public void TestProcreate184()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5754,-3763.089626330093), result);
        }

        [TestMethod]
        public void TestProcreate185()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5755,-4259.448320713872), result);
        }

        [TestMethod]
        public void TestProcreate186()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5756,-3414.4523090591247), result);
        }

        [TestMethod]
        public void TestProcreate187()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5757,-3469.4149777494404), result);
        }

        [TestMethod]
        public void TestProcreate188()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5758,-3343.218063882742), result);
        }

        [TestMethod]
        public void TestProcreate189()
        {
            var result = RandomMonad.evaluateWith(new System.Random(18), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5759,-3360.685844196386), result);
        }

        [TestMethod]
        public void TestProcreate190()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5760,-3490.1978334807836), result);
        }

        [TestMethod]
        public void TestProcreate191()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5761,-3758.6304254185397), result);
        }

        [TestMethod]
        public void TestProcreate192()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5762,-3776.9729131344575), result);
        }

        [TestMethod]
        public void TestProcreate193()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5763,-3635.769440086157), result);
        }

        [TestMethod]
        public void TestProcreate194()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5764,-4041.6482442188376), result);
        }

        [TestMethod]
        public void TestProcreate195()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5765,-4208.314957687042), result);
        }

        [TestMethod]
        public void TestProcreate196()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5766,-3482.496193517313), result);
        }

        [TestMethod]
        public void TestProcreate197()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5767,-3852.2122535775106), result);
        }

        [TestMethod]
        public void TestProcreate198()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5768,-4324.3547632790805), result);
        }

        [TestMethod]
        public void TestProcreate199()
        {
            var result = RandomMonad.evaluateWith(new System.Random(19), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5769,-3540.848540259409), result);
        }

        [TestMethod]
        public void TestProcreate200()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5770,-3915.7149544243575), result);
        }

        [TestMethod]
        public void TestProcreate201()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5771,-3605.5143675256445), result);
        }

        [TestMethod]
        public void TestProcreate202()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5772,-3790.2572960023017), result);
        }

        [TestMethod]
        public void TestProcreate203()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5773,-4225.937378954471), result);
        }

        [TestMethod]
        public void TestProcreate204()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5774,-4231.3259314648285), result);
        }

        [TestMethod]
        public void TestProcreate205()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5775,-4017.139147611344), result);
        }

        [TestMethod]
        public void TestProcreate206()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5776,-3149.9487715290807), result);
        }

        [TestMethod]
        public void TestProcreate207()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5777,-3938.15495729735), result);
        }

        [TestMethod]
        public void TestProcreate208()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5778,-3321.680003476079), result);
        }

        [TestMethod]
        public void TestProcreate209()
        {
            var result = RandomMonad.evaluateWith(new System.Random(20), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5779,-3671.016381606564), result);
        }

        [TestMethod]
        public void TestProcreate210()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5780,-3109.5070285513925), result);
        }

        [TestMethod]
        public void TestProcreate211()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5781,-3821.9334472479563), result);
        }

        [TestMethod]
        public void TestProcreate212()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5782,-3497.2238376933597), result);
        }

        [TestMethod]
        public void TestProcreate213()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5783,-4153.239037614689), result);
        }

        [TestMethod]
        public void TestProcreate214()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5784,-3046.150705144801), result);
        }

        [TestMethod]
        public void TestProcreate215()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5785,-4389.787789292437), result);
        }

        [TestMethod]
        public void TestProcreate216()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5786,-3620.080677866796), result);
        }

        [TestMethod]
        public void TestProcreate217()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5787,-4111.153751609349), result);
        }

        [TestMethod]
        public void TestProcreate218()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5788,-4107.32749954601), result);
        }

        [TestMethod]
        public void TestProcreate219()
        {
            var result = RandomMonad.evaluateWith(new System.Random(21), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5789,-4311.614617847532), result);
        }

        [TestMethod]
        public void TestProcreate220()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5790,-3676.8400134608655), result);
        }

        [TestMethod]
        public void TestProcreate221()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5791,-3298.9493193162575), result);
        }

        [TestMethod]
        public void TestProcreate222()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5792,-3550.720117818482), result);
        }

        [TestMethod]
        public void TestProcreate223()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5793,-3324.5022586380474), result);
        }

        [TestMethod]
        public void TestProcreate224()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5794,-3385.3356178513577), result);
        }

        [TestMethod]
        public void TestProcreate225()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5795,-4156.272467266336), result);
        }

        [TestMethod]
        public void TestProcreate226()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5796,-3490.0778412733657), result);
        }

        [TestMethod]
        public void TestProcreate227()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5797,-3959.496205083781), result);
        }

        [TestMethod]
        public void TestProcreate228()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5798,-3050.626231239329), result);
        }

        [TestMethod]
        public void TestProcreate229()
        {
            var result = RandomMonad.evaluateWith(new System.Random(22), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5799,-3741.4959226244064), result);
        }

        [TestMethod]
        public void TestProcreate230()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5800,-4164.494573727639), result);
        }

        [TestMethod]
        public void TestProcreate231()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5801,-4143.100190005342), result);
        }

        [TestMethod]
        public void TestProcreate232()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5802,-3306.9059347601883), result);
        }

        [TestMethod]
        public void TestProcreate233()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5803,-4422.318590400082), result);
        }

        [TestMethod]
        public void TestProcreate234()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5804,-3227.821666171222), result);
        }

        [TestMethod]
        public void TestProcreate235()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5805,-3733.4922604209078), result);
        }

        [TestMethod]
        public void TestProcreate236()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5806,-3346.395103988109), result);
        }

        [TestMethod]
        public void TestProcreate237()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5807,-3695.0882446034034), result);
        }

        [TestMethod]
        public void TestProcreate238()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5808,-3748.38812582479), result);
        }

        [TestMethod]
        public void TestProcreate239()
        {
            var result = RandomMonad.evaluateWith(new System.Random(23), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5809,-3359.7360744244997), result);
        }

        [TestMethod]
        public void TestProcreate240()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5810,-4425.030954925775), result);
        }

        [TestMethod]
        public void TestProcreate241()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5811,-3897.721709067775), result);
        }

        [TestMethod]
        public void TestProcreate242()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5812,-4240.718166958029), result);
        }

        [TestMethod]
        public void TestProcreate243()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5813,-4397.819230408185), result);
        }

        [TestMethod]
        public void TestProcreate244()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5814,-3429.825322538015), result);
        }

        [TestMethod]
        public void TestProcreate245()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5815,-4208.314957687042), result);
        }

        [TestMethod]
        public void TestProcreate246()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5816,-3440.4609358744115), result);
        }

        [TestMethod]
        public void TestProcreate247()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5817,-3852.2122535775106), result);
        }

        [TestMethod]
        public void TestProcreate248()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5818,-3867.687146597979), result);
        }

        [TestMethod]
        public void TestProcreate249()
        {
            var result = RandomMonad.evaluateWith(new System.Random(24), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5819,-3721.3277532762754), result);
        }

        [TestMethod]
        public void TestProcreate250()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5820,-3998.9459089105644), result);
        }

        [TestMethod]
        public void TestProcreate251()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5821,-3946.6041065619165), result);
        }

        [TestMethod]
        public void TestProcreate252()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5822,-3823.039464170224), result);
        }

        [TestMethod]
        public void TestProcreate253()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5823,-3989.6338667421514), result);
        }

        [TestMethod]
        public void TestProcreate254()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5824,-3831.3250193172353), result);
        }

        [TestMethod]
        public void TestProcreate255()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5825,-4430.012360068374), result);
        }

        [TestMethod]
        public void TestProcreate256()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5826,-3621.1530564937443), result);
        }

        [TestMethod]
        public void TestProcreate257()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5827,-3837.340778541998), result);
        }

        [TestMethod]
        public void TestProcreate258()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5828,-4119.773367373652), result);
        }

        [TestMethod]
        public void TestProcreate259()
        {
            var result = RandomMonad.evaluateWith(new System.Random(25), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5829,-3786.061127896983), result);
        }

        [TestMethod]
        public void TestProcreate260()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5830,-3975.351765085832), result);
        }

        [TestMethod]
        public void TestProcreate261()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5831,-3534.431349846838), result);
        }

        [TestMethod]
        public void TestProcreate262()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5832,-3689.0574736106028), result);
        }

        [TestMethod]
        public void TestProcreate263()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5833,-3520.484105025386), result);
        }

        [TestMethod]
        public void TestProcreate264()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5834,-4333.757764501626), result);
        }

        [TestMethod]
        public void TestProcreate265()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5835,-4479.778891613835), result);
        }

        [TestMethod]
        public void TestProcreate266()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5836,-3589.3882489736466), result);
        }

        [TestMethod]
        public void TestProcreate267()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5837,-4114.624336532248), result);
        }

        [TestMethod]
        public void TestProcreate268()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5838,-3930.4247212764526), result);
        }

        [TestMethod]
        public void TestProcreate269()
        {
            var result = RandomMonad.evaluateWith(new System.Random(26), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5839,-3815.6831034433126), result);
        }

        [TestMethod]
        public void TestProcreate270()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5840,-3748.6739319880207), result);
        }

        [TestMethod]
        public void TestProcreate271()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5841,-3778.0546872946893), result);
        }

        [TestMethod]
        public void TestProcreate272()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5842,-4010.5662869925004), result);
        }

        [TestMethod]
        public void TestProcreate273()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5843,-3452.004302658038), result);
        }

        [TestMethod]
        public void TestProcreate274()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5844,-3821.7260231941323), result);
        }

        [TestMethod]
        public void TestProcreate275()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5845,-4013.4545557695265), result);
        }

        [TestMethod]
        public void TestProcreate276()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5846,-3072.757241721296), result);
        }

        [TestMethod]
        public void TestProcreate277()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5847,-3783.322255512985), result);
        }

        [TestMethod]
        public void TestProcreate278()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5848,-3526.971377388363), result);
        }

        [TestMethod]
        public void TestProcreate279()
        {
            var result = RandomMonad.evaluateWith(new System.Random(27), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5849,-3754.615134800175), result);
        }

        [TestMethod]
        public void TestProcreate280()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5850,-4470.679769865309), result);
        }

        [TestMethod]
        public void TestProcreate281()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5851,-3819.7618822628865), result);
        }

        [TestMethod]
        public void TestProcreate282()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5852,-3796.17174426678), result);
        }

        [TestMethod]
        public void TestProcreate283()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5853,-3548.416963814609), result);
        }

        [TestMethod]
        public void TestProcreate284()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5854,-3414.8532041299472), result);
        }

        [TestMethod]
        public void TestProcreate285()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5855,-4363.074748863453), result);
        }

        [TestMethod]
        public void TestProcreate286()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5856,-3636.99865702012), result);
        }

        [TestMethod]
        public void TestProcreate287()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5857,-3714.3703398447597), result);
        }

        [TestMethod]
        public void TestProcreate288()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5858,-3885.1352879924084), result);
        }

        [TestMethod]
        public void TestProcreate289()
        {
            var result = RandomMonad.evaluateWith(new System.Random(28), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5859,-3623.4993566465805), result);
        }

        [TestMethod]
        public void TestProcreate290()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5860,-3883.9930785647057), result);
        }

        [TestMethod]
        public void TestProcreate291()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5861,-3075.636694507708), result);
        }

        [TestMethod]
        public void TestProcreate292()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5862,-3839.4750176620823), result);
        }

        [TestMethod]
        public void TestProcreate293()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5863,-3316.03552656596), result);
        }

        [TestMethod]
        public void TestProcreate294()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5864,-3951.534516384026), result);
        }

        [TestMethod]
        public void TestProcreate295()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5865,-4203.588069917348), result);
        }

        [TestMethod]
        public void TestProcreate296()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5866,-3830.4403446497863), result);
        }

        [TestMethod]
        public void TestProcreate297()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5867,-3493.918353816145), result);
        }

        [TestMethod]
        public void TestProcreate298()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5868,-3228.725542952114), result);
        }

        [TestMethod]
        public void TestProcreate299()
        {
            var result = RandomMonad.evaluateWith(new System.Random(29), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5869,-3753.3641778236515), result);
        }

        [TestMethod]
        public void TestProcreate300()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5870,-3851.8998372225924), result);
        }

        [TestMethod]
        public void TestProcreate301()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5871,-3798.624531566846), result);
        }

        [TestMethod]
        public void TestProcreate302()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5872,-3327.38485441947), result);
        }

        [TestMethod]
        public void TestProcreate303()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5873,-3632.3449254280276), result);
        }

        [TestMethod]
        public void TestProcreate304()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5874,-4333.757764501626), result);
        }

        [TestMethod]
        public void TestProcreate305()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5875,-4013.7983287250104), result);
        }

        [TestMethod]
        public void TestProcreate306()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5876,-3669.0754919538863), result);
        }

        [TestMethod]
        public void TestProcreate307()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5877,-4288.517006581556), result);
        }

        [TestMethod]
        public void TestProcreate308()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5878,-4362.88730766427), result);
        }

        [TestMethod]
        public void TestProcreate309()
        {
            var result = RandomMonad.evaluateWith(new System.Random(30), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5879,-4153.710790424803), result);
        }

        [TestMethod]
        public void TestProcreate310()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5880,-3060.8920828791306), result);
        }

        [TestMethod]
        public void TestProcreate311()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5881,-4081.9906049141064), result);
        }

        [TestMethod]
        public void TestProcreate312()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5882,-3076.1952234452087), result);
        }

        [TestMethod]
        public void TestProcreate313()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5883,-4083.3319101944894), result);
        }

        [TestMethod]
        public void TestProcreate314()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5884,-3205.9165115173287), result);
        }

        [TestMethod]
        public void TestProcreate315()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5885,-4321.144008332974), result);
        }

        [TestMethod]
        public void TestProcreate316()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5886,-3377.9841868702547), result);
        }

        [TestMethod]
        public void TestProcreate317()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5887,-4044.5681478498313), result);
        }

        [TestMethod]
        public void TestProcreate318()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5888,-4060.7551147145577), result);
        }

        [TestMethod]
        public void TestProcreate319()
        {
            var result = RandomMonad.evaluateWith(new System.Random(31), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5889,-3599.1090265861176), result);
        }

        [TestMethod]
        public void TestProcreate320()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5890,-3860.026308983918), result);
        }

        [TestMethod]
        public void TestProcreate321()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5891,-3036.386710204603), result);
        }

        [TestMethod]
        public void TestProcreate322()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5892,-3329.9225853088933), result);
        }

        [TestMethod]
        public void TestProcreate323()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5893,-3239.6900210644685), result);
        }

        [TestMethod]
        public void TestProcreate324()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5894,-3876.441685279331), result);
        }

        [TestMethod]
        public void TestProcreate325()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5895,-3899.830774283593), result);
        }

        [TestMethod]
        public void TestProcreate326()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5896,-3714.3737494588204), result);
        }

        [TestMethod]
        public void TestProcreate327()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5897,-4645.713595889785), result);
        }

        [TestMethod]
        public void TestProcreate328()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5898,-3621.487714258503), result);
        }

        [TestMethod]
        public void TestProcreate329()
        {
            var result = RandomMonad.evaluateWith(new System.Random(32), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5899,-3563.9103792657847), result);
        }

        [TestMethod]
        public void TestProcreate330()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5900,-3820.501406441839), result);
        }

        [TestMethod]
        public void TestProcreate331()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5901,-4060.30841494654), result);
        }

        [TestMethod]
        public void TestProcreate332()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5902,-3776.9729131344575), result);
        }

        [TestMethod]
        public void TestProcreate333()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5903,-4100.097042291935), result);
        }

        [TestMethod]
        public void TestProcreate334()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5904,-4319.549343334786), result);
        }

        [TestMethod]
        public void TestProcreate335()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5905,-3790.8485171030115), result);
        }

        [TestMethod]
        public void TestProcreate336()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5906,-4352.7906659960945), result);
        }

        [TestMethod]
        public void TestProcreate337()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5907,-4071.884861197075), result);
        }

        [TestMethod]
        public void TestProcreate338()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5908,-3727.1690201992405), result);
        }

        [TestMethod]
        public void TestProcreate339()
        {
            var result = RandomMonad.evaluateWith(new System.Random(33), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5909,-3685.0906911637253), result);
        }

        [TestMethod]
        public void TestProcreate340()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5910,-4417.7872934027655), result);
        }

        [TestMethod]
        public void TestProcreate341()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5911,-3730.9167246421744), result);
        }

        [TestMethod]
        public void TestProcreate342()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5912,-3301.8939408470883), result);
        }

        [TestMethod]
        public void TestProcreate343()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5913,-3997.6436024051663), result);
        }

        [TestMethod]
        public void TestProcreate344()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5914,-3862.3963453592846), result);
        }

        [TestMethod]
        public void TestProcreate345()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5915,-4555.230179807072), result);
        }

        [TestMethod]
        public void TestProcreate346()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5916,-3764.287605027046), result);
        }

        [TestMethod]
        public void TestProcreate347()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5917,-4599.619349689607), result);
        }

        [TestMethod]
        public void TestProcreate348()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5918,-3681.9749089544057), result);
        }

        [TestMethod]
        public void TestProcreate349()
        {
            var result = RandomMonad.evaluateWith(new System.Random(34), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5919,-4037.3216179026276), result);
        }

        [TestMethod]
        public void TestProcreate350()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5920,-3325.5085683212774), result);
        }

        [TestMethod]
        public void TestProcreate351()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5921,-3320.765094100461), result);
        }

        [TestMethod]
        public void TestProcreate352()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5922,-4561.440646069779), result);
        }

        [TestMethod]
        public void TestProcreate353()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5923,-3318.319003665225), result);
        }

        [TestMethod]
        public void TestProcreate354()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5924,-3816.496389755491), result);
        }

        [TestMethod]
        public void TestProcreate355()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5925,-3349.271864681964), result);
        }

        [TestMethod]
        public void TestProcreate356()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5926,-4168.165361232195), result);
        }

        [TestMethod]
        public void TestProcreate357()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5927,-3912.050866327193), result);
        }

        [TestMethod]
        public void TestProcreate358()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5928,-3107.4539593674826), result);
        }

        [TestMethod]
        public void TestProcreate359()
        {
            var result = RandomMonad.evaluateWith(new System.Random(35), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5929,-3643.5849283726193), result);
        }

        [TestMethod]
        public void TestProcreate360()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5930,-3620.879753766576), result);
        }

        [TestMethod]
        public void TestProcreate361()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5931,-3597.113002190516), result);
        }

        [TestMethod]
        public void TestProcreate362()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5932,-3830.565721319992), result);
        }

        [TestMethod]
        public void TestProcreate363()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5933,-3536.8227053839064), result);
        }

        [TestMethod]
        public void TestProcreate364()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5934,-3826.5904309050884), result);
        }

        [TestMethod]
        public void TestProcreate365()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5935,-3947.4864495872193), result);
        }

        [TestMethod]
        public void TestProcreate366()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5936,-3441.874863806807), result);
        }

        [TestMethod]
        public void TestProcreate367()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5937,-3413.6939395679965), result);
        }

        [TestMethod]
        public void TestProcreate368()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5938,-3948.6597889442764), result);
        }

        [TestMethod]
        public void TestProcreate369()
        {
            var result = RandomMonad.evaluateWith(new System.Random(36), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5939,-3054.7391884471554), result);
        }

        [TestMethod]
        public void TestProcreate370()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5940,-3490.1978334807836), result);
        }

        [TestMethod]
        public void TestProcreate371()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5941,-3824.785986720627), result);
        }

        [TestMethod]
        public void TestProcreate372()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5942,-3497.2238376933597), result);
        }

        [TestMethod]
        public void TestProcreate373()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5943,-3778.6963303320017), result);
        }

        [TestMethod]
        public void TestProcreate374()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5944,-3210.867978677269), result);
        }

        [TestMethod]
        public void TestProcreate375()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5945,-4208.314957687042), result);
        }

        [TestMethod]
        public void TestProcreate376()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5946,-3992.56549489296), result);
        }

        [TestMethod]
        public void TestProcreate377()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5947,-3852.2122535775106), result);
        }

        [TestMethod]
        public void TestProcreate378()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5948,-3300.7076351373944), result);
        }

        [TestMethod]
        public void TestProcreate379()
        {
            var result = RandomMonad.evaluateWith(new System.Random(37), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5949,-3540.848540259409), result);
        }

        [TestMethod]
        public void TestProcreate380()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5950,-4340.694694161835), result);
        }

        [TestMethod]
        public void TestProcreate381()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5951,-3696.9148330869566), result);
        }

        [TestMethod]
        public void TestProcreate382()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5952,-3850.153570517852), result);
        }

        [TestMethod]
        public void TestProcreate383()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5953,-3238.72196669681), result);
        }

        [TestMethod]
        public void TestProcreate384()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5954,-3638.912021762713), result);
        }

        [TestMethod]
        public void TestProcreate385()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5955,-3845.272264138688), result);
        }

        [TestMethod]
        public void TestProcreate386()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5956,-3495.3072324707955), result);
        }

        [TestMethod]
        public void TestProcreate387()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5957,-4079.2878910637346), result);
        }

        [TestMethod]
        public void TestProcreate388()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5958,-3917.8227574013586), result);
        }

        [TestMethod]
        public void TestProcreate389()
        {
            var result = RandomMonad.evaluateWith(new System.Random(38), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5959,-3860.407888344454), result);
        }

        [TestMethod]
        public void TestProcreate390()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5960,-3718.6050900629316), result);
        }

        [TestMethod]
        public void TestProcreate391()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5961,-3298.9493193162575), result);
        }

        [TestMethod]
        public void TestProcreate392()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5962,-3375.0732325007366), result);
        }

        [TestMethod]
        public void TestProcreate393()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5963,-3915.9690691775486), result);
        }

        [TestMethod]
        public void TestProcreate394()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5964,-3450.2668350803397), result);
        }

        [TestMethod]
        public void TestProcreate395()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5965,-3931.6186014080868), result);
        }

        [TestMethod]
        public void TestProcreate396()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5966,-3680.0630693376947), result);
        }

        [TestMethod]
        public void TestProcreate397()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5967,-3778.762151485695), result);
        }

        [TestMethod]
        public void TestProcreate398()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5968,-3057.566886547248), result);
        }

        [TestMethod]
        public void TestProcreate399()
        {
            var result = RandomMonad.evaluateWith(new System.Random(39), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5969,-3581.9791979190513), result);
        }

        [TestMethod]
        public void TestProcreate400()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5970,-3878.945869061179), result);
        }

        [TestMethod]
        public void TestProcreate401()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5971,-3439.0987418076775), result);
        }

        [TestMethod]
        public void TestProcreate402()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5972,-3681.803109980077), result);
        }

        [TestMethod]
        public void TestProcreate403()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5973,-3461.4729438450017), result);
        }

        [TestMethod]
        public void TestProcreate404()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5974,-3884.681839860882), result);
        }

        [TestMethod]
        public void TestProcreate405()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5975,-3904.961758068568), result);
        }

        [TestMethod]
        public void TestProcreate406()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5976,-2965.557481512016), result);
        }

        [TestMethod]
        public void TestProcreate407()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5977,-4433.3134673852155), result);
        }

        [TestMethod]
        public void TestProcreate408()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5978,-3185.138209209398), result);
        }

        [TestMethod]
        public void TestProcreate409()
        {
            var result = RandomMonad.evaluateWith(new System.Random(40), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5979,-4207.892146546747), result);
        }

        [TestMethod]
        public void TestProcreate410()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5980,-3990.1549885680192), result);
        }

        [TestMethod]
        public void TestProcreate411()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5981,-3979.4691554248593), result);
        }

        [TestMethod]
        public void TestProcreate412()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5982,-3825.1455288451575), result);
        }

        [TestMethod]
        public void TestProcreate413()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5983,-3258.71748562652), result);
        }

        [TestMethod]
        public void TestProcreate414()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5984,-3348.0970453049317), result);
        }

        [TestMethod]
        public void TestProcreate415()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5985,-3223.670753594588), result);
        }

        [TestMethod]
        public void TestProcreate416()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5986,-4403.082487598346), result);
        }

        [TestMethod]
        public void TestProcreate417()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5987,-4202.999980334416), result);
        }

        [TestMethod]
        public void TestProcreate418()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5988,-3416.717501508902), result);
        }

        [TestMethod]
        public void TestProcreate419()
        {
            var result = RandomMonad.evaluateWith(new System.Random(41), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5989,-3012.774981221023), result);
        }

        [TestMethod]
        public void TestProcreate420()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5990,-4046.3385456886185), result);
        }

        [TestMethod]
        public void TestProcreate421()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5991,-3842.9615068349667), result);
        }

        [TestMethod]
        public void TestProcreate422()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5992,-4453.392384251438), result);
        }

        [TestMethod]
        public void TestProcreate423()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5993,-4300.4268733458175), result);
        }

        [TestMethod]
        public void TestProcreate424()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5994,-3348.0970453049317), result);
        }

        [TestMethod]
        public void TestProcreate425()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5995,-4159.2541247212575), result);
        }

        [TestMethod]
        public void TestProcreate426()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5996,-4244.132121023919), result);
        }

        [TestMethod]
        public void TestProcreate427()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5997,-4571.4522010431765), result);
        }

        [TestMethod]
        public void TestProcreate428()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5998,-3610.2027104562567), result);
        }

        [TestMethod]
        public void TestProcreate429()
        {
            var result = RandomMonad.evaluateWith(new System.Random(42), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result5999,-3828.5981849090704), result);
        }

        [TestMethod]
        public void TestProcreate430()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6000,-2834.4310016535906), result);
        }

        [TestMethod]
        public void TestProcreate431()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6001,-3684.305718313478), result);
        }

        [TestMethod]
        public void TestProcreate432()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6002,-3343.578866910435), result);
        }

        [TestMethod]
        public void TestProcreate433()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6003,-4107.543303087026), result);
        }

        [TestMethod]
        public void TestProcreate434()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6004,-3683.959751104504), result);
        }

        [TestMethod]
        public void TestProcreate435()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6005,-4199.711122585619), result);
        }

        [TestMethod]
        public void TestProcreate436()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6006,-3726.6446021092306), result);
        }

        [TestMethod]
        public void TestProcreate437()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6007,-3575.2535600594656), result);
        }

        [TestMethod]
        public void TestProcreate438()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6008,-4172.042685194411), result);
        }

        [TestMethod]
        public void TestProcreate439()
        {
            var result = RandomMonad.evaluateWith(new System.Random(43), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6009,-4517.124921661706), result);
        }

        [TestMethod]
        public void TestProcreate440()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6010,-3742.0097862561324), result);
        }

        [TestMethod]
        public void TestProcreate441()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6011,-4234.106723407558), result);
        }

        [TestMethod]
        public void TestProcreate442()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6012,-4443.383447298479), result);
        }

        [TestMethod]
        public void TestProcreate443()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6013,-4000.4334883240513), result);
        }

        [TestMethod]
        public void TestProcreate444()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6014,-3676.194435912771), result);
        }

        [TestMethod]
        public void TestProcreate445()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6015,-3586.6965576869843), result);
        }

        [TestMethod]
        public void TestProcreate446()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6016,-3513.670452260194), result);
        }

        [TestMethod]
        public void TestProcreate447()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6017,-4252.463832818385), result);
        }

        [TestMethod]
        public void TestProcreate448()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6018,-4505.797008589291), result);
        }

        [TestMethod]
        public void TestProcreate449()
        {
            var result = RandomMonad.evaluateWith(new System.Random(44), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6019,-3436.726125276688), result);
        }

        [TestMethod]
        public void TestProcreate450()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6020,-3676.8400134608655), result);
        }

        [TestMethod]
        public void TestProcreate451()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6021,-3298.9493193162575), result);
        }

        [TestMethod]
        public void TestProcreate452()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6022,-3550.720117818482), result);
        }

        [TestMethod]
        public void TestProcreate453()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6023,-3324.5022586380474), result);
        }

        [TestMethod]
        public void TestProcreate454()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6024,-3841.1886729311573), result);
        }

        [TestMethod]
        public void TestProcreate455()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6025,-4156.272467266336), result);
        }

        [TestMethod]
        public void TestProcreate456()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6026,-3490.0778412733657), result);
        }

        [TestMethod]
        public void TestProcreate457()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6027,-3959.447644877879), result);
        }

        [TestMethod]
        public void TestProcreate458()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6028,-3050.626231239329), result);
        }

        [TestMethod]
        public void TestProcreate459()
        {
            var result = RandomMonad.evaluateWith(new System.Random(45), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6029,-3545.0453885306924), result);
        }

        [TestMethod]
        public void TestProcreate460()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6030,-3528.591485517745), result);
        }

        [TestMethod]
        public void TestProcreate461()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6031,-3534.431349846838), result);
        }

        [TestMethod]
        public void TestProcreate462()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6032,-3264.554736813887), result);
        }

        [TestMethod]
        public void TestProcreate463()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6033,-3520.484105025386), result);
        }

        [TestMethod]
        public void TestProcreate464()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6034,-4175.238249436268), result);
        }

        [TestMethod]
        public void TestProcreate465()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6035,-4354.661539128872), result);
        }

        [TestMethod]
        public void TestProcreate466()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6036,-3205.5971121540315), result);
        }

        [TestMethod]
        public void TestProcreate467()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6037,-4254.766783824145), result);
        }

        [TestMethod]
        public void TestProcreate468()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6038,-3964.38655810401), result);
        }

        [TestMethod]
        public void TestProcreate469()
        {
            var result = RandomMonad.evaluateWith(new System.Random(46), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6039,-3815.6831034433126), result);
        }

        [TestMethod]
        public void TestProcreate470()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6040,-3490.1978334807836), result);
        }

        [TestMethod]
        public void TestProcreate471()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6041,-3778.080836884063), result);
        }

        [TestMethod]
        public void TestProcreate472()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6042,-4139.335348814824), result);
        }

        [TestMethod]
        public void TestProcreate473()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6043,-4093.6182024692453), result);
        }

        [TestMethod]
        public void TestProcreate474()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6044,-3157.087892789123), result);
        }

        [TestMethod]
        public void TestProcreate475()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6045,-3801.0000682016857), result);
        }

        [TestMethod]
        public void TestProcreate476()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6046,-3987.354417557209), result);
        }

        [TestMethod]
        public void TestProcreate477()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6047,-3852.2122535775106), result);
        }

        [TestMethod]
        public void TestProcreate478()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6048,-3623.513534370063), result);
        }

        [TestMethod]
        public void TestProcreate479()
        {
            var result = RandomMonad.evaluateWith(new System.Random(47), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6049,-3540.848540259409), result);
        }

        [TestMethod]
        public void TestProcreate480()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6050,-3951.8219049238246), result);
        }

        [TestMethod]
        public void TestProcreate481()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6051,-3657.748522798644), result);
        }

        [TestMethod]
        public void TestProcreate482()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6052,-3913.774683270462), result);
        }

        [TestMethod]
        public void TestProcreate483()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6053,-4003.9946461563713), result);
        }

        [TestMethod]
        public void TestProcreate484()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6054,-3262.2963497715837), result);
        }

        [TestMethod]
        public void TestProcreate485()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6055,-4248.3665703714505), result);
        }

        [TestMethod]
        public void TestProcreate486()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6056,-3799.877080312456), result);
        }

        [TestMethod]
        public void TestProcreate487()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6057,-4165.963770276487), result);
        }

        [TestMethod]
        public void TestProcreate488()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6058,-3378.7468390810627), result);
        }

        [TestMethod]
        public void TestProcreate489()
        {
            var result = RandomMonad.evaluateWith(new System.Random(48), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6059,-3482.0079746203587), result);
        }

        [TestMethod]
        public void TestProcreate490()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6060,-4114.68137415897), result);
        }

        [TestMethod]
        public void TestProcreate491()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6061,-3903.78202906267), result);
        }

        [TestMethod]
        public void TestProcreate492()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6062,-4133.3825371915245), result);
        }

        [TestMethod]
        public void TestProcreate493()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6063,-3316.03552656596), result);
        }

        [TestMethod]
        public void TestProcreate494()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6064,-3621.072724901182), result);
        }

        [TestMethod]
        public void TestProcreate495()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6065,-3843.7521417598987), result);
        }

        [TestMethod]
        public void TestProcreate496()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6066,-3225.930516661587), result);
        }

        [TestMethod]
        public void TestProcreate497()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6067,-3903.8472390498123), result);
        }

        [TestMethod]
        public void TestProcreate498()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6068,-4016.047374826316), result);
        }

        [TestMethod]
        public void TestProcreate499()
        {
            var result = RandomMonad.evaluateWith(new System.Random(49), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6069,-3656.4255071028015), result);
        }

        [TestMethod]
        public void TestProcreate500()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6070,-4099.055977719809), result);
        }

        [TestMethod]
        public void TestProcreate501()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6071,-4411.383746026883), result);
        }

        [TestMethod]
        public void TestProcreate502()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6072,-3598.500803103532), result);
        }

        [TestMethod]
        public void TestProcreate503()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6073,-3734.71995980458), result);
        }

        [TestMethod]
        public void TestProcreate504()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6074,-3883.980542514228), result);
        }

        [TestMethod]
        public void TestProcreate505()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6075,-3790.8485171030115), result);
        }

        [TestMethod]
        public void TestProcreate506()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6076,-3589.3882489736466), result);
        }

        [TestMethod]
        public void TestProcreate507()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6077,-4784.200087551816), result);
        }

        [TestMethod]
        public void TestProcreate508()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6078,-3325.676796454667), result);
        }

        [TestMethod]
        public void TestProcreate509()
        {
            var result = RandomMonad.evaluateWith(new System.Random(50), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6079,-3596.481322840638), result);
        }

        [TestMethod]
        public void TestProcreate510()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6080,-4168.181535926482), result);
        }

        [TestMethod]
        public void TestProcreate511()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6081,-2970.0403767075886), result);
        }

        [TestMethod]
        public void TestProcreate512()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6082,-3216.186739750544), result);
        }

        [TestMethod]
        public void TestProcreate513()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6083,-3884.5426880458826), result);
        }

        [TestMethod]
        public void TestProcreate514()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6084,-3691.6866097281822), result);
        }

        [TestMethod]
        public void TestProcreate515()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6085,-3521.8481466751164), result);
        }

        [TestMethod]
        public void TestProcreate516()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6086,-2738.8905031682903), result);
        }

        [TestMethod]
        public void TestProcreate517()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6087,-4498.998161781805), result);
        }

        [TestMethod]
        public void TestProcreate518()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6088,-4165.230347185063), result);
        }

        [TestMethod]
        public void TestProcreate519()
        {
            var result = RandomMonad.evaluateWith(new System.Random(51), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6089,-3226.6288391682792), result);
        }

        [TestMethod]
        public void TestProcreate520()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6090,-4444.368997449891), result);
        }

        [TestMethod]
        public void TestProcreate521()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6091,-4110.62713537479), result);
        }

        [TestMethod]
        public void TestProcreate522()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6092,-3989.6891237462205), result);
        }

        [TestMethod]
        public void TestProcreate523()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6093,-3937.3294346524085), result);
        }

        [TestMethod]
        public void TestProcreate524()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6094,-3306.3198701162764), result);
        }

        [TestMethod]
        public void TestProcreate525()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6095,-3700.3914180307684), result);
        }

        [TestMethod]
        public void TestProcreate526()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6096,-3642.835281549932), result);
        }

        [TestMethod]
        public void TestProcreate527()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6097,-4055.1246108371133), result);
        }

        [TestMethod]
        public void TestProcreate528()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6098,-4463.138709185084), result);
        }

        [TestMethod]
        public void TestProcreate529()
        {
            var result = RandomMonad.evaluateWith(new System.Random(52), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6099,-3529.417562162959), result);
        }

        [TestMethod]
        public void TestProcreate530()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6100,-4244.762648044935), result);
        }

        [TestMethod]
        public void TestProcreate531()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6101,-3785.125684423213), result);
        }

        [TestMethod]
        public void TestProcreate532()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6102,-4334.154636175254), result);
        }

        [TestMethod]
        public void TestProcreate533()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6103,-3567.652002998963), result);
        }

        [TestMethod]
        public void TestProcreate534()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6104,-4137.830027045548), result);
        }

        [TestMethod]
        public void TestProcreate535()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6105,-3672.1449661846086), result);
        }

        [TestMethod]
        public void TestProcreate536()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6106,-4409.951764158144), result);
        }

        [TestMethod]
        public void TestProcreate537()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6107,-4129.250374457176), result);
        }

        [TestMethod]
        public void TestProcreate538()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6108,-3727.16902019924), result);
        }

        [TestMethod]
        public void TestProcreate539()
        {
            var result = RandomMonad.evaluateWith(new System.Random(53), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6109,-3711.3750747152835), result);
        }

        [TestMethod]
        public void TestProcreate540()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6110,-4139.327070166768), result);
        }

        [TestMethod]
        public void TestProcreate541()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6111,-4557.263135632304), result);
        }

        [TestMethod]
        public void TestProcreate542()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6112,-4285.359542357066), result);
        }

        [TestMethod]
        public void TestProcreate543()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6113,-4153.239037614689), result);
        }

        [TestMethod]
        public void TestProcreate544()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6114,-3046.150705144801), result);
        }

        [TestMethod]
        public void TestProcreate545()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6115,-3627.52878924599), result);
        }

        [TestMethod]
        public void TestProcreate546()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6116,-3766.1383335830624), result);
        }

        [TestMethod]
        public void TestProcreate547()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6117,-3699.903678673818), result);
        }

        [TestMethod]
        public void TestProcreate548()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6118,-4118.100258101105), result);
        }

        [TestMethod]
        public void TestProcreate549()
        {
            var result = RandomMonad.evaluateWith(new System.Random(54), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6119,-3517.271154028612), result);
        }

        [TestMethod]
        public void TestProcreate550()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6120,-2854.773698105342), result);
        }

        [TestMethod]
        public void TestProcreate551()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6121,-3149.143568284159), result);
        }

        [TestMethod]
        public void TestProcreate552()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6122,-3550.720117818482), result);
        }

        [TestMethod]
        public void TestProcreate553()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6123,-3324.5022586380474), result);
        }

        [TestMethod]
        public void TestProcreate554()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6124,-4108.33275683597), result);
        }

        [TestMethod]
        public void TestProcreate555()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6125,-3629.865135305279), result);
        }

        [TestMethod]
        public void TestProcreate556()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6126,-3490.0778412733657), result);
        }

        [TestMethod]
        public void TestProcreate557()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6127,-4213.209567935317), result);
        }

        [TestMethod]
        public void TestProcreate558()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6128,-2599.8700220524893), result);
        }

        [TestMethod]
        public void TestProcreate559()
        {
            var result = RandomMonad.evaluateWith(new System.Random(55), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6129,-4133.8123712959505), result);
        }

        [TestMethod]
        public void TestProcreate560()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6130,-3874.415343082803), result);
        }

        [TestMethod]
        public void TestProcreate561()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6131,-3754.287022387447), result);
        }

        [TestMethod]
        public void TestProcreate562()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6132,-3287.89512896994), result);
        }

        [TestMethod]
        public void TestProcreate563()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6133,-3888.5826897176794), result);
        }

        [TestMethod]
        public void TestProcreate564()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6134,-2980.658752414498), result);
        }

        [TestMethod]
        public void TestProcreate565()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6135,-3825.8669615811814), result);
        }

        [TestMethod]
        public void TestProcreate566()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6136,-3987.354417557209), result);
        }

        [TestMethod]
        public void TestProcreate567()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6137,-4082.660107953007), result);
        }

        [TestMethod]
        public void TestProcreate568()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6138,-3332.6432801583333), result);
        }

        [TestMethod]
        public void TestProcreate569()
        {
            var result = RandomMonad.evaluateWith(new System.Random(56), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6139,-3912.704645797472), result);
        }

        [TestMethod]
        public void TestProcreate570()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6140,-3721.316407466423), result);
        }

        [TestMethod]
        public void TestProcreate571()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6141,-3408.4441063303734), result);
        }

        [TestMethod]
        public void TestProcreate572()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6142,-3782.399959741127), result);
        }

        [TestMethod]
        public void TestProcreate573()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6143,-4355.888676903461), result);
        }

        [TestMethod]
        public void TestProcreate574()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6144,-3429.825322538015), result);
        }

        [TestMethod]
        public void TestProcreate575()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6145,-4210.5808204609), result);
        }

        [TestMethod]
        public void TestProcreate576()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6146,-3660.4985184160787), result);
        }

        [TestMethod]
        public void TestProcreate577()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6147,-4262.362367363726), result);
        }

        [TestMethod]
        public void TestProcreate578()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6148,-3667.950507723622), result);
        }

        [TestMethod]
        public void TestProcreate579()
        {
            var result = RandomMonad.evaluateWith(new System.Random(57), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6149,-3775.9507554393954), result);
        }

        [TestMethod]
        public void TestProcreate580()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6150,-4172.042685194412), result);
        }

        [TestMethod]
        public void TestProcreate581()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6151,-3743.351116810344), result);
        }

        [TestMethod]
        public void TestProcreate582()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6152,-4184.618976435157), result);
        }

        [TestMethod]
        public void TestProcreate583()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6153,-3856.9577413464635), result);
        }

        [TestMethod]
        public void TestProcreate584()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6154,-3556.184238568299), result);
        }

        [TestMethod]
        public void TestProcreate585()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6155,-3525.519157175563), result);
        }

        [TestMethod]
        public void TestProcreate586()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6156,-3829.2839226769556), result);
        }

        [TestMethod]
        public void TestProcreate587()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6157,-3898.371408054822), result);
        }

        [TestMethod]
        public void TestProcreate588()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6158,-3526.581559525909), result);
        }

        [TestMethod]
        public void TestProcreate589()
        {
            var result = RandomMonad.evaluateWith(new System.Random(58), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6159,-3127.9266542955643), result);
        }

        [TestMethod]
        public void TestProcreate590()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6160,-4099.736232466962), result);
        }

        [TestMethod]
        public void TestProcreate591()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6161,-3938.2961082020815), result);
        }

        [TestMethod]
        public void TestProcreate592()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6162,-3228.842007177617), result);
        }

        [TestMethod]
        public void TestProcreate593()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6163,-3527.559260928511), result);
        }

        [TestMethod]
        public void TestProcreate594()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6164,-3313.8138227241625), result);
        }

        [TestMethod]
        public void TestProcreate595()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6165,-4108.109418248278), result);
        }

        [TestMethod]
        public void TestProcreate596()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6166,-4318.331987385174), result);
        }

        [TestMethod]
        public void TestProcreate597()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6167,-3696.7475261122363), result);
        }

        [TestMethod]
        public void TestProcreate598()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6168,-3549.386393413826), result);
        }

        [TestMethod]
        public void TestProcreate599()
        {
            var result = RandomMonad.evaluateWith(new System.Random(59), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6169,-3871.701549444294), result);
        }

        [TestMethod]
        public void TestProcreate600()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6170,-3943.755797525178), result);
        }

        [TestMethod]
        public void TestProcreate601()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6171,-3925.7153602007), result);
        }

        [TestMethod]
        public void TestProcreate602()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6172,-3683.9275374740782), result);
        }

        [TestMethod]
        public void TestProcreate603()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6173,-3856.9577413464635), result);
        }

        [TestMethod]
        public void TestProcreate604()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6174,-3607.5440094681294), result);
        }

        [TestMethod]
        public void TestProcreate605()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6175,-3951.1258532516617), result);
        }

        [TestMethod]
        public void TestProcreate606()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6176,-3149.94877152908), result);
        }

        [TestMethod]
        public void TestProcreate607()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6177,-3771.535580820741), result);
        }

        [TestMethod]
        public void TestProcreate608()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6178,-4100.719401925833), result);
        }

        [TestMethod]
        public void TestProcreate609()
        {
            var result = RandomMonad.evaluateWith(new System.Random(60), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6179,-4037.0854557685525), result);
        }

        [TestMethod]
        public void TestProcreate610()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6180,-3400.851316153914), result);
        }

        [TestMethod]
        public void TestProcreate611()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6181,-3730.9167246421744), result);
        }

        [TestMethod]
        public void TestProcreate612()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6182,-3306.9059347601883), result);
        }

        [TestMethod]
        public void TestProcreate613()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6183,-4532.218291081942), result);
        }

        [TestMethod]
        public void TestProcreate614()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6184,-3497.8821821335823), result);
        }

        [TestMethod]
        public void TestProcreate615()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6185,-4210.5808204609), result);
        }

        [TestMethod]
        public void TestProcreate616()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6186,-3561.9463844926668), result);
        }

        [TestMethod]
        public void TestProcreate617()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6187,-4284.753038946458), result);
        }

        [TestMethod]
        public void TestProcreate618()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6188,-3667.950507723622), result);
        }

        [TestMethod]
        public void TestProcreate619()
        {
            var result = RandomMonad.evaluateWith(new System.Random(61), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6189,-3775.9507554393954), result);
        }

        [TestMethod]
        public void TestProcreate620()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6190,-3883.993078564706), result);
        }

        [TestMethod]
        public void TestProcreate621()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6191,-3633.493988591075), result);
        }

        [TestMethod]
        public void TestProcreate622()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6192,-3452.734446402179), result);
        }

        [TestMethod]
        public void TestProcreate623()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6193,-4507.933806997528), result);
        }

        [TestMethod]
        public void TestProcreate624()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6194,-3568.84197293035), result);
        }

        [TestMethod]
        public void TestProcreate625()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6195,-4159.2541247212575), result);
        }

        [TestMethod]
        public void TestProcreate626()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6196,-3153.37328618721), result);
        }

        [TestMethod]
        public void TestProcreate627()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6197,-4651.930833674493), result);
        }

        [TestMethod]
        public void TestProcreate628()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6198,-3934.9523283445087), result);
        }

        [TestMethod]
        public void TestProcreate629()
        {
            var result = RandomMonad.evaluateWith(new System.Random(62), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6199,-3637.6265509574605), result);
        }

        [TestMethod]
        public void TestProcreate630()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6200,-3109.5070285513925), result);
        }

        [TestMethod]
        public void TestProcreate631()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6201,-3676.5263594524704), result);
        }

        [TestMethod]
        public void TestProcreate632()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6202,-3854.9688718921925), result);
        }

        [TestMethod]
        public void TestProcreate633()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6203,-3839.309834061065), result);
        }

        [TestMethod]
        public void TestProcreate634()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6204,-4161.178467535377), result);
        }

        [TestMethod]
        public void TestProcreate635()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6205,-4099.961912938811), result);
        }

        [TestMethod]
        public void TestProcreate636()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6206,-3146.598857475215), result);
        }

        [TestMethod]
        public void TestProcreate637()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6207,-4111.153751609349), result);
        }

        [TestMethod]
        public void TestProcreate638()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6208,-3414.8008885761833), result);
        }

        [TestMethod]
        public void TestProcreate639()
        {
            var result = RandomMonad.evaluateWith(new System.Random(63), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6209,-3883.670481179305), result);
        }

        [TestMethod]
        public void TestProcreate640()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6210,-3758.8546388343243), result);
        }

        [TestMethod]
        public void TestProcreate641()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6211,-3684.605579493391), result);
        }

        [TestMethod]
        public void TestProcreate642()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6212,-3828.088382038333), result);
        }

        [TestMethod]
        public void TestProcreate643()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6213,-3981.5214237251103), result);
        }

        [TestMethod]
        public void TestProcreate644()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6214,-3462.770053131828), result);
        }

        [TestMethod]
        public void TestProcreate645()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6215,-3287.3579204619386), result);
        }

        [TestMethod]
        public void TestProcreate646()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6216,-3626.076916473698), result);
        }

        [TestMethod]
        public void TestProcreate647()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6217,-4368.994428700484), result);
        }

        [TestMethod]
        public void TestProcreate648()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6218,-3294.4418857944497), result);
        }

        [TestMethod]
        public void TestProcreate649()
        {
            var result = RandomMonad.evaluateWith(new System.Random(64), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6219,-3356.5990269842837), result);
        }

        [TestMethod]
        public void TestProcreate650()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6220,-3988.0095145721402), result);
        }

        [TestMethod]
        public void TestProcreate651()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6221,-3834.0858956543716), result);
        }

        [TestMethod]
        public void TestProcreate652()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6222,-3870.5247656132824), result);
        }

        [TestMethod]
        public void TestProcreate653()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6223,-3673.6174439245424), result);
        }

        [TestMethod]
        public void TestProcreate654()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6224,-3928.53563252928), result);
        }

        [TestMethod]
        public void TestProcreate655()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6225,-3236.213213988959), result);
        }

        [TestMethod]
        public void TestProcreate656()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6226,-3746.3204117953974), result);
        }

        [TestMethod]
        public void TestProcreate657()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6227,-3957.6052206470295), result);
        }

        [TestMethod]
        public void TestProcreate658()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6228,-3031.4540004374694), result);
        }

        [TestMethod]
        public void TestProcreate659()
        {
            var result = RandomMonad.evaluateWith(new System.Random(65), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6229,-3155.959236990082), result);
        }

        [TestMethod]
        public void TestProcreate660()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6230,-4425.030954925775), result);
        }

        [TestMethod]
        public void TestProcreate661()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6231,-3852.9114957267766), result);
        }

        [TestMethod]
        public void TestProcreate662()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6232,-4240.718166958029), result);
        }

        [TestMethod]
        public void TestProcreate663()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6233,-4117.914132187205), result);
        }

        [TestMethod]
        public void TestProcreate664()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6234,-3017.2203147737096), result);
        }

        [TestMethod]
        public void TestProcreate665()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6235,-3825.8669615811814), result);
        }

        [TestMethod]
        public void TestProcreate666()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6236,-3745.8926304855822), result);
        }

        [TestMethod]
        public void TestProcreate667()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6237,-3927.064016785188), result);
        }

        [TestMethod]
        public void TestProcreate668()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6238,-3644.8135961849753), result);
        }

        [TestMethod]
        public void TestProcreate669()
        {
            var result = RandomMonad.evaluateWith(new System.Random(66), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6239,-4063.8381560450325), result);
        }

        [TestMethod]
        public void TestProcreate670()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6240,-3796.609722559598), result);
        }

        [TestMethod]
        public void TestProcreate671()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6241,-4297.887610763459), result);
        }

        [TestMethod]
        public void TestProcreate672()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6242,-3501.3788252041286), result);
        }

        [TestMethod]
        public void TestProcreate673()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6243,-4013.0203963200984), result);
        }

        [TestMethod]
        public void TestProcreate674()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6244,-4320.2641140152045), result);
        }

        [TestMethod]
        public void TestProcreate675()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6245,-4110.597224660529), result);
        }

        [TestMethod]
        public void TestProcreate676()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6246,-3346.395103988109), result);
        }

        [TestMethod]
        public void TestProcreate677()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6247,-4176.952736096192), result);
        }

        [TestMethod]
        public void TestProcreate678()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6248,-4010.832766215033), result);
        }

        [TestMethod]
        public void TestProcreate679()
        {
            var result = RandomMonad.evaluateWith(new System.Random(67), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6249,-3216.8466491625736), result);
        }

        [TestMethod]
        public void TestProcreate680()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6250,-3528.591485517745), result);
        }

        [TestMethod]
        public void TestProcreate681()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6251,-3298.9493193162575), result);
        }

        [TestMethod]
        public void TestProcreate682()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6252,-3367.051407629086), result);
        }

        [TestMethod]
        public void TestProcreate683()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6253,-3324.5022586380474), result);
        }

        [TestMethod]
        public void TestProcreate684()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6254,-3876.441685279331), result);
        }

        [TestMethod]
        public void TestProcreate685()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6255,-4156.272467266336), result);
        }

        [TestMethod]
        public void TestProcreate686()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6256,-3205.5971121540315), result);
        }

        [TestMethod]
        public void TestProcreate687()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6257,-3428.0868755559854), result);
        }

        [TestMethod]
        public void TestProcreate688()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6258,-3050.626231239329), result);
        }

        [TestMethod]
        public void TestProcreate689()
        {
            var result = RandomMonad.evaluateWith(new System.Random(68), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6259,-3683.143297897421), result);
        }

        [TestMethod]
        public void TestProcreate690()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6260,-4138.331206821408), result);
        }

        [TestMethod]
        public void TestProcreate691()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6261,-3702.788452006795), result);
        }

        [TestMethod]
        public void TestProcreate692()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6262,-3823.039464170224), result);
        }

        [TestMethod]
        public void TestProcreate693()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6263,-3095.8269235014695), result);
        }

        [TestMethod]
        public void TestProcreate694()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6264,-3120.4417152806727), result);
        }

        [TestMethod]
        public void TestProcreate695()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6265,-4345.504353468917), result);
        }

        [TestMethod]
        public void TestProcreate696()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6266,-3588.8290234006167), result);
        }

        [TestMethod]
        public void TestProcreate697()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6267,-3058.3031956332507), result);
        }

        [TestMethod]
        public void TestProcreate698()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6268,-3088.7157850561134), result);
        }

        [TestMethod]
        public void TestProcreate699()
        {
            var result = RandomMonad.evaluateWith(new System.Random(69), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6269,-4232.706154547032), result);
        }

        [TestMethod]
        public void TestProcreate700()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6270,-4151.6709377826655), result);
        }

        [TestMethod]
        public void TestProcreate701()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6271,-3036.386710204603), result);
        }

        [TestMethod]
        public void TestProcreate702()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6272,-4023.2921017895255), result);
        }

        [TestMethod]
        public void TestProcreate703()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6273,-3300.4616206467354), result);
        }

        [TestMethod]
        public void TestProcreate704()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6274,-3706.978054934408), result);
        }

        [TestMethod]
        public void TestProcreate705()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6275,-3931.6186014080868), result);
        }

        [TestMethod]
        public void TestProcreate706()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6276,-3490.0778412733657), result);
        }

        [TestMethod]
        public void TestProcreate707()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6277,-3630.4080409226463), result);
        }

        [TestMethod]
        public void TestProcreate708()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6278,-2599.8700220524893), result);
        }

        [TestMethod]
        public void TestProcreate709()
        {
            var result = RandomMonad.evaluateWith(new System.Random(70), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6279,-3683.143297897421), result);
        }

        [TestMethod]
        public void TestProcreate710()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6280,-3878.945869061179), result);
        }

        [TestMethod]
        public void TestProcreate711()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6281,-3536.9909256484125), result);
        }

        [TestMethod]
        public void TestProcreate712()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6282,-3681.803109980077), result);
        }

        [TestMethod]
        public void TestProcreate713()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6283,-4010.9700268008487), result);
        }

        [TestMethod]
        public void TestProcreate714()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6284,-4053.367979310895), result);
        }

        [TestMethod]
        public void TestProcreate715()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6285,-4203.588069917348), result);
        }

        [TestMethod]
        public void TestProcreate716()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6286,-3394.6359232609184), result);
        }

        [TestMethod]
        public void TestProcreate717()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6287,-4451.603209764552), result);
        }

        [TestMethod]
        public void TestProcreate718()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6288,-3810.063252342998), result);
        }

        [TestMethod]
        public void TestProcreate719()
        {
            var result = RandomMonad.evaluateWith(new System.Random(71), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6289,-3333.6756297424004), result);
        }

        [TestMethod]
        public void TestProcreate720()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6290,-4222.733828169658), result);
        }

        [TestMethod]
        public void TestProcreate721()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6291,-4083.691273979702), result);
        }

        [TestMethod]
        public void TestProcreate722()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6292,-3913.774683270462), result);
        }

        [TestMethod]
        public void TestProcreate723()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6293,-3839.309834061065), result);
        }

        [TestMethod]
        public void TestProcreate724()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6294,-2980.658752414498), result);
        }

        [TestMethod]
        public void TestProcreate725()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6295,-3825.8669615811814), result);
        }

        [TestMethod]
        public void TestProcreate726()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6296,-3360.8337580264415), result);
        }

        [TestMethod]
        public void TestProcreate727()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6297,-4381.651427585102), result);
        }

        [TestMethod]
        public void TestProcreate728()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6298,-4107.32749954601), result);
        }

        [TestMethod]
        public void TestProcreate729()
        {
            var result = RandomMonad.evaluateWith(new System.Random(72), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6299,-3972.2058963881395), result);
        }

        [TestMethod]
        public void TestProcreate730()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6300,-3680.600391595012), result);
        }

        [TestMethod]
        public void TestProcreate731()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6301,-3925.496043883856), result);
        }

        [TestMethod]
        public void TestProcreate732()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6302,-3796.796371297851), result);
        }

        [TestMethod]
        public void TestProcreate733()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6303,-4444.820117942711), result);
        }

        [TestMethod]
        public void TestProcreate734()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6304,-3582.87415919441), result);
        }

        [TestMethod]
        public void TestProcreate735()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6305,-3822.0687584307498), result);
        }

        [TestMethod]
        public void TestProcreate736()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6306,-3815.1625212296262), result);
        }

        [TestMethod]
        public void TestProcreate737()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6307,-4131.346851211868), result);
        }

        [TestMethod]
        public void TestProcreate738()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6308,-4347.325304345234), result);
        }

        [TestMethod]
        public void TestProcreate739()
        {
            var result = RandomMonad.evaluateWith(new System.Random(73), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6309,-3823.577182825756), result);
        }

        [TestMethod]
        public void TestProcreate740()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6310,-4222.733780604055), result);
        }

        [TestMethod]
        public void TestProcreate741()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6311,-3534.431349846838), result);
        }

        [TestMethod]
        public void TestProcreate742()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6312,-4008.969258847613), result);
        }

        [TestMethod]
        public void TestProcreate743()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6313,-3520.484105025386), result);
        }

        [TestMethod]
        public void TestProcreate744()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6314,-3399.954371219876), result);
        }

        [TestMethod]
        public void TestProcreate745()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6315,-4162.9718938920205), result);
        }

        [TestMethod]
        public void TestProcreate746()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6316,-3314.745420509959), result);
        }

        [TestMethod]
        public void TestProcreate747()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6317,-3695.0882446034034), result);
        }

        [TestMethod]
        public void TestProcreate748()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6318,-3497.6753720461857), result);
        }

        [TestMethod]
        public void TestProcreate749()
        {
            var result = RandomMonad.evaluateWith(new System.Random(74), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6319,-3784.5301051930737), result);
        }

        [TestMethod]
        public void TestProcreate750()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6320,-3627.888535301025), result);
        }

        [TestMethod]
        public void TestProcreate751()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6321,-3861.9549106384516), result);
        }

        [TestMethod]
        public void TestProcreate752()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6322,-3570.581469930499), result);
        }

        [TestMethod]
        public void TestProcreate753()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6323,-3808.088820744376), result);
        }

        [TestMethod]
        public void TestProcreate754()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6324,-4222.852488766181), result);
        }

        [TestMethod]
        public void TestProcreate755()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6325,-4294.678194341643), result);
        }

        [TestMethod]
        public void TestProcreate756()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6326,-4422.20135905212), result);
        }

        [TestMethod]
        public void TestProcreate757()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6327,-4569.916208301034), result);
        }

        [TestMethod]
        public void TestProcreate758()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6328,-3691.166187639936), result);
        }

        [TestMethod]
        public void TestProcreate759()
        {
            var result = RandomMonad.evaluateWith(new System.Random(75), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6329,-3818.7676524828585), result);
        }

        [TestMethod]
        public void TestProcreate760()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6330,-3639.6433757222835), result);
        }

        [TestMethod]
        public void TestProcreate761()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6331,-3520.852883745579), result);
        }

        [TestMethod]
        public void TestProcreate762()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6332,-3686.772080250398), result);
        }

        [TestMethod]
        public void TestProcreate763()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6333,-3997.6436024051663), result);
        }

        [TestMethod]
        public void TestProcreate764()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6334,-3461.246597801258), result);
        }

        [TestMethod]
        public void TestProcreate765()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6335,-4445.636123572621), result);
        }

        [TestMethod]
        public void TestProcreate766()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6336,-3219.643299707638), result);
        }

        [TestMethod]
        public void TestProcreate767()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6337,-3698.9577726934426), result);
        }

        [TestMethod]
        public void TestProcreate768()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6338,-4191.410877964158), result);
        }

        [TestMethod]
        public void TestProcreate769()
        {
            var result = RandomMonad.evaluateWith(new System.Random(76), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6339,-3871.2057395467345), result);
        }

        [TestMethod]
        public void TestProcreate770()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6340,-4174.535058227071), result);
        }

        [TestMethod]
        public void TestProcreate771()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6341,-3674.8825826256852), result);
        }

        [TestMethod]
        public void TestProcreate772()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6342,-3598.500803103532), result);
        }

        [TestMethod]
        public void TestProcreate773()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6343,-4049.413156049253), result);
        }

        [TestMethod]
        public void TestProcreate774()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6344,-2980.658752414498), result);
        }

        [TestMethod]
        public void TestProcreate775()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6345,-3825.8669615811814), result);
        }

        [TestMethod]
        public void TestProcreate776()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6346,-3589.3882489736466), result);
        }

        [TestMethod]
        public void TestProcreate777()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6347,-4229.909671593019), result);
        }

        [TestMethod]
        public void TestProcreate778()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6348,-3644.8135961849753), result);
        }

        [TestMethod]
        public void TestProcreate779()
        {
            var result = RandomMonad.evaluateWith(new System.Random(77), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6349,-4183.652575641759), result);
        }

        [TestMethod]
        public void TestProcreate780()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6350,-3998.9459089105644), result);
        }

        [TestMethod]
        public void TestProcreate781()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6351,-3946.6041065619165), result);
        }

        [TestMethod]
        public void TestProcreate782()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6352,-3823.039464170224), result);
        }

        [TestMethod]
        public void TestProcreate783()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6353,-4163.325958393934), result);
        }

        [TestMethod]
        public void TestProcreate784()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6354,-3615.9169595155117), result);
        }

        [TestMethod]
        public void TestProcreate785()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6355,-4025.4526130107774), result);
        }

        [TestMethod]
        public void TestProcreate786()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6356,-3621.1530564937443), result);
        }

        [TestMethod]
        public void TestProcreate787()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6357,-4107.768773988129), result);
        }

        [TestMethod]
        public void TestProcreate788()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6358,-4119.773367373652), result);
        }

        [TestMethod]
        public void TestProcreate789()
        {
            var result = RandomMonad.evaluateWith(new System.Random(78), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6359,-4126.030721536181), result);
        }

        [TestMethod]
        public void TestProcreate790()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6360,-3951.8219049238246), result);
        }

        [TestMethod]
        public void TestProcreate791()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6361,-3674.8825826256852), result);
        }

        [TestMethod]
        public void TestProcreate792()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6362,-3913.774683270462), result);
        }

        [TestMethod]
        public void TestProcreate793()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6363,-3738.4713679538045), result);
        }

        [TestMethod]
        public void TestProcreate794()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6364,-2980.658752414498), result);
        }

        [TestMethod]
        public void TestProcreate795()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6365,-3825.8669615811814), result);
        }

        [TestMethod]
        public void TestProcreate796()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6366,-3836.1116053087057), result);
        }

        [TestMethod]
        public void TestProcreate797()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6367,-4648.604300750638), result);
        }

        [TestMethod]
        public void TestProcreate798()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6368,-3644.8135961849753), result);
        }

        [TestMethod]
        public void TestProcreate799()
        {
            var result = RandomMonad.evaluateWith(new System.Random(79), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6369,-4459.702093818433), result);
        }

        [TestMethod]
        public void TestProcreate800()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6370,-4021.0775571615322), result);
        }

        [TestMethod]
        public void TestProcreate801()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6371,-4158.815369072266), result);
        }

        [TestMethod]
        public void TestProcreate802()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6372,-3736.7700159452297), result);
        }

        [TestMethod]
        public void TestProcreate803()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6373,-4093.6182024692453), result);
        }

        [TestMethod]
        public void TestProcreate804()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6374,-3983.9914518842197), result);
        }

        [TestMethod]
        public void TestProcreate805()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6375,-3880.6080437381047), result);
        }

        [TestMethod]
        public void TestProcreate806()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6376,-3905.7330588073723), result);
        }

        [TestMethod]
        public void TestProcreate807()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6377,-4482.989897025497), result);
        }

        [TestMethod]
        public void TestProcreate808()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6378,-2764.088733776013), result);
        }

        [TestMethod]
        public void TestProcreate809()
        {
            var result = RandomMonad.evaluateWith(new System.Random(80), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6379,-3467.217676596729), result);
        }

        [TestMethod]
        public void TestProcreate810()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6380,-3695.2707080888426), result);
        }

        [TestMethod]
        public void TestProcreate811()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6381,-3532.1373966876477), result);
        }

        [TestMethod]
        public void TestProcreate812()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6382,-3881.496894572245), result);
        }

        [TestMethod]
        public void TestProcreate813()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6383,-3934.484891876088), result);
        }

        [TestMethod]
        public void TestProcreate814()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6384,-3352.1990131156203), result);
        }

        [TestMethod]
        public void TestProcreate815()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6385,-3799.33074752537), result);
        }

        [TestMethod]
        public void TestProcreate816()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6386,-3267.5876837182313), result);
        }

        [TestMethod]
        public void TestProcreate817()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6387,-3931.1504980831096), result);
        }

        [TestMethod]
        public void TestProcreate818()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6388,-3236.2132139889595), result);
        }

        [TestMethod]
        public void TestProcreate819()
        {
            var result = RandomMonad.evaluateWith(new System.Random(81), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6389,-3580.7877825112632), result);
        }

        [TestMethod]
        public void TestProcreate820()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6390,-4321.8520166557255), result);
        }

        [TestMethod]
        public void TestProcreate821()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6391,-3728.8503564574467), result);
        }

        [TestMethod]
        public void TestProcreate822()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6392,-4076.808056965422), result);
        }

        [TestMethod]
        public void TestProcreate823()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6393,-3391.610549298833), result);
        }

        [TestMethod]
        public void TestProcreate824()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6394,-3709.6337858396387), result);
        }

        [TestMethod]
        public void TestProcreate825()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6395,-4213.1364748383085), result);
        }

        [TestMethod]
        public void TestProcreate826()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6396,-3878.3908030125776), result);
        }

        [TestMethod]
        public void TestProcreate827()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6397,-3493.918353816145), result);
        }

        [TestMethod]
        public void TestProcreate828()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6398,-3228.725542952114), result);
        }

        [TestMethod]
        public void TestProcreate829()
        {
            var result = RandomMonad.evaluateWith(new System.Random(82), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6399,-3948.0558676119877), result);
        }

        [TestMethod]
        public void TestProcreate830()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6400,-3819.064154165005), result);
        }

        [TestMethod]
        public void TestProcreate831()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6401,-3645.0210225197084), result);
        }

        [TestMethod]
        public void TestProcreate832()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6402,-3819.8545637771986), result);
        }

        [TestMethod]
        public void TestProcreate833()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6403,-3625.0035088977897), result);
        }

        [TestMethod]
        public void TestProcreate834()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6404,-3777.2019611134965), result);
        }

        [TestMethod]
        public void TestProcreate835()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6405,-4236.557783937432), result);
        }

        [TestMethod]
        public void TestProcreate836()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6406,-4419.006282757573), result);
        }

        [TestMethod]
        public void TestProcreate837()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6407,-4470.039125860837), result);
        }

        [TestMethod]
        public void TestProcreate838()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6408,-3347.5087338366216), result);
        }

        [TestMethod]
        public void TestProcreate839()
        {
            var result = RandomMonad.evaluateWith(new System.Random(83), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6409,-4030.557686063927), result);
        }

        [TestMethod]
        public void TestProcreate840()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6410,-3990.4728530797424), result);
        }

        [TestMethod]
        public void TestProcreate841()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6411,-3924.7014604027827), result);
        }

        [TestMethod]
        public void TestProcreate842()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6412,-3689.0574736106028), result);
        }

        [TestMethod]
        public void TestProcreate843()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6413,-3854.2501831211202), result);
        }

        [TestMethod]
        public void TestProcreate844()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6414,-4376.9789823635365), result);
        }

        [TestMethod]
        public void TestProcreate845()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6415,-3920.709130090296), result);
        }

        [TestMethod]
        public void TestProcreate846()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6416,-3589.3882489736466), result);
        }

        [TestMethod]
        public void TestProcreate847()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6417,-3443.7350939062153), result);
        }

        [TestMethod]
        public void TestProcreate848()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6418,-4088.5581449871866), result);
        }

        [TestMethod]
        public void TestProcreate849()
        {
            var result = RandomMonad.evaluateWith(new System.Random(84), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6419,-4098.507963992008), result);
        }

        [TestMethod]
        public void TestProcreate850()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6420,-3528.591485517745), result);
        }

        [TestMethod]
        public void TestProcreate851()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6421,-3702.917694885148), result);
        }

        [TestMethod]
        public void TestProcreate852()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6422,-3367.051407629086), result);
        }

        [TestMethod]
        public void TestProcreate853()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6423,-4508.074023615812), result);
        }

        [TestMethod]
        public void TestProcreate854()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6424,-3348.0970453049317), result);
        }

        [TestMethod]
        public void TestProcreate855()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6425,-4159.2541247212575), result);
        }

        [TestMethod]
        public void TestProcreate856()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6426,-3334.1642610208582), result);
        }

        [TestMethod]
        public void TestProcreate857()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6427,-4049.9236792859892), result);
        }

        [TestMethod]
        public void TestProcreate858()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6428,-3964.38655810401), result);
        }

        [TestMethod]
        public void TestProcreate859()
        {
            var result = RandomMonad.evaluateWith(new System.Random(85), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6429,-3637.6265509574605), result);
        }

        [TestMethod]
        public void TestProcreate860()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6430,-4120.237157354459), result);
        }

        [TestMethod]
        public void TestProcreate861()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6431,-3852.9114957267766), result);
        }

        [TestMethod]
        public void TestProcreate862()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6432,-3933.405120030342), result);
        }

        [TestMethod]
        public void TestProcreate863()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6433,-4276.954532933401), result);
        }

        [TestMethod]
        public void TestProcreate864()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6434,-3143.8691012997842), result);
        }

        [TestMethod]
        public void TestProcreate865()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6435,-4033.324632191552), result);
        }

        [TestMethod]
        public void TestProcreate866()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6436,-3478.3208303811225), result);
        }

        [TestMethod]
        public void TestProcreate867()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6437,-4165.963770276487), result);
        }

        [TestMethod]
        public void TestProcreate868()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6438,-3785.2652098286294), result);
        }

        [TestMethod]
        public void TestProcreate869()
        {
            var result = RandomMonad.evaluateWith(new System.Random(86), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6439,-3803.6767446103945), result);
        }

        [TestMethod]
        public void TestProcreate870()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6440,-3358.7694957320828), result);
        }

        [TestMethod]
        public void TestProcreate871()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6441,-3710.7461949250496), result);
        }

        [TestMethod]
        public void TestProcreate872()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6442,-3825.1455288451575), result);
        }

        [TestMethod]
        public void TestProcreate873()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6443,-3676.1944359127715), result);
        }

        [TestMethod]
        public void TestProcreate874()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6444,-3348.0970453049317), result);
        }

        [TestMethod]
        public void TestProcreate875()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6445,-4159.2541247212575), result);
        }

        [TestMethod]
        public void TestProcreate876()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6446,-3899.886003176707), result);
        }

        [TestMethod]
        public void TestProcreate877()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6447,-4049.9236792859892), result);
        }

        [TestMethod]
        public void TestProcreate878()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6448,-3913.9126173867144), result);
        }

        [TestMethod]
        public void TestProcreate879()
        {
            var result = RandomMonad.evaluateWith(new System.Random(87), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6449,-3637.6265509574605), result);
        }

        [TestMethod]
        public void TestProcreate880()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6450,-3490.1978334807836), result);
        }

        [TestMethod]
        public void TestProcreate881()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6451,-4108.109609800592), result);
        }

        [TestMethod]
        public void TestProcreate882()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6452,-3776.9729131344575), result);
        }

        [TestMethod]
        public void TestProcreate883()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6453,-4416.95858067073), result);
        }

        [TestMethod]
        public void TestProcreate884()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6454,-4384.319250375804), result);
        }

        [TestMethod]
        public void TestProcreate885()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6455,-4013.7983287250104), result);
        }

        [TestMethod]
        public void TestProcreate886()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6456,-4568.051660754984), result);
        }

        [TestMethod]
        public void TestProcreate887()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6457,-4288.517006581556), result);
        }

        [TestMethod]
        public void TestProcreate888()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6458,-3935.4194923091923), result);
        }

        [TestMethod]
        public void TestProcreate889()
        {
            var result = RandomMonad.evaluateWith(new System.Random(88), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6459,-4153.710790424803), result);
        }

        [TestMethod]
        public void TestProcreate890()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6460,-3874.415343082803), result);
        }

        [TestMethod]
        public void TestProcreate891()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6461,-3754.287022387447), result);
        }

        [TestMethod]
        public void TestProcreate892()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6462,-3287.89512896994), result);
        }

        [TestMethod]
        public void TestProcreate893()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6463,-3888.5826897176794), result);
        }

        [TestMethod]
        public void TestProcreate894()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6464,-2980.658752414498), result);
        }

        [TestMethod]
        public void TestProcreate895()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6465,-3825.8669615811814), result);
        }

        [TestMethod]
        public void TestProcreate896()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6466,-3987.354417557209), result);
        }

        [TestMethod]
        public void TestProcreate897()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6467,-4082.660107953007), result);
        }

        [TestMethod]
        public void TestProcreate898()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6468,-3332.6432801583333), result);
        }

        [TestMethod]
        public void TestProcreate899()
        {
            var result = RandomMonad.evaluateWith(new System.Random(89), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6469,-3912.704645797472), result);
        }

        [TestMethod]
        public void TestProcreate900()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6470,-4032.0334689566694), result);
        }

        [TestMethod]
        public void TestProcreate901()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6471,-3036.386710204603), result);
        }

        [TestMethod]
        public void TestProcreate902()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6472,-3367.051407629086), result);
        }

        [TestMethod]
        public void TestProcreate903()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6473,-3915.9690691775486), result);
        }

        [TestMethod]
        public void TestProcreate904()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6474,-3706.978054934408), result);
        }

        [TestMethod]
        public void TestProcreate905()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6475,-3931.6186014080868), result);
        }

        [TestMethod]
        public void TestProcreate906()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6476,-3334.1642610208582), result);
        }

        [TestMethod]
        public void TestProcreate907()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6477,-3630.4080409226463), result);
        }

        [TestMethod]
        public void TestProcreate908()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6478,-2599.8700220524893), result);
        }

        [TestMethod]
        public void TestProcreate909()
        {
            var result = RandomMonad.evaluateWith(new System.Random(90), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6479,-3683.143297897421), result);
        }

        [TestMethod]
        public void TestProcreate910()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6480,-4063.4405929917743), result);
        }

        [TestMethod]
        public void TestProcreate911()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6481,-3303.9104938942933), result);
        }

        [TestMethod]
        public void TestProcreate912()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6482,-4049.2231368978373), result);
        }

        [TestMethod]
        public void TestProcreate913()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6483,-3476.2603937752256), result);
        }

        [TestMethod]
        public void TestProcreate914()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6484,-3904.3700787796993), result);
        }

        [TestMethod]
        public void TestProcreate915()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6485,-3587.7978573739206), result);
        }

        [TestMethod]
        public void TestProcreate916()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6486,-3790.2572960023017), result);
        }

        [TestMethod]
        public void TestProcreate917()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6487,-3892.17355531552), result);
        }

        [TestMethod]
        public void TestProcreate918()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6488,-3417.4029844038223), result);
        }

        [TestMethod]
        public void TestProcreate919()
        {
            var result = RandomMonad.evaluateWith(new System.Random(91), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6489,-3824.0791335340205), result);
        }

        [TestMethod]
        public void TestProcreate920()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6490,-3545.7876807656235), result);
        }

        [TestMethod]
        public void TestProcreate921()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6491,-3826.2769971555176), result);
        }

        [TestMethod]
        public void TestProcreate922()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6492,-3306.1738448787746), result);
        }

        [TestMethod]
        public void TestProcreate923()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6493,-3120.2638915446546), result);
        }

        [TestMethod]
        public void TestProcreate924()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6494,-3940.4262556990575), result);
        }

        [TestMethod]
        public void TestProcreate925()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6495,-3464.3017192892894), result);
        }

        [TestMethod]
        public void TestProcreate926()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6496,-3809.0897210921644), result);
        }

        [TestMethod]
        public void TestProcreate927()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6497,-4176.486134070022), result);
        }

        [TestMethod]
        public void TestProcreate928()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6498,-2869.5593772926904), result);
        }

        [TestMethod]
        public void TestProcreate929()
        {
            var result = RandomMonad.evaluateWith(new System.Random(92), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6499,-3726.006663731207), result);
        }

        [TestMethod]
        public void TestProcreate930()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6500,-3307.9741144334403), result);
        }

        [TestMethod]
        public void TestProcreate931()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6501,-3075.636694507708), result);
        }

        [TestMethod]
        public void TestProcreate932()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6502,-3452.734446402179), result);
        }

        [TestMethod]
        public void TestProcreate933()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6503,-3854.2501831211202), result);
        }

        [TestMethod]
        public void TestProcreate934()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6504,-3974.7651698371556), result);
        }

        [TestMethod]
        public void TestProcreate935()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6505,-4599.69801642771), result);
        }

        [TestMethod]
        public void TestProcreate936()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6506,-3501.433031154411), result);
        }

        [TestMethod]
        public void TestProcreate937()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6507,-4317.132786343392), result);
        }

        [TestMethod]
        public void TestProcreate938()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6508,-4116.185604543688), result);
        }

        [TestMethod]
        public void TestProcreate939()
        {
            var result = RandomMonad.evaluateWith(new System.Random(93), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6509,-3804.049817135887), result);
        }

        [TestMethod]
        public void TestProcreate940()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6510,-4286.108902350878), result);
        }

        [TestMethod]
        public void TestProcreate941()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6511,-3978.628284425883), result);
        }

        [TestMethod]
        public void TestProcreate942()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6512,-4065.0412653272256), result);
        }

        [TestMethod]
        public void TestProcreate943()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6513,-3477.3723420385513), result);
        }

        [TestMethod]
        public void TestProcreate944()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6514,-3856.782638641484), result);
        }

        [TestMethod]
        public void TestProcreate945()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6515,-3362.5143715712406), result);
        }

        [TestMethod]
        public void TestProcreate946()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6516,-3669.0754919538863), result);
        }

        [TestMethod]
        public void TestProcreate947()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6517,-3866.2835574806286), result);
        }

        [TestMethod]
        public void TestProcreate948()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6518,-3315.846264028455), result);
        }

        [TestMethod]
        public void TestProcreate949()
        {
            var result = RandomMonad.evaluateWith(new System.Random(94), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6519,-3482.0079746203587), result);
        }

        [TestMethod]
        public void TestProcreate950()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6520,-3928.9756802258994), result);
        }

        [TestMethod]
        public void TestProcreate951()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6521,-4291.48232459409), result);
        }

        [TestMethod]
        public void TestProcreate952()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6522,-3920.6607227747018), result);
        }

        [TestMethod]
        public void TestProcreate953()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6523,-3638.274166917898), result);
        }

        [TestMethod]
        public void TestProcreate954()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6524,-3348.0970453049317), result);
        }

        [TestMethod]
        public void TestProcreate955()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6525,-3884.544299001644), result);
        }

        [TestMethod]
        public void TestProcreate956()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6526,-4175.238249436267), result);
        }

        [TestMethod]
        public void TestProcreate957()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6527,-4651.930833674493), result);
        }

        [TestMethod]
        public void TestProcreate958()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6528,-3378.7468390810627), result);
        }

        [TestMethod]
        public void TestProcreate959()
        {
            var result = RandomMonad.evaluateWith(new System.Random(95), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6529,-3803.6767446103945), result);
        }

        [TestMethod]
        public void TestProcreate960()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6530,-4222.733828169658), result);
        }

        [TestMethod]
        public void TestProcreate961()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6531,-4557.263135632304), result);
        }

        [TestMethod]
        public void TestProcreate962()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6532,-3928.631624390103), result);
        }

        [TestMethod]
        public void TestProcreate963()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6533,-3120.2638915446546), result);
        }

        [TestMethod]
        public void TestProcreate964()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6534,-3046.150705144801), result);
        }

        [TestMethod]
        public void TestProcreate965()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6535,-4421.979729138072), result);
        }

        [TestMethod]
        public void TestProcreate966()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6536,-4298.910262785452), result);
        }

        [TestMethod]
        public void TestProcreate967()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6537,-4176.486134070022), result);
        }

        [TestMethod]
        public void TestProcreate968()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6538,-3276.250168265863), result);
        }

        [TestMethod]
        public void TestProcreate969()
        {
            var result = RandomMonad.evaluateWith(new System.Random(96), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6539,-3482.0079746203587), result);
        }

        [TestMethod]
        public void TestProcreate970()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6540,-3676.8400134608655), result);
        }

        [TestMethod]
        public void TestProcreate971()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6541,-3298.9493193162575), result);
        }

        [TestMethod]
        public void TestProcreate972()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6542,-3550.720117818482), result);
        }

        [TestMethod]
        public void TestProcreate973()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6543,-3324.5022586380474), result);
        }

        [TestMethod]
        public void TestProcreate974()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6544,-3497.882182133582), result);
        }

        [TestMethod]
        public void TestProcreate975()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6545,-4156.272467266336), result);
        }

        [TestMethod]
        public void TestProcreate976()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6546,-3490.0778412733657), result);
        }

        [TestMethod]
        public void TestProcreate977()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6547,-4213.209567935317), result);
        }

        [TestMethod]
        public void TestProcreate978()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6548,-3050.626231239329), result);
        }

        [TestMethod]
        public void TestProcreate979()
        {
            var result = RandomMonad.evaluateWith(new System.Random(97), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6549,-3683.143297897421), result);
        }

        [TestMethod]
        public void TestProcreate980()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6550,-3782.2593350275256), result);
        }

        [TestMethod]
        public void TestProcreate981()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6551,-3921.048953662621), result);
        }

        [TestMethod]
        public void TestProcreate982()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6552,-3731.228093061051), result);
        }

        [TestMethod]
        public void TestProcreate983()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6553,-3802.6427944080656), result);
        }

        [TestMethod]
        public void TestProcreate984()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6554,-3917.1460653740714), result);
        }

        [TestMethod]
        public void TestProcreate985()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6555,-4267.258862823278), result);
        }

        [TestMethod]
        public void TestProcreate986()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6556,-4336.047097062421), result);
        }

        [TestMethod]
        public void TestProcreate987()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6557,-3043.2359118737186), result);
        }

        [TestMethod]
        public void TestProcreate988()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6558,-4077.719043309406), result);
        }

        [TestMethod]
        public void TestProcreate989()
        {
            var result = RandomMonad.evaluateWith(new System.Random(98), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6559,-3575.357792180165), result);
        }

        [TestMethod]
        public void TestProcreate990()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population0));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6560,-4172.4110203550135), result);
        }

        [TestMethod]
        public void TestProcreate991()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population1));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6561,-3912.6276441062223), result);
        }

        [TestMethod]
        public void TestProcreate992()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population2));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6562,-3684.3257714226393), result);
        }

        [TestMethod]
        public void TestProcreate993()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population3));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6563,-4362.174373816425), result);
        }

        [TestMethod]
        public void TestProcreate994()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population4));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6564,-4103.79904887987), result);
        }

        [TestMethod]
        public void TestProcreate995()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population5));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6565,-3969.3565365752233), result);
        }

        [TestMethod]
        public void TestProcreate996()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population6));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6566,-3647.546574023873), result);
        }

        [TestMethod]
        public void TestProcreate997()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population7));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6567,-3203.270977303691), result);
        }

        [TestMethod]
        public void TestProcreate998()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population8));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6568,-3984.375250159284), result);
        }

        [TestMethod]
        public void TestProcreate999()
        {
            var result = RandomMonad.evaluateWith(new System.Random(99), GeneticAlgorithm.procreate(TestFitnessFunctions.fitness10, TestPopulations.population9));
            CompareIndividuals(new Tuple<int[],double>(IndividualsResults.result6569,-4372.193656553509), result);
        }

    }
}
