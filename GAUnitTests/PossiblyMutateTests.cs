using Microsoft.VisualStudio.TestTools.UnitTesting;
using CAB402.FSharp;

namespace GeneticAlgorithmUnitTests
{
    [TestClass]
    public class PossiblyMutateTests
    {
        [TestMethod]
        public void TestPossiblyMutate00()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result4470, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate01()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result4471, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate02()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result4472, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate03()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result4473, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate04()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result4474, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate05()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result4475, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate06()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result4476, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate07()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result4477, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate08()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result4478, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate09()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result4479, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate010()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual10));
            CollectionAssert.AreEqual(IndividualsResults.result4480, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate011()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual11));
            CollectionAssert.AreEqual(IndividualsResults.result4481, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate012()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual12));
            CollectionAssert.AreEqual(IndividualsResults.result4482, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate013()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual13));
            CollectionAssert.AreEqual(IndividualsResults.result4483, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate014()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual14));
            CollectionAssert.AreEqual(IndividualsResults.result4484, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate015()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual15));
            CollectionAssert.AreEqual(IndividualsResults.result4485, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate016()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual16));
            CollectionAssert.AreEqual(IndividualsResults.result4486, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate017()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual17));
            CollectionAssert.AreEqual(IndividualsResults.result4487, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate018()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual18));
            CollectionAssert.AreEqual(IndividualsResults.result4488, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate019()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual19));
            CollectionAssert.AreEqual(IndividualsResults.result4489, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate020()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual20));
            CollectionAssert.AreEqual(IndividualsResults.result4490, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate021()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual21));
            CollectionAssert.AreEqual(IndividualsResults.result4491, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate022()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual22));
            CollectionAssert.AreEqual(IndividualsResults.result4492, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate023()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual23));
            CollectionAssert.AreEqual(IndividualsResults.result4493, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate024()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual24));
            CollectionAssert.AreEqual(IndividualsResults.result4494, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate025()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual25));
            CollectionAssert.AreEqual(IndividualsResults.result4495, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate026()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual26));
            CollectionAssert.AreEqual(IndividualsResults.result4496, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate027()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual27));
            CollectionAssert.AreEqual(IndividualsResults.result4497, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate028()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual28));
            CollectionAssert.AreEqual(IndividualsResults.result4498, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate029()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual29));
            CollectionAssert.AreEqual(IndividualsResults.result4499, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate030()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual30));
            CollectionAssert.AreEqual(IndividualsResults.result4500, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate031()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual31));
            CollectionAssert.AreEqual(IndividualsResults.result4501, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate032()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual32));
            CollectionAssert.AreEqual(IndividualsResults.result4502, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate033()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual33));
            CollectionAssert.AreEqual(IndividualsResults.result4503, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate034()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual34));
            CollectionAssert.AreEqual(IndividualsResults.result4504, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate035()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual35));
            CollectionAssert.AreEqual(IndividualsResults.result4505, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate036()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual36));
            CollectionAssert.AreEqual(IndividualsResults.result4506, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate037()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual37));
            CollectionAssert.AreEqual(IndividualsResults.result4507, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate038()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual38));
            CollectionAssert.AreEqual(IndividualsResults.result4508, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate039()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual39));
            CollectionAssert.AreEqual(IndividualsResults.result4509, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate040()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual40));
            CollectionAssert.AreEqual(IndividualsResults.result4510, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate041()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual41));
            CollectionAssert.AreEqual(IndividualsResults.result4511, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate042()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual42));
            CollectionAssert.AreEqual(IndividualsResults.result4512, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate043()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual43));
            CollectionAssert.AreEqual(IndividualsResults.result4513, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate044()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual44));
            CollectionAssert.AreEqual(IndividualsResults.result4514, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate045()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual45));
            CollectionAssert.AreEqual(IndividualsResults.result4515, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate046()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual46));
            CollectionAssert.AreEqual(IndividualsResults.result4516, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate047()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual47));
            CollectionAssert.AreEqual(IndividualsResults.result4517, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate048()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual48));
            CollectionAssert.AreEqual(IndividualsResults.result4518, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate049()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual49));
            CollectionAssert.AreEqual(IndividualsResults.result4519, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate050()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual50));
            CollectionAssert.AreEqual(IndividualsResults.result4520, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate051()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual51));
            CollectionAssert.AreEqual(IndividualsResults.result4521, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate052()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual52));
            CollectionAssert.AreEqual(IndividualsResults.result4522, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate053()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual53));
            CollectionAssert.AreEqual(IndividualsResults.result4523, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate054()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual54));
            CollectionAssert.AreEqual(IndividualsResults.result4524, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate055()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual55));
            CollectionAssert.AreEqual(IndividualsResults.result4525, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate056()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual56));
            CollectionAssert.AreEqual(IndividualsResults.result4526, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate057()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual57));
            CollectionAssert.AreEqual(IndividualsResults.result4527, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate058()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual58));
            CollectionAssert.AreEqual(IndividualsResults.result4528, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate059()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual59));
            CollectionAssert.AreEqual(IndividualsResults.result4529, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate060()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual60));
            CollectionAssert.AreEqual(IndividualsResults.result4530, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate061()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual61));
            CollectionAssert.AreEqual(IndividualsResults.result4531, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate062()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual62));
            CollectionAssert.AreEqual(IndividualsResults.result4532, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate063()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual63));
            CollectionAssert.AreEqual(IndividualsResults.result4533, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate064()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual64));
            CollectionAssert.AreEqual(IndividualsResults.result4534, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate065()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual65));
            CollectionAssert.AreEqual(IndividualsResults.result4535, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate066()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual66));
            CollectionAssert.AreEqual(IndividualsResults.result4536, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate067()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual67));
            CollectionAssert.AreEqual(IndividualsResults.result4537, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate068()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual68));
            CollectionAssert.AreEqual(IndividualsResults.result4538, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate069()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual69));
            CollectionAssert.AreEqual(IndividualsResults.result4539, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate070()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual70));
            CollectionAssert.AreEqual(IndividualsResults.result4540, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate071()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual71));
            CollectionAssert.AreEqual(IndividualsResults.result4541, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate072()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual72));
            CollectionAssert.AreEqual(IndividualsResults.result4542, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate073()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual73));
            CollectionAssert.AreEqual(IndividualsResults.result4543, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate074()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual74));
            CollectionAssert.AreEqual(IndividualsResults.result4544, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate075()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual75));
            CollectionAssert.AreEqual(IndividualsResults.result4545, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate076()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual76));
            CollectionAssert.AreEqual(IndividualsResults.result4546, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate077()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual77));
            CollectionAssert.AreEqual(IndividualsResults.result4547, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate078()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual78));
            CollectionAssert.AreEqual(IndividualsResults.result4548, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate079()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual79));
            CollectionAssert.AreEqual(IndividualsResults.result4549, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate080()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual80));
            CollectionAssert.AreEqual(IndividualsResults.result4550, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate081()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual81));
            CollectionAssert.AreEqual(IndividualsResults.result4551, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate082()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual82));
            CollectionAssert.AreEqual(IndividualsResults.result4552, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate083()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual83));
            CollectionAssert.AreEqual(IndividualsResults.result4553, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate084()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual84));
            CollectionAssert.AreEqual(IndividualsResults.result4554, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate085()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual85));
            CollectionAssert.AreEqual(IndividualsResults.result4555, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate086()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual86));
            CollectionAssert.AreEqual(IndividualsResults.result4556, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate087()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual87));
            CollectionAssert.AreEqual(IndividualsResults.result4557, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate088()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual88));
            CollectionAssert.AreEqual(IndividualsResults.result4558, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate089()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual89));
            CollectionAssert.AreEqual(IndividualsResults.result4559, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate090()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual90));
            CollectionAssert.AreEqual(IndividualsResults.result4560, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate091()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual91));
            CollectionAssert.AreEqual(IndividualsResults.result4561, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate092()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual92));
            CollectionAssert.AreEqual(IndividualsResults.result4562, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate093()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual93));
            CollectionAssert.AreEqual(IndividualsResults.result4563, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate094()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual94));
            CollectionAssert.AreEqual(IndividualsResults.result4564, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate095()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual95));
            CollectionAssert.AreEqual(IndividualsResults.result4565, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate096()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual96));
            CollectionAssert.AreEqual(IndividualsResults.result4566, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate097()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual97));
            CollectionAssert.AreEqual(IndividualsResults.result4567, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate098()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual98));
            CollectionAssert.AreEqual(IndividualsResults.result4568, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate099()
        {
            var random = new System.Random(0);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual99));
            CollectionAssert.AreEqual(IndividualsResults.result4569, result);
            Assert.AreEqual(1755192844, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate10()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result4570, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate11()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result4571, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate12()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result4572, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate13()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result4573, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate14()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result4574, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate15()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result4575, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate16()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result4576, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate17()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result4577, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate18()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result4578, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate19()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result4579, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate110()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual10));
            CollectionAssert.AreEqual(IndividualsResults.result4580, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate111()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual11));
            CollectionAssert.AreEqual(IndividualsResults.result4581, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate112()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual12));
            CollectionAssert.AreEqual(IndividualsResults.result4582, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate113()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual13));
            CollectionAssert.AreEqual(IndividualsResults.result4583, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate114()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual14));
            CollectionAssert.AreEqual(IndividualsResults.result4584, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate115()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual15));
            CollectionAssert.AreEqual(IndividualsResults.result4585, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate116()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual16));
            CollectionAssert.AreEqual(IndividualsResults.result4586, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate117()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual17));
            CollectionAssert.AreEqual(IndividualsResults.result4587, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate118()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual18));
            CollectionAssert.AreEqual(IndividualsResults.result4588, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate119()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual19));
            CollectionAssert.AreEqual(IndividualsResults.result4589, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate120()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual20));
            CollectionAssert.AreEqual(IndividualsResults.result4590, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate121()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual21));
            CollectionAssert.AreEqual(IndividualsResults.result4591, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate122()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual22));
            CollectionAssert.AreEqual(IndividualsResults.result4592, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate123()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual23));
            CollectionAssert.AreEqual(IndividualsResults.result4593, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate124()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual24));
            CollectionAssert.AreEqual(IndividualsResults.result4594, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate125()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual25));
            CollectionAssert.AreEqual(IndividualsResults.result4595, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate126()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual26));
            CollectionAssert.AreEqual(IndividualsResults.result4596, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate127()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual27));
            CollectionAssert.AreEqual(IndividualsResults.result4597, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate128()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual28));
            CollectionAssert.AreEqual(IndividualsResults.result4598, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate129()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual29));
            CollectionAssert.AreEqual(IndividualsResults.result4599, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate130()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual30));
            CollectionAssert.AreEqual(IndividualsResults.result4600, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate131()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual31));
            CollectionAssert.AreEqual(IndividualsResults.result4601, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate132()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual32));
            CollectionAssert.AreEqual(IndividualsResults.result4602, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate133()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual33));
            CollectionAssert.AreEqual(IndividualsResults.result4603, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate134()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual34));
            CollectionAssert.AreEqual(IndividualsResults.result4604, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate135()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual35));
            CollectionAssert.AreEqual(IndividualsResults.result4605, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate136()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual36));
            CollectionAssert.AreEqual(IndividualsResults.result4606, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate137()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual37));
            CollectionAssert.AreEqual(IndividualsResults.result4607, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate138()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual38));
            CollectionAssert.AreEqual(IndividualsResults.result4608, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate139()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual39));
            CollectionAssert.AreEqual(IndividualsResults.result4609, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate140()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual40));
            CollectionAssert.AreEqual(IndividualsResults.result4610, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate141()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual41));
            CollectionAssert.AreEqual(IndividualsResults.result4611, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate142()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual42));
            CollectionAssert.AreEqual(IndividualsResults.result4612, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate143()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual43));
            CollectionAssert.AreEqual(IndividualsResults.result4613, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate144()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual44));
            CollectionAssert.AreEqual(IndividualsResults.result4614, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate145()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual45));
            CollectionAssert.AreEqual(IndividualsResults.result4615, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate146()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual46));
            CollectionAssert.AreEqual(IndividualsResults.result4616, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate147()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual47));
            CollectionAssert.AreEqual(IndividualsResults.result4617, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate148()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual48));
            CollectionAssert.AreEqual(IndividualsResults.result4618, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate149()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual49));
            CollectionAssert.AreEqual(IndividualsResults.result4619, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate150()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual50));
            CollectionAssert.AreEqual(IndividualsResults.result4620, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate151()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual51));
            CollectionAssert.AreEqual(IndividualsResults.result4621, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate152()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual52));
            CollectionAssert.AreEqual(IndividualsResults.result4622, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate153()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual53));
            CollectionAssert.AreEqual(IndividualsResults.result4623, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate154()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual54));
            CollectionAssert.AreEqual(IndividualsResults.result4624, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate155()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual55));
            CollectionAssert.AreEqual(IndividualsResults.result4625, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate156()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual56));
            CollectionAssert.AreEqual(IndividualsResults.result4626, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate157()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual57));
            CollectionAssert.AreEqual(IndividualsResults.result4627, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate158()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual58));
            CollectionAssert.AreEqual(IndividualsResults.result4628, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate159()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual59));
            CollectionAssert.AreEqual(IndividualsResults.result4629, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate160()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual60));
            CollectionAssert.AreEqual(IndividualsResults.result4630, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate161()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual61));
            CollectionAssert.AreEqual(IndividualsResults.result4631, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate162()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual62));
            CollectionAssert.AreEqual(IndividualsResults.result4632, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate163()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual63));
            CollectionAssert.AreEqual(IndividualsResults.result4633, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate164()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual64));
            CollectionAssert.AreEqual(IndividualsResults.result4634, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate165()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual65));
            CollectionAssert.AreEqual(IndividualsResults.result4635, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate166()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual66));
            CollectionAssert.AreEqual(IndividualsResults.result4636, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate167()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual67));
            CollectionAssert.AreEqual(IndividualsResults.result4637, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate168()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual68));
            CollectionAssert.AreEqual(IndividualsResults.result4638, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate169()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual69));
            CollectionAssert.AreEqual(IndividualsResults.result4639, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate170()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual70));
            CollectionAssert.AreEqual(IndividualsResults.result4640, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate171()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual71));
            CollectionAssert.AreEqual(IndividualsResults.result4641, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate172()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual72));
            CollectionAssert.AreEqual(IndividualsResults.result4642, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate173()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual73));
            CollectionAssert.AreEqual(IndividualsResults.result4643, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate174()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual74));
            CollectionAssert.AreEqual(IndividualsResults.result4644, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate175()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual75));
            CollectionAssert.AreEqual(IndividualsResults.result4645, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate176()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual76));
            CollectionAssert.AreEqual(IndividualsResults.result4646, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate177()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual77));
            CollectionAssert.AreEqual(IndividualsResults.result4647, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate178()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual78));
            CollectionAssert.AreEqual(IndividualsResults.result4648, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate179()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual79));
            CollectionAssert.AreEqual(IndividualsResults.result4649, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate180()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual80));
            CollectionAssert.AreEqual(IndividualsResults.result4650, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate181()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual81));
            CollectionAssert.AreEqual(IndividualsResults.result4651, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate182()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual82));
            CollectionAssert.AreEqual(IndividualsResults.result4652, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate183()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual83));
            CollectionAssert.AreEqual(IndividualsResults.result4653, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate184()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual84));
            CollectionAssert.AreEqual(IndividualsResults.result4654, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate185()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual85));
            CollectionAssert.AreEqual(IndividualsResults.result4655, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate186()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual86));
            CollectionAssert.AreEqual(IndividualsResults.result4656, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate187()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual87));
            CollectionAssert.AreEqual(IndividualsResults.result4657, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate188()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual88));
            CollectionAssert.AreEqual(IndividualsResults.result4658, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate189()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual89));
            CollectionAssert.AreEqual(IndividualsResults.result4659, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate190()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual90));
            CollectionAssert.AreEqual(IndividualsResults.result4660, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate191()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual91));
            CollectionAssert.AreEqual(IndividualsResults.result4661, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate192()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual92));
            CollectionAssert.AreEqual(IndividualsResults.result4662, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate193()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual93));
            CollectionAssert.AreEqual(IndividualsResults.result4663, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate194()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual94));
            CollectionAssert.AreEqual(IndividualsResults.result4664, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate195()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual95));
            CollectionAssert.AreEqual(IndividualsResults.result4665, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate196()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual96));
            CollectionAssert.AreEqual(IndividualsResults.result4666, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate197()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual97));
            CollectionAssert.AreEqual(IndividualsResults.result4667, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate198()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual98));
            CollectionAssert.AreEqual(IndividualsResults.result4668, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate199()
        {
            var random = new System.Random(1);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual99));
            CollectionAssert.AreEqual(IndividualsResults.result4669, result);
            Assert.AreEqual(237820880, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate20()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result4670, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate21()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result4671, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate22()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result4672, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate23()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result4673, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate24()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result4674, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate25()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result4675, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate26()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result4676, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate27()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result4677, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate28()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result4678, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate29()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result4679, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate210()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual10));
            CollectionAssert.AreEqual(IndividualsResults.result4680, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate211()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual11));
            CollectionAssert.AreEqual(IndividualsResults.result4681, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate212()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual12));
            CollectionAssert.AreEqual(IndividualsResults.result4682, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate213()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual13));
            CollectionAssert.AreEqual(IndividualsResults.result4683, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate214()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual14));
            CollectionAssert.AreEqual(IndividualsResults.result4684, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate215()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual15));
            CollectionAssert.AreEqual(IndividualsResults.result4685, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate216()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual16));
            CollectionAssert.AreEqual(IndividualsResults.result4686, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate217()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual17));
            CollectionAssert.AreEqual(IndividualsResults.result4687, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate218()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual18));
            CollectionAssert.AreEqual(IndividualsResults.result4688, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate219()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual19));
            CollectionAssert.AreEqual(IndividualsResults.result4689, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate220()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual20));
            CollectionAssert.AreEqual(IndividualsResults.result4690, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate221()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual21));
            CollectionAssert.AreEqual(IndividualsResults.result4691, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate222()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual22));
            CollectionAssert.AreEqual(IndividualsResults.result4692, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate223()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual23));
            CollectionAssert.AreEqual(IndividualsResults.result4693, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate224()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual24));
            CollectionAssert.AreEqual(IndividualsResults.result4694, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate225()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual25));
            CollectionAssert.AreEqual(IndividualsResults.result4695, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate226()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual26));
            CollectionAssert.AreEqual(IndividualsResults.result4696, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate227()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual27));
            CollectionAssert.AreEqual(IndividualsResults.result4697, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate228()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual28));
            CollectionAssert.AreEqual(IndividualsResults.result4698, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate229()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual29));
            CollectionAssert.AreEqual(IndividualsResults.result4699, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate230()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual30));
            CollectionAssert.AreEqual(IndividualsResults.result4700, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate231()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual31));
            CollectionAssert.AreEqual(IndividualsResults.result4701, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate232()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual32));
            CollectionAssert.AreEqual(IndividualsResults.result4702, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate233()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual33));
            CollectionAssert.AreEqual(IndividualsResults.result4703, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate234()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual34));
            CollectionAssert.AreEqual(IndividualsResults.result4704, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate235()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual35));
            CollectionAssert.AreEqual(IndividualsResults.result4705, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate236()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual36));
            CollectionAssert.AreEqual(IndividualsResults.result4706, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate237()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual37));
            CollectionAssert.AreEqual(IndividualsResults.result4707, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate238()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual38));
            CollectionAssert.AreEqual(IndividualsResults.result4708, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate239()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual39));
            CollectionAssert.AreEqual(IndividualsResults.result4709, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate240()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual40));
            CollectionAssert.AreEqual(IndividualsResults.result4710, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate241()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual41));
            CollectionAssert.AreEqual(IndividualsResults.result4711, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate242()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual42));
            CollectionAssert.AreEqual(IndividualsResults.result4712, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate243()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual43));
            CollectionAssert.AreEqual(IndividualsResults.result4713, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate244()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual44));
            CollectionAssert.AreEqual(IndividualsResults.result4714, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate245()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual45));
            CollectionAssert.AreEqual(IndividualsResults.result4715, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate246()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual46));
            CollectionAssert.AreEqual(IndividualsResults.result4716, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate247()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual47));
            CollectionAssert.AreEqual(IndividualsResults.result4717, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate248()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual48));
            CollectionAssert.AreEqual(IndividualsResults.result4718, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate249()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual49));
            CollectionAssert.AreEqual(IndividualsResults.result4719, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate250()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual50));
            CollectionAssert.AreEqual(IndividualsResults.result4720, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate251()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual51));
            CollectionAssert.AreEqual(IndividualsResults.result4721, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate252()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual52));
            CollectionAssert.AreEqual(IndividualsResults.result4722, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate253()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual53));
            CollectionAssert.AreEqual(IndividualsResults.result4723, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate254()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual54));
            CollectionAssert.AreEqual(IndividualsResults.result4724, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate255()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual55));
            CollectionAssert.AreEqual(IndividualsResults.result4725, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate256()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual56));
            CollectionAssert.AreEqual(IndividualsResults.result4726, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate257()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual57));
            CollectionAssert.AreEqual(IndividualsResults.result4727, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate258()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual58));
            CollectionAssert.AreEqual(IndividualsResults.result4728, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate259()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual59));
            CollectionAssert.AreEqual(IndividualsResults.result4729, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate260()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual60));
            CollectionAssert.AreEqual(IndividualsResults.result4730, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate261()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual61));
            CollectionAssert.AreEqual(IndividualsResults.result4731, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate262()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual62));
            CollectionAssert.AreEqual(IndividualsResults.result4732, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate263()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual63));
            CollectionAssert.AreEqual(IndividualsResults.result4733, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate264()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual64));
            CollectionAssert.AreEqual(IndividualsResults.result4734, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate265()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual65));
            CollectionAssert.AreEqual(IndividualsResults.result4735, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate266()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual66));
            CollectionAssert.AreEqual(IndividualsResults.result4736, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate267()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual67));
            CollectionAssert.AreEqual(IndividualsResults.result4737, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate268()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual68));
            CollectionAssert.AreEqual(IndividualsResults.result4738, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate269()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual69));
            CollectionAssert.AreEqual(IndividualsResults.result4739, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate270()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual70));
            CollectionAssert.AreEqual(IndividualsResults.result4740, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate271()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual71));
            CollectionAssert.AreEqual(IndividualsResults.result4741, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate272()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual72));
            CollectionAssert.AreEqual(IndividualsResults.result4742, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate273()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual73));
            CollectionAssert.AreEqual(IndividualsResults.result4743, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate274()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual74));
            CollectionAssert.AreEqual(IndividualsResults.result4744, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate275()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual75));
            CollectionAssert.AreEqual(IndividualsResults.result4745, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate276()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual76));
            CollectionAssert.AreEqual(IndividualsResults.result4746, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate277()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual77));
            CollectionAssert.AreEqual(IndividualsResults.result4747, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate278()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual78));
            CollectionAssert.AreEqual(IndividualsResults.result4748, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate279()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual79));
            CollectionAssert.AreEqual(IndividualsResults.result4749, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate280()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual80));
            CollectionAssert.AreEqual(IndividualsResults.result4750, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate281()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual81));
            CollectionAssert.AreEqual(IndividualsResults.result4751, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate282()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual82));
            CollectionAssert.AreEqual(IndividualsResults.result4752, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate283()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual83));
            CollectionAssert.AreEqual(IndividualsResults.result4753, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate284()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual84));
            CollectionAssert.AreEqual(IndividualsResults.result4754, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate285()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual85));
            CollectionAssert.AreEqual(IndividualsResults.result4755, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate286()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual86));
            CollectionAssert.AreEqual(IndividualsResults.result4756, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate287()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual87));
            CollectionAssert.AreEqual(IndividualsResults.result4757, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate288()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual88));
            CollectionAssert.AreEqual(IndividualsResults.result4758, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate289()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual89));
            CollectionAssert.AreEqual(IndividualsResults.result4759, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate290()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual90));
            CollectionAssert.AreEqual(IndividualsResults.result4760, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate291()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual91));
            CollectionAssert.AreEqual(IndividualsResults.result4761, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate292()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual92));
            CollectionAssert.AreEqual(IndividualsResults.result4762, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate293()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual93));
            CollectionAssert.AreEqual(IndividualsResults.result4763, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate294()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual94));
            CollectionAssert.AreEqual(IndividualsResults.result4764, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate295()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual95));
            CollectionAssert.AreEqual(IndividualsResults.result4765, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate296()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual96));
            CollectionAssert.AreEqual(IndividualsResults.result4766, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate297()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual97));
            CollectionAssert.AreEqual(IndividualsResults.result4767, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate298()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual98));
            CollectionAssert.AreEqual(IndividualsResults.result4768, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate299()
        {
            var random = new System.Random(2);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual99));
            CollectionAssert.AreEqual(IndividualsResults.result4769, result);
            Assert.AreEqual(867932563, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate30()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result4770, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate31()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result4771, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate32()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result4772, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate33()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result4773, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate34()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result4774, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate35()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result4775, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate36()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result4776, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate37()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result4777, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate38()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result4778, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate39()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result4779, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate310()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual10));
            CollectionAssert.AreEqual(IndividualsResults.result4780, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate311()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual11));
            CollectionAssert.AreEqual(IndividualsResults.result4781, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate312()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual12));
            CollectionAssert.AreEqual(IndividualsResults.result4782, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate313()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual13));
            CollectionAssert.AreEqual(IndividualsResults.result4783, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate314()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual14));
            CollectionAssert.AreEqual(IndividualsResults.result4784, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate315()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual15));
            CollectionAssert.AreEqual(IndividualsResults.result4785, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate316()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual16));
            CollectionAssert.AreEqual(IndividualsResults.result4786, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate317()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual17));
            CollectionAssert.AreEqual(IndividualsResults.result4787, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate318()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual18));
            CollectionAssert.AreEqual(IndividualsResults.result4788, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate319()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual19));
            CollectionAssert.AreEqual(IndividualsResults.result4789, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate320()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual20));
            CollectionAssert.AreEqual(IndividualsResults.result4790, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate321()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual21));
            CollectionAssert.AreEqual(IndividualsResults.result4791, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate322()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual22));
            CollectionAssert.AreEqual(IndividualsResults.result4792, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate323()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual23));
            CollectionAssert.AreEqual(IndividualsResults.result4793, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate324()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual24));
            CollectionAssert.AreEqual(IndividualsResults.result4794, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate325()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual25));
            CollectionAssert.AreEqual(IndividualsResults.result4795, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate326()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual26));
            CollectionAssert.AreEqual(IndividualsResults.result4796, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate327()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual27));
            CollectionAssert.AreEqual(IndividualsResults.result4797, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate328()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual28));
            CollectionAssert.AreEqual(IndividualsResults.result4798, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate329()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual29));
            CollectionAssert.AreEqual(IndividualsResults.result4799, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate330()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual30));
            CollectionAssert.AreEqual(IndividualsResults.result4800, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate331()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual31));
            CollectionAssert.AreEqual(IndividualsResults.result4801, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate332()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual32));
            CollectionAssert.AreEqual(IndividualsResults.result4802, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate333()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual33));
            CollectionAssert.AreEqual(IndividualsResults.result4803, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate334()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual34));
            CollectionAssert.AreEqual(IndividualsResults.result4804, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate335()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual35));
            CollectionAssert.AreEqual(IndividualsResults.result4805, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate336()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual36));
            CollectionAssert.AreEqual(IndividualsResults.result4806, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate337()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual37));
            CollectionAssert.AreEqual(IndividualsResults.result4807, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate338()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual38));
            CollectionAssert.AreEqual(IndividualsResults.result4808, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate339()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual39));
            CollectionAssert.AreEqual(IndividualsResults.result4809, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate340()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual40));
            CollectionAssert.AreEqual(IndividualsResults.result4810, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate341()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual41));
            CollectionAssert.AreEqual(IndividualsResults.result4811, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate342()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual42));
            CollectionAssert.AreEqual(IndividualsResults.result4812, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate343()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual43));
            CollectionAssert.AreEqual(IndividualsResults.result4813, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate344()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual44));
            CollectionAssert.AreEqual(IndividualsResults.result4814, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate345()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual45));
            CollectionAssert.AreEqual(IndividualsResults.result4815, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate346()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual46));
            CollectionAssert.AreEqual(IndividualsResults.result4816, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate347()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual47));
            CollectionAssert.AreEqual(IndividualsResults.result4817, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate348()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual48));
            CollectionAssert.AreEqual(IndividualsResults.result4818, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate349()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual49));
            CollectionAssert.AreEqual(IndividualsResults.result4819, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate350()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual50));
            CollectionAssert.AreEqual(IndividualsResults.result4820, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate351()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual51));
            CollectionAssert.AreEqual(IndividualsResults.result4821, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate352()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual52));
            CollectionAssert.AreEqual(IndividualsResults.result4822, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate353()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual53));
            CollectionAssert.AreEqual(IndividualsResults.result4823, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate354()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual54));
            CollectionAssert.AreEqual(IndividualsResults.result4824, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate355()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual55));
            CollectionAssert.AreEqual(IndividualsResults.result4825, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate356()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual56));
            CollectionAssert.AreEqual(IndividualsResults.result4826, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate357()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual57));
            CollectionAssert.AreEqual(IndividualsResults.result4827, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate358()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual58));
            CollectionAssert.AreEqual(IndividualsResults.result4828, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate359()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual59));
            CollectionAssert.AreEqual(IndividualsResults.result4829, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate360()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual60));
            CollectionAssert.AreEqual(IndividualsResults.result4830, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate361()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual61));
            CollectionAssert.AreEqual(IndividualsResults.result4831, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate362()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual62));
            CollectionAssert.AreEqual(IndividualsResults.result4832, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate363()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual63));
            CollectionAssert.AreEqual(IndividualsResults.result4833, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate364()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual64));
            CollectionAssert.AreEqual(IndividualsResults.result4834, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate365()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual65));
            CollectionAssert.AreEqual(IndividualsResults.result4835, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate366()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual66));
            CollectionAssert.AreEqual(IndividualsResults.result4836, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate367()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual67));
            CollectionAssert.AreEqual(IndividualsResults.result4837, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate368()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual68));
            CollectionAssert.AreEqual(IndividualsResults.result4838, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate369()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual69));
            CollectionAssert.AreEqual(IndividualsResults.result4839, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate370()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual70));
            CollectionAssert.AreEqual(IndividualsResults.result4840, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate371()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual71));
            CollectionAssert.AreEqual(IndividualsResults.result4841, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate372()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual72));
            CollectionAssert.AreEqual(IndividualsResults.result4842, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate373()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual73));
            CollectionAssert.AreEqual(IndividualsResults.result4843, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate374()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual74));
            CollectionAssert.AreEqual(IndividualsResults.result4844, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate375()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual75));
            CollectionAssert.AreEqual(IndividualsResults.result4845, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate376()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual76));
            CollectionAssert.AreEqual(IndividualsResults.result4846, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate377()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual77));
            CollectionAssert.AreEqual(IndividualsResults.result4847, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate378()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual78));
            CollectionAssert.AreEqual(IndividualsResults.result4848, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate379()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual79));
            CollectionAssert.AreEqual(IndividualsResults.result4849, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate380()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual80));
            CollectionAssert.AreEqual(IndividualsResults.result4850, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate381()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual81));
            CollectionAssert.AreEqual(IndividualsResults.result4851, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate382()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual82));
            CollectionAssert.AreEqual(IndividualsResults.result4852, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate383()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual83));
            CollectionAssert.AreEqual(IndividualsResults.result4853, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate384()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual84));
            CollectionAssert.AreEqual(IndividualsResults.result4854, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate385()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual85));
            CollectionAssert.AreEqual(IndividualsResults.result4855, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate386()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual86));
            CollectionAssert.AreEqual(IndividualsResults.result4856, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate387()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual87));
            CollectionAssert.AreEqual(IndividualsResults.result4857, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate388()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual88));
            CollectionAssert.AreEqual(IndividualsResults.result4858, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate389()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual89));
            CollectionAssert.AreEqual(IndividualsResults.result4859, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate390()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual90));
            CollectionAssert.AreEqual(IndividualsResults.result4860, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate391()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual91));
            CollectionAssert.AreEqual(IndividualsResults.result4861, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate392()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual92));
            CollectionAssert.AreEqual(IndividualsResults.result4862, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate393()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual93));
            CollectionAssert.AreEqual(IndividualsResults.result4863, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate394()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual94));
            CollectionAssert.AreEqual(IndividualsResults.result4864, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate395()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual95));
            CollectionAssert.AreEqual(IndividualsResults.result4865, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate396()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual96));
            CollectionAssert.AreEqual(IndividualsResults.result4866, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate397()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual97));
            CollectionAssert.AreEqual(IndividualsResults.result4867, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate398()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual98));
            CollectionAssert.AreEqual(IndividualsResults.result4868, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate399()
        {
            var random = new System.Random(3);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual99));
            CollectionAssert.AreEqual(IndividualsResults.result4869, result);
            Assert.AreEqual(1498044246, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate40()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result4870, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate41()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result4871, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate42()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result4872, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate43()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result4873, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate44()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result4874, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate45()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result4875, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate46()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result4876, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate47()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result4877, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate48()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result4878, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate49()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result4879, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate410()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual10));
            CollectionAssert.AreEqual(IndividualsResults.result4880, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate411()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual11));
            CollectionAssert.AreEqual(IndividualsResults.result4881, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate412()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual12));
            CollectionAssert.AreEqual(IndividualsResults.result4882, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate413()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual13));
            CollectionAssert.AreEqual(IndividualsResults.result4883, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate414()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual14));
            CollectionAssert.AreEqual(IndividualsResults.result4884, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate415()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual15));
            CollectionAssert.AreEqual(IndividualsResults.result4885, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate416()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual16));
            CollectionAssert.AreEqual(IndividualsResults.result4886, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate417()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual17));
            CollectionAssert.AreEqual(IndividualsResults.result4887, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate418()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual18));
            CollectionAssert.AreEqual(IndividualsResults.result4888, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate419()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual19));
            CollectionAssert.AreEqual(IndividualsResults.result4889, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate420()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual20));
            CollectionAssert.AreEqual(IndividualsResults.result4890, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate421()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual21));
            CollectionAssert.AreEqual(IndividualsResults.result4891, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate422()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual22));
            CollectionAssert.AreEqual(IndividualsResults.result4892, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate423()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual23));
            CollectionAssert.AreEqual(IndividualsResults.result4893, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate424()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual24));
            CollectionAssert.AreEqual(IndividualsResults.result4894, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate425()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual25));
            CollectionAssert.AreEqual(IndividualsResults.result4895, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate426()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual26));
            CollectionAssert.AreEqual(IndividualsResults.result4896, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate427()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual27));
            CollectionAssert.AreEqual(IndividualsResults.result4897, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate428()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual28));
            CollectionAssert.AreEqual(IndividualsResults.result4898, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate429()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual29));
            CollectionAssert.AreEqual(IndividualsResults.result4899, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate430()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual30));
            CollectionAssert.AreEqual(IndividualsResults.result4900, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate431()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual31));
            CollectionAssert.AreEqual(IndividualsResults.result4901, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate432()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual32));
            CollectionAssert.AreEqual(IndividualsResults.result4902, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate433()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual33));
            CollectionAssert.AreEqual(IndividualsResults.result4903, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate434()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual34));
            CollectionAssert.AreEqual(IndividualsResults.result4904, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate435()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual35));
            CollectionAssert.AreEqual(IndividualsResults.result4905, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate436()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual36));
            CollectionAssert.AreEqual(IndividualsResults.result4906, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate437()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual37));
            CollectionAssert.AreEqual(IndividualsResults.result4907, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate438()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual38));
            CollectionAssert.AreEqual(IndividualsResults.result4908, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate439()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual39));
            CollectionAssert.AreEqual(IndividualsResults.result4909, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate440()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual40));
            CollectionAssert.AreEqual(IndividualsResults.result4910, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate441()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual41));
            CollectionAssert.AreEqual(IndividualsResults.result4911, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate442()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual42));
            CollectionAssert.AreEqual(IndividualsResults.result4912, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate443()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual43));
            CollectionAssert.AreEqual(IndividualsResults.result4913, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate444()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual44));
            CollectionAssert.AreEqual(IndividualsResults.result4914, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate445()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual45));
            CollectionAssert.AreEqual(IndividualsResults.result4915, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate446()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual46));
            CollectionAssert.AreEqual(IndividualsResults.result4916, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate447()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual47));
            CollectionAssert.AreEqual(IndividualsResults.result4917, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate448()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual48));
            CollectionAssert.AreEqual(IndividualsResults.result4918, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate449()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual49));
            CollectionAssert.AreEqual(IndividualsResults.result4919, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate450()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual50));
            CollectionAssert.AreEqual(IndividualsResults.result4920, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate451()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual51));
            CollectionAssert.AreEqual(IndividualsResults.result4921, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate452()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual52));
            CollectionAssert.AreEqual(IndividualsResults.result4922, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate453()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual53));
            CollectionAssert.AreEqual(IndividualsResults.result4923, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate454()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual54));
            CollectionAssert.AreEqual(IndividualsResults.result4924, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate455()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual55));
            CollectionAssert.AreEqual(IndividualsResults.result4925, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate456()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual56));
            CollectionAssert.AreEqual(IndividualsResults.result4926, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate457()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual57));
            CollectionAssert.AreEqual(IndividualsResults.result4927, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate458()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual58));
            CollectionAssert.AreEqual(IndividualsResults.result4928, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate459()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual59));
            CollectionAssert.AreEqual(IndividualsResults.result4929, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate460()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual60));
            CollectionAssert.AreEqual(IndividualsResults.result4930, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate461()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual61));
            CollectionAssert.AreEqual(IndividualsResults.result4931, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate462()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual62));
            CollectionAssert.AreEqual(IndividualsResults.result4932, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate463()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual63));
            CollectionAssert.AreEqual(IndividualsResults.result4933, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate464()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual64));
            CollectionAssert.AreEqual(IndividualsResults.result4934, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate465()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual65));
            CollectionAssert.AreEqual(IndividualsResults.result4935, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate466()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual66));
            CollectionAssert.AreEqual(IndividualsResults.result4936, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate467()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual67));
            CollectionAssert.AreEqual(IndividualsResults.result4937, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate468()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual68));
            CollectionAssert.AreEqual(IndividualsResults.result4938, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate469()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual69));
            CollectionAssert.AreEqual(IndividualsResults.result4939, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate470()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual70));
            CollectionAssert.AreEqual(IndividualsResults.result4940, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate471()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual71));
            CollectionAssert.AreEqual(IndividualsResults.result4941, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate472()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual72));
            CollectionAssert.AreEqual(IndividualsResults.result4942, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate473()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual73));
            CollectionAssert.AreEqual(IndividualsResults.result4943, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate474()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual74));
            CollectionAssert.AreEqual(IndividualsResults.result4944, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate475()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual75));
            CollectionAssert.AreEqual(IndividualsResults.result4945, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate476()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual76));
            CollectionAssert.AreEqual(IndividualsResults.result4946, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate477()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual77));
            CollectionAssert.AreEqual(IndividualsResults.result4947, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate478()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual78));
            CollectionAssert.AreEqual(IndividualsResults.result4948, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate479()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual79));
            CollectionAssert.AreEqual(IndividualsResults.result4949, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate480()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual80));
            CollectionAssert.AreEqual(IndividualsResults.result4950, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate481()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual81));
            CollectionAssert.AreEqual(IndividualsResults.result4951, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate482()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual82));
            CollectionAssert.AreEqual(IndividualsResults.result4952, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate483()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual83));
            CollectionAssert.AreEqual(IndividualsResults.result4953, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate484()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual84));
            CollectionAssert.AreEqual(IndividualsResults.result4954, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate485()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual85));
            CollectionAssert.AreEqual(IndividualsResults.result4955, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate486()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual86));
            CollectionAssert.AreEqual(IndividualsResults.result4956, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate487()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual87));
            CollectionAssert.AreEqual(IndividualsResults.result4957, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate488()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual88));
            CollectionAssert.AreEqual(IndividualsResults.result4958, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate489()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual89));
            CollectionAssert.AreEqual(IndividualsResults.result4959, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate490()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual90));
            CollectionAssert.AreEqual(IndividualsResults.result4960, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate491()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual91));
            CollectionAssert.AreEqual(IndividualsResults.result4961, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate492()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual92));
            CollectionAssert.AreEqual(IndividualsResults.result4962, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate493()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual93));
            CollectionAssert.AreEqual(IndividualsResults.result4963, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate494()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual94));
            CollectionAssert.AreEqual(IndividualsResults.result4964, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate495()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual95));
            CollectionAssert.AreEqual(IndividualsResults.result4965, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate496()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual96));
            CollectionAssert.AreEqual(IndividualsResults.result4966, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate497()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual97));
            CollectionAssert.AreEqual(IndividualsResults.result4967, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate498()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual98));
            CollectionAssert.AreEqual(IndividualsResults.result4968, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate499()
        {
            var random = new System.Random(4);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual99));
            CollectionAssert.AreEqual(IndividualsResults.result4969, result);
            Assert.AreEqual(2128155929, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate50()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result4970, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate51()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result4971, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate52()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result4972, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate53()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result4973, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate54()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result4974, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate55()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result4975, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate56()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result4976, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate57()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result4977, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate58()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result4978, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate59()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result4979, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate510()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual10));
            CollectionAssert.AreEqual(IndividualsResults.result4980, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate511()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual11));
            CollectionAssert.AreEqual(IndividualsResults.result4981, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate512()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual12));
            CollectionAssert.AreEqual(IndividualsResults.result4982, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate513()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual13));
            CollectionAssert.AreEqual(IndividualsResults.result4983, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate514()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual14));
            CollectionAssert.AreEqual(IndividualsResults.result4984, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate515()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual15));
            CollectionAssert.AreEqual(IndividualsResults.result4985, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate516()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual16));
            CollectionAssert.AreEqual(IndividualsResults.result4986, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate517()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual17));
            CollectionAssert.AreEqual(IndividualsResults.result4987, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate518()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual18));
            CollectionAssert.AreEqual(IndividualsResults.result4988, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate519()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual19));
            CollectionAssert.AreEqual(IndividualsResults.result4989, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate520()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual20));
            CollectionAssert.AreEqual(IndividualsResults.result4990, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate521()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual21));
            CollectionAssert.AreEqual(IndividualsResults.result4991, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate522()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual22));
            CollectionAssert.AreEqual(IndividualsResults.result4992, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate523()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual23));
            CollectionAssert.AreEqual(IndividualsResults.result4993, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate524()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual24));
            CollectionAssert.AreEqual(IndividualsResults.result4994, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate525()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual25));
            CollectionAssert.AreEqual(IndividualsResults.result4995, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate526()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual26));
            CollectionAssert.AreEqual(IndividualsResults.result4996, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate527()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual27));
            CollectionAssert.AreEqual(IndividualsResults.result4997, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate528()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual28));
            CollectionAssert.AreEqual(IndividualsResults.result4998, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate529()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual29));
            CollectionAssert.AreEqual(IndividualsResults.result4999, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate530()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual30));
            CollectionAssert.AreEqual(IndividualsResults.result5000, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate531()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual31));
            CollectionAssert.AreEqual(IndividualsResults.result5001, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate532()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual32));
            CollectionAssert.AreEqual(IndividualsResults.result5002, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate533()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual33));
            CollectionAssert.AreEqual(IndividualsResults.result5003, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate534()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual34));
            CollectionAssert.AreEqual(IndividualsResults.result5004, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate535()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual35));
            CollectionAssert.AreEqual(IndividualsResults.result5005, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate536()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual36));
            CollectionAssert.AreEqual(IndividualsResults.result5006, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate537()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual37));
            CollectionAssert.AreEqual(IndividualsResults.result5007, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate538()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual38));
            CollectionAssert.AreEqual(IndividualsResults.result5008, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate539()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual39));
            CollectionAssert.AreEqual(IndividualsResults.result5009, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate540()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual40));
            CollectionAssert.AreEqual(IndividualsResults.result5010, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate541()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual41));
            CollectionAssert.AreEqual(IndividualsResults.result5011, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate542()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual42));
            CollectionAssert.AreEqual(IndividualsResults.result5012, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate543()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual43));
            CollectionAssert.AreEqual(IndividualsResults.result5013, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate544()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual44));
            CollectionAssert.AreEqual(IndividualsResults.result5014, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate545()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual45));
            CollectionAssert.AreEqual(IndividualsResults.result5015, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate546()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual46));
            CollectionAssert.AreEqual(IndividualsResults.result5016, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate547()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual47));
            CollectionAssert.AreEqual(IndividualsResults.result5017, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate548()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual48));
            CollectionAssert.AreEqual(IndividualsResults.result5018, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate549()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual49));
            CollectionAssert.AreEqual(IndividualsResults.result5019, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate550()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual50));
            CollectionAssert.AreEqual(IndividualsResults.result5020, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate551()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual51));
            CollectionAssert.AreEqual(IndividualsResults.result5021, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate552()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual52));
            CollectionAssert.AreEqual(IndividualsResults.result5022, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate553()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual53));
            CollectionAssert.AreEqual(IndividualsResults.result5023, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate554()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual54));
            CollectionAssert.AreEqual(IndividualsResults.result5024, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate555()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual55));
            CollectionAssert.AreEqual(IndividualsResults.result5025, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate556()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual56));
            CollectionAssert.AreEqual(IndividualsResults.result5026, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate557()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual57));
            CollectionAssert.AreEqual(IndividualsResults.result5027, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate558()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual58));
            CollectionAssert.AreEqual(IndividualsResults.result5028, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate559()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual59));
            CollectionAssert.AreEqual(IndividualsResults.result5029, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate560()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual60));
            CollectionAssert.AreEqual(IndividualsResults.result5030, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate561()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual61));
            CollectionAssert.AreEqual(IndividualsResults.result5031, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate562()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual62));
            CollectionAssert.AreEqual(IndividualsResults.result5032, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate563()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual63));
            CollectionAssert.AreEqual(IndividualsResults.result5033, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate564()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual64));
            CollectionAssert.AreEqual(IndividualsResults.result5034, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate565()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual65));
            CollectionAssert.AreEqual(IndividualsResults.result5035, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate566()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual66));
            CollectionAssert.AreEqual(IndividualsResults.result5036, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate567()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual67));
            CollectionAssert.AreEqual(IndividualsResults.result5037, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate568()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual68));
            CollectionAssert.AreEqual(IndividualsResults.result5038, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate569()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual69));
            CollectionAssert.AreEqual(IndividualsResults.result5039, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate570()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual70));
            CollectionAssert.AreEqual(IndividualsResults.result5040, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate571()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual71));
            CollectionAssert.AreEqual(IndividualsResults.result5041, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate572()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual72));
            CollectionAssert.AreEqual(IndividualsResults.result5042, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate573()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual73));
            CollectionAssert.AreEqual(IndividualsResults.result5043, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate574()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual74));
            CollectionAssert.AreEqual(IndividualsResults.result5044, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate575()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual75));
            CollectionAssert.AreEqual(IndividualsResults.result5045, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate576()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual76));
            CollectionAssert.AreEqual(IndividualsResults.result5046, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate577()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual77));
            CollectionAssert.AreEqual(IndividualsResults.result5047, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate578()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual78));
            CollectionAssert.AreEqual(IndividualsResults.result5048, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate579()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual79));
            CollectionAssert.AreEqual(IndividualsResults.result5049, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate580()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual80));
            CollectionAssert.AreEqual(IndividualsResults.result5050, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate581()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual81));
            CollectionAssert.AreEqual(IndividualsResults.result5051, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate582()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual82));
            CollectionAssert.AreEqual(IndividualsResults.result5052, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate583()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual83));
            CollectionAssert.AreEqual(IndividualsResults.result5053, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate584()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual84));
            CollectionAssert.AreEqual(IndividualsResults.result5054, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate585()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual85));
            CollectionAssert.AreEqual(IndividualsResults.result5055, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate586()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual86));
            CollectionAssert.AreEqual(IndividualsResults.result5056, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate587()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual87));
            CollectionAssert.AreEqual(IndividualsResults.result5057, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate588()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual88));
            CollectionAssert.AreEqual(IndividualsResults.result5058, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate589()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual89));
            CollectionAssert.AreEqual(IndividualsResults.result5059, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate590()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual90));
            CollectionAssert.AreEqual(IndividualsResults.result5060, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate591()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual91));
            CollectionAssert.AreEqual(IndividualsResults.result5061, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate592()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual92));
            CollectionAssert.AreEqual(IndividualsResults.result5062, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate593()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual93));
            CollectionAssert.AreEqual(IndividualsResults.result5063, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate594()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual94));
            CollectionAssert.AreEqual(IndividualsResults.result5064, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate595()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual95));
            CollectionAssert.AreEqual(IndividualsResults.result5065, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate596()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual96));
            CollectionAssert.AreEqual(IndividualsResults.result5066, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate597()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual97));
            CollectionAssert.AreEqual(IndividualsResults.result5067, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate598()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual98));
            CollectionAssert.AreEqual(IndividualsResults.result5068, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate599()
        {
            var random = new System.Random(5);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual99));
            CollectionAssert.AreEqual(IndividualsResults.result5069, result);
            Assert.AreEqual(610783965, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate60()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result5070, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate61()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result5071, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate62()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result5072, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate63()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result5073, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate64()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result5074, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate65()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result5075, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate66()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result5076, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate67()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result5077, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate68()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result5078, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate69()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result5079, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate610()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual10));
            CollectionAssert.AreEqual(IndividualsResults.result5080, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate611()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual11));
            CollectionAssert.AreEqual(IndividualsResults.result5081, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate612()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual12));
            CollectionAssert.AreEqual(IndividualsResults.result5082, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate613()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual13));
            CollectionAssert.AreEqual(IndividualsResults.result5083, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate614()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual14));
            CollectionAssert.AreEqual(IndividualsResults.result5084, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate615()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual15));
            CollectionAssert.AreEqual(IndividualsResults.result5085, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate616()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual16));
            CollectionAssert.AreEqual(IndividualsResults.result5086, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate617()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual17));
            CollectionAssert.AreEqual(IndividualsResults.result5087, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate618()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual18));
            CollectionAssert.AreEqual(IndividualsResults.result5088, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate619()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual19));
            CollectionAssert.AreEqual(IndividualsResults.result5089, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate620()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual20));
            CollectionAssert.AreEqual(IndividualsResults.result5090, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate621()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual21));
            CollectionAssert.AreEqual(IndividualsResults.result5091, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate622()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual22));
            CollectionAssert.AreEqual(IndividualsResults.result5092, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate623()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual23));
            CollectionAssert.AreEqual(IndividualsResults.result5093, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate624()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual24));
            CollectionAssert.AreEqual(IndividualsResults.result5094, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate625()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual25));
            CollectionAssert.AreEqual(IndividualsResults.result5095, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate626()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual26));
            CollectionAssert.AreEqual(IndividualsResults.result5096, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate627()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual27));
            CollectionAssert.AreEqual(IndividualsResults.result5097, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate628()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual28));
            CollectionAssert.AreEqual(IndividualsResults.result5098, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate629()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual29));
            CollectionAssert.AreEqual(IndividualsResults.result5099, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate630()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual30));
            CollectionAssert.AreEqual(IndividualsResults.result5100, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate631()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual31));
            CollectionAssert.AreEqual(IndividualsResults.result5101, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate632()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual32));
            CollectionAssert.AreEqual(IndividualsResults.result5102, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate633()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual33));
            CollectionAssert.AreEqual(IndividualsResults.result5103, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate634()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual34));
            CollectionAssert.AreEqual(IndividualsResults.result5104, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate635()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual35));
            CollectionAssert.AreEqual(IndividualsResults.result5105, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate636()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual36));
            CollectionAssert.AreEqual(IndividualsResults.result5106, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate637()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual37));
            CollectionAssert.AreEqual(IndividualsResults.result5107, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate638()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual38));
            CollectionAssert.AreEqual(IndividualsResults.result5108, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate639()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual39));
            CollectionAssert.AreEqual(IndividualsResults.result5109, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate640()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual40));
            CollectionAssert.AreEqual(IndividualsResults.result5110, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate641()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual41));
            CollectionAssert.AreEqual(IndividualsResults.result5111, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate642()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual42));
            CollectionAssert.AreEqual(IndividualsResults.result5112, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate643()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual43));
            CollectionAssert.AreEqual(IndividualsResults.result5113, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate644()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual44));
            CollectionAssert.AreEqual(IndividualsResults.result5114, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate645()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual45));
            CollectionAssert.AreEqual(IndividualsResults.result5115, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate646()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual46));
            CollectionAssert.AreEqual(IndividualsResults.result5116, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate647()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual47));
            CollectionAssert.AreEqual(IndividualsResults.result5117, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate648()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual48));
            CollectionAssert.AreEqual(IndividualsResults.result5118, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate649()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual49));
            CollectionAssert.AreEqual(IndividualsResults.result5119, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate650()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual50));
            CollectionAssert.AreEqual(IndividualsResults.result5120, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate651()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual51));
            CollectionAssert.AreEqual(IndividualsResults.result5121, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate652()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual52));
            CollectionAssert.AreEqual(IndividualsResults.result5122, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate653()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual53));
            CollectionAssert.AreEqual(IndividualsResults.result5123, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate654()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual54));
            CollectionAssert.AreEqual(IndividualsResults.result5124, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate655()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual55));
            CollectionAssert.AreEqual(IndividualsResults.result5125, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate656()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual56));
            CollectionAssert.AreEqual(IndividualsResults.result5126, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate657()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual57));
            CollectionAssert.AreEqual(IndividualsResults.result5127, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate658()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual58));
            CollectionAssert.AreEqual(IndividualsResults.result5128, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate659()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual59));
            CollectionAssert.AreEqual(IndividualsResults.result5129, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate660()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual60));
            CollectionAssert.AreEqual(IndividualsResults.result5130, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate661()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual61));
            CollectionAssert.AreEqual(IndividualsResults.result5131, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate662()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual62));
            CollectionAssert.AreEqual(IndividualsResults.result5132, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate663()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual63));
            CollectionAssert.AreEqual(IndividualsResults.result5133, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate664()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual64));
            CollectionAssert.AreEqual(IndividualsResults.result5134, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate665()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual65));
            CollectionAssert.AreEqual(IndividualsResults.result5135, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate666()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual66));
            CollectionAssert.AreEqual(IndividualsResults.result5136, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate667()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual67));
            CollectionAssert.AreEqual(IndividualsResults.result5137, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate668()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual68));
            CollectionAssert.AreEqual(IndividualsResults.result5138, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate669()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual69));
            CollectionAssert.AreEqual(IndividualsResults.result5139, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate670()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual70));
            CollectionAssert.AreEqual(IndividualsResults.result5140, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate671()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual71));
            CollectionAssert.AreEqual(IndividualsResults.result5141, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate672()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual72));
            CollectionAssert.AreEqual(IndividualsResults.result5142, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate673()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual73));
            CollectionAssert.AreEqual(IndividualsResults.result5143, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate674()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual74));
            CollectionAssert.AreEqual(IndividualsResults.result5144, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate675()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual75));
            CollectionAssert.AreEqual(IndividualsResults.result5145, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate676()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual76));
            CollectionAssert.AreEqual(IndividualsResults.result5146, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate677()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual77));
            CollectionAssert.AreEqual(IndividualsResults.result5147, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate678()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual78));
            CollectionAssert.AreEqual(IndividualsResults.result5148, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate679()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual79));
            CollectionAssert.AreEqual(IndividualsResults.result5149, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate680()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual80));
            CollectionAssert.AreEqual(IndividualsResults.result5150, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate681()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual81));
            CollectionAssert.AreEqual(IndividualsResults.result5151, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate682()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual82));
            CollectionAssert.AreEqual(IndividualsResults.result5152, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate683()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual83));
            CollectionAssert.AreEqual(IndividualsResults.result5153, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate684()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual84));
            CollectionAssert.AreEqual(IndividualsResults.result5154, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate685()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual85));
            CollectionAssert.AreEqual(IndividualsResults.result5155, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate686()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual86));
            CollectionAssert.AreEqual(IndividualsResults.result5156, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate687()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual87));
            CollectionAssert.AreEqual(IndividualsResults.result5157, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate688()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual88));
            CollectionAssert.AreEqual(IndividualsResults.result5158, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate689()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual89));
            CollectionAssert.AreEqual(IndividualsResults.result5159, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate690()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual90));
            CollectionAssert.AreEqual(IndividualsResults.result5160, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate691()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual91));
            CollectionAssert.AreEqual(IndividualsResults.result5161, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate692()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual92));
            CollectionAssert.AreEqual(IndividualsResults.result5162, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate693()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual93));
            CollectionAssert.AreEqual(IndividualsResults.result5163, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate694()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual94));
            CollectionAssert.AreEqual(IndividualsResults.result5164, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate695()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual95));
            CollectionAssert.AreEqual(IndividualsResults.result5165, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate696()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual96));
            CollectionAssert.AreEqual(IndividualsResults.result5166, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate697()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual97));
            CollectionAssert.AreEqual(IndividualsResults.result5167, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate698()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual98));
            CollectionAssert.AreEqual(IndividualsResults.result5168, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate699()
        {
            var random = new System.Random(6);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual99));
            CollectionAssert.AreEqual(IndividualsResults.result5169, result);
            Assert.AreEqual(1240895648, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate70()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result5170, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate71()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result5171, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate72()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result5172, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate73()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result5173, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate74()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result5174, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate75()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result5175, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate76()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result5176, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate77()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result5177, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate78()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result5178, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate79()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result5179, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate710()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual10));
            CollectionAssert.AreEqual(IndividualsResults.result5180, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate711()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual11));
            CollectionAssert.AreEqual(IndividualsResults.result5181, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate712()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual12));
            CollectionAssert.AreEqual(IndividualsResults.result5182, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate713()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual13));
            CollectionAssert.AreEqual(IndividualsResults.result5183, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate714()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual14));
            CollectionAssert.AreEqual(IndividualsResults.result5184, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate715()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual15));
            CollectionAssert.AreEqual(IndividualsResults.result5185, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate716()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual16));
            CollectionAssert.AreEqual(IndividualsResults.result5186, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate717()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual17));
            CollectionAssert.AreEqual(IndividualsResults.result5187, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate718()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual18));
            CollectionAssert.AreEqual(IndividualsResults.result5188, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate719()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual19));
            CollectionAssert.AreEqual(IndividualsResults.result5189, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate720()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual20));
            CollectionAssert.AreEqual(IndividualsResults.result5190, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate721()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual21));
            CollectionAssert.AreEqual(IndividualsResults.result5191, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate722()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual22));
            CollectionAssert.AreEqual(IndividualsResults.result5192, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate723()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual23));
            CollectionAssert.AreEqual(IndividualsResults.result5193, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate724()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual24));
            CollectionAssert.AreEqual(IndividualsResults.result5194, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate725()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual25));
            CollectionAssert.AreEqual(IndividualsResults.result5195, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate726()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual26));
            CollectionAssert.AreEqual(IndividualsResults.result5196, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate727()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual27));
            CollectionAssert.AreEqual(IndividualsResults.result5197, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate728()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual28));
            CollectionAssert.AreEqual(IndividualsResults.result5198, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate729()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual29));
            CollectionAssert.AreEqual(IndividualsResults.result5199, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate730()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual30));
            CollectionAssert.AreEqual(IndividualsResults.result5200, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate731()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual31));
            CollectionAssert.AreEqual(IndividualsResults.result5201, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate732()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual32));
            CollectionAssert.AreEqual(IndividualsResults.result5202, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate733()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual33));
            CollectionAssert.AreEqual(IndividualsResults.result5203, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate734()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual34));
            CollectionAssert.AreEqual(IndividualsResults.result5204, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate735()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual35));
            CollectionAssert.AreEqual(IndividualsResults.result5205, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate736()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual36));
            CollectionAssert.AreEqual(IndividualsResults.result5206, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate737()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual37));
            CollectionAssert.AreEqual(IndividualsResults.result5207, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate738()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual38));
            CollectionAssert.AreEqual(IndividualsResults.result5208, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate739()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual39));
            CollectionAssert.AreEqual(IndividualsResults.result5209, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate740()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual40));
            CollectionAssert.AreEqual(IndividualsResults.result5210, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate741()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual41));
            CollectionAssert.AreEqual(IndividualsResults.result5211, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate742()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual42));
            CollectionAssert.AreEqual(IndividualsResults.result5212, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate743()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual43));
            CollectionAssert.AreEqual(IndividualsResults.result5213, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate744()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual44));
            CollectionAssert.AreEqual(IndividualsResults.result5214, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate745()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual45));
            CollectionAssert.AreEqual(IndividualsResults.result5215, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate746()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual46));
            CollectionAssert.AreEqual(IndividualsResults.result5216, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate747()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual47));
            CollectionAssert.AreEqual(IndividualsResults.result5217, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate748()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual48));
            CollectionAssert.AreEqual(IndividualsResults.result5218, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate749()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual49));
            CollectionAssert.AreEqual(IndividualsResults.result5219, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate750()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual50));
            CollectionAssert.AreEqual(IndividualsResults.result5220, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate751()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual51));
            CollectionAssert.AreEqual(IndividualsResults.result5221, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate752()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual52));
            CollectionAssert.AreEqual(IndividualsResults.result5222, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate753()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual53));
            CollectionAssert.AreEqual(IndividualsResults.result5223, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate754()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual54));
            CollectionAssert.AreEqual(IndividualsResults.result5224, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate755()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual55));
            CollectionAssert.AreEqual(IndividualsResults.result5225, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate756()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual56));
            CollectionAssert.AreEqual(IndividualsResults.result5226, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate757()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual57));
            CollectionAssert.AreEqual(IndividualsResults.result5227, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate758()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual58));
            CollectionAssert.AreEqual(IndividualsResults.result5228, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate759()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual59));
            CollectionAssert.AreEqual(IndividualsResults.result5229, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate760()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual60));
            CollectionAssert.AreEqual(IndividualsResults.result5230, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate761()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual61));
            CollectionAssert.AreEqual(IndividualsResults.result5231, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate762()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual62));
            CollectionAssert.AreEqual(IndividualsResults.result5232, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate763()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual63));
            CollectionAssert.AreEqual(IndividualsResults.result5233, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate764()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual64));
            CollectionAssert.AreEqual(IndividualsResults.result5234, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate765()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual65));
            CollectionAssert.AreEqual(IndividualsResults.result5235, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate766()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual66));
            CollectionAssert.AreEqual(IndividualsResults.result5236, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate767()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual67));
            CollectionAssert.AreEqual(IndividualsResults.result5237, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate768()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual68));
            CollectionAssert.AreEqual(IndividualsResults.result5238, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate769()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual69));
            CollectionAssert.AreEqual(IndividualsResults.result5239, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate770()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual70));
            CollectionAssert.AreEqual(IndividualsResults.result5240, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate771()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual71));
            CollectionAssert.AreEqual(IndividualsResults.result5241, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate772()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual72));
            CollectionAssert.AreEqual(IndividualsResults.result5242, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate773()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual73));
            CollectionAssert.AreEqual(IndividualsResults.result5243, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate774()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual74));
            CollectionAssert.AreEqual(IndividualsResults.result5244, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate775()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual75));
            CollectionAssert.AreEqual(IndividualsResults.result5245, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate776()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual76));
            CollectionAssert.AreEqual(IndividualsResults.result5246, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate777()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual77));
            CollectionAssert.AreEqual(IndividualsResults.result5247, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate778()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual78));
            CollectionAssert.AreEqual(IndividualsResults.result5248, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate779()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual79));
            CollectionAssert.AreEqual(IndividualsResults.result5249, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate780()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual80));
            CollectionAssert.AreEqual(IndividualsResults.result5250, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate781()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual81));
            CollectionAssert.AreEqual(IndividualsResults.result5251, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate782()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual82));
            CollectionAssert.AreEqual(IndividualsResults.result5252, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate783()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual83));
            CollectionAssert.AreEqual(IndividualsResults.result5253, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate784()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual84));
            CollectionAssert.AreEqual(IndividualsResults.result5254, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate785()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual85));
            CollectionAssert.AreEqual(IndividualsResults.result5255, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate786()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual86));
            CollectionAssert.AreEqual(IndividualsResults.result5256, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate787()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual87));
            CollectionAssert.AreEqual(IndividualsResults.result5257, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate788()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual88));
            CollectionAssert.AreEqual(IndividualsResults.result5258, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate789()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual89));
            CollectionAssert.AreEqual(IndividualsResults.result5259, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate790()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual90));
            CollectionAssert.AreEqual(IndividualsResults.result5260, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate791()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual91));
            CollectionAssert.AreEqual(IndividualsResults.result5261, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate792()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual92));
            CollectionAssert.AreEqual(IndividualsResults.result5262, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate793()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual93));
            CollectionAssert.AreEqual(IndividualsResults.result5263, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate794()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual94));
            CollectionAssert.AreEqual(IndividualsResults.result5264, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate795()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual95));
            CollectionAssert.AreEqual(IndividualsResults.result5265, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate796()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual96));
            CollectionAssert.AreEqual(IndividualsResults.result5266, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate797()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual97));
            CollectionAssert.AreEqual(IndividualsResults.result5267, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate798()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual98));
            CollectionAssert.AreEqual(IndividualsResults.result5268, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate799()
        {
            var random = new System.Random(7);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual99));
            CollectionAssert.AreEqual(IndividualsResults.result5269, result);
            Assert.AreEqual(1871007331, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate80()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result5270, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate81()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result5271, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate82()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result5272, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate83()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result5273, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate84()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result5274, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate85()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result5275, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate86()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result5276, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate87()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result5277, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate88()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result5278, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate89()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result5279, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate810()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual10));
            CollectionAssert.AreEqual(IndividualsResults.result5280, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate811()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual11));
            CollectionAssert.AreEqual(IndividualsResults.result5281, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate812()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual12));
            CollectionAssert.AreEqual(IndividualsResults.result5282, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate813()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual13));
            CollectionAssert.AreEqual(IndividualsResults.result5283, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate814()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual14));
            CollectionAssert.AreEqual(IndividualsResults.result5284, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate815()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual15));
            CollectionAssert.AreEqual(IndividualsResults.result5285, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate816()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual16));
            CollectionAssert.AreEqual(IndividualsResults.result5286, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate817()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual17));
            CollectionAssert.AreEqual(IndividualsResults.result5287, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate818()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual18));
            CollectionAssert.AreEqual(IndividualsResults.result5288, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate819()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual19));
            CollectionAssert.AreEqual(IndividualsResults.result5289, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate820()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual20));
            CollectionAssert.AreEqual(IndividualsResults.result5290, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate821()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual21));
            CollectionAssert.AreEqual(IndividualsResults.result5291, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate822()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual22));
            CollectionAssert.AreEqual(IndividualsResults.result5292, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate823()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual23));
            CollectionAssert.AreEqual(IndividualsResults.result5293, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate824()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual24));
            CollectionAssert.AreEqual(IndividualsResults.result5294, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate825()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual25));
            CollectionAssert.AreEqual(IndividualsResults.result5295, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate826()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual26));
            CollectionAssert.AreEqual(IndividualsResults.result5296, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate827()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual27));
            CollectionAssert.AreEqual(IndividualsResults.result5297, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate828()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual28));
            CollectionAssert.AreEqual(IndividualsResults.result5298, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate829()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual29));
            CollectionAssert.AreEqual(IndividualsResults.result5299, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate830()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual30));
            CollectionAssert.AreEqual(IndividualsResults.result5300, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate831()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual31));
            CollectionAssert.AreEqual(IndividualsResults.result5301, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate832()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual32));
            CollectionAssert.AreEqual(IndividualsResults.result5302, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate833()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual33));
            CollectionAssert.AreEqual(IndividualsResults.result5303, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate834()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual34));
            CollectionAssert.AreEqual(IndividualsResults.result5304, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate835()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual35));
            CollectionAssert.AreEqual(IndividualsResults.result5305, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate836()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual36));
            CollectionAssert.AreEqual(IndividualsResults.result5306, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate837()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual37));
            CollectionAssert.AreEqual(IndividualsResults.result5307, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate838()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual38));
            CollectionAssert.AreEqual(IndividualsResults.result5308, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate839()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual39));
            CollectionAssert.AreEqual(IndividualsResults.result5309, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate840()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual40));
            CollectionAssert.AreEqual(IndividualsResults.result5310, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate841()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual41));
            CollectionAssert.AreEqual(IndividualsResults.result5311, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate842()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual42));
            CollectionAssert.AreEqual(IndividualsResults.result5312, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate843()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual43));
            CollectionAssert.AreEqual(IndividualsResults.result5313, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate844()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual44));
            CollectionAssert.AreEqual(IndividualsResults.result5314, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate845()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual45));
            CollectionAssert.AreEqual(IndividualsResults.result5315, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate846()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual46));
            CollectionAssert.AreEqual(IndividualsResults.result5316, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate847()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual47));
            CollectionAssert.AreEqual(IndividualsResults.result5317, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate848()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual48));
            CollectionAssert.AreEqual(IndividualsResults.result5318, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate849()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual49));
            CollectionAssert.AreEqual(IndividualsResults.result5319, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate850()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual50));
            CollectionAssert.AreEqual(IndividualsResults.result5320, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate851()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual51));
            CollectionAssert.AreEqual(IndividualsResults.result5321, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate852()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual52));
            CollectionAssert.AreEqual(IndividualsResults.result5322, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate853()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual53));
            CollectionAssert.AreEqual(IndividualsResults.result5323, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate854()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual54));
            CollectionAssert.AreEqual(IndividualsResults.result5324, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate855()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual55));
            CollectionAssert.AreEqual(IndividualsResults.result5325, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate856()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual56));
            CollectionAssert.AreEqual(IndividualsResults.result5326, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate857()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual57));
            CollectionAssert.AreEqual(IndividualsResults.result5327, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate858()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual58));
            CollectionAssert.AreEqual(IndividualsResults.result5328, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate859()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual59));
            CollectionAssert.AreEqual(IndividualsResults.result5329, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate860()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual60));
            CollectionAssert.AreEqual(IndividualsResults.result5330, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate861()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual61));
            CollectionAssert.AreEqual(IndividualsResults.result5331, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate862()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual62));
            CollectionAssert.AreEqual(IndividualsResults.result5332, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate863()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual63));
            CollectionAssert.AreEqual(IndividualsResults.result5333, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate864()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual64));
            CollectionAssert.AreEqual(IndividualsResults.result5334, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate865()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual65));
            CollectionAssert.AreEqual(IndividualsResults.result5335, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate866()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual66));
            CollectionAssert.AreEqual(IndividualsResults.result5336, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate867()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual67));
            CollectionAssert.AreEqual(IndividualsResults.result5337, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate868()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual68));
            CollectionAssert.AreEqual(IndividualsResults.result5338, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate869()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual69));
            CollectionAssert.AreEqual(IndividualsResults.result5339, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate870()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual70));
            CollectionAssert.AreEqual(IndividualsResults.result5340, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate871()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual71));
            CollectionAssert.AreEqual(IndividualsResults.result5341, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate872()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual72));
            CollectionAssert.AreEqual(IndividualsResults.result5342, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate873()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual73));
            CollectionAssert.AreEqual(IndividualsResults.result5343, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate874()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual74));
            CollectionAssert.AreEqual(IndividualsResults.result5344, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate875()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual75));
            CollectionAssert.AreEqual(IndividualsResults.result5345, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate876()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual76));
            CollectionAssert.AreEqual(IndividualsResults.result5346, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate877()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual77));
            CollectionAssert.AreEqual(IndividualsResults.result5347, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate878()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual78));
            CollectionAssert.AreEqual(IndividualsResults.result5348, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate879()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual79));
            CollectionAssert.AreEqual(IndividualsResults.result5349, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate880()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual80));
            CollectionAssert.AreEqual(IndividualsResults.result5350, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate881()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual81));
            CollectionAssert.AreEqual(IndividualsResults.result5351, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate882()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual82));
            CollectionAssert.AreEqual(IndividualsResults.result5352, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate883()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual83));
            CollectionAssert.AreEqual(IndividualsResults.result5353, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate884()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual84));
            CollectionAssert.AreEqual(IndividualsResults.result5354, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate885()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual85));
            CollectionAssert.AreEqual(IndividualsResults.result5355, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate886()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual86));
            CollectionAssert.AreEqual(IndividualsResults.result5356, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate887()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual87));
            CollectionAssert.AreEqual(IndividualsResults.result5357, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate888()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual88));
            CollectionAssert.AreEqual(IndividualsResults.result5358, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate889()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual89));
            CollectionAssert.AreEqual(IndividualsResults.result5359, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate890()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual90));
            CollectionAssert.AreEqual(IndividualsResults.result5360, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate891()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual91));
            CollectionAssert.AreEqual(IndividualsResults.result5361, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate892()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual92));
            CollectionAssert.AreEqual(IndividualsResults.result5362, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate893()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual93));
            CollectionAssert.AreEqual(IndividualsResults.result5363, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate894()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual94));
            CollectionAssert.AreEqual(IndividualsResults.result5364, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate895()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual95));
            CollectionAssert.AreEqual(IndividualsResults.result5365, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate896()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual96));
            CollectionAssert.AreEqual(IndividualsResults.result5366, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate897()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual97));
            CollectionAssert.AreEqual(IndividualsResults.result5367, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate898()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual98));
            CollectionAssert.AreEqual(IndividualsResults.result5368, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate899()
        {
            var random = new System.Random(8);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual99));
            CollectionAssert.AreEqual(IndividualsResults.result5369, result);
            Assert.AreEqual(353635367, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate90()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result5370, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate91()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result5371, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate92()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result5372, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate93()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result5373, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate94()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result5374, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate95()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result5375, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate96()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result5376, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate97()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result5377, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate98()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result5378, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate99()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result5379, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate910()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual10));
            CollectionAssert.AreEqual(IndividualsResults.result5380, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate911()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual11));
            CollectionAssert.AreEqual(IndividualsResults.result5381, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate912()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual12));
            CollectionAssert.AreEqual(IndividualsResults.result5382, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate913()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual13));
            CollectionAssert.AreEqual(IndividualsResults.result5383, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate914()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual14));
            CollectionAssert.AreEqual(IndividualsResults.result5384, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate915()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual15));
            CollectionAssert.AreEqual(IndividualsResults.result5385, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate916()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual16));
            CollectionAssert.AreEqual(IndividualsResults.result5386, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate917()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual17));
            CollectionAssert.AreEqual(IndividualsResults.result5387, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate918()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual18));
            CollectionAssert.AreEqual(IndividualsResults.result5388, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate919()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual19));
            CollectionAssert.AreEqual(IndividualsResults.result5389, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate920()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual20));
            CollectionAssert.AreEqual(IndividualsResults.result5390, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate921()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual21));
            CollectionAssert.AreEqual(IndividualsResults.result5391, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate922()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual22));
            CollectionAssert.AreEqual(IndividualsResults.result5392, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate923()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual23));
            CollectionAssert.AreEqual(IndividualsResults.result5393, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate924()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual24));
            CollectionAssert.AreEqual(IndividualsResults.result5394, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate925()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual25));
            CollectionAssert.AreEqual(IndividualsResults.result5395, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate926()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual26));
            CollectionAssert.AreEqual(IndividualsResults.result5396, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate927()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual27));
            CollectionAssert.AreEqual(IndividualsResults.result5397, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate928()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual28));
            CollectionAssert.AreEqual(IndividualsResults.result5398, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate929()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual29));
            CollectionAssert.AreEqual(IndividualsResults.result5399, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate930()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual30));
            CollectionAssert.AreEqual(IndividualsResults.result5400, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate931()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual31));
            CollectionAssert.AreEqual(IndividualsResults.result5401, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate932()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual32));
            CollectionAssert.AreEqual(IndividualsResults.result5402, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate933()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual33));
            CollectionAssert.AreEqual(IndividualsResults.result5403, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate934()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual34));
            CollectionAssert.AreEqual(IndividualsResults.result5404, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate935()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual35));
            CollectionAssert.AreEqual(IndividualsResults.result5405, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate936()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual36));
            CollectionAssert.AreEqual(IndividualsResults.result5406, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate937()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual37));
            CollectionAssert.AreEqual(IndividualsResults.result5407, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate938()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual38));
            CollectionAssert.AreEqual(IndividualsResults.result5408, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate939()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual39));
            CollectionAssert.AreEqual(IndividualsResults.result5409, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate940()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual40));
            CollectionAssert.AreEqual(IndividualsResults.result5410, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate941()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual41));
            CollectionAssert.AreEqual(IndividualsResults.result5411, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate942()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual42));
            CollectionAssert.AreEqual(IndividualsResults.result5412, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate943()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual43));
            CollectionAssert.AreEqual(IndividualsResults.result5413, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate944()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual44));
            CollectionAssert.AreEqual(IndividualsResults.result5414, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate945()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual45));
            CollectionAssert.AreEqual(IndividualsResults.result5415, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate946()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual46));
            CollectionAssert.AreEqual(IndividualsResults.result5416, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate947()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual47));
            CollectionAssert.AreEqual(IndividualsResults.result5417, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate948()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual48));
            CollectionAssert.AreEqual(IndividualsResults.result5418, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate949()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual49));
            CollectionAssert.AreEqual(IndividualsResults.result5419, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate950()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual50));
            CollectionAssert.AreEqual(IndividualsResults.result5420, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate951()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual51));
            CollectionAssert.AreEqual(IndividualsResults.result5421, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate952()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual52));
            CollectionAssert.AreEqual(IndividualsResults.result5422, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate953()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual53));
            CollectionAssert.AreEqual(IndividualsResults.result5423, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate954()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual54));
            CollectionAssert.AreEqual(IndividualsResults.result5424, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate955()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual55));
            CollectionAssert.AreEqual(IndividualsResults.result5425, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate956()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual56));
            CollectionAssert.AreEqual(IndividualsResults.result5426, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate957()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual57));
            CollectionAssert.AreEqual(IndividualsResults.result5427, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate958()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual58));
            CollectionAssert.AreEqual(IndividualsResults.result5428, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate959()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual59));
            CollectionAssert.AreEqual(IndividualsResults.result5429, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate960()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual60));
            CollectionAssert.AreEqual(IndividualsResults.result5430, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate961()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual61));
            CollectionAssert.AreEqual(IndividualsResults.result5431, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate962()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual62));
            CollectionAssert.AreEqual(IndividualsResults.result5432, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate963()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual63));
            CollectionAssert.AreEqual(IndividualsResults.result5433, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate964()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual64));
            CollectionAssert.AreEqual(IndividualsResults.result5434, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate965()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual65));
            CollectionAssert.AreEqual(IndividualsResults.result5435, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate966()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual66));
            CollectionAssert.AreEqual(IndividualsResults.result5436, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate967()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual67));
            CollectionAssert.AreEqual(IndividualsResults.result5437, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate968()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual68));
            CollectionAssert.AreEqual(IndividualsResults.result5438, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate969()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual69));
            CollectionAssert.AreEqual(IndividualsResults.result5439, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate970()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual70));
            CollectionAssert.AreEqual(IndividualsResults.result5440, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate971()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual71));
            CollectionAssert.AreEqual(IndividualsResults.result5441, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate972()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual72));
            CollectionAssert.AreEqual(IndividualsResults.result5442, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate973()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual73));
            CollectionAssert.AreEqual(IndividualsResults.result5443, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate974()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual74));
            CollectionAssert.AreEqual(IndividualsResults.result5444, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate975()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual75));
            CollectionAssert.AreEqual(IndividualsResults.result5445, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate976()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual76));
            CollectionAssert.AreEqual(IndividualsResults.result5446, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate977()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual77));
            CollectionAssert.AreEqual(IndividualsResults.result5447, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate978()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual78));
            CollectionAssert.AreEqual(IndividualsResults.result5448, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate979()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual79));
            CollectionAssert.AreEqual(IndividualsResults.result5449, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate980()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual80));
            CollectionAssert.AreEqual(IndividualsResults.result5450, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate981()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual81));
            CollectionAssert.AreEqual(IndividualsResults.result5451, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate982()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual82));
            CollectionAssert.AreEqual(IndividualsResults.result5452, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate983()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual83));
            CollectionAssert.AreEqual(IndividualsResults.result5453, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate984()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual84));
            CollectionAssert.AreEqual(IndividualsResults.result5454, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate985()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual85));
            CollectionAssert.AreEqual(IndividualsResults.result5455, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate986()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual86));
            CollectionAssert.AreEqual(IndividualsResults.result5456, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate987()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual87));
            CollectionAssert.AreEqual(IndividualsResults.result5457, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate988()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual88));
            CollectionAssert.AreEqual(IndividualsResults.result5458, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate989()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual89));
            CollectionAssert.AreEqual(IndividualsResults.result5459, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate990()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual90));
            CollectionAssert.AreEqual(IndividualsResults.result5460, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate991()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual91));
            CollectionAssert.AreEqual(IndividualsResults.result5461, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate992()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual92));
            CollectionAssert.AreEqual(IndividualsResults.result5462, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate993()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual93));
            CollectionAssert.AreEqual(IndividualsResults.result5463, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate994()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual94));
            CollectionAssert.AreEqual(IndividualsResults.result5464, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate995()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual95));
            CollectionAssert.AreEqual(IndividualsResults.result5465, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate996()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual96));
            CollectionAssert.AreEqual(IndividualsResults.result5466, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate997()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual97));
            CollectionAssert.AreEqual(IndividualsResults.result5467, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate998()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual98));
            CollectionAssert.AreEqual(IndividualsResults.result5468, result);
            Assert.AreEqual(983747050, random.Next());
        }

        [TestMethod]
        public void TestPossiblyMutate999()
        {
            var random = new System.Random(9);
            var result = RandomMonad.evaluateWith(random, GeneticAlgorithm.possiblyMutate(TestIndividuals.individual99));
            CollectionAssert.AreEqual(IndividualsResults.result5469, result);
            Assert.AreEqual(983747050, random.Next());
        }
    }
}
