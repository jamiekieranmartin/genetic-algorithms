using Microsoft.VisualStudio.TestTools.UnitTesting;
using CAB402.FSharp;

namespace GeneticAlgorithmUnitTests
{
    [TestClass]
    public class ScoreTests
    {
        [TestMethod]
        public void TestScore0()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual0);
            Assert.AreEqual(-3760.1380734888075, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5470, result.Item1);
        }

        [TestMethod]
        public void TestScore1()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual1);
            Assert.AreEqual(-4080.0218517031362, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5471, result.Item1);
        }

        [TestMethod]
        public void TestScore2()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual2);
            Assert.AreEqual(-3676.8400134608655, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5472, result.Item1);
        }

        [TestMethod]
        public void TestScore3()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual3);
            Assert.AreEqual(-4222.053561352473, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5473, result.Item1);
        }

        [TestMethod]
        public void TestScore4()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual4);
            Assert.AreEqual(-4147.250971419821, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5474, result.Item1);
        }

        [TestMethod]
        public void TestScore5()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual5);
            Assert.AreEqual(-3721.316407466423, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5475, result.Item1);
        }

        [TestMethod]
        public void TestScore6()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual6);
            Assert.AreEqual(-3490.1978334807836, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5476, result.Item1);
        }

        [TestMethod]
        public void TestScore7()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual7);
            Assert.AreEqual(-3528.591485517745, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5477, result.Item1);
        }

        [TestMethod]
        public void TestScore8()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual8);
            Assert.AreEqual(-4255.28501183847, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5478, result.Item1);
        }

        [TestMethod]
        public void TestScore9()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual9);
            Assert.AreEqual(-3951.8219049238246, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5479, result.Item1);
        }

        [TestMethod]
        public void TestScore10()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual10);
            Assert.AreEqual(-3824.785986720627, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5480, result.Item1);
        }

        [TestMethod]
        public void TestScore11()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual11);
            Assert.AreEqual(-4138.818333042259, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5481, result.Item1);
        }

        [TestMethod]
        public void TestScore12()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual12);
            Assert.AreEqual(-3298.9493193162575, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5482, result.Item1);
        }

        [TestMethod]
        public void TestScore13()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual13);
            Assert.AreEqual(-3534.431349846838, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5483, result.Item1);
        }

        [TestMethod]
        public void TestScore14()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual14);
            Assert.AreEqual(-4209.921165362595, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5484, result.Item1);
        }

        [TestMethod]
        public void TestScore15()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual15);
            Assert.AreEqual(-3842.9615068349667, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5485, result.Item1);
        }

        [TestMethod]
        public void TestScore16()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual16);
            Assert.AreEqual(-4009.6377609331585, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5486, result.Item1);
        }

        [TestMethod]
        public void TestScore17()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual17);
            Assert.AreEqual(-3702.917694885148, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5487, result.Item1);
        }

        [TestMethod]
        public void TestScore18()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual18);
            Assert.AreEqual(-4172.213342132685, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5488, result.Item1);
        }

        [TestMethod]
        public void TestScore19()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual19);
            Assert.AreEqual(-3674.8825826256852, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5489, result.Item1);
        }

        [TestMethod]
        public void TestScore20()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual20);
            Assert.AreEqual(-4130.794209829419, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5490, result.Item1);
        }

        [TestMethod]
        public void TestScore21()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual21);
            Assert.AreEqual(-3825.1455288451575, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5491, result.Item1);
        }

        [TestMethod]
        public void TestScore22()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual22);
            Assert.AreEqual(-3550.720117818482, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5492, result.Item1);
        }

        [TestMethod]
        public void TestScore23()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual23);
            Assert.AreEqual(-4205.704452856764, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5493, result.Item1);
        }

        [TestMethod]
        public void TestScore24()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual24);
            Assert.AreEqual(-3689.0574736106028, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5494, result.Item1);
        }

        [TestMethod]
        public void TestScore25()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual25);
            Assert.AreEqual(-3881.496894572245, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5495, result.Item1);
        }

        [TestMethod]
        public void TestScore26()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual26);
            Assert.AreEqual(-3776.9729131344575, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5496, result.Item1);
        }

        [TestMethod]
        public void TestScore27()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual27);
            Assert.AreEqual(-3367.051407629086, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5497, result.Item1);
        }

        [TestMethod]
        public void TestScore28()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual28);
            Assert.AreEqual(-4334.154636175254, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5498, result.Item1);
        }

        [TestMethod]
        public void TestScore29()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual29);
            Assert.AreEqual(-3913.774683270462, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5499, result.Item1);
        }

        [TestMethod]
        public void TestScore30()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual30);
            Assert.AreEqual(-3778.6963303320017, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5500, result.Item1);
        }

        [TestMethod]
        public void TestScore31()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual31);
            Assert.AreEqual(-4508.074023615812, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5501, result.Item1);
        }

        [TestMethod]
        public void TestScore32()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual32);
            Assert.AreEqual(-3324.5022586380474, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5502, result.Item1);
        }

        [TestMethod]
        public void TestScore33()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual33);
            Assert.AreEqual(-3520.484105025386, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5503, result.Item1);
        }

        [TestMethod]
        public void TestScore34()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual34);
            Assert.AreEqual(-3854.2501831211202, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5504, result.Item1);
        }

        [TestMethod]
        public void TestScore35()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual35);
            Assert.AreEqual(-4417.744942861662, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5505, result.Item1);
        }

        [TestMethod]
        public void TestScore36()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual36);
            Assert.AreEqual(-4416.95858067073, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5506, result.Item1);
        }

        [TestMethod]
        public void TestScore37()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual37);
            Assert.AreEqual(-4527.982929301884, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5507, result.Item1);
        }

        [TestMethod]
        public void TestScore38()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual38);
            Assert.AreEqual(-4003.9946461563713, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5508, result.Item1);
        }

        [TestMethod]
        public void TestScore39()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual39);
            Assert.AreEqual(-4279.269627028865, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5509, result.Item1);
        }

        [TestMethod]
        public void TestScore40()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual40);
            Assert.AreEqual(-3210.867978677269, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5510, result.Item1);
        }

        [TestMethod]
        public void TestScore41()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual41);
            Assert.AreEqual(-3348.0970453049317, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5511, result.Item1);
        }

        [TestMethod]
        public void TestScore42()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual42);
            Assert.AreEqual(-3876.441685279331, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5512, result.Item1);
        }

        [TestMethod]
        public void TestScore43()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual43);
            Assert.AreEqual(-4333.757764501626, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5513, result.Item1);
        }

        [TestMethod]
        public void TestScore44()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual44);
            Assert.AreEqual(-4478.351879392318, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5514, result.Item1);
        }

        [TestMethod]
        public void TestScore45()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual45);
            Assert.AreEqual(-3497.8821821335823, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5515, result.Item1);
        }

        [TestMethod]
        public void TestScore46()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual46);
            Assert.AreEqual(-4384.319250375804, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5516, result.Item1);
        }

        [TestMethod]
        public void TestScore47()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual47);
            Assert.AreEqual(-4236.015329089381, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5517, result.Item1);
        }

        [TestMethod]
        public void TestScore48()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual48);
            Assert.AreEqual(-3745.526948432362, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5518, result.Item1);
        }

        [TestMethod]
        public void TestScore49()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual49);
            Assert.AreEqual(-2980.658752414498, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5519, result.Item1);
        }

        [TestMethod]
        public void TestScore50()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual50);
            Assert.AreEqual(-4712.666688564296, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5520, result.Item1);
        }

        [TestMethod]
        public void TestScore51()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual51);
            Assert.AreEqual(-4159.2541247212575, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5521, result.Item1);
        }

        [TestMethod]
        public void TestScore52()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual52);
            Assert.AreEqual(-4156.272467266336, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5522, result.Item1);
        }

        [TestMethod]
        public void TestScore53()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual53);
            Assert.AreEqual(-4400.313321409879, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5523, result.Item1);
        }

        [TestMethod]
        public void TestScore54()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual54);
            Assert.AreEqual(-4216.492755887659, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5524, result.Item1);
        }

        [TestMethod]
        public void TestScore55()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual55);
            Assert.AreEqual(-4210.5808204609, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5525, result.Item1);
        }

        [TestMethod]
        public void TestScore56()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual56);
            Assert.AreEqual(-4208.314957687042, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5526, result.Item1);
        }

        [TestMethod]
        public void TestScore57()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual57);
            Assert.AreEqual(-4354.661539128872, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5527, result.Item1);
        }

        [TestMethod]
        public void TestScore58()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual58);
            Assert.AreEqual(-3945.3158985839113, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5528, result.Item1);
        }

        [TestMethod]
        public void TestScore59()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual59);
            Assert.AreEqual(-3825.8669615811814, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5529, result.Item1);
        }

        [TestMethod]
        public void TestScore60()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual60);
            Assert.AreEqual(-3992.56549489296, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5530, result.Item1);
        }

        [TestMethod]
        public void TestScore61()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual61);
            Assert.AreEqual(-3887.692389134715, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5531, result.Item1);
        }

        [TestMethod]
        public void TestScore62()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual62);
            Assert.AreEqual(-3490.0778412733657, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5532, result.Item1);
        }

        [TestMethod]
        public void TestScore63()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual63);
            Assert.AreEqual(-3628.332700987491, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5533, result.Item1);
        }

        [TestMethod]
        public void TestScore64()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual64);
            Assert.AreEqual(-3589.3882489736466, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5534, result.Item1);
        }

        [TestMethod]
        public void TestScore65()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual65);
            Assert.AreEqual(-3660.4985184160787, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5535, result.Item1);
        }

        [TestMethod]
        public void TestScore66()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual66);
            Assert.AreEqual(-4187.295718813082, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5536, result.Item1);
        }

        [TestMethod]
        public void TestScore67()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual67);
            Assert.AreEqual(-3334.1642610208582, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5537, result.Item1);
        }

        [TestMethod]
        public void TestScore68()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual68);
            Assert.AreEqual(-4409.951764158144, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5538, result.Item1);
        }

        [TestMethod]
        public void TestScore69()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual69);
            Assert.AreEqual(-3836.1116053087057, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5539, result.Item1);
        }

        [TestMethod]
        public void TestScore70()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual70);
            Assert.AreEqual(-3938.096565704773, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5540, result.Item1);
        }

        [TestMethod]
        public void TestScore71()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual71);
            Assert.AreEqual(-4049.9236792859892, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5541, result.Item1);
        }

        [TestMethod]
        public void TestScore72()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual72);
            Assert.AreEqual(-4213.209567935317, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5542, result.Item1);
        }

        [TestMethod]
        public void TestScore73()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual73);
            Assert.AreEqual(-4460.407530043101, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5543, result.Item1);
        }

        [TestMethod]
        public void TestScore74()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual74);
            Assert.AreEqual(-4114.624336532248, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5544, result.Item1);
        }

        [TestMethod]
        public void TestScore75()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual75);
            Assert.AreEqual(-4262.362367363726, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5545, result.Item1);
        }

        [TestMethod]
        public void TestScore76()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual76);
            Assert.AreEqual(-3852.2122535775106, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5546, result.Item1);
        }

        [TestMethod]
        public void TestScore77()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual77);
            Assert.AreEqual(-4451.8260390933265, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5547, result.Item1);
        }

        [TestMethod]
        public void TestScore78()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual78);
            Assert.AreEqual(-4165.963770276487, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5548, result.Item1);
        }

        [TestMethod]
        public void TestScore79()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual79);
            Assert.AreEqual(-4276.075708181937, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5549, result.Item1);
        }

        [TestMethod]
        public void TestScore80()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual80);
            Assert.AreEqual(-3236.2132139889595, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5550, result.Item1);
        }

        [TestMethod]
        public void TestScore81()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual81);
            Assert.AreEqual(-4300.683869378428, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5551, result.Item1);
        }

        [TestMethod]
        public void TestScore82()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual82);
            Assert.AreEqual(-3050.626231239329, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5552, result.Item1);
        }

        [TestMethod]
        public void TestScore83()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual83);
            Assert.AreEqual(-3988.3566726125878, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5553, result.Item1);
        }

        [TestMethod]
        public void TestScore84()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual84);
            Assert.AreEqual(-4157.2789393393905, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5554, result.Item1);
        }

        [TestMethod]
        public void TestScore85()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual85);
            Assert.AreEqual(-3667.950507723622, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5555, result.Item1);
        }

        [TestMethod]
        public void TestScore86()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual86);
            Assert.AreEqual(-3935.4194923091923, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5556, result.Item1);
        }

        [TestMethod]
        public void TestScore87()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual87);
            Assert.AreEqual(-3964.38655810401, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5557, result.Item1);
        }

        [TestMethod]
        public void TestScore88()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual88);
            Assert.AreEqual(-3378.7468390810627, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5558, result.Item1);
        }

        [TestMethod]
        public void TestScore89()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual89);
            Assert.AreEqual(-3644.8135961849753, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5559, result.Item1);
        }

        [TestMethod]
        public void TestScore90()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual90);
            Assert.AreEqual(-4313.682810235794, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5560, result.Item1);
        }

        [TestMethod]
        public void TestScore91()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual91);
            Assert.AreEqual(-3637.6265509574605, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5561, result.Item1);
        }

        [TestMethod]
        public void TestScore92()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual92);
            Assert.AreEqual(-3683.143297897421, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5562, result.Item1);
        }

        [TestMethod]
        public void TestScore93()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual93);
            Assert.AreEqual(-3815.6831034433126, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5563, result.Item1);
        }

        [TestMethod]
        public void TestScore94()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual94);
            Assert.AreEqual(-3951.7648706963364, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5564, result.Item1);
        }

        [TestMethod]
        public void TestScore95()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual95);
            Assert.AreEqual(-3775.9507554393954, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5565, result.Item1);
        }

        [TestMethod]
        public void TestScore96()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual96);
            Assert.AreEqual(-3540.848540259409, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5566, result.Item1);
        }

        [TestMethod]
        public void TestScore97()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual97);
            Assert.AreEqual(-4140.821368908253, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5567, result.Item1);
        }

        [TestMethod]
        public void TestScore98()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual98);
            Assert.AreEqual(-3482.0079746203587, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5568, result.Item1);
        }

        [TestMethod]
        public void TestScore99()
        {
            var result = GeneticAlgorithm.score(TestFitnessFunctions.fitness10, TestIndividuals.individual99);
            Assert.AreEqual(-4390.985386729413, result.Item2);
            CollectionAssert.AreEqual(IndividualsResults.result5569, result.Item1);
        }

    }
}
