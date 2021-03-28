using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using CAB402.FSharp;

namespace GeneticAlgorithmUnitTests
{
    [TestClass]
    public class CrossAtTests
    {
        [TestMethod]
        public void TestCrossAt000()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual0, 0);
            CollectionAssert.AreEqual(IndividualsResults.result0, result);
        }

        [TestMethod]
        public void TestCrossAt001()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual0, 1);
            CollectionAssert.AreEqual(IndividualsResults.result1, result);
        }

        [TestMethod]
        public void TestCrossAt002()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual0, 2);
            CollectionAssert.AreEqual(IndividualsResults.result2, result);
        }

        [TestMethod]
        public void TestCrossAt003()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual0, 3);
            CollectionAssert.AreEqual(IndividualsResults.result3, result);
        }

        [TestMethod]
        public void TestCrossAt004()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual0, 4);
            CollectionAssert.AreEqual(IndividualsResults.result4, result);
        }

        [TestMethod]
        public void TestCrossAt005()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual0, 5);
            CollectionAssert.AreEqual(IndividualsResults.result5, result);
        }

        [TestMethod]
        public void TestCrossAt006()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual0, 6);
            CollectionAssert.AreEqual(IndividualsResults.result6, result);
        }

        [TestMethod]
        public void TestCrossAt007()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual0, 7);
            CollectionAssert.AreEqual(IndividualsResults.result7, result);
        }

        [TestMethod]
        public void TestCrossAt008()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual0, 8);
            CollectionAssert.AreEqual(IndividualsResults.result8, result);
        }

        [TestMethod]
        public void TestCrossAt009()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual0, 9);
            CollectionAssert.AreEqual(IndividualsResults.result9, result);
        }

        [TestMethod]
        public void TestCrossAt010()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual1, 0);
            CollectionAssert.AreEqual(IndividualsResults.result10, result);
        }

        [TestMethod]
        public void TestCrossAt011()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual1, 1);
            CollectionAssert.AreEqual(IndividualsResults.result11, result);
        }

        [TestMethod]
        public void TestCrossAt012()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual1, 2);
            CollectionAssert.AreEqual(IndividualsResults.result12, result);
        }

        [TestMethod]
        public void TestCrossAt013()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual1, 3);
            CollectionAssert.AreEqual(IndividualsResults.result13, result);
        }

        [TestMethod]
        public void TestCrossAt014()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual1, 4);
            CollectionAssert.AreEqual(IndividualsResults.result14, result);
        }

        [TestMethod]
        public void TestCrossAt015()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual1, 5);
            CollectionAssert.AreEqual(IndividualsResults.result15, result);
        }

        [TestMethod]
        public void TestCrossAt016()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual1, 6);
            CollectionAssert.AreEqual(IndividualsResults.result16, result);
        }

        [TestMethod]
        public void TestCrossAt017()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual1, 7);
            CollectionAssert.AreEqual(IndividualsResults.result17, result);
        }

        [TestMethod]
        public void TestCrossAt018()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual1, 8);
            CollectionAssert.AreEqual(IndividualsResults.result18, result);
        }

        [TestMethod]
        public void TestCrossAt019()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual1, 9);
            CollectionAssert.AreEqual(IndividualsResults.result19, result);
        }

        [TestMethod]
        public void TestCrossAt020()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual2, 0);
            CollectionAssert.AreEqual(IndividualsResults.result20, result);
        }

        [TestMethod]
        public void TestCrossAt021()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual2, 1);
            CollectionAssert.AreEqual(IndividualsResults.result21, result);
        }

        [TestMethod]
        public void TestCrossAt022()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual2, 2);
            CollectionAssert.AreEqual(IndividualsResults.result22, result);
        }

        [TestMethod]
        public void TestCrossAt023()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual2, 3);
            CollectionAssert.AreEqual(IndividualsResults.result23, result);
        }

        [TestMethod]
        public void TestCrossAt024()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual2, 4);
            CollectionAssert.AreEqual(IndividualsResults.result24, result);
        }

        [TestMethod]
        public void TestCrossAt025()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual2, 5);
            CollectionAssert.AreEqual(IndividualsResults.result25, result);
        }

        [TestMethod]
        public void TestCrossAt026()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual2, 6);
            CollectionAssert.AreEqual(IndividualsResults.result26, result);
        }

        [TestMethod]
        public void TestCrossAt027()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual2, 7);
            CollectionAssert.AreEqual(IndividualsResults.result27, result);
        }

        [TestMethod]
        public void TestCrossAt028()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual2, 8);
            CollectionAssert.AreEqual(IndividualsResults.result28, result);
        }

        [TestMethod]
        public void TestCrossAt029()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual2, 9);
            CollectionAssert.AreEqual(IndividualsResults.result29, result);
        }

        [TestMethod]
        public void TestCrossAt030()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual3, 0);
            CollectionAssert.AreEqual(IndividualsResults.result30, result);
        }

        [TestMethod]
        public void TestCrossAt031()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual3, 1);
            CollectionAssert.AreEqual(IndividualsResults.result31, result);
        }

        [TestMethod]
        public void TestCrossAt032()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual3, 2);
            CollectionAssert.AreEqual(IndividualsResults.result32, result);
        }

        [TestMethod]
        public void TestCrossAt033()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual3, 3);
            CollectionAssert.AreEqual(IndividualsResults.result33, result);
        }

        [TestMethod]
        public void TestCrossAt034()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual3, 4);
            CollectionAssert.AreEqual(IndividualsResults.result34, result);
        }

        [TestMethod]
        public void TestCrossAt035()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual3, 5);
            CollectionAssert.AreEqual(IndividualsResults.result35, result);
        }

        [TestMethod]
        public void TestCrossAt036()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual3, 6);
            CollectionAssert.AreEqual(IndividualsResults.result36, result);
        }

        [TestMethod]
        public void TestCrossAt037()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual3, 7);
            CollectionAssert.AreEqual(IndividualsResults.result37, result);
        }

        [TestMethod]
        public void TestCrossAt038()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual3, 8);
            CollectionAssert.AreEqual(IndividualsResults.result38, result);
        }

        [TestMethod]
        public void TestCrossAt039()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual3, 9);
            CollectionAssert.AreEqual(IndividualsResults.result39, result);
        }

        [TestMethod]
        public void TestCrossAt040()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual4, 0);
            CollectionAssert.AreEqual(IndividualsResults.result40, result);
        }

        [TestMethod]
        public void TestCrossAt041()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual4, 1);
            CollectionAssert.AreEqual(IndividualsResults.result41, result);
        }

        [TestMethod]
        public void TestCrossAt042()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual4, 2);
            CollectionAssert.AreEqual(IndividualsResults.result42, result);
        }

        [TestMethod]
        public void TestCrossAt043()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual4, 3);
            CollectionAssert.AreEqual(IndividualsResults.result43, result);
        }

        [TestMethod]
        public void TestCrossAt044()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual4, 4);
            CollectionAssert.AreEqual(IndividualsResults.result44, result);
        }

        [TestMethod]
        public void TestCrossAt045()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual4, 5);
            CollectionAssert.AreEqual(IndividualsResults.result45, result);
        }

        [TestMethod]
        public void TestCrossAt046()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual4, 6);
            CollectionAssert.AreEqual(IndividualsResults.result46, result);
        }

        [TestMethod]
        public void TestCrossAt047()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual4, 7);
            CollectionAssert.AreEqual(IndividualsResults.result47, result);
        }

        [TestMethod]
        public void TestCrossAt048()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual4, 8);
            CollectionAssert.AreEqual(IndividualsResults.result48, result);
        }

        [TestMethod]
        public void TestCrossAt049()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual4, 9);
            CollectionAssert.AreEqual(IndividualsResults.result49, result);
        }

        [TestMethod]
        public void TestCrossAt050()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual5, 0);
            CollectionAssert.AreEqual(IndividualsResults.result50, result);
        }

        [TestMethod]
        public void TestCrossAt051()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual5, 1);
            CollectionAssert.AreEqual(IndividualsResults.result51, result);
        }

        [TestMethod]
        public void TestCrossAt052()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual5, 2);
            CollectionAssert.AreEqual(IndividualsResults.result52, result);
        }

        [TestMethod]
        public void TestCrossAt053()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual5, 3);
            CollectionAssert.AreEqual(IndividualsResults.result53, result);
        }

        [TestMethod]
        public void TestCrossAt054()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual5, 4);
            CollectionAssert.AreEqual(IndividualsResults.result54, result);
        }

        [TestMethod]
        public void TestCrossAt055()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual5, 5);
            CollectionAssert.AreEqual(IndividualsResults.result55, result);
        }

        [TestMethod]
        public void TestCrossAt056()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual5, 6);
            CollectionAssert.AreEqual(IndividualsResults.result56, result);
        }

        [TestMethod]
        public void TestCrossAt057()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual5, 7);
            CollectionAssert.AreEqual(IndividualsResults.result57, result);
        }

        [TestMethod]
        public void TestCrossAt058()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual5, 8);
            CollectionAssert.AreEqual(IndividualsResults.result58, result);
        }

        [TestMethod]
        public void TestCrossAt059()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual5, 9);
            CollectionAssert.AreEqual(IndividualsResults.result59, result);
        }

        [TestMethod]
        public void TestCrossAt060()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual6, 0);
            CollectionAssert.AreEqual(IndividualsResults.result60, result);
        }

        [TestMethod]
        public void TestCrossAt061()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual6, 1);
            CollectionAssert.AreEqual(IndividualsResults.result61, result);
        }

        [TestMethod]
        public void TestCrossAt062()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual6, 2);
            CollectionAssert.AreEqual(IndividualsResults.result62, result);
        }

        [TestMethod]
        public void TestCrossAt063()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual6, 3);
            CollectionAssert.AreEqual(IndividualsResults.result63, result);
        }

        [TestMethod]
        public void TestCrossAt064()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual6, 4);
            CollectionAssert.AreEqual(IndividualsResults.result64, result);
        }

        [TestMethod]
        public void TestCrossAt065()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual6, 5);
            CollectionAssert.AreEqual(IndividualsResults.result65, result);
        }

        [TestMethod]
        public void TestCrossAt066()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual6, 6);
            CollectionAssert.AreEqual(IndividualsResults.result66, result);
        }

        [TestMethod]
        public void TestCrossAt067()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual6, 7);
            CollectionAssert.AreEqual(IndividualsResults.result67, result);
        }

        [TestMethod]
        public void TestCrossAt068()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual6, 8);
            CollectionAssert.AreEqual(IndividualsResults.result68, result);
        }

        [TestMethod]
        public void TestCrossAt069()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual6, 9);
            CollectionAssert.AreEqual(IndividualsResults.result69, result);
        }

        [TestMethod]
        public void TestCrossAt070()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual7, 0);
            CollectionAssert.AreEqual(IndividualsResults.result70, result);
        }

        [TestMethod]
        public void TestCrossAt071()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual7, 1);
            CollectionAssert.AreEqual(IndividualsResults.result71, result);
        }

        [TestMethod]
        public void TestCrossAt072()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual7, 2);
            CollectionAssert.AreEqual(IndividualsResults.result72, result);
        }

        [TestMethod]
        public void TestCrossAt073()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual7, 3);
            CollectionAssert.AreEqual(IndividualsResults.result73, result);
        }

        [TestMethod]
        public void TestCrossAt074()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual7, 4);
            CollectionAssert.AreEqual(IndividualsResults.result74, result);
        }

        [TestMethod]
        public void TestCrossAt075()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual7, 5);
            CollectionAssert.AreEqual(IndividualsResults.result75, result);
        }

        [TestMethod]
        public void TestCrossAt076()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual7, 6);
            CollectionAssert.AreEqual(IndividualsResults.result76, result);
        }

        [TestMethod]
        public void TestCrossAt077()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual7, 7);
            CollectionAssert.AreEqual(IndividualsResults.result77, result);
        }

        [TestMethod]
        public void TestCrossAt078()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual7, 8);
            CollectionAssert.AreEqual(IndividualsResults.result78, result);
        }

        [TestMethod]
        public void TestCrossAt079()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual7, 9);
            CollectionAssert.AreEqual(IndividualsResults.result79, result);
        }

        [TestMethod]
        public void TestCrossAt080()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual8, 0);
            CollectionAssert.AreEqual(IndividualsResults.result80, result);
        }

        [TestMethod]
        public void TestCrossAt081()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual8, 1);
            CollectionAssert.AreEqual(IndividualsResults.result81, result);
        }

        [TestMethod]
        public void TestCrossAt082()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual8, 2);
            CollectionAssert.AreEqual(IndividualsResults.result82, result);
        }

        [TestMethod]
        public void TestCrossAt083()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual8, 3);
            CollectionAssert.AreEqual(IndividualsResults.result83, result);
        }

        [TestMethod]
        public void TestCrossAt084()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual8, 4);
            CollectionAssert.AreEqual(IndividualsResults.result84, result);
        }

        [TestMethod]
        public void TestCrossAt085()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual8, 5);
            CollectionAssert.AreEqual(IndividualsResults.result85, result);
        }

        [TestMethod]
        public void TestCrossAt086()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual8, 6);
            CollectionAssert.AreEqual(IndividualsResults.result86, result);
        }

        [TestMethod]
        public void TestCrossAt087()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual8, 7);
            CollectionAssert.AreEqual(IndividualsResults.result87, result);
        }

        [TestMethod]
        public void TestCrossAt088()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual8, 8);
            CollectionAssert.AreEqual(IndividualsResults.result88, result);
        }

        [TestMethod]
        public void TestCrossAt089()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual8, 9);
            CollectionAssert.AreEqual(IndividualsResults.result89, result);
        }

        [TestMethod]
        public void TestCrossAt090()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual9, 0);
            CollectionAssert.AreEqual(IndividualsResults.result90, result);
        }

        [TestMethod]
        public void TestCrossAt091()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual9, 1);
            CollectionAssert.AreEqual(IndividualsResults.result91, result);
        }

        [TestMethod]
        public void TestCrossAt092()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual9, 2);
            CollectionAssert.AreEqual(IndividualsResults.result92, result);
        }

        [TestMethod]
        public void TestCrossAt093()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual9, 3);
            CollectionAssert.AreEqual(IndividualsResults.result93, result);
        }

        [TestMethod]
        public void TestCrossAt094()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual9, 4);
            CollectionAssert.AreEqual(IndividualsResults.result94, result);
        }

        [TestMethod]
        public void TestCrossAt095()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual9, 5);
            CollectionAssert.AreEqual(IndividualsResults.result95, result);
        }

        [TestMethod]
        public void TestCrossAt096()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual9, 6);
            CollectionAssert.AreEqual(IndividualsResults.result96, result);
        }

        [TestMethod]
        public void TestCrossAt097()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual9, 7);
            CollectionAssert.AreEqual(IndividualsResults.result97, result);
        }

        [TestMethod]
        public void TestCrossAt098()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual9, 8);
            CollectionAssert.AreEqual(IndividualsResults.result98, result);
        }

        [TestMethod]
        public void TestCrossAt099()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual0, TestIndividuals.individual9, 9);
            CollectionAssert.AreEqual(IndividualsResults.result99, result);
        }

        [TestMethod]
        public void TestCrossAt100()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual0, 0);
            CollectionAssert.AreEqual(IndividualsResults.result100, result);
        }

        [TestMethod]
        public void TestCrossAt101()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual0, 1);
            CollectionAssert.AreEqual(IndividualsResults.result101, result);
        }

        [TestMethod]
        public void TestCrossAt102()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual0, 2);
            CollectionAssert.AreEqual(IndividualsResults.result102, result);
        }

        [TestMethod]
        public void TestCrossAt103()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual0, 3);
            CollectionAssert.AreEqual(IndividualsResults.result103, result);
        }

        [TestMethod]
        public void TestCrossAt104()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual0, 4);
            CollectionAssert.AreEqual(IndividualsResults.result104, result);
        }

        [TestMethod]
        public void TestCrossAt105()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual0, 5);
            CollectionAssert.AreEqual(IndividualsResults.result105, result);
        }

        [TestMethod]
        public void TestCrossAt106()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual0, 6);
            CollectionAssert.AreEqual(IndividualsResults.result106, result);
        }

        [TestMethod]
        public void TestCrossAt107()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual0, 7);
            CollectionAssert.AreEqual(IndividualsResults.result107, result);
        }

        [TestMethod]
        public void TestCrossAt108()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual0, 8);
            CollectionAssert.AreEqual(IndividualsResults.result108, result);
        }

        [TestMethod]
        public void TestCrossAt109()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual0, 9);
            CollectionAssert.AreEqual(IndividualsResults.result109, result);
        }

        [TestMethod]
        public void TestCrossAt110()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual1, 0);
            CollectionAssert.AreEqual(IndividualsResults.result110, result);
        }

        [TestMethod]
        public void TestCrossAt111()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual1, 1);
            CollectionAssert.AreEqual(IndividualsResults.result111, result);
        }

        [TestMethod]
        public void TestCrossAt112()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual1, 2);
            CollectionAssert.AreEqual(IndividualsResults.result112, result);
        }

        [TestMethod]
        public void TestCrossAt113()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual1, 3);
            CollectionAssert.AreEqual(IndividualsResults.result113, result);
        }

        [TestMethod]
        public void TestCrossAt114()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual1, 4);
            CollectionAssert.AreEqual(IndividualsResults.result114, result);
        }

        [TestMethod]
        public void TestCrossAt115()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual1, 5);
            CollectionAssert.AreEqual(IndividualsResults.result115, result);
        }

        [TestMethod]
        public void TestCrossAt116()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual1, 6);
            CollectionAssert.AreEqual(IndividualsResults.result116, result);
        }

        [TestMethod]
        public void TestCrossAt117()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual1, 7);
            CollectionAssert.AreEqual(IndividualsResults.result117, result);
        }

        [TestMethod]
        public void TestCrossAt118()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual1, 8);
            CollectionAssert.AreEqual(IndividualsResults.result118, result);
        }

        [TestMethod]
        public void TestCrossAt119()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual1, 9);
            CollectionAssert.AreEqual(IndividualsResults.result119, result);
        }

        [TestMethod]
        public void TestCrossAt120()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual2, 0);
            CollectionAssert.AreEqual(IndividualsResults.result120, result);
        }

        [TestMethod]
        public void TestCrossAt121()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual2, 1);
            CollectionAssert.AreEqual(IndividualsResults.result121, result);
        }

        [TestMethod]
        public void TestCrossAt122()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual2, 2);
            CollectionAssert.AreEqual(IndividualsResults.result122, result);
        }

        [TestMethod]
        public void TestCrossAt123()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual2, 3);
            CollectionAssert.AreEqual(IndividualsResults.result123, result);
        }

        [TestMethod]
        public void TestCrossAt124()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual2, 4);
            CollectionAssert.AreEqual(IndividualsResults.result124, result);
        }

        [TestMethod]
        public void TestCrossAt125()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual2, 5);
            CollectionAssert.AreEqual(IndividualsResults.result125, result);
        }

        [TestMethod]
        public void TestCrossAt126()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual2, 6);
            CollectionAssert.AreEqual(IndividualsResults.result126, result);
        }

        [TestMethod]
        public void TestCrossAt127()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual2, 7);
            CollectionAssert.AreEqual(IndividualsResults.result127, result);
        }

        [TestMethod]
        public void TestCrossAt128()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual2, 8);
            CollectionAssert.AreEqual(IndividualsResults.result128, result);
        }

        [TestMethod]
        public void TestCrossAt129()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual2, 9);
            CollectionAssert.AreEqual(IndividualsResults.result129, result);
        }

        [TestMethod]
        public void TestCrossAt130()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual3, 0);
            CollectionAssert.AreEqual(IndividualsResults.result130, result);
        }

        [TestMethod]
        public void TestCrossAt131()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual3, 1);
            CollectionAssert.AreEqual(IndividualsResults.result131, result);
        }

        [TestMethod]
        public void TestCrossAt132()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual3, 2);
            CollectionAssert.AreEqual(IndividualsResults.result132, result);
        }

        [TestMethod]
        public void TestCrossAt133()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual3, 3);
            CollectionAssert.AreEqual(IndividualsResults.result133, result);
        }

        [TestMethod]
        public void TestCrossAt134()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual3, 4);
            CollectionAssert.AreEqual(IndividualsResults.result134, result);
        }

        [TestMethod]
        public void TestCrossAt135()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual3, 5);
            CollectionAssert.AreEqual(IndividualsResults.result135, result);
        }

        [TestMethod]
        public void TestCrossAt136()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual3, 6);
            CollectionAssert.AreEqual(IndividualsResults.result136, result);
        }

        [TestMethod]
        public void TestCrossAt137()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual3, 7);
            CollectionAssert.AreEqual(IndividualsResults.result137, result);
        }

        [TestMethod]
        public void TestCrossAt138()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual3, 8);
            CollectionAssert.AreEqual(IndividualsResults.result138, result);
        }

        [TestMethod]
        public void TestCrossAt139()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual3, 9);
            CollectionAssert.AreEqual(IndividualsResults.result139, result);
        }

        [TestMethod]
        public void TestCrossAt140()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual4, 0);
            CollectionAssert.AreEqual(IndividualsResults.result140, result);
        }

        [TestMethod]
        public void TestCrossAt141()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual4, 1);
            CollectionAssert.AreEqual(IndividualsResults.result141, result);
        }

        [TestMethod]
        public void TestCrossAt142()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual4, 2);
            CollectionAssert.AreEqual(IndividualsResults.result142, result);
        }

        [TestMethod]
        public void TestCrossAt143()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual4, 3);
            CollectionAssert.AreEqual(IndividualsResults.result143, result);
        }

        [TestMethod]
        public void TestCrossAt144()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual4, 4);
            CollectionAssert.AreEqual(IndividualsResults.result144, result);
        }

        [TestMethod]
        public void TestCrossAt145()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual4, 5);
            CollectionAssert.AreEqual(IndividualsResults.result145, result);
        }

        [TestMethod]
        public void TestCrossAt146()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual4, 6);
            CollectionAssert.AreEqual(IndividualsResults.result146, result);
        }

        [TestMethod]
        public void TestCrossAt147()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual4, 7);
            CollectionAssert.AreEqual(IndividualsResults.result147, result);
        }

        [TestMethod]
        public void TestCrossAt148()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual4, 8);
            CollectionAssert.AreEqual(IndividualsResults.result148, result);
        }

        [TestMethod]
        public void TestCrossAt149()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual4, 9);
            CollectionAssert.AreEqual(IndividualsResults.result149, result);
        }

        [TestMethod]
        public void TestCrossAt150()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual5, 0);
            CollectionAssert.AreEqual(IndividualsResults.result150, result);
        }

        [TestMethod]
        public void TestCrossAt151()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual5, 1);
            CollectionAssert.AreEqual(IndividualsResults.result151, result);
        }

        [TestMethod]
        public void TestCrossAt152()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual5, 2);
            CollectionAssert.AreEqual(IndividualsResults.result152, result);
        }

        [TestMethod]
        public void TestCrossAt153()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual5, 3);
            CollectionAssert.AreEqual(IndividualsResults.result153, result);
        }

        [TestMethod]
        public void TestCrossAt154()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual5, 4);
            CollectionAssert.AreEqual(IndividualsResults.result154, result);
        }

        [TestMethod]
        public void TestCrossAt155()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual5, 5);
            CollectionAssert.AreEqual(IndividualsResults.result155, result);
        }

        [TestMethod]
        public void TestCrossAt156()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual5, 6);
            CollectionAssert.AreEqual(IndividualsResults.result156, result);
        }

        [TestMethod]
        public void TestCrossAt157()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual5, 7);
            CollectionAssert.AreEqual(IndividualsResults.result157, result);
        }

        [TestMethod]
        public void TestCrossAt158()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual5, 8);
            CollectionAssert.AreEqual(IndividualsResults.result158, result);
        }

        [TestMethod]
        public void TestCrossAt159()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual5, 9);
            CollectionAssert.AreEqual(IndividualsResults.result159, result);
        }

        [TestMethod]
        public void TestCrossAt160()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual6, 0);
            CollectionAssert.AreEqual(IndividualsResults.result160, result);
        }

        [TestMethod]
        public void TestCrossAt161()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual6, 1);
            CollectionAssert.AreEqual(IndividualsResults.result161, result);
        }

        [TestMethod]
        public void TestCrossAt162()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual6, 2);
            CollectionAssert.AreEqual(IndividualsResults.result162, result);
        }

        [TestMethod]
        public void TestCrossAt163()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual6, 3);
            CollectionAssert.AreEqual(IndividualsResults.result163, result);
        }

        [TestMethod]
        public void TestCrossAt164()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual6, 4);
            CollectionAssert.AreEqual(IndividualsResults.result164, result);
        }

        [TestMethod]
        public void TestCrossAt165()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual6, 5);
            CollectionAssert.AreEqual(IndividualsResults.result165, result);
        }

        [TestMethod]
        public void TestCrossAt166()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual6, 6);
            CollectionAssert.AreEqual(IndividualsResults.result166, result);
        }

        [TestMethod]
        public void TestCrossAt167()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual6, 7);
            CollectionAssert.AreEqual(IndividualsResults.result167, result);
        }

        [TestMethod]
        public void TestCrossAt168()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual6, 8);
            CollectionAssert.AreEqual(IndividualsResults.result168, result);
        }

        [TestMethod]
        public void TestCrossAt169()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual6, 9);
            CollectionAssert.AreEqual(IndividualsResults.result169, result);
        }

        [TestMethod]
        public void TestCrossAt170()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual7, 0);
            CollectionAssert.AreEqual(IndividualsResults.result170, result);
        }

        [TestMethod]
        public void TestCrossAt171()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual7, 1);
            CollectionAssert.AreEqual(IndividualsResults.result171, result);
        }

        [TestMethod]
        public void TestCrossAt172()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual7, 2);
            CollectionAssert.AreEqual(IndividualsResults.result172, result);
        }

        [TestMethod]
        public void TestCrossAt173()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual7, 3);
            CollectionAssert.AreEqual(IndividualsResults.result173, result);
        }

        [TestMethod]
        public void TestCrossAt174()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual7, 4);
            CollectionAssert.AreEqual(IndividualsResults.result174, result);
        }

        [TestMethod]
        public void TestCrossAt175()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual7, 5);
            CollectionAssert.AreEqual(IndividualsResults.result175, result);
        }

        [TestMethod]
        public void TestCrossAt176()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual7, 6);
            CollectionAssert.AreEqual(IndividualsResults.result176, result);
        }

        [TestMethod]
        public void TestCrossAt177()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual7, 7);
            CollectionAssert.AreEqual(IndividualsResults.result177, result);
        }

        [TestMethod]
        public void TestCrossAt178()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual7, 8);
            CollectionAssert.AreEqual(IndividualsResults.result178, result);
        }

        [TestMethod]
        public void TestCrossAt179()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual7, 9);
            CollectionAssert.AreEqual(IndividualsResults.result179, result);
        }

        [TestMethod]
        public void TestCrossAt180()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual8, 0);
            CollectionAssert.AreEqual(IndividualsResults.result180, result);
        }

        [TestMethod]
        public void TestCrossAt181()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual8, 1);
            CollectionAssert.AreEqual(IndividualsResults.result181, result);
        }

        [TestMethod]
        public void TestCrossAt182()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual8, 2);
            CollectionAssert.AreEqual(IndividualsResults.result182, result);
        }

        [TestMethod]
        public void TestCrossAt183()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual8, 3);
            CollectionAssert.AreEqual(IndividualsResults.result183, result);
        }

        [TestMethod]
        public void TestCrossAt184()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual8, 4);
            CollectionAssert.AreEqual(IndividualsResults.result184, result);
        }

        [TestMethod]
        public void TestCrossAt185()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual8, 5);
            CollectionAssert.AreEqual(IndividualsResults.result185, result);
        }

        [TestMethod]
        public void TestCrossAt186()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual8, 6);
            CollectionAssert.AreEqual(IndividualsResults.result186, result);
        }

        [TestMethod]
        public void TestCrossAt187()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual8, 7);
            CollectionAssert.AreEqual(IndividualsResults.result187, result);
        }

        [TestMethod]
        public void TestCrossAt188()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual8, 8);
            CollectionAssert.AreEqual(IndividualsResults.result188, result);
        }

        [TestMethod]
        public void TestCrossAt189()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual8, 9);
            CollectionAssert.AreEqual(IndividualsResults.result189, result);
        }

        [TestMethod]
        public void TestCrossAt190()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual9, 0);
            CollectionAssert.AreEqual(IndividualsResults.result190, result);
        }

        [TestMethod]
        public void TestCrossAt191()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual9, 1);
            CollectionAssert.AreEqual(IndividualsResults.result191, result);
        }

        [TestMethod]
        public void TestCrossAt192()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual9, 2);
            CollectionAssert.AreEqual(IndividualsResults.result192, result);
        }

        [TestMethod]
        public void TestCrossAt193()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual9, 3);
            CollectionAssert.AreEqual(IndividualsResults.result193, result);
        }

        [TestMethod]
        public void TestCrossAt194()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual9, 4);
            CollectionAssert.AreEqual(IndividualsResults.result194, result);
        }

        [TestMethod]
        public void TestCrossAt195()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual9, 5);
            CollectionAssert.AreEqual(IndividualsResults.result195, result);
        }

        [TestMethod]
        public void TestCrossAt196()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual9, 6);
            CollectionAssert.AreEqual(IndividualsResults.result196, result);
        }

        [TestMethod]
        public void TestCrossAt197()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual9, 7);
            CollectionAssert.AreEqual(IndividualsResults.result197, result);
        }

        [TestMethod]
        public void TestCrossAt198()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual9, 8);
            CollectionAssert.AreEqual(IndividualsResults.result198, result);
        }

        [TestMethod]
        public void TestCrossAt199()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual1, TestIndividuals.individual9, 9);
            CollectionAssert.AreEqual(IndividualsResults.result199, result);
        }

        [TestMethod]
        public void TestCrossAt200()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual0, 0);
            CollectionAssert.AreEqual(IndividualsResults.result200, result);
        }

        [TestMethod]
        public void TestCrossAt201()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual0, 1);
            CollectionAssert.AreEqual(IndividualsResults.result201, result);
        }

        [TestMethod]
        public void TestCrossAt202()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual0, 2);
            CollectionAssert.AreEqual(IndividualsResults.result202, result);
        }

        [TestMethod]
        public void TestCrossAt203()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual0, 3);
            CollectionAssert.AreEqual(IndividualsResults.result203, result);
        }

        [TestMethod]
        public void TestCrossAt204()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual0, 4);
            CollectionAssert.AreEqual(IndividualsResults.result204, result);
        }

        [TestMethod]
        public void TestCrossAt205()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual0, 5);
            CollectionAssert.AreEqual(IndividualsResults.result205, result);
        }

        [TestMethod]
        public void TestCrossAt206()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual0, 6);
            CollectionAssert.AreEqual(IndividualsResults.result206, result);
        }

        [TestMethod]
        public void TestCrossAt207()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual0, 7);
            CollectionAssert.AreEqual(IndividualsResults.result207, result);
        }

        [TestMethod]
        public void TestCrossAt208()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual0, 8);
            CollectionAssert.AreEqual(IndividualsResults.result208, result);
        }

        [TestMethod]
        public void TestCrossAt209()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual0, 9);
            CollectionAssert.AreEqual(IndividualsResults.result209, result);
        }

        [TestMethod]
        public void TestCrossAt210()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual1, 0);
            CollectionAssert.AreEqual(IndividualsResults.result210, result);
        }

        [TestMethod]
        public void TestCrossAt211()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual1, 1);
            CollectionAssert.AreEqual(IndividualsResults.result211, result);
        }

        [TestMethod]
        public void TestCrossAt212()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual1, 2);
            CollectionAssert.AreEqual(IndividualsResults.result212, result);
        }

        [TestMethod]
        public void TestCrossAt213()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual1, 3);
            CollectionAssert.AreEqual(IndividualsResults.result213, result);
        }

        [TestMethod]
        public void TestCrossAt214()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual1, 4);
            CollectionAssert.AreEqual(IndividualsResults.result214, result);
        }

        [TestMethod]
        public void TestCrossAt215()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual1, 5);
            CollectionAssert.AreEqual(IndividualsResults.result215, result);
        }

        [TestMethod]
        public void TestCrossAt216()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual1, 6);
            CollectionAssert.AreEqual(IndividualsResults.result216, result);
        }

        [TestMethod]
        public void TestCrossAt217()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual1, 7);
            CollectionAssert.AreEqual(IndividualsResults.result217, result);
        }

        [TestMethod]
        public void TestCrossAt218()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual1, 8);
            CollectionAssert.AreEqual(IndividualsResults.result218, result);
        }

        [TestMethod]
        public void TestCrossAt219()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual1, 9);
            CollectionAssert.AreEqual(IndividualsResults.result219, result);
        }

        [TestMethod]
        public void TestCrossAt220()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual2, 0);
            CollectionAssert.AreEqual(IndividualsResults.result220, result);
        }

        [TestMethod]
        public void TestCrossAt221()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual2, 1);
            CollectionAssert.AreEqual(IndividualsResults.result221, result);
        }

        [TestMethod]
        public void TestCrossAt222()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual2, 2);
            CollectionAssert.AreEqual(IndividualsResults.result222, result);
        }

        [TestMethod]
        public void TestCrossAt223()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual2, 3);
            CollectionAssert.AreEqual(IndividualsResults.result223, result);
        }

        [TestMethod]
        public void TestCrossAt224()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual2, 4);
            CollectionAssert.AreEqual(IndividualsResults.result224, result);
        }

        [TestMethod]
        public void TestCrossAt225()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual2, 5);
            CollectionAssert.AreEqual(IndividualsResults.result225, result);
        }

        [TestMethod]
        public void TestCrossAt226()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual2, 6);
            CollectionAssert.AreEqual(IndividualsResults.result226, result);
        }

        [TestMethod]
        public void TestCrossAt227()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual2, 7);
            CollectionAssert.AreEqual(IndividualsResults.result227, result);
        }

        [TestMethod]
        public void TestCrossAt228()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual2, 8);
            CollectionAssert.AreEqual(IndividualsResults.result228, result);
        }

        [TestMethod]
        public void TestCrossAt229()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual2, 9);
            CollectionAssert.AreEqual(IndividualsResults.result229, result);
        }

        [TestMethod]
        public void TestCrossAt230()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual3, 0);
            CollectionAssert.AreEqual(IndividualsResults.result230, result);
        }

        [TestMethod]
        public void TestCrossAt231()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual3, 1);
            CollectionAssert.AreEqual(IndividualsResults.result231, result);
        }

        [TestMethod]
        public void TestCrossAt232()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual3, 2);
            CollectionAssert.AreEqual(IndividualsResults.result232, result);
        }

        [TestMethod]
        public void TestCrossAt233()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual3, 3);
            CollectionAssert.AreEqual(IndividualsResults.result233, result);
        }

        [TestMethod]
        public void TestCrossAt234()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual3, 4);
            CollectionAssert.AreEqual(IndividualsResults.result234, result);
        }

        [TestMethod]
        public void TestCrossAt235()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual3, 5);
            CollectionAssert.AreEqual(IndividualsResults.result235, result);
        }

        [TestMethod]
        public void TestCrossAt236()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual3, 6);
            CollectionAssert.AreEqual(IndividualsResults.result236, result);
        }

        [TestMethod]
        public void TestCrossAt237()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual3, 7);
            CollectionAssert.AreEqual(IndividualsResults.result237, result);
        }

        [TestMethod]
        public void TestCrossAt238()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual3, 8);
            CollectionAssert.AreEqual(IndividualsResults.result238, result);
        }

        [TestMethod]
        public void TestCrossAt239()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual3, 9);
            CollectionAssert.AreEqual(IndividualsResults.result239, result);
        }

        [TestMethod]
        public void TestCrossAt240()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual4, 0);
            CollectionAssert.AreEqual(IndividualsResults.result240, result);
        }

        [TestMethod]
        public void TestCrossAt241()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual4, 1);
            CollectionAssert.AreEqual(IndividualsResults.result241, result);
        }

        [TestMethod]
        public void TestCrossAt242()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual4, 2);
            CollectionAssert.AreEqual(IndividualsResults.result242, result);
        }

        [TestMethod]
        public void TestCrossAt243()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual4, 3);
            CollectionAssert.AreEqual(IndividualsResults.result243, result);
        }

        [TestMethod]
        public void TestCrossAt244()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual4, 4);
            CollectionAssert.AreEqual(IndividualsResults.result244, result);
        }

        [TestMethod]
        public void TestCrossAt245()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual4, 5);
            CollectionAssert.AreEqual(IndividualsResults.result245, result);
        }

        [TestMethod]
        public void TestCrossAt246()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual4, 6);
            CollectionAssert.AreEqual(IndividualsResults.result246, result);
        }

        [TestMethod]
        public void TestCrossAt247()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual4, 7);
            CollectionAssert.AreEqual(IndividualsResults.result247, result);
        }

        [TestMethod]
        public void TestCrossAt248()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual4, 8);
            CollectionAssert.AreEqual(IndividualsResults.result248, result);
        }

        [TestMethod]
        public void TestCrossAt249()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual4, 9);
            CollectionAssert.AreEqual(IndividualsResults.result249, result);
        }

        [TestMethod]
        public void TestCrossAt250()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual5, 0);
            CollectionAssert.AreEqual(IndividualsResults.result250, result);
        }

        [TestMethod]
        public void TestCrossAt251()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual5, 1);
            CollectionAssert.AreEqual(IndividualsResults.result251, result);
        }

        [TestMethod]
        public void TestCrossAt252()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual5, 2);
            CollectionAssert.AreEqual(IndividualsResults.result252, result);
        }

        [TestMethod]
        public void TestCrossAt253()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual5, 3);
            CollectionAssert.AreEqual(IndividualsResults.result253, result);
        }

        [TestMethod]
        public void TestCrossAt254()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual5, 4);
            CollectionAssert.AreEqual(IndividualsResults.result254, result);
        }

        [TestMethod]
        public void TestCrossAt255()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual5, 5);
            CollectionAssert.AreEqual(IndividualsResults.result255, result);
        }

        [TestMethod]
        public void TestCrossAt256()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual5, 6);
            CollectionAssert.AreEqual(IndividualsResults.result256, result);
        }

        [TestMethod]
        public void TestCrossAt257()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual5, 7);
            CollectionAssert.AreEqual(IndividualsResults.result257, result);
        }

        [TestMethod]
        public void TestCrossAt258()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual5, 8);
            CollectionAssert.AreEqual(IndividualsResults.result258, result);
        }

        [TestMethod]
        public void TestCrossAt259()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual5, 9);
            CollectionAssert.AreEqual(IndividualsResults.result259, result);
        }

        [TestMethod]
        public void TestCrossAt260()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual6, 0);
            CollectionAssert.AreEqual(IndividualsResults.result260, result);
        }

        [TestMethod]
        public void TestCrossAt261()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual6, 1);
            CollectionAssert.AreEqual(IndividualsResults.result261, result);
        }

        [TestMethod]
        public void TestCrossAt262()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual6, 2);
            CollectionAssert.AreEqual(IndividualsResults.result262, result);
        }

        [TestMethod]
        public void TestCrossAt263()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual6, 3);
            CollectionAssert.AreEqual(IndividualsResults.result263, result);
        }

        [TestMethod]
        public void TestCrossAt264()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual6, 4);
            CollectionAssert.AreEqual(IndividualsResults.result264, result);
        }

        [TestMethod]
        public void TestCrossAt265()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual6, 5);
            CollectionAssert.AreEqual(IndividualsResults.result265, result);
        }

        [TestMethod]
        public void TestCrossAt266()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual6, 6);
            CollectionAssert.AreEqual(IndividualsResults.result266, result);
        }

        [TestMethod]
        public void TestCrossAt267()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual6, 7);
            CollectionAssert.AreEqual(IndividualsResults.result267, result);
        }

        [TestMethod]
        public void TestCrossAt268()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual6, 8);
            CollectionAssert.AreEqual(IndividualsResults.result268, result);
        }

        [TestMethod]
        public void TestCrossAt269()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual6, 9);
            CollectionAssert.AreEqual(IndividualsResults.result269, result);
        }

        [TestMethod]
        public void TestCrossAt270()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual7, 0);
            CollectionAssert.AreEqual(IndividualsResults.result270, result);
        }

        [TestMethod]
        public void TestCrossAt271()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual7, 1);
            CollectionAssert.AreEqual(IndividualsResults.result271, result);
        }

        [TestMethod]
        public void TestCrossAt272()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual7, 2);
            CollectionAssert.AreEqual(IndividualsResults.result272, result);
        }

        [TestMethod]
        public void TestCrossAt273()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual7, 3);
            CollectionAssert.AreEqual(IndividualsResults.result273, result);
        }

        [TestMethod]
        public void TestCrossAt274()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual7, 4);
            CollectionAssert.AreEqual(IndividualsResults.result274, result);
        }

        [TestMethod]
        public void TestCrossAt275()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual7, 5);
            CollectionAssert.AreEqual(IndividualsResults.result275, result);
        }

        [TestMethod]
        public void TestCrossAt276()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual7, 6);
            CollectionAssert.AreEqual(IndividualsResults.result276, result);
        }

        [TestMethod]
        public void TestCrossAt277()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual7, 7);
            CollectionAssert.AreEqual(IndividualsResults.result277, result);
        }

        [TestMethod]
        public void TestCrossAt278()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual7, 8);
            CollectionAssert.AreEqual(IndividualsResults.result278, result);
        }

        [TestMethod]
        public void TestCrossAt279()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual7, 9);
            CollectionAssert.AreEqual(IndividualsResults.result279, result);
        }

        [TestMethod]
        public void TestCrossAt280()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual8, 0);
            CollectionAssert.AreEqual(IndividualsResults.result280, result);
        }

        [TestMethod]
        public void TestCrossAt281()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual8, 1);
            CollectionAssert.AreEqual(IndividualsResults.result281, result);
        }

        [TestMethod]
        public void TestCrossAt282()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual8, 2);
            CollectionAssert.AreEqual(IndividualsResults.result282, result);
        }

        [TestMethod]
        public void TestCrossAt283()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual8, 3);
            CollectionAssert.AreEqual(IndividualsResults.result283, result);
        }

        [TestMethod]
        public void TestCrossAt284()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual8, 4);
            CollectionAssert.AreEqual(IndividualsResults.result284, result);
        }

        [TestMethod]
        public void TestCrossAt285()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual8, 5);
            CollectionAssert.AreEqual(IndividualsResults.result285, result);
        }

        [TestMethod]
        public void TestCrossAt286()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual8, 6);
            CollectionAssert.AreEqual(IndividualsResults.result286, result);
        }

        [TestMethod]
        public void TestCrossAt287()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual8, 7);
            CollectionAssert.AreEqual(IndividualsResults.result287, result);
        }

        [TestMethod]
        public void TestCrossAt288()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual8, 8);
            CollectionAssert.AreEqual(IndividualsResults.result288, result);
        }

        [TestMethod]
        public void TestCrossAt289()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual8, 9);
            CollectionAssert.AreEqual(IndividualsResults.result289, result);
        }

        [TestMethod]
        public void TestCrossAt290()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual9, 0);
            CollectionAssert.AreEqual(IndividualsResults.result290, result);
        }

        [TestMethod]
        public void TestCrossAt291()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual9, 1);
            CollectionAssert.AreEqual(IndividualsResults.result291, result);
        }

        [TestMethod]
        public void TestCrossAt292()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual9, 2);
            CollectionAssert.AreEqual(IndividualsResults.result292, result);
        }

        [TestMethod]
        public void TestCrossAt293()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual9, 3);
            CollectionAssert.AreEqual(IndividualsResults.result293, result);
        }

        [TestMethod]
        public void TestCrossAt294()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual9, 4);
            CollectionAssert.AreEqual(IndividualsResults.result294, result);
        }

        [TestMethod]
        public void TestCrossAt295()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual9, 5);
            CollectionAssert.AreEqual(IndividualsResults.result295, result);
        }

        [TestMethod]
        public void TestCrossAt296()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual9, 6);
            CollectionAssert.AreEqual(IndividualsResults.result296, result);
        }

        [TestMethod]
        public void TestCrossAt297()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual9, 7);
            CollectionAssert.AreEqual(IndividualsResults.result297, result);
        }

        [TestMethod]
        public void TestCrossAt298()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual9, 8);
            CollectionAssert.AreEqual(IndividualsResults.result298, result);
        }

        [TestMethod]
        public void TestCrossAt299()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual2, TestIndividuals.individual9, 9);
            CollectionAssert.AreEqual(IndividualsResults.result299, result);
        }

        [TestMethod]
        public void TestCrossAt300()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual0, 0);
            CollectionAssert.AreEqual(IndividualsResults.result300, result);
        }

        [TestMethod]
        public void TestCrossAt301()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual0, 1);
            CollectionAssert.AreEqual(IndividualsResults.result301, result);
        }

        [TestMethod]
        public void TestCrossAt302()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual0, 2);
            CollectionAssert.AreEqual(IndividualsResults.result302, result);
        }

        [TestMethod]
        public void TestCrossAt303()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual0, 3);
            CollectionAssert.AreEqual(IndividualsResults.result303, result);
        }

        [TestMethod]
        public void TestCrossAt304()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual0, 4);
            CollectionAssert.AreEqual(IndividualsResults.result304, result);
        }

        [TestMethod]
        public void TestCrossAt305()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual0, 5);
            CollectionAssert.AreEqual(IndividualsResults.result305, result);
        }

        [TestMethod]
        public void TestCrossAt306()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual0, 6);
            CollectionAssert.AreEqual(IndividualsResults.result306, result);
        }

        [TestMethod]
        public void TestCrossAt307()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual0, 7);
            CollectionAssert.AreEqual(IndividualsResults.result307, result);
        }

        [TestMethod]
        public void TestCrossAt308()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual0, 8);
            CollectionAssert.AreEqual(IndividualsResults.result308, result);
        }

        [TestMethod]
        public void TestCrossAt309()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual0, 9);
            CollectionAssert.AreEqual(IndividualsResults.result309, result);
        }

        [TestMethod]
        public void TestCrossAt310()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual1, 0);
            CollectionAssert.AreEqual(IndividualsResults.result310, result);
        }

        [TestMethod]
        public void TestCrossAt311()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual1, 1);
            CollectionAssert.AreEqual(IndividualsResults.result311, result);
        }

        [TestMethod]
        public void TestCrossAt312()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual1, 2);
            CollectionAssert.AreEqual(IndividualsResults.result312, result);
        }

        [TestMethod]
        public void TestCrossAt313()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual1, 3);
            CollectionAssert.AreEqual(IndividualsResults.result313, result);
        }

        [TestMethod]
        public void TestCrossAt314()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual1, 4);
            CollectionAssert.AreEqual(IndividualsResults.result314, result);
        }

        [TestMethod]
        public void TestCrossAt315()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual1, 5);
            CollectionAssert.AreEqual(IndividualsResults.result315, result);
        }

        [TestMethod]
        public void TestCrossAt316()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual1, 6);
            CollectionAssert.AreEqual(IndividualsResults.result316, result);
        }

        [TestMethod]
        public void TestCrossAt317()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual1, 7);
            CollectionAssert.AreEqual(IndividualsResults.result317, result);
        }

        [TestMethod]
        public void TestCrossAt318()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual1, 8);
            CollectionAssert.AreEqual(IndividualsResults.result318, result);
        }

        [TestMethod]
        public void TestCrossAt319()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual1, 9);
            CollectionAssert.AreEqual(IndividualsResults.result319, result);
        }

        [TestMethod]
        public void TestCrossAt320()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual2, 0);
            CollectionAssert.AreEqual(IndividualsResults.result320, result);
        }

        [TestMethod]
        public void TestCrossAt321()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual2, 1);
            CollectionAssert.AreEqual(IndividualsResults.result321, result);
        }

        [TestMethod]
        public void TestCrossAt322()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual2, 2);
            CollectionAssert.AreEqual(IndividualsResults.result322, result);
        }

        [TestMethod]
        public void TestCrossAt323()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual2, 3);
            CollectionAssert.AreEqual(IndividualsResults.result323, result);
        }

        [TestMethod]
        public void TestCrossAt324()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual2, 4);
            CollectionAssert.AreEqual(IndividualsResults.result324, result);
        }

        [TestMethod]
        public void TestCrossAt325()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual2, 5);
            CollectionAssert.AreEqual(IndividualsResults.result325, result);
        }

        [TestMethod]
        public void TestCrossAt326()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual2, 6);
            CollectionAssert.AreEqual(IndividualsResults.result326, result);
        }

        [TestMethod]
        public void TestCrossAt327()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual2, 7);
            CollectionAssert.AreEqual(IndividualsResults.result327, result);
        }

        [TestMethod]
        public void TestCrossAt328()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual2, 8);
            CollectionAssert.AreEqual(IndividualsResults.result328, result);
        }

        [TestMethod]
        public void TestCrossAt329()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual2, 9);
            CollectionAssert.AreEqual(IndividualsResults.result329, result);
        }

        [TestMethod]
        public void TestCrossAt330()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual3, 0);
            CollectionAssert.AreEqual(IndividualsResults.result330, result);
        }

        [TestMethod]
        public void TestCrossAt331()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual3, 1);
            CollectionAssert.AreEqual(IndividualsResults.result331, result);
        }

        [TestMethod]
        public void TestCrossAt332()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual3, 2);
            CollectionAssert.AreEqual(IndividualsResults.result332, result);
        }

        [TestMethod]
        public void TestCrossAt333()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual3, 3);
            CollectionAssert.AreEqual(IndividualsResults.result333, result);
        }

        [TestMethod]
        public void TestCrossAt334()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual3, 4);
            CollectionAssert.AreEqual(IndividualsResults.result334, result);
        }

        [TestMethod]
        public void TestCrossAt335()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual3, 5);
            CollectionAssert.AreEqual(IndividualsResults.result335, result);
        }

        [TestMethod]
        public void TestCrossAt336()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual3, 6);
            CollectionAssert.AreEqual(IndividualsResults.result336, result);
        }

        [TestMethod]
        public void TestCrossAt337()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual3, 7);
            CollectionAssert.AreEqual(IndividualsResults.result337, result);
        }

        [TestMethod]
        public void TestCrossAt338()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual3, 8);
            CollectionAssert.AreEqual(IndividualsResults.result338, result);
        }

        [TestMethod]
        public void TestCrossAt339()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual3, 9);
            CollectionAssert.AreEqual(IndividualsResults.result339, result);
        }

        [TestMethod]
        public void TestCrossAt340()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual4, 0);
            CollectionAssert.AreEqual(IndividualsResults.result340, result);
        }

        [TestMethod]
        public void TestCrossAt341()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual4, 1);
            CollectionAssert.AreEqual(IndividualsResults.result341, result);
        }

        [TestMethod]
        public void TestCrossAt342()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual4, 2);
            CollectionAssert.AreEqual(IndividualsResults.result342, result);
        }

        [TestMethod]
        public void TestCrossAt343()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual4, 3);
            CollectionAssert.AreEqual(IndividualsResults.result343, result);
        }

        [TestMethod]
        public void TestCrossAt344()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual4, 4);
            CollectionAssert.AreEqual(IndividualsResults.result344, result);
        }

        [TestMethod]
        public void TestCrossAt345()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual4, 5);
            CollectionAssert.AreEqual(IndividualsResults.result345, result);
        }

        [TestMethod]
        public void TestCrossAt346()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual4, 6);
            CollectionAssert.AreEqual(IndividualsResults.result346, result);
        }

        [TestMethod]
        public void TestCrossAt347()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual4, 7);
            CollectionAssert.AreEqual(IndividualsResults.result347, result);
        }

        [TestMethod]
        public void TestCrossAt348()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual4, 8);
            CollectionAssert.AreEqual(IndividualsResults.result348, result);
        }

        [TestMethod]
        public void TestCrossAt349()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual4, 9);
            CollectionAssert.AreEqual(IndividualsResults.result349, result);
        }

        [TestMethod]
        public void TestCrossAt350()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual5, 0);
            CollectionAssert.AreEqual(IndividualsResults.result350, result);
        }

        [TestMethod]
        public void TestCrossAt351()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual5, 1);
            CollectionAssert.AreEqual(IndividualsResults.result351, result);
        }

        [TestMethod]
        public void TestCrossAt352()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual5, 2);
            CollectionAssert.AreEqual(IndividualsResults.result352, result);
        }

        [TestMethod]
        public void TestCrossAt353()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual5, 3);
            CollectionAssert.AreEqual(IndividualsResults.result353, result);
        }

        [TestMethod]
        public void TestCrossAt354()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual5, 4);
            CollectionAssert.AreEqual(IndividualsResults.result354, result);
        }

        [TestMethod]
        public void TestCrossAt355()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual5, 5);
            CollectionAssert.AreEqual(IndividualsResults.result355, result);
        }

        [TestMethod]
        public void TestCrossAt356()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual5, 6);
            CollectionAssert.AreEqual(IndividualsResults.result356, result);
        }

        [TestMethod]
        public void TestCrossAt357()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual5, 7);
            CollectionAssert.AreEqual(IndividualsResults.result357, result);
        }

        [TestMethod]
        public void TestCrossAt358()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual5, 8);
            CollectionAssert.AreEqual(IndividualsResults.result358, result);
        }

        [TestMethod]
        public void TestCrossAt359()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual5, 9);
            CollectionAssert.AreEqual(IndividualsResults.result359, result);
        }

        [TestMethod]
        public void TestCrossAt360()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual6, 0);
            CollectionAssert.AreEqual(IndividualsResults.result360, result);
        }

        [TestMethod]
        public void TestCrossAt361()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual6, 1);
            CollectionAssert.AreEqual(IndividualsResults.result361, result);
        }

        [TestMethod]
        public void TestCrossAt362()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual6, 2);
            CollectionAssert.AreEqual(IndividualsResults.result362, result);
        }

        [TestMethod]
        public void TestCrossAt363()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual6, 3);
            CollectionAssert.AreEqual(IndividualsResults.result363, result);
        }

        [TestMethod]
        public void TestCrossAt364()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual6, 4);
            CollectionAssert.AreEqual(IndividualsResults.result364, result);
        }

        [TestMethod]
        public void TestCrossAt365()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual6, 5);
            CollectionAssert.AreEqual(IndividualsResults.result365, result);
        }

        [TestMethod]
        public void TestCrossAt366()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual6, 6);
            CollectionAssert.AreEqual(IndividualsResults.result366, result);
        }

        [TestMethod]
        public void TestCrossAt367()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual6, 7);
            CollectionAssert.AreEqual(IndividualsResults.result367, result);
        }

        [TestMethod]
        public void TestCrossAt368()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual6, 8);
            CollectionAssert.AreEqual(IndividualsResults.result368, result);
        }

        [TestMethod]
        public void TestCrossAt369()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual6, 9);
            CollectionAssert.AreEqual(IndividualsResults.result369, result);
        }

        [TestMethod]
        public void TestCrossAt370()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual7, 0);
            CollectionAssert.AreEqual(IndividualsResults.result370, result);
        }

        [TestMethod]
        public void TestCrossAt371()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual7, 1);
            CollectionAssert.AreEqual(IndividualsResults.result371, result);
        }

        [TestMethod]
        public void TestCrossAt372()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual7, 2);
            CollectionAssert.AreEqual(IndividualsResults.result372, result);
        }

        [TestMethod]
        public void TestCrossAt373()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual7, 3);
            CollectionAssert.AreEqual(IndividualsResults.result373, result);
        }

        [TestMethod]
        public void TestCrossAt374()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual7, 4);
            CollectionAssert.AreEqual(IndividualsResults.result374, result);
        }

        [TestMethod]
        public void TestCrossAt375()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual7, 5);
            CollectionAssert.AreEqual(IndividualsResults.result375, result);
        }

        [TestMethod]
        public void TestCrossAt376()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual7, 6);
            CollectionAssert.AreEqual(IndividualsResults.result376, result);
        }

        [TestMethod]
        public void TestCrossAt377()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual7, 7);
            CollectionAssert.AreEqual(IndividualsResults.result377, result);
        }

        [TestMethod]
        public void TestCrossAt378()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual7, 8);
            CollectionAssert.AreEqual(IndividualsResults.result378, result);
        }

        [TestMethod]
        public void TestCrossAt379()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual7, 9);
            CollectionAssert.AreEqual(IndividualsResults.result379, result);
        }

        [TestMethod]
        public void TestCrossAt380()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual8, 0);
            CollectionAssert.AreEqual(IndividualsResults.result380, result);
        }

        [TestMethod]
        public void TestCrossAt381()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual8, 1);
            CollectionAssert.AreEqual(IndividualsResults.result381, result);
        }

        [TestMethod]
        public void TestCrossAt382()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual8, 2);
            CollectionAssert.AreEqual(IndividualsResults.result382, result);
        }

        [TestMethod]
        public void TestCrossAt383()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual8, 3);
            CollectionAssert.AreEqual(IndividualsResults.result383, result);
        }

        [TestMethod]
        public void TestCrossAt384()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual8, 4);
            CollectionAssert.AreEqual(IndividualsResults.result384, result);
        }

        [TestMethod]
        public void TestCrossAt385()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual8, 5);
            CollectionAssert.AreEqual(IndividualsResults.result385, result);
        }

        [TestMethod]
        public void TestCrossAt386()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual8, 6);
            CollectionAssert.AreEqual(IndividualsResults.result386, result);
        }

        [TestMethod]
        public void TestCrossAt387()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual8, 7);
            CollectionAssert.AreEqual(IndividualsResults.result387, result);
        }

        [TestMethod]
        public void TestCrossAt388()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual8, 8);
            CollectionAssert.AreEqual(IndividualsResults.result388, result);
        }

        [TestMethod]
        public void TestCrossAt389()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual8, 9);
            CollectionAssert.AreEqual(IndividualsResults.result389, result);
        }

        [TestMethod]
        public void TestCrossAt390()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual9, 0);
            CollectionAssert.AreEqual(IndividualsResults.result390, result);
        }

        [TestMethod]
        public void TestCrossAt391()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual9, 1);
            CollectionAssert.AreEqual(IndividualsResults.result391, result);
        }

        [TestMethod]
        public void TestCrossAt392()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual9, 2);
            CollectionAssert.AreEqual(IndividualsResults.result392, result);
        }

        [TestMethod]
        public void TestCrossAt393()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual9, 3);
            CollectionAssert.AreEqual(IndividualsResults.result393, result);
        }

        [TestMethod]
        public void TestCrossAt394()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual9, 4);
            CollectionAssert.AreEqual(IndividualsResults.result394, result);
        }

        [TestMethod]
        public void TestCrossAt395()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual9, 5);
            CollectionAssert.AreEqual(IndividualsResults.result395, result);
        }

        [TestMethod]
        public void TestCrossAt396()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual9, 6);
            CollectionAssert.AreEqual(IndividualsResults.result396, result);
        }

        [TestMethod]
        public void TestCrossAt397()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual9, 7);
            CollectionAssert.AreEqual(IndividualsResults.result397, result);
        }

        [TestMethod]
        public void TestCrossAt398()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual9, 8);
            CollectionAssert.AreEqual(IndividualsResults.result398, result);
        }

        [TestMethod]
        public void TestCrossAt399()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual3, TestIndividuals.individual9, 9);
            CollectionAssert.AreEqual(IndividualsResults.result399, result);
        }

        [TestMethod]
        public void TestCrossAt400()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual0, 0);
            CollectionAssert.AreEqual(IndividualsResults.result400, result);
        }

        [TestMethod]
        public void TestCrossAt401()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual0, 1);
            CollectionAssert.AreEqual(IndividualsResults.result401, result);
        }

        [TestMethod]
        public void TestCrossAt402()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual0, 2);
            CollectionAssert.AreEqual(IndividualsResults.result402, result);
        }

        [TestMethod]
        public void TestCrossAt403()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual0, 3);
            CollectionAssert.AreEqual(IndividualsResults.result403, result);
        }

        [TestMethod]
        public void TestCrossAt404()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual0, 4);
            CollectionAssert.AreEqual(IndividualsResults.result404, result);
        }

        [TestMethod]
        public void TestCrossAt405()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual0, 5);
            CollectionAssert.AreEqual(IndividualsResults.result405, result);
        }

        [TestMethod]
        public void TestCrossAt406()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual0, 6);
            CollectionAssert.AreEqual(IndividualsResults.result406, result);
        }

        [TestMethod]
        public void TestCrossAt407()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual0, 7);
            CollectionAssert.AreEqual(IndividualsResults.result407, result);
        }

        [TestMethod]
        public void TestCrossAt408()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual0, 8);
            CollectionAssert.AreEqual(IndividualsResults.result408, result);
        }

        [TestMethod]
        public void TestCrossAt409()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual0, 9);
            CollectionAssert.AreEqual(IndividualsResults.result409, result);
        }

        [TestMethod]
        public void TestCrossAt410()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual1, 0);
            CollectionAssert.AreEqual(IndividualsResults.result410, result);
        }

        [TestMethod]
        public void TestCrossAt411()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual1, 1);
            CollectionAssert.AreEqual(IndividualsResults.result411, result);
        }

        [TestMethod]
        public void TestCrossAt412()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual1, 2);
            CollectionAssert.AreEqual(IndividualsResults.result412, result);
        }

        [TestMethod]
        public void TestCrossAt413()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual1, 3);
            CollectionAssert.AreEqual(IndividualsResults.result413, result);
        }

        [TestMethod]
        public void TestCrossAt414()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual1, 4);
            CollectionAssert.AreEqual(IndividualsResults.result414, result);
        }

        [TestMethod]
        public void TestCrossAt415()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual1, 5);
            CollectionAssert.AreEqual(IndividualsResults.result415, result);
        }

        [TestMethod]
        public void TestCrossAt416()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual1, 6);
            CollectionAssert.AreEqual(IndividualsResults.result416, result);
        }

        [TestMethod]
        public void TestCrossAt417()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual1, 7);
            CollectionAssert.AreEqual(IndividualsResults.result417, result);
        }

        [TestMethod]
        public void TestCrossAt418()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual1, 8);
            CollectionAssert.AreEqual(IndividualsResults.result418, result);
        }

        [TestMethod]
        public void TestCrossAt419()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual1, 9);
            CollectionAssert.AreEqual(IndividualsResults.result419, result);
        }

        [TestMethod]
        public void TestCrossAt420()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual2, 0);
            CollectionAssert.AreEqual(IndividualsResults.result420, result);
        }

        [TestMethod]
        public void TestCrossAt421()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual2, 1);
            CollectionAssert.AreEqual(IndividualsResults.result421, result);
        }

        [TestMethod]
        public void TestCrossAt422()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual2, 2);
            CollectionAssert.AreEqual(IndividualsResults.result422, result);
        }

        [TestMethod]
        public void TestCrossAt423()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual2, 3);
            CollectionAssert.AreEqual(IndividualsResults.result423, result);
        }

        [TestMethod]
        public void TestCrossAt424()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual2, 4);
            CollectionAssert.AreEqual(IndividualsResults.result424, result);
        }

        [TestMethod]
        public void TestCrossAt425()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual2, 5);
            CollectionAssert.AreEqual(IndividualsResults.result425, result);
        }

        [TestMethod]
        public void TestCrossAt426()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual2, 6);
            CollectionAssert.AreEqual(IndividualsResults.result426, result);
        }

        [TestMethod]
        public void TestCrossAt427()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual2, 7);
            CollectionAssert.AreEqual(IndividualsResults.result427, result);
        }

        [TestMethod]
        public void TestCrossAt428()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual2, 8);
            CollectionAssert.AreEqual(IndividualsResults.result428, result);
        }

        [TestMethod]
        public void TestCrossAt429()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual2, 9);
            CollectionAssert.AreEqual(IndividualsResults.result429, result);
        }

        [TestMethod]
        public void TestCrossAt430()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual3, 0);
            CollectionAssert.AreEqual(IndividualsResults.result430, result);
        }

        [TestMethod]
        public void TestCrossAt431()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual3, 1);
            CollectionAssert.AreEqual(IndividualsResults.result431, result);
        }

        [TestMethod]
        public void TestCrossAt432()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual3, 2);
            CollectionAssert.AreEqual(IndividualsResults.result432, result);
        }

        [TestMethod]
        public void TestCrossAt433()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual3, 3);
            CollectionAssert.AreEqual(IndividualsResults.result433, result);
        }

        [TestMethod]
        public void TestCrossAt434()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual3, 4);
            CollectionAssert.AreEqual(IndividualsResults.result434, result);
        }

        [TestMethod]
        public void TestCrossAt435()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual3, 5);
            CollectionAssert.AreEqual(IndividualsResults.result435, result);
        }

        [TestMethod]
        public void TestCrossAt436()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual3, 6);
            CollectionAssert.AreEqual(IndividualsResults.result436, result);
        }

        [TestMethod]
        public void TestCrossAt437()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual3, 7);
            CollectionAssert.AreEqual(IndividualsResults.result437, result);
        }

        [TestMethod]
        public void TestCrossAt438()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual3, 8);
            CollectionAssert.AreEqual(IndividualsResults.result438, result);
        }

        [TestMethod]
        public void TestCrossAt439()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual3, 9);
            CollectionAssert.AreEqual(IndividualsResults.result439, result);
        }

        [TestMethod]
        public void TestCrossAt440()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual4, 0);
            CollectionAssert.AreEqual(IndividualsResults.result440, result);
        }

        [TestMethod]
        public void TestCrossAt441()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual4, 1);
            CollectionAssert.AreEqual(IndividualsResults.result441, result);
        }

        [TestMethod]
        public void TestCrossAt442()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual4, 2);
            CollectionAssert.AreEqual(IndividualsResults.result442, result);
        }

        [TestMethod]
        public void TestCrossAt443()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual4, 3);
            CollectionAssert.AreEqual(IndividualsResults.result443, result);
        }

        [TestMethod]
        public void TestCrossAt444()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual4, 4);
            CollectionAssert.AreEqual(IndividualsResults.result444, result);
        }

        [TestMethod]
        public void TestCrossAt445()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual4, 5);
            CollectionAssert.AreEqual(IndividualsResults.result445, result);
        }

        [TestMethod]
        public void TestCrossAt446()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual4, 6);
            CollectionAssert.AreEqual(IndividualsResults.result446, result);
        }

        [TestMethod]
        public void TestCrossAt447()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual4, 7);
            CollectionAssert.AreEqual(IndividualsResults.result447, result);
        }

        [TestMethod]
        public void TestCrossAt448()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual4, 8);
            CollectionAssert.AreEqual(IndividualsResults.result448, result);
        }

        [TestMethod]
        public void TestCrossAt449()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual4, 9);
            CollectionAssert.AreEqual(IndividualsResults.result449, result);
        }

        [TestMethod]
        public void TestCrossAt450()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual5, 0);
            CollectionAssert.AreEqual(IndividualsResults.result450, result);
        }

        [TestMethod]
        public void TestCrossAt451()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual5, 1);
            CollectionAssert.AreEqual(IndividualsResults.result451, result);
        }

        [TestMethod]
        public void TestCrossAt452()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual5, 2);
            CollectionAssert.AreEqual(IndividualsResults.result452, result);
        }

        [TestMethod]
        public void TestCrossAt453()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual5, 3);
            CollectionAssert.AreEqual(IndividualsResults.result453, result);
        }

        [TestMethod]
        public void TestCrossAt454()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual5, 4);
            CollectionAssert.AreEqual(IndividualsResults.result454, result);
        }

        [TestMethod]
        public void TestCrossAt455()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual5, 5);
            CollectionAssert.AreEqual(IndividualsResults.result455, result);
        }

        [TestMethod]
        public void TestCrossAt456()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual5, 6);
            CollectionAssert.AreEqual(IndividualsResults.result456, result);
        }

        [TestMethod]
        public void TestCrossAt457()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual5, 7);
            CollectionAssert.AreEqual(IndividualsResults.result457, result);
        }

        [TestMethod]
        public void TestCrossAt458()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual5, 8);
            CollectionAssert.AreEqual(IndividualsResults.result458, result);
        }

        [TestMethod]
        public void TestCrossAt459()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual5, 9);
            CollectionAssert.AreEqual(IndividualsResults.result459, result);
        }

        [TestMethod]
        public void TestCrossAt460()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual6, 0);
            CollectionAssert.AreEqual(IndividualsResults.result460, result);
        }

        [TestMethod]
        public void TestCrossAt461()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual6, 1);
            CollectionAssert.AreEqual(IndividualsResults.result461, result);
        }

        [TestMethod]
        public void TestCrossAt462()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual6, 2);
            CollectionAssert.AreEqual(IndividualsResults.result462, result);
        }

        [TestMethod]
        public void TestCrossAt463()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual6, 3);
            CollectionAssert.AreEqual(IndividualsResults.result463, result);
        }

        [TestMethod]
        public void TestCrossAt464()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual6, 4);
            CollectionAssert.AreEqual(IndividualsResults.result464, result);
        }

        [TestMethod]
        public void TestCrossAt465()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual6, 5);
            CollectionAssert.AreEqual(IndividualsResults.result465, result);
        }

        [TestMethod]
        public void TestCrossAt466()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual6, 6);
            CollectionAssert.AreEqual(IndividualsResults.result466, result);
        }

        [TestMethod]
        public void TestCrossAt467()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual6, 7);
            CollectionAssert.AreEqual(IndividualsResults.result467, result);
        }

        [TestMethod]
        public void TestCrossAt468()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual6, 8);
            CollectionAssert.AreEqual(IndividualsResults.result468, result);
        }

        [TestMethod]
        public void TestCrossAt469()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual6, 9);
            CollectionAssert.AreEqual(IndividualsResults.result469, result);
        }

        [TestMethod]
        public void TestCrossAt470()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual7, 0);
            CollectionAssert.AreEqual(IndividualsResults.result470, result);
        }

        [TestMethod]
        public void TestCrossAt471()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual7, 1);
            CollectionAssert.AreEqual(IndividualsResults.result471, result);
        }

        [TestMethod]
        public void TestCrossAt472()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual7, 2);
            CollectionAssert.AreEqual(IndividualsResults.result472, result);
        }

        [TestMethod]
        public void TestCrossAt473()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual7, 3);
            CollectionAssert.AreEqual(IndividualsResults.result473, result);
        }

        [TestMethod]
        public void TestCrossAt474()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual7, 4);
            CollectionAssert.AreEqual(IndividualsResults.result474, result);
        }

        [TestMethod]
        public void TestCrossAt475()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual7, 5);
            CollectionAssert.AreEqual(IndividualsResults.result475, result);
        }

        [TestMethod]
        public void TestCrossAt476()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual7, 6);
            CollectionAssert.AreEqual(IndividualsResults.result476, result);
        }

        [TestMethod]
        public void TestCrossAt477()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual7, 7);
            CollectionAssert.AreEqual(IndividualsResults.result477, result);
        }

        [TestMethod]
        public void TestCrossAt478()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual7, 8);
            CollectionAssert.AreEqual(IndividualsResults.result478, result);
        }

        [TestMethod]
        public void TestCrossAt479()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual7, 9);
            CollectionAssert.AreEqual(IndividualsResults.result479, result);
        }

        [TestMethod]
        public void TestCrossAt480()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual8, 0);
            CollectionAssert.AreEqual(IndividualsResults.result480, result);
        }

        [TestMethod]
        public void TestCrossAt481()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual8, 1);
            CollectionAssert.AreEqual(IndividualsResults.result481, result);
        }

        [TestMethod]
        public void TestCrossAt482()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual8, 2);
            CollectionAssert.AreEqual(IndividualsResults.result482, result);
        }

        [TestMethod]
        public void TestCrossAt483()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual8, 3);
            CollectionAssert.AreEqual(IndividualsResults.result483, result);
        }

        [TestMethod]
        public void TestCrossAt484()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual8, 4);
            CollectionAssert.AreEqual(IndividualsResults.result484, result);
        }

        [TestMethod]
        public void TestCrossAt485()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual8, 5);
            CollectionAssert.AreEqual(IndividualsResults.result485, result);
        }

        [TestMethod]
        public void TestCrossAt486()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual8, 6);
            CollectionAssert.AreEqual(IndividualsResults.result486, result);
        }

        [TestMethod]
        public void TestCrossAt487()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual8, 7);
            CollectionAssert.AreEqual(IndividualsResults.result487, result);
        }

        [TestMethod]
        public void TestCrossAt488()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual8, 8);
            CollectionAssert.AreEqual(IndividualsResults.result488, result);
        }

        [TestMethod]
        public void TestCrossAt489()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual8, 9);
            CollectionAssert.AreEqual(IndividualsResults.result489, result);
        }

        [TestMethod]
        public void TestCrossAt490()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual9, 0);
            CollectionAssert.AreEqual(IndividualsResults.result490, result);
        }

        [TestMethod]
        public void TestCrossAt491()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual9, 1);
            CollectionAssert.AreEqual(IndividualsResults.result491, result);
        }

        [TestMethod]
        public void TestCrossAt492()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual9, 2);
            CollectionAssert.AreEqual(IndividualsResults.result492, result);
        }

        [TestMethod]
        public void TestCrossAt493()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual9, 3);
            CollectionAssert.AreEqual(IndividualsResults.result493, result);
        }

        [TestMethod]
        public void TestCrossAt494()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual9, 4);
            CollectionAssert.AreEqual(IndividualsResults.result494, result);
        }

        [TestMethod]
        public void TestCrossAt495()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual9, 5);
            CollectionAssert.AreEqual(IndividualsResults.result495, result);
        }

        [TestMethod]
        public void TestCrossAt496()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual9, 6);
            CollectionAssert.AreEqual(IndividualsResults.result496, result);
        }

        [TestMethod]
        public void TestCrossAt497()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual9, 7);
            CollectionAssert.AreEqual(IndividualsResults.result497, result);
        }

        [TestMethod]
        public void TestCrossAt498()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual9, 8);
            CollectionAssert.AreEqual(IndividualsResults.result498, result);
        }

        [TestMethod]
        public void TestCrossAt499()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual4, TestIndividuals.individual9, 9);
            CollectionAssert.AreEqual(IndividualsResults.result499, result);
        }

        [TestMethod]
        public void TestCrossAt500()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual0, 0);
            CollectionAssert.AreEqual(IndividualsResults.result500, result);
        }

        [TestMethod]
        public void TestCrossAt501()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual0, 1);
            CollectionAssert.AreEqual(IndividualsResults.result501, result);
        }

        [TestMethod]
        public void TestCrossAt502()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual0, 2);
            CollectionAssert.AreEqual(IndividualsResults.result502, result);
        }

        [TestMethod]
        public void TestCrossAt503()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual0, 3);
            CollectionAssert.AreEqual(IndividualsResults.result503, result);
        }

        [TestMethod]
        public void TestCrossAt504()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual0, 4);
            CollectionAssert.AreEqual(IndividualsResults.result504, result);
        }

        [TestMethod]
        public void TestCrossAt505()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual0, 5);
            CollectionAssert.AreEqual(IndividualsResults.result505, result);
        }

        [TestMethod]
        public void TestCrossAt506()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual0, 6);
            CollectionAssert.AreEqual(IndividualsResults.result506, result);
        }

        [TestMethod]
        public void TestCrossAt507()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual0, 7);
            CollectionAssert.AreEqual(IndividualsResults.result507, result);
        }

        [TestMethod]
        public void TestCrossAt508()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual0, 8);
            CollectionAssert.AreEqual(IndividualsResults.result508, result);
        }

        [TestMethod]
        public void TestCrossAt509()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual0, 9);
            CollectionAssert.AreEqual(IndividualsResults.result509, result);
        }

        [TestMethod]
        public void TestCrossAt510()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual1, 0);
            CollectionAssert.AreEqual(IndividualsResults.result510, result);
        }

        [TestMethod]
        public void TestCrossAt511()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual1, 1);
            CollectionAssert.AreEqual(IndividualsResults.result511, result);
        }

        [TestMethod]
        public void TestCrossAt512()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual1, 2);
            CollectionAssert.AreEqual(IndividualsResults.result512, result);
        }

        [TestMethod]
        public void TestCrossAt513()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual1, 3);
            CollectionAssert.AreEqual(IndividualsResults.result513, result);
        }

        [TestMethod]
        public void TestCrossAt514()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual1, 4);
            CollectionAssert.AreEqual(IndividualsResults.result514, result);
        }

        [TestMethod]
        public void TestCrossAt515()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual1, 5);
            CollectionAssert.AreEqual(IndividualsResults.result515, result);
        }

        [TestMethod]
        public void TestCrossAt516()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual1, 6);
            CollectionAssert.AreEqual(IndividualsResults.result516, result);
        }

        [TestMethod]
        public void TestCrossAt517()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual1, 7);
            CollectionAssert.AreEqual(IndividualsResults.result517, result);
        }

        [TestMethod]
        public void TestCrossAt518()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual1, 8);
            CollectionAssert.AreEqual(IndividualsResults.result518, result);
        }

        [TestMethod]
        public void TestCrossAt519()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual1, 9);
            CollectionAssert.AreEqual(IndividualsResults.result519, result);
        }

        [TestMethod]
        public void TestCrossAt520()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual2, 0);
            CollectionAssert.AreEqual(IndividualsResults.result520, result);
        }

        [TestMethod]
        public void TestCrossAt521()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual2, 1);
            CollectionAssert.AreEqual(IndividualsResults.result521, result);
        }

        [TestMethod]
        public void TestCrossAt522()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual2, 2);
            CollectionAssert.AreEqual(IndividualsResults.result522, result);
        }

        [TestMethod]
        public void TestCrossAt523()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual2, 3);
            CollectionAssert.AreEqual(IndividualsResults.result523, result);
        }

        [TestMethod]
        public void TestCrossAt524()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual2, 4);
            CollectionAssert.AreEqual(IndividualsResults.result524, result);
        }

        [TestMethod]
        public void TestCrossAt525()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual2, 5);
            CollectionAssert.AreEqual(IndividualsResults.result525, result);
        }

        [TestMethod]
        public void TestCrossAt526()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual2, 6);
            CollectionAssert.AreEqual(IndividualsResults.result526, result);
        }

        [TestMethod]
        public void TestCrossAt527()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual2, 7);
            CollectionAssert.AreEqual(IndividualsResults.result527, result);
        }

        [TestMethod]
        public void TestCrossAt528()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual2, 8);
            CollectionAssert.AreEqual(IndividualsResults.result528, result);
        }

        [TestMethod]
        public void TestCrossAt529()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual2, 9);
            CollectionAssert.AreEqual(IndividualsResults.result529, result);
        }

        [TestMethod]
        public void TestCrossAt530()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual3, 0);
            CollectionAssert.AreEqual(IndividualsResults.result530, result);
        }

        [TestMethod]
        public void TestCrossAt531()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual3, 1);
            CollectionAssert.AreEqual(IndividualsResults.result531, result);
        }

        [TestMethod]
        public void TestCrossAt532()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual3, 2);
            CollectionAssert.AreEqual(IndividualsResults.result532, result);
        }

        [TestMethod]
        public void TestCrossAt533()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual3, 3);
            CollectionAssert.AreEqual(IndividualsResults.result533, result);
        }

        [TestMethod]
        public void TestCrossAt534()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual3, 4);
            CollectionAssert.AreEqual(IndividualsResults.result534, result);
        }

        [TestMethod]
        public void TestCrossAt535()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual3, 5);
            CollectionAssert.AreEqual(IndividualsResults.result535, result);
        }

        [TestMethod]
        public void TestCrossAt536()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual3, 6);
            CollectionAssert.AreEqual(IndividualsResults.result536, result);
        }

        [TestMethod]
        public void TestCrossAt537()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual3, 7);
            CollectionAssert.AreEqual(IndividualsResults.result537, result);
        }

        [TestMethod]
        public void TestCrossAt538()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual3, 8);
            CollectionAssert.AreEqual(IndividualsResults.result538, result);
        }

        [TestMethod]
        public void TestCrossAt539()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual3, 9);
            CollectionAssert.AreEqual(IndividualsResults.result539, result);
        }

        [TestMethod]
        public void TestCrossAt540()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual4, 0);
            CollectionAssert.AreEqual(IndividualsResults.result540, result);
        }

        [TestMethod]
        public void TestCrossAt541()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual4, 1);
            CollectionAssert.AreEqual(IndividualsResults.result541, result);
        }

        [TestMethod]
        public void TestCrossAt542()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual4, 2);
            CollectionAssert.AreEqual(IndividualsResults.result542, result);
        }

        [TestMethod]
        public void TestCrossAt543()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual4, 3);
            CollectionAssert.AreEqual(IndividualsResults.result543, result);
        }

        [TestMethod]
        public void TestCrossAt544()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual4, 4);
            CollectionAssert.AreEqual(IndividualsResults.result544, result);
        }

        [TestMethod]
        public void TestCrossAt545()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual4, 5);
            CollectionAssert.AreEqual(IndividualsResults.result545, result);
        }

        [TestMethod]
        public void TestCrossAt546()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual4, 6);
            CollectionAssert.AreEqual(IndividualsResults.result546, result);
        }

        [TestMethod]
        public void TestCrossAt547()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual4, 7);
            CollectionAssert.AreEqual(IndividualsResults.result547, result);
        }

        [TestMethod]
        public void TestCrossAt548()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual4, 8);
            CollectionAssert.AreEqual(IndividualsResults.result548, result);
        }

        [TestMethod]
        public void TestCrossAt549()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual4, 9);
            CollectionAssert.AreEqual(IndividualsResults.result549, result);
        }

        [TestMethod]
        public void TestCrossAt550()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual5, 0);
            CollectionAssert.AreEqual(IndividualsResults.result550, result);
        }

        [TestMethod]
        public void TestCrossAt551()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual5, 1);
            CollectionAssert.AreEqual(IndividualsResults.result551, result);
        }

        [TestMethod]
        public void TestCrossAt552()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual5, 2);
            CollectionAssert.AreEqual(IndividualsResults.result552, result);
        }

        [TestMethod]
        public void TestCrossAt553()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual5, 3);
            CollectionAssert.AreEqual(IndividualsResults.result553, result);
        }

        [TestMethod]
        public void TestCrossAt554()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual5, 4);
            CollectionAssert.AreEqual(IndividualsResults.result554, result);
        }

        [TestMethod]
        public void TestCrossAt555()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual5, 5);
            CollectionAssert.AreEqual(IndividualsResults.result555, result);
        }

        [TestMethod]
        public void TestCrossAt556()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual5, 6);
            CollectionAssert.AreEqual(IndividualsResults.result556, result);
        }

        [TestMethod]
        public void TestCrossAt557()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual5, 7);
            CollectionAssert.AreEqual(IndividualsResults.result557, result);
        }

        [TestMethod]
        public void TestCrossAt558()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual5, 8);
            CollectionAssert.AreEqual(IndividualsResults.result558, result);
        }

        [TestMethod]
        public void TestCrossAt559()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual5, 9);
            CollectionAssert.AreEqual(IndividualsResults.result559, result);
        }

        [TestMethod]
        public void TestCrossAt560()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual6, 0);
            CollectionAssert.AreEqual(IndividualsResults.result560, result);
        }

        [TestMethod]
        public void TestCrossAt561()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual6, 1);
            CollectionAssert.AreEqual(IndividualsResults.result561, result);
        }

        [TestMethod]
        public void TestCrossAt562()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual6, 2);
            CollectionAssert.AreEqual(IndividualsResults.result562, result);
        }

        [TestMethod]
        public void TestCrossAt563()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual6, 3);
            CollectionAssert.AreEqual(IndividualsResults.result563, result);
        }

        [TestMethod]
        public void TestCrossAt564()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual6, 4);
            CollectionAssert.AreEqual(IndividualsResults.result564, result);
        }

        [TestMethod]
        public void TestCrossAt565()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual6, 5);
            CollectionAssert.AreEqual(IndividualsResults.result565, result);
        }

        [TestMethod]
        public void TestCrossAt566()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual6, 6);
            CollectionAssert.AreEqual(IndividualsResults.result566, result);
        }

        [TestMethod]
        public void TestCrossAt567()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual6, 7);
            CollectionAssert.AreEqual(IndividualsResults.result567, result);
        }

        [TestMethod]
        public void TestCrossAt568()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual6, 8);
            CollectionAssert.AreEqual(IndividualsResults.result568, result);
        }

        [TestMethod]
        public void TestCrossAt569()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual6, 9);
            CollectionAssert.AreEqual(IndividualsResults.result569, result);
        }

        [TestMethod]
        public void TestCrossAt570()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual7, 0);
            CollectionAssert.AreEqual(IndividualsResults.result570, result);
        }

        [TestMethod]
        public void TestCrossAt571()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual7, 1);
            CollectionAssert.AreEqual(IndividualsResults.result571, result);
        }

        [TestMethod]
        public void TestCrossAt572()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual7, 2);
            CollectionAssert.AreEqual(IndividualsResults.result572, result);
        }

        [TestMethod]
        public void TestCrossAt573()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual7, 3);
            CollectionAssert.AreEqual(IndividualsResults.result573, result);
        }

        [TestMethod]
        public void TestCrossAt574()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual7, 4);
            CollectionAssert.AreEqual(IndividualsResults.result574, result);
        }

        [TestMethod]
        public void TestCrossAt575()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual7, 5);
            CollectionAssert.AreEqual(IndividualsResults.result575, result);
        }

        [TestMethod]
        public void TestCrossAt576()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual7, 6);
            CollectionAssert.AreEqual(IndividualsResults.result576, result);
        }

        [TestMethod]
        public void TestCrossAt577()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual7, 7);
            CollectionAssert.AreEqual(IndividualsResults.result577, result);
        }

        [TestMethod]
        public void TestCrossAt578()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual7, 8);
            CollectionAssert.AreEqual(IndividualsResults.result578, result);
        }

        [TestMethod]
        public void TestCrossAt579()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual7, 9);
            CollectionAssert.AreEqual(IndividualsResults.result579, result);
        }

        [TestMethod]
        public void TestCrossAt580()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual8, 0);
            CollectionAssert.AreEqual(IndividualsResults.result580, result);
        }

        [TestMethod]
        public void TestCrossAt581()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual8, 1);
            CollectionAssert.AreEqual(IndividualsResults.result581, result);
        }

        [TestMethod]
        public void TestCrossAt582()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual8, 2);
            CollectionAssert.AreEqual(IndividualsResults.result582, result);
        }

        [TestMethod]
        public void TestCrossAt583()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual8, 3);
            CollectionAssert.AreEqual(IndividualsResults.result583, result);
        }

        [TestMethod]
        public void TestCrossAt584()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual8, 4);
            CollectionAssert.AreEqual(IndividualsResults.result584, result);
        }

        [TestMethod]
        public void TestCrossAt585()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual8, 5);
            CollectionAssert.AreEqual(IndividualsResults.result585, result);
        }

        [TestMethod]
        public void TestCrossAt586()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual8, 6);
            CollectionAssert.AreEqual(IndividualsResults.result586, result);
        }

        [TestMethod]
        public void TestCrossAt587()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual8, 7);
            CollectionAssert.AreEqual(IndividualsResults.result587, result);
        }

        [TestMethod]
        public void TestCrossAt588()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual8, 8);
            CollectionAssert.AreEqual(IndividualsResults.result588, result);
        }

        [TestMethod]
        public void TestCrossAt589()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual8, 9);
            CollectionAssert.AreEqual(IndividualsResults.result589, result);
        }

        [TestMethod]
        public void TestCrossAt590()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual9, 0);
            CollectionAssert.AreEqual(IndividualsResults.result590, result);
        }

        [TestMethod]
        public void TestCrossAt591()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual9, 1);
            CollectionAssert.AreEqual(IndividualsResults.result591, result);
        }

        [TestMethod]
        public void TestCrossAt592()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual9, 2);
            CollectionAssert.AreEqual(IndividualsResults.result592, result);
        }

        [TestMethod]
        public void TestCrossAt593()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual9, 3);
            CollectionAssert.AreEqual(IndividualsResults.result593, result);
        }

        [TestMethod]
        public void TestCrossAt594()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual9, 4);
            CollectionAssert.AreEqual(IndividualsResults.result594, result);
        }

        [TestMethod]
        public void TestCrossAt595()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual9, 5);
            CollectionAssert.AreEqual(IndividualsResults.result595, result);
        }

        [TestMethod]
        public void TestCrossAt596()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual9, 6);
            CollectionAssert.AreEqual(IndividualsResults.result596, result);
        }

        [TestMethod]
        public void TestCrossAt597()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual9, 7);
            CollectionAssert.AreEqual(IndividualsResults.result597, result);
        }

        [TestMethod]
        public void TestCrossAt598()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual9, 8);
            CollectionAssert.AreEqual(IndividualsResults.result598, result);
        }

        [TestMethod]
        public void TestCrossAt599()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual5, TestIndividuals.individual9, 9);
            CollectionAssert.AreEqual(IndividualsResults.result599, result);
        }

        [TestMethod]
        public void TestCrossAt600()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual0, 0);
            CollectionAssert.AreEqual(IndividualsResults.result600, result);
        }

        [TestMethod]
        public void TestCrossAt601()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual0, 1);
            CollectionAssert.AreEqual(IndividualsResults.result601, result);
        }

        [TestMethod]
        public void TestCrossAt602()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual0, 2);
            CollectionAssert.AreEqual(IndividualsResults.result602, result);
        }

        [TestMethod]
        public void TestCrossAt603()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual0, 3);
            CollectionAssert.AreEqual(IndividualsResults.result603, result);
        }

        [TestMethod]
        public void TestCrossAt604()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual0, 4);
            CollectionAssert.AreEqual(IndividualsResults.result604, result);
        }

        [TestMethod]
        public void TestCrossAt605()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual0, 5);
            CollectionAssert.AreEqual(IndividualsResults.result605, result);
        }

        [TestMethod]
        public void TestCrossAt606()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual0, 6);
            CollectionAssert.AreEqual(IndividualsResults.result606, result);
        }

        [TestMethod]
        public void TestCrossAt607()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual0, 7);
            CollectionAssert.AreEqual(IndividualsResults.result607, result);
        }

        [TestMethod]
        public void TestCrossAt608()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual0, 8);
            CollectionAssert.AreEqual(IndividualsResults.result608, result);
        }

        [TestMethod]
        public void TestCrossAt609()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual0, 9);
            CollectionAssert.AreEqual(IndividualsResults.result609, result);
        }

        [TestMethod]
        public void TestCrossAt610()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual1, 0);
            CollectionAssert.AreEqual(IndividualsResults.result610, result);
        }

        [TestMethod]
        public void TestCrossAt611()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual1, 1);
            CollectionAssert.AreEqual(IndividualsResults.result611, result);
        }

        [TestMethod]
        public void TestCrossAt612()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual1, 2);
            CollectionAssert.AreEqual(IndividualsResults.result612, result);
        }

        [TestMethod]
        public void TestCrossAt613()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual1, 3);
            CollectionAssert.AreEqual(IndividualsResults.result613, result);
        }

        [TestMethod]
        public void TestCrossAt614()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual1, 4);
            CollectionAssert.AreEqual(IndividualsResults.result614, result);
        }

        [TestMethod]
        public void TestCrossAt615()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual1, 5);
            CollectionAssert.AreEqual(IndividualsResults.result615, result);
        }

        [TestMethod]
        public void TestCrossAt616()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual1, 6);
            CollectionAssert.AreEqual(IndividualsResults.result616, result);
        }

        [TestMethod]
        public void TestCrossAt617()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual1, 7);
            CollectionAssert.AreEqual(IndividualsResults.result617, result);
        }

        [TestMethod]
        public void TestCrossAt618()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual1, 8);
            CollectionAssert.AreEqual(IndividualsResults.result618, result);
        }

        [TestMethod]
        public void TestCrossAt619()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual1, 9);
            CollectionAssert.AreEqual(IndividualsResults.result619, result);
        }

        [TestMethod]
        public void TestCrossAt620()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual2, 0);
            CollectionAssert.AreEqual(IndividualsResults.result620, result);
        }

        [TestMethod]
        public void TestCrossAt621()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual2, 1);
            CollectionAssert.AreEqual(IndividualsResults.result621, result);
        }

        [TestMethod]
        public void TestCrossAt622()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual2, 2);
            CollectionAssert.AreEqual(IndividualsResults.result622, result);
        }

        [TestMethod]
        public void TestCrossAt623()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual2, 3);
            CollectionAssert.AreEqual(IndividualsResults.result623, result);
        }

        [TestMethod]
        public void TestCrossAt624()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual2, 4);
            CollectionAssert.AreEqual(IndividualsResults.result624, result);
        }

        [TestMethod]
        public void TestCrossAt625()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual2, 5);
            CollectionAssert.AreEqual(IndividualsResults.result625, result);
        }

        [TestMethod]
        public void TestCrossAt626()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual2, 6);
            CollectionAssert.AreEqual(IndividualsResults.result626, result);
        }

        [TestMethod]
        public void TestCrossAt627()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual2, 7);
            CollectionAssert.AreEqual(IndividualsResults.result627, result);
        }

        [TestMethod]
        public void TestCrossAt628()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual2, 8);
            CollectionAssert.AreEqual(IndividualsResults.result628, result);
        }

        [TestMethod]
        public void TestCrossAt629()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual2, 9);
            CollectionAssert.AreEqual(IndividualsResults.result629, result);
        }

        [TestMethod]
        public void TestCrossAt630()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual3, 0);
            CollectionAssert.AreEqual(IndividualsResults.result630, result);
        }

        [TestMethod]
        public void TestCrossAt631()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual3, 1);
            CollectionAssert.AreEqual(IndividualsResults.result631, result);
        }

        [TestMethod]
        public void TestCrossAt632()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual3, 2);
            CollectionAssert.AreEqual(IndividualsResults.result632, result);
        }

        [TestMethod]
        public void TestCrossAt633()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual3, 3);
            CollectionAssert.AreEqual(IndividualsResults.result633, result);
        }

        [TestMethod]
        public void TestCrossAt634()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual3, 4);
            CollectionAssert.AreEqual(IndividualsResults.result634, result);
        }

        [TestMethod]
        public void TestCrossAt635()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual3, 5);
            CollectionAssert.AreEqual(IndividualsResults.result635, result);
        }

        [TestMethod]
        public void TestCrossAt636()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual3, 6);
            CollectionAssert.AreEqual(IndividualsResults.result636, result);
        }

        [TestMethod]
        public void TestCrossAt637()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual3, 7);
            CollectionAssert.AreEqual(IndividualsResults.result637, result);
        }

        [TestMethod]
        public void TestCrossAt638()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual3, 8);
            CollectionAssert.AreEqual(IndividualsResults.result638, result);
        }

        [TestMethod]
        public void TestCrossAt639()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual3, 9);
            CollectionAssert.AreEqual(IndividualsResults.result639, result);
        }

        [TestMethod]
        public void TestCrossAt640()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual4, 0);
            CollectionAssert.AreEqual(IndividualsResults.result640, result);
        }

        [TestMethod]
        public void TestCrossAt641()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual4, 1);
            CollectionAssert.AreEqual(IndividualsResults.result641, result);
        }

        [TestMethod]
        public void TestCrossAt642()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual4, 2);
            CollectionAssert.AreEqual(IndividualsResults.result642, result);
        }

        [TestMethod]
        public void TestCrossAt643()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual4, 3);
            CollectionAssert.AreEqual(IndividualsResults.result643, result);
        }

        [TestMethod]
        public void TestCrossAt644()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual4, 4);
            CollectionAssert.AreEqual(IndividualsResults.result644, result);
        }

        [TestMethod]
        public void TestCrossAt645()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual4, 5);
            CollectionAssert.AreEqual(IndividualsResults.result645, result);
        }

        [TestMethod]
        public void TestCrossAt646()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual4, 6);
            CollectionAssert.AreEqual(IndividualsResults.result646, result);
        }

        [TestMethod]
        public void TestCrossAt647()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual4, 7);
            CollectionAssert.AreEqual(IndividualsResults.result647, result);
        }

        [TestMethod]
        public void TestCrossAt648()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual4, 8);
            CollectionAssert.AreEqual(IndividualsResults.result648, result);
        }

        [TestMethod]
        public void TestCrossAt649()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual4, 9);
            CollectionAssert.AreEqual(IndividualsResults.result649, result);
        }

        [TestMethod]
        public void TestCrossAt650()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual5, 0);
            CollectionAssert.AreEqual(IndividualsResults.result650, result);
        }

        [TestMethod]
        public void TestCrossAt651()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual5, 1);
            CollectionAssert.AreEqual(IndividualsResults.result651, result);
        }

        [TestMethod]
        public void TestCrossAt652()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual5, 2);
            CollectionAssert.AreEqual(IndividualsResults.result652, result);
        }

        [TestMethod]
        public void TestCrossAt653()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual5, 3);
            CollectionAssert.AreEqual(IndividualsResults.result653, result);
        }

        [TestMethod]
        public void TestCrossAt654()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual5, 4);
            CollectionAssert.AreEqual(IndividualsResults.result654, result);
        }

        [TestMethod]
        public void TestCrossAt655()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual5, 5);
            CollectionAssert.AreEqual(IndividualsResults.result655, result);
        }

        [TestMethod]
        public void TestCrossAt656()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual5, 6);
            CollectionAssert.AreEqual(IndividualsResults.result656, result);
        }

        [TestMethod]
        public void TestCrossAt657()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual5, 7);
            CollectionAssert.AreEqual(IndividualsResults.result657, result);
        }

        [TestMethod]
        public void TestCrossAt658()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual5, 8);
            CollectionAssert.AreEqual(IndividualsResults.result658, result);
        }

        [TestMethod]
        public void TestCrossAt659()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual5, 9);
            CollectionAssert.AreEqual(IndividualsResults.result659, result);
        }

        [TestMethod]
        public void TestCrossAt660()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual6, 0);
            CollectionAssert.AreEqual(IndividualsResults.result660, result);
        }

        [TestMethod]
        public void TestCrossAt661()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual6, 1);
            CollectionAssert.AreEqual(IndividualsResults.result661, result);
        }

        [TestMethod]
        public void TestCrossAt662()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual6, 2);
            CollectionAssert.AreEqual(IndividualsResults.result662, result);
        }

        [TestMethod]
        public void TestCrossAt663()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual6, 3);
            CollectionAssert.AreEqual(IndividualsResults.result663, result);
        }

        [TestMethod]
        public void TestCrossAt664()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual6, 4);
            CollectionAssert.AreEqual(IndividualsResults.result664, result);
        }

        [TestMethod]
        public void TestCrossAt665()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual6, 5);
            CollectionAssert.AreEqual(IndividualsResults.result665, result);
        }

        [TestMethod]
        public void TestCrossAt666()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual6, 6);
            CollectionAssert.AreEqual(IndividualsResults.result666, result);
        }

        [TestMethod]
        public void TestCrossAt667()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual6, 7);
            CollectionAssert.AreEqual(IndividualsResults.result667, result);
        }

        [TestMethod]
        public void TestCrossAt668()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual6, 8);
            CollectionAssert.AreEqual(IndividualsResults.result668, result);
        }

        [TestMethod]
        public void TestCrossAt669()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual6, 9);
            CollectionAssert.AreEqual(IndividualsResults.result669, result);
        }

        [TestMethod]
        public void TestCrossAt670()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual7, 0);
            CollectionAssert.AreEqual(IndividualsResults.result670, result);
        }

        [TestMethod]
        public void TestCrossAt671()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual7, 1);
            CollectionAssert.AreEqual(IndividualsResults.result671, result);
        }

        [TestMethod]
        public void TestCrossAt672()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual7, 2);
            CollectionAssert.AreEqual(IndividualsResults.result672, result);
        }

        [TestMethod]
        public void TestCrossAt673()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual7, 3);
            CollectionAssert.AreEqual(IndividualsResults.result673, result);
        }

        [TestMethod]
        public void TestCrossAt674()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual7, 4);
            CollectionAssert.AreEqual(IndividualsResults.result674, result);
        }

        [TestMethod]
        public void TestCrossAt675()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual7, 5);
            CollectionAssert.AreEqual(IndividualsResults.result675, result);
        }

        [TestMethod]
        public void TestCrossAt676()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual7, 6);
            CollectionAssert.AreEqual(IndividualsResults.result676, result);
        }

        [TestMethod]
        public void TestCrossAt677()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual7, 7);
            CollectionAssert.AreEqual(IndividualsResults.result677, result);
        }

        [TestMethod]
        public void TestCrossAt678()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual7, 8);
            CollectionAssert.AreEqual(IndividualsResults.result678, result);
        }

        [TestMethod]
        public void TestCrossAt679()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual7, 9);
            CollectionAssert.AreEqual(IndividualsResults.result679, result);
        }

        [TestMethod]
        public void TestCrossAt680()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual8, 0);
            CollectionAssert.AreEqual(IndividualsResults.result680, result);
        }

        [TestMethod]
        public void TestCrossAt681()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual8, 1);
            CollectionAssert.AreEqual(IndividualsResults.result681, result);
        }

        [TestMethod]
        public void TestCrossAt682()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual8, 2);
            CollectionAssert.AreEqual(IndividualsResults.result682, result);
        }

        [TestMethod]
        public void TestCrossAt683()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual8, 3);
            CollectionAssert.AreEqual(IndividualsResults.result683, result);
        }

        [TestMethod]
        public void TestCrossAt684()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual8, 4);
            CollectionAssert.AreEqual(IndividualsResults.result684, result);
        }

        [TestMethod]
        public void TestCrossAt685()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual8, 5);
            CollectionAssert.AreEqual(IndividualsResults.result685, result);
        }

        [TestMethod]
        public void TestCrossAt686()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual8, 6);
            CollectionAssert.AreEqual(IndividualsResults.result686, result);
        }

        [TestMethod]
        public void TestCrossAt687()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual8, 7);
            CollectionAssert.AreEqual(IndividualsResults.result687, result);
        }

        [TestMethod]
        public void TestCrossAt688()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual8, 8);
            CollectionAssert.AreEqual(IndividualsResults.result688, result);
        }

        [TestMethod]
        public void TestCrossAt689()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual8, 9);
            CollectionAssert.AreEqual(IndividualsResults.result689, result);
        }

        [TestMethod]
        public void TestCrossAt690()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual9, 0);
            CollectionAssert.AreEqual(IndividualsResults.result690, result);
        }

        [TestMethod]
        public void TestCrossAt691()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual9, 1);
            CollectionAssert.AreEqual(IndividualsResults.result691, result);
        }

        [TestMethod]
        public void TestCrossAt692()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual9, 2);
            CollectionAssert.AreEqual(IndividualsResults.result692, result);
        }

        [TestMethod]
        public void TestCrossAt693()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual9, 3);
            CollectionAssert.AreEqual(IndividualsResults.result693, result);
        }

        [TestMethod]
        public void TestCrossAt694()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual9, 4);
            CollectionAssert.AreEqual(IndividualsResults.result694, result);
        }

        [TestMethod]
        public void TestCrossAt695()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual9, 5);
            CollectionAssert.AreEqual(IndividualsResults.result695, result);
        }

        [TestMethod]
        public void TestCrossAt696()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual9, 6);
            CollectionAssert.AreEqual(IndividualsResults.result696, result);
        }

        [TestMethod]
        public void TestCrossAt697()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual9, 7);
            CollectionAssert.AreEqual(IndividualsResults.result697, result);
        }

        [TestMethod]
        public void TestCrossAt698()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual9, 8);
            CollectionAssert.AreEqual(IndividualsResults.result698, result);
        }

        [TestMethod]
        public void TestCrossAt699()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual6, TestIndividuals.individual9, 9);
            CollectionAssert.AreEqual(IndividualsResults.result699, result);
        }

        [TestMethod]
        public void TestCrossAt700()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual0, 0);
            CollectionAssert.AreEqual(IndividualsResults.result700, result);
        }

        [TestMethod]
        public void TestCrossAt701()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual0, 1);
            CollectionAssert.AreEqual(IndividualsResults.result701, result);
        }

        [TestMethod]
        public void TestCrossAt702()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual0, 2);
            CollectionAssert.AreEqual(IndividualsResults.result702, result);
        }

        [TestMethod]
        public void TestCrossAt703()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual0, 3);
            CollectionAssert.AreEqual(IndividualsResults.result703, result);
        }

        [TestMethod]
        public void TestCrossAt704()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual0, 4);
            CollectionAssert.AreEqual(IndividualsResults.result704, result);
        }

        [TestMethod]
        public void TestCrossAt705()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual0, 5);
            CollectionAssert.AreEqual(IndividualsResults.result705, result);
        }

        [TestMethod]
        public void TestCrossAt706()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual0, 6);
            CollectionAssert.AreEqual(IndividualsResults.result706, result);
        }

        [TestMethod]
        public void TestCrossAt707()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual0, 7);
            CollectionAssert.AreEqual(IndividualsResults.result707, result);
        }

        [TestMethod]
        public void TestCrossAt708()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual0, 8);
            CollectionAssert.AreEqual(IndividualsResults.result708, result);
        }

        [TestMethod]
        public void TestCrossAt709()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual0, 9);
            CollectionAssert.AreEqual(IndividualsResults.result709, result);
        }

        [TestMethod]
        public void TestCrossAt710()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual1, 0);
            CollectionAssert.AreEqual(IndividualsResults.result710, result);
        }

        [TestMethod]
        public void TestCrossAt711()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual1, 1);
            CollectionAssert.AreEqual(IndividualsResults.result711, result);
        }

        [TestMethod]
        public void TestCrossAt712()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual1, 2);
            CollectionAssert.AreEqual(IndividualsResults.result712, result);
        }

        [TestMethod]
        public void TestCrossAt713()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual1, 3);
            CollectionAssert.AreEqual(IndividualsResults.result713, result);
        }

        [TestMethod]
        public void TestCrossAt714()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual1, 4);
            CollectionAssert.AreEqual(IndividualsResults.result714, result);
        }

        [TestMethod]
        public void TestCrossAt715()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual1, 5);
            CollectionAssert.AreEqual(IndividualsResults.result715, result);
        }

        [TestMethod]
        public void TestCrossAt716()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual1, 6);
            CollectionAssert.AreEqual(IndividualsResults.result716, result);
        }

        [TestMethod]
        public void TestCrossAt717()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual1, 7);
            CollectionAssert.AreEqual(IndividualsResults.result717, result);
        }

        [TestMethod]
        public void TestCrossAt718()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual1, 8);
            CollectionAssert.AreEqual(IndividualsResults.result718, result);
        }

        [TestMethod]
        public void TestCrossAt719()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual1, 9);
            CollectionAssert.AreEqual(IndividualsResults.result719, result);
        }

        [TestMethod]
        public void TestCrossAt720()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual2, 0);
            CollectionAssert.AreEqual(IndividualsResults.result720, result);
        }

        [TestMethod]
        public void TestCrossAt721()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual2, 1);
            CollectionAssert.AreEqual(IndividualsResults.result721, result);
        }

        [TestMethod]
        public void TestCrossAt722()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual2, 2);
            CollectionAssert.AreEqual(IndividualsResults.result722, result);
        }

        [TestMethod]
        public void TestCrossAt723()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual2, 3);
            CollectionAssert.AreEqual(IndividualsResults.result723, result);
        }

        [TestMethod]
        public void TestCrossAt724()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual2, 4);
            CollectionAssert.AreEqual(IndividualsResults.result724, result);
        }

        [TestMethod]
        public void TestCrossAt725()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual2, 5);
            CollectionAssert.AreEqual(IndividualsResults.result725, result);
        }

        [TestMethod]
        public void TestCrossAt726()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual2, 6);
            CollectionAssert.AreEqual(IndividualsResults.result726, result);
        }

        [TestMethod]
        public void TestCrossAt727()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual2, 7);
            CollectionAssert.AreEqual(IndividualsResults.result727, result);
        }

        [TestMethod]
        public void TestCrossAt728()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual2, 8);
            CollectionAssert.AreEqual(IndividualsResults.result728, result);
        }

        [TestMethod]
        public void TestCrossAt729()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual2, 9);
            CollectionAssert.AreEqual(IndividualsResults.result729, result);
        }

        [TestMethod]
        public void TestCrossAt730()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual3, 0);
            CollectionAssert.AreEqual(IndividualsResults.result730, result);
        }

        [TestMethod]
        public void TestCrossAt731()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual3, 1);
            CollectionAssert.AreEqual(IndividualsResults.result731, result);
        }

        [TestMethod]
        public void TestCrossAt732()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual3, 2);
            CollectionAssert.AreEqual(IndividualsResults.result732, result);
        }

        [TestMethod]
        public void TestCrossAt733()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual3, 3);
            CollectionAssert.AreEqual(IndividualsResults.result733, result);
        }

        [TestMethod]
        public void TestCrossAt734()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual3, 4);
            CollectionAssert.AreEqual(IndividualsResults.result734, result);
        }

        [TestMethod]
        public void TestCrossAt735()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual3, 5);
            CollectionAssert.AreEqual(IndividualsResults.result735, result);
        }

        [TestMethod]
        public void TestCrossAt736()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual3, 6);
            CollectionAssert.AreEqual(IndividualsResults.result736, result);
        }

        [TestMethod]
        public void TestCrossAt737()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual3, 7);
            CollectionAssert.AreEqual(IndividualsResults.result737, result);
        }

        [TestMethod]
        public void TestCrossAt738()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual3, 8);
            CollectionAssert.AreEqual(IndividualsResults.result738, result);
        }

        [TestMethod]
        public void TestCrossAt739()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual3, 9);
            CollectionAssert.AreEqual(IndividualsResults.result739, result);
        }

        [TestMethod]
        public void TestCrossAt740()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual4, 0);
            CollectionAssert.AreEqual(IndividualsResults.result740, result);
        }

        [TestMethod]
        public void TestCrossAt741()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual4, 1);
            CollectionAssert.AreEqual(IndividualsResults.result741, result);
        }

        [TestMethod]
        public void TestCrossAt742()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual4, 2);
            CollectionAssert.AreEqual(IndividualsResults.result742, result);
        }

        [TestMethod]
        public void TestCrossAt743()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual4, 3);
            CollectionAssert.AreEqual(IndividualsResults.result743, result);
        }

        [TestMethod]
        public void TestCrossAt744()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual4, 4);
            CollectionAssert.AreEqual(IndividualsResults.result744, result);
        }

        [TestMethod]
        public void TestCrossAt745()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual4, 5);
            CollectionAssert.AreEqual(IndividualsResults.result745, result);
        }

        [TestMethod]
        public void TestCrossAt746()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual4, 6);
            CollectionAssert.AreEqual(IndividualsResults.result746, result);
        }

        [TestMethod]
        public void TestCrossAt747()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual4, 7);
            CollectionAssert.AreEqual(IndividualsResults.result747, result);
        }

        [TestMethod]
        public void TestCrossAt748()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual4, 8);
            CollectionAssert.AreEqual(IndividualsResults.result748, result);
        }

        [TestMethod]
        public void TestCrossAt749()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual4, 9);
            CollectionAssert.AreEqual(IndividualsResults.result749, result);
        }

        [TestMethod]
        public void TestCrossAt750()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual5, 0);
            CollectionAssert.AreEqual(IndividualsResults.result750, result);
        }

        [TestMethod]
        public void TestCrossAt751()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual5, 1);
            CollectionAssert.AreEqual(IndividualsResults.result751, result);
        }

        [TestMethod]
        public void TestCrossAt752()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual5, 2);
            CollectionAssert.AreEqual(IndividualsResults.result752, result);
        }

        [TestMethod]
        public void TestCrossAt753()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual5, 3);
            CollectionAssert.AreEqual(IndividualsResults.result753, result);
        }

        [TestMethod]
        public void TestCrossAt754()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual5, 4);
            CollectionAssert.AreEqual(IndividualsResults.result754, result);
        }

        [TestMethod]
        public void TestCrossAt755()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual5, 5);
            CollectionAssert.AreEqual(IndividualsResults.result755, result);
        }

        [TestMethod]
        public void TestCrossAt756()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual5, 6);
            CollectionAssert.AreEqual(IndividualsResults.result756, result);
        }

        [TestMethod]
        public void TestCrossAt757()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual5, 7);
            CollectionAssert.AreEqual(IndividualsResults.result757, result);
        }

        [TestMethod]
        public void TestCrossAt758()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual5, 8);
            CollectionAssert.AreEqual(IndividualsResults.result758, result);
        }

        [TestMethod]
        public void TestCrossAt759()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual5, 9);
            CollectionAssert.AreEqual(IndividualsResults.result759, result);
        }

        [TestMethod]
        public void TestCrossAt760()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual6, 0);
            CollectionAssert.AreEqual(IndividualsResults.result760, result);
        }

        [TestMethod]
        public void TestCrossAt761()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual6, 1);
            CollectionAssert.AreEqual(IndividualsResults.result761, result);
        }

        [TestMethod]
        public void TestCrossAt762()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual6, 2);
            CollectionAssert.AreEqual(IndividualsResults.result762, result);
        }

        [TestMethod]
        public void TestCrossAt763()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual6, 3);
            CollectionAssert.AreEqual(IndividualsResults.result763, result);
        }

        [TestMethod]
        public void TestCrossAt764()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual6, 4);
            CollectionAssert.AreEqual(IndividualsResults.result764, result);
        }

        [TestMethod]
        public void TestCrossAt765()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual6, 5);
            CollectionAssert.AreEqual(IndividualsResults.result765, result);
        }

        [TestMethod]
        public void TestCrossAt766()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual6, 6);
            CollectionAssert.AreEqual(IndividualsResults.result766, result);
        }

        [TestMethod]
        public void TestCrossAt767()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual6, 7);
            CollectionAssert.AreEqual(IndividualsResults.result767, result);
        }

        [TestMethod]
        public void TestCrossAt768()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual6, 8);
            CollectionAssert.AreEqual(IndividualsResults.result768, result);
        }

        [TestMethod]
        public void TestCrossAt769()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual6, 9);
            CollectionAssert.AreEqual(IndividualsResults.result769, result);
        }

        [TestMethod]
        public void TestCrossAt770()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual7, 0);
            CollectionAssert.AreEqual(IndividualsResults.result770, result);
        }

        [TestMethod]
        public void TestCrossAt771()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual7, 1);
            CollectionAssert.AreEqual(IndividualsResults.result771, result);
        }

        [TestMethod]
        public void TestCrossAt772()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual7, 2);
            CollectionAssert.AreEqual(IndividualsResults.result772, result);
        }

        [TestMethod]
        public void TestCrossAt773()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual7, 3);
            CollectionAssert.AreEqual(IndividualsResults.result773, result);
        }

        [TestMethod]
        public void TestCrossAt774()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual7, 4);
            CollectionAssert.AreEqual(IndividualsResults.result774, result);
        }

        [TestMethod]
        public void TestCrossAt775()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual7, 5);
            CollectionAssert.AreEqual(IndividualsResults.result775, result);
        }

        [TestMethod]
        public void TestCrossAt776()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual7, 6);
            CollectionAssert.AreEqual(IndividualsResults.result776, result);
        }

        [TestMethod]
        public void TestCrossAt777()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual7, 7);
            CollectionAssert.AreEqual(IndividualsResults.result777, result);
        }

        [TestMethod]
        public void TestCrossAt778()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual7, 8);
            CollectionAssert.AreEqual(IndividualsResults.result778, result);
        }

        [TestMethod]
        public void TestCrossAt779()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual7, 9);
            CollectionAssert.AreEqual(IndividualsResults.result779, result);
        }

        [TestMethod]
        public void TestCrossAt780()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual8, 0);
            CollectionAssert.AreEqual(IndividualsResults.result780, result);
        }

        [TestMethod]
        public void TestCrossAt781()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual8, 1);
            CollectionAssert.AreEqual(IndividualsResults.result781, result);
        }

        [TestMethod]
        public void TestCrossAt782()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual8, 2);
            CollectionAssert.AreEqual(IndividualsResults.result782, result);
        }

        [TestMethod]
        public void TestCrossAt783()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual8, 3);
            CollectionAssert.AreEqual(IndividualsResults.result783, result);
        }

        [TestMethod]
        public void TestCrossAt784()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual8, 4);
            CollectionAssert.AreEqual(IndividualsResults.result784, result);
        }

        [TestMethod]
        public void TestCrossAt785()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual8, 5);
            CollectionAssert.AreEqual(IndividualsResults.result785, result);
        }

        [TestMethod]
        public void TestCrossAt786()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual8, 6);
            CollectionAssert.AreEqual(IndividualsResults.result786, result);
        }

        [TestMethod]
        public void TestCrossAt787()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual8, 7);
            CollectionAssert.AreEqual(IndividualsResults.result787, result);
        }

        [TestMethod]
        public void TestCrossAt788()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual8, 8);
            CollectionAssert.AreEqual(IndividualsResults.result788, result);
        }

        [TestMethod]
        public void TestCrossAt789()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual8, 9);
            CollectionAssert.AreEqual(IndividualsResults.result789, result);
        }

        [TestMethod]
        public void TestCrossAt790()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual9, 0);
            CollectionAssert.AreEqual(IndividualsResults.result790, result);
        }

        [TestMethod]
        public void TestCrossAt791()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual9, 1);
            CollectionAssert.AreEqual(IndividualsResults.result791, result);
        }

        [TestMethod]
        public void TestCrossAt792()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual9, 2);
            CollectionAssert.AreEqual(IndividualsResults.result792, result);
        }

        [TestMethod]
        public void TestCrossAt793()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual9, 3);
            CollectionAssert.AreEqual(IndividualsResults.result793, result);
        }

        [TestMethod]
        public void TestCrossAt794()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual9, 4);
            CollectionAssert.AreEqual(IndividualsResults.result794, result);
        }

        [TestMethod]
        public void TestCrossAt795()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual9, 5);
            CollectionAssert.AreEqual(IndividualsResults.result795, result);
        }

        [TestMethod]
        public void TestCrossAt796()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual9, 6);
            CollectionAssert.AreEqual(IndividualsResults.result796, result);
        }

        [TestMethod]
        public void TestCrossAt797()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual9, 7);
            CollectionAssert.AreEqual(IndividualsResults.result797, result);
        }

        [TestMethod]
        public void TestCrossAt798()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual9, 8);
            CollectionAssert.AreEqual(IndividualsResults.result798, result);
        }

        [TestMethod]
        public void TestCrossAt799()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual7, TestIndividuals.individual9, 9);
            CollectionAssert.AreEqual(IndividualsResults.result799, result);
        }

        [TestMethod]
        public void TestCrossAt800()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual0, 0);
            CollectionAssert.AreEqual(IndividualsResults.result800, result);
        }

        [TestMethod]
        public void TestCrossAt801()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual0, 1);
            CollectionAssert.AreEqual(IndividualsResults.result801, result);
        }

        [TestMethod]
        public void TestCrossAt802()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual0, 2);
            CollectionAssert.AreEqual(IndividualsResults.result802, result);
        }

        [TestMethod]
        public void TestCrossAt803()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual0, 3);
            CollectionAssert.AreEqual(IndividualsResults.result803, result);
        }

        [TestMethod]
        public void TestCrossAt804()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual0, 4);
            CollectionAssert.AreEqual(IndividualsResults.result804, result);
        }

        [TestMethod]
        public void TestCrossAt805()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual0, 5);
            CollectionAssert.AreEqual(IndividualsResults.result805, result);
        }

        [TestMethod]
        public void TestCrossAt806()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual0, 6);
            CollectionAssert.AreEqual(IndividualsResults.result806, result);
        }

        [TestMethod]
        public void TestCrossAt807()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual0, 7);
            CollectionAssert.AreEqual(IndividualsResults.result807, result);
        }

        [TestMethod]
        public void TestCrossAt808()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual0, 8);
            CollectionAssert.AreEqual(IndividualsResults.result808, result);
        }

        [TestMethod]
        public void TestCrossAt809()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual0, 9);
            CollectionAssert.AreEqual(IndividualsResults.result809, result);
        }

        [TestMethod]
        public void TestCrossAt810()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual1, 0);
            CollectionAssert.AreEqual(IndividualsResults.result810, result);
        }

        [TestMethod]
        public void TestCrossAt811()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual1, 1);
            CollectionAssert.AreEqual(IndividualsResults.result811, result);
        }

        [TestMethod]
        public void TestCrossAt812()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual1, 2);
            CollectionAssert.AreEqual(IndividualsResults.result812, result);
        }

        [TestMethod]
        public void TestCrossAt813()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual1, 3);
            CollectionAssert.AreEqual(IndividualsResults.result813, result);
        }

        [TestMethod]
        public void TestCrossAt814()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual1, 4);
            CollectionAssert.AreEqual(IndividualsResults.result814, result);
        }

        [TestMethod]
        public void TestCrossAt815()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual1, 5);
            CollectionAssert.AreEqual(IndividualsResults.result815, result);
        }

        [TestMethod]
        public void TestCrossAt816()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual1, 6);
            CollectionAssert.AreEqual(IndividualsResults.result816, result);
        }

        [TestMethod]
        public void TestCrossAt817()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual1, 7);
            CollectionAssert.AreEqual(IndividualsResults.result817, result);
        }

        [TestMethod]
        public void TestCrossAt818()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual1, 8);
            CollectionAssert.AreEqual(IndividualsResults.result818, result);
        }

        [TestMethod]
        public void TestCrossAt819()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual1, 9);
            CollectionAssert.AreEqual(IndividualsResults.result819, result);
        }

        [TestMethod]
        public void TestCrossAt820()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual2, 0);
            CollectionAssert.AreEqual(IndividualsResults.result820, result);
        }

        [TestMethod]
        public void TestCrossAt821()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual2, 1);
            CollectionAssert.AreEqual(IndividualsResults.result821, result);
        }

        [TestMethod]
        public void TestCrossAt822()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual2, 2);
            CollectionAssert.AreEqual(IndividualsResults.result822, result);
        }

        [TestMethod]
        public void TestCrossAt823()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual2, 3);
            CollectionAssert.AreEqual(IndividualsResults.result823, result);
        }

        [TestMethod]
        public void TestCrossAt824()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual2, 4);
            CollectionAssert.AreEqual(IndividualsResults.result824, result);
        }

        [TestMethod]
        public void TestCrossAt825()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual2, 5);
            CollectionAssert.AreEqual(IndividualsResults.result825, result);
        }

        [TestMethod]
        public void TestCrossAt826()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual2, 6);
            CollectionAssert.AreEqual(IndividualsResults.result826, result);
        }

        [TestMethod]
        public void TestCrossAt827()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual2, 7);
            CollectionAssert.AreEqual(IndividualsResults.result827, result);
        }

        [TestMethod]
        public void TestCrossAt828()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual2, 8);
            CollectionAssert.AreEqual(IndividualsResults.result828, result);
        }

        [TestMethod]
        public void TestCrossAt829()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual2, 9);
            CollectionAssert.AreEqual(IndividualsResults.result829, result);
        }

        [TestMethod]
        public void TestCrossAt830()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual3, 0);
            CollectionAssert.AreEqual(IndividualsResults.result830, result);
        }

        [TestMethod]
        public void TestCrossAt831()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual3, 1);
            CollectionAssert.AreEqual(IndividualsResults.result831, result);
        }

        [TestMethod]
        public void TestCrossAt832()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual3, 2);
            CollectionAssert.AreEqual(IndividualsResults.result832, result);
        }

        [TestMethod]
        public void TestCrossAt833()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual3, 3);
            CollectionAssert.AreEqual(IndividualsResults.result833, result);
        }

        [TestMethod]
        public void TestCrossAt834()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual3, 4);
            CollectionAssert.AreEqual(IndividualsResults.result834, result);
        }

        [TestMethod]
        public void TestCrossAt835()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual3, 5);
            CollectionAssert.AreEqual(IndividualsResults.result835, result);
        }

        [TestMethod]
        public void TestCrossAt836()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual3, 6);
            CollectionAssert.AreEqual(IndividualsResults.result836, result);
        }

        [TestMethod]
        public void TestCrossAt837()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual3, 7);
            CollectionAssert.AreEqual(IndividualsResults.result837, result);
        }

        [TestMethod]
        public void TestCrossAt838()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual3, 8);
            CollectionAssert.AreEqual(IndividualsResults.result838, result);
        }

        [TestMethod]
        public void TestCrossAt839()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual3, 9);
            CollectionAssert.AreEqual(IndividualsResults.result839, result);
        }

        [TestMethod]
        public void TestCrossAt840()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual4, 0);
            CollectionAssert.AreEqual(IndividualsResults.result840, result);
        }

        [TestMethod]
        public void TestCrossAt841()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual4, 1);
            CollectionAssert.AreEqual(IndividualsResults.result841, result);
        }

        [TestMethod]
        public void TestCrossAt842()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual4, 2);
            CollectionAssert.AreEqual(IndividualsResults.result842, result);
        }

        [TestMethod]
        public void TestCrossAt843()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual4, 3);
            CollectionAssert.AreEqual(IndividualsResults.result843, result);
        }

        [TestMethod]
        public void TestCrossAt844()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual4, 4);
            CollectionAssert.AreEqual(IndividualsResults.result844, result);
        }

        [TestMethod]
        public void TestCrossAt845()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual4, 5);
            CollectionAssert.AreEqual(IndividualsResults.result845, result);
        }

        [TestMethod]
        public void TestCrossAt846()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual4, 6);
            CollectionAssert.AreEqual(IndividualsResults.result846, result);
        }

        [TestMethod]
        public void TestCrossAt847()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual4, 7);
            CollectionAssert.AreEqual(IndividualsResults.result847, result);
        }

        [TestMethod]
        public void TestCrossAt848()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual4, 8);
            CollectionAssert.AreEqual(IndividualsResults.result848, result);
        }

        [TestMethod]
        public void TestCrossAt849()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual4, 9);
            CollectionAssert.AreEqual(IndividualsResults.result849, result);
        }

        [TestMethod]
        public void TestCrossAt850()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual5, 0);
            CollectionAssert.AreEqual(IndividualsResults.result850, result);
        }

        [TestMethod]
        public void TestCrossAt851()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual5, 1);
            CollectionAssert.AreEqual(IndividualsResults.result851, result);
        }

        [TestMethod]
        public void TestCrossAt852()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual5, 2);
            CollectionAssert.AreEqual(IndividualsResults.result852, result);
        }

        [TestMethod]
        public void TestCrossAt853()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual5, 3);
            CollectionAssert.AreEqual(IndividualsResults.result853, result);
        }

        [TestMethod]
        public void TestCrossAt854()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual5, 4);
            CollectionAssert.AreEqual(IndividualsResults.result854, result);
        }

        [TestMethod]
        public void TestCrossAt855()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual5, 5);
            CollectionAssert.AreEqual(IndividualsResults.result855, result);
        }

        [TestMethod]
        public void TestCrossAt856()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual5, 6);
            CollectionAssert.AreEqual(IndividualsResults.result856, result);
        }

        [TestMethod]
        public void TestCrossAt857()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual5, 7);
            CollectionAssert.AreEqual(IndividualsResults.result857, result);
        }

        [TestMethod]
        public void TestCrossAt858()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual5, 8);
            CollectionAssert.AreEqual(IndividualsResults.result858, result);
        }

        [TestMethod]
        public void TestCrossAt859()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual5, 9);
            CollectionAssert.AreEqual(IndividualsResults.result859, result);
        }

        [TestMethod]
        public void TestCrossAt860()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual6, 0);
            CollectionAssert.AreEqual(IndividualsResults.result860, result);
        }

        [TestMethod]
        public void TestCrossAt861()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual6, 1);
            CollectionAssert.AreEqual(IndividualsResults.result861, result);
        }

        [TestMethod]
        public void TestCrossAt862()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual6, 2);
            CollectionAssert.AreEqual(IndividualsResults.result862, result);
        }

        [TestMethod]
        public void TestCrossAt863()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual6, 3);
            CollectionAssert.AreEqual(IndividualsResults.result863, result);
        }

        [TestMethod]
        public void TestCrossAt864()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual6, 4);
            CollectionAssert.AreEqual(IndividualsResults.result864, result);
        }

        [TestMethod]
        public void TestCrossAt865()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual6, 5);
            CollectionAssert.AreEqual(IndividualsResults.result865, result);
        }

        [TestMethod]
        public void TestCrossAt866()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual6, 6);
            CollectionAssert.AreEqual(IndividualsResults.result866, result);
        }

        [TestMethod]
        public void TestCrossAt867()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual6, 7);
            CollectionAssert.AreEqual(IndividualsResults.result867, result);
        }

        [TestMethod]
        public void TestCrossAt868()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual6, 8);
            CollectionAssert.AreEqual(IndividualsResults.result868, result);
        }

        [TestMethod]
        public void TestCrossAt869()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual6, 9);
            CollectionAssert.AreEqual(IndividualsResults.result869, result);
        }

        [TestMethod]
        public void TestCrossAt870()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual7, 0);
            CollectionAssert.AreEqual(IndividualsResults.result870, result);
        }

        [TestMethod]
        public void TestCrossAt871()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual7, 1);
            CollectionAssert.AreEqual(IndividualsResults.result871, result);
        }

        [TestMethod]
        public void TestCrossAt872()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual7, 2);
            CollectionAssert.AreEqual(IndividualsResults.result872, result);
        }

        [TestMethod]
        public void TestCrossAt873()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual7, 3);
            CollectionAssert.AreEqual(IndividualsResults.result873, result);
        }

        [TestMethod]
        public void TestCrossAt874()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual7, 4);
            CollectionAssert.AreEqual(IndividualsResults.result874, result);
        }

        [TestMethod]
        public void TestCrossAt875()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual7, 5);
            CollectionAssert.AreEqual(IndividualsResults.result875, result);
        }

        [TestMethod]
        public void TestCrossAt876()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual7, 6);
            CollectionAssert.AreEqual(IndividualsResults.result876, result);
        }

        [TestMethod]
        public void TestCrossAt877()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual7, 7);
            CollectionAssert.AreEqual(IndividualsResults.result877, result);
        }

        [TestMethod]
        public void TestCrossAt878()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual7, 8);
            CollectionAssert.AreEqual(IndividualsResults.result878, result);
        }

        [TestMethod]
        public void TestCrossAt879()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual7, 9);
            CollectionAssert.AreEqual(IndividualsResults.result879, result);
        }

        [TestMethod]
        public void TestCrossAt880()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual8, 0);
            CollectionAssert.AreEqual(IndividualsResults.result880, result);
        }

        [TestMethod]
        public void TestCrossAt881()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual8, 1);
            CollectionAssert.AreEqual(IndividualsResults.result881, result);
        }

        [TestMethod]
        public void TestCrossAt882()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual8, 2);
            CollectionAssert.AreEqual(IndividualsResults.result882, result);
        }

        [TestMethod]
        public void TestCrossAt883()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual8, 3);
            CollectionAssert.AreEqual(IndividualsResults.result883, result);
        }

        [TestMethod]
        public void TestCrossAt884()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual8, 4);
            CollectionAssert.AreEqual(IndividualsResults.result884, result);
        }

        [TestMethod]
        public void TestCrossAt885()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual8, 5);
            CollectionAssert.AreEqual(IndividualsResults.result885, result);
        }

        [TestMethod]
        public void TestCrossAt886()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual8, 6);
            CollectionAssert.AreEqual(IndividualsResults.result886, result);
        }

        [TestMethod]
        public void TestCrossAt887()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual8, 7);
            CollectionAssert.AreEqual(IndividualsResults.result887, result);
        }

        [TestMethod]
        public void TestCrossAt888()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual8, 8);
            CollectionAssert.AreEqual(IndividualsResults.result888, result);
        }

        [TestMethod]
        public void TestCrossAt889()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual8, 9);
            CollectionAssert.AreEqual(IndividualsResults.result889, result);
        }

        [TestMethod]
        public void TestCrossAt890()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual9, 0);
            CollectionAssert.AreEqual(IndividualsResults.result890, result);
        }

        [TestMethod]
        public void TestCrossAt891()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual9, 1);
            CollectionAssert.AreEqual(IndividualsResults.result891, result);
        }

        [TestMethod]
        public void TestCrossAt892()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual9, 2);
            CollectionAssert.AreEqual(IndividualsResults.result892, result);
        }

        [TestMethod]
        public void TestCrossAt893()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual9, 3);
            CollectionAssert.AreEqual(IndividualsResults.result893, result);
        }

        [TestMethod]
        public void TestCrossAt894()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual9, 4);
            CollectionAssert.AreEqual(IndividualsResults.result894, result);
        }

        [TestMethod]
        public void TestCrossAt895()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual9, 5);
            CollectionAssert.AreEqual(IndividualsResults.result895, result);
        }

        [TestMethod]
        public void TestCrossAt896()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual9, 6);
            CollectionAssert.AreEqual(IndividualsResults.result896, result);
        }

        [TestMethod]
        public void TestCrossAt897()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual9, 7);
            CollectionAssert.AreEqual(IndividualsResults.result897, result);
        }

        [TestMethod]
        public void TestCrossAt898()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual9, 8);
            CollectionAssert.AreEqual(IndividualsResults.result898, result);
        }

        [TestMethod]
        public void TestCrossAt899()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual8, TestIndividuals.individual9, 9);
            CollectionAssert.AreEqual(IndividualsResults.result899, result);
        }

        [TestMethod]
        public void TestCrossAt900()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual0, 0);
            CollectionAssert.AreEqual(IndividualsResults.result900, result);
        }

        [TestMethod]
        public void TestCrossAt901()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual0, 1);
            CollectionAssert.AreEqual(IndividualsResults.result901, result);
        }

        [TestMethod]
        public void TestCrossAt902()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual0, 2);
            CollectionAssert.AreEqual(IndividualsResults.result902, result);
        }

        [TestMethod]
        public void TestCrossAt903()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual0, 3);
            CollectionAssert.AreEqual(IndividualsResults.result903, result);
        }

        [TestMethod]
        public void TestCrossAt904()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual0, 4);
            CollectionAssert.AreEqual(IndividualsResults.result904, result);
        }

        [TestMethod]
        public void TestCrossAt905()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual0, 5);
            CollectionAssert.AreEqual(IndividualsResults.result905, result);
        }

        [TestMethod]
        public void TestCrossAt906()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual0, 6);
            CollectionAssert.AreEqual(IndividualsResults.result906, result);
        }

        [TestMethod]
        public void TestCrossAt907()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual0, 7);
            CollectionAssert.AreEqual(IndividualsResults.result907, result);
        }

        [TestMethod]
        public void TestCrossAt908()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual0, 8);
            CollectionAssert.AreEqual(IndividualsResults.result908, result);
        }

        [TestMethod]
        public void TestCrossAt909()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual0, 9);
            CollectionAssert.AreEqual(IndividualsResults.result909, result);
        }

        [TestMethod]
        public void TestCrossAt910()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual1, 0);
            CollectionAssert.AreEqual(IndividualsResults.result910, result);
        }

        [TestMethod]
        public void TestCrossAt911()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual1, 1);
            CollectionAssert.AreEqual(IndividualsResults.result911, result);
        }

        [TestMethod]
        public void TestCrossAt912()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual1, 2);
            CollectionAssert.AreEqual(IndividualsResults.result912, result);
        }

        [TestMethod]
        public void TestCrossAt913()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual1, 3);
            CollectionAssert.AreEqual(IndividualsResults.result913, result);
        }

        [TestMethod]
        public void TestCrossAt914()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual1, 4);
            CollectionAssert.AreEqual(IndividualsResults.result914, result);
        }

        [TestMethod]
        public void TestCrossAt915()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual1, 5);
            CollectionAssert.AreEqual(IndividualsResults.result915, result);
        }

        [TestMethod]
        public void TestCrossAt916()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual1, 6);
            CollectionAssert.AreEqual(IndividualsResults.result916, result);
        }

        [TestMethod]
        public void TestCrossAt917()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual1, 7);
            CollectionAssert.AreEqual(IndividualsResults.result917, result);
        }

        [TestMethod]
        public void TestCrossAt918()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual1, 8);
            CollectionAssert.AreEqual(IndividualsResults.result918, result);
        }

        [TestMethod]
        public void TestCrossAt919()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual1, 9);
            CollectionAssert.AreEqual(IndividualsResults.result919, result);
        }

        [TestMethod]
        public void TestCrossAt920()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual2, 0);
            CollectionAssert.AreEqual(IndividualsResults.result920, result);
        }

        [TestMethod]
        public void TestCrossAt921()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual2, 1);
            CollectionAssert.AreEqual(IndividualsResults.result921, result);
        }

        [TestMethod]
        public void TestCrossAt922()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual2, 2);
            CollectionAssert.AreEqual(IndividualsResults.result922, result);
        }

        [TestMethod]
        public void TestCrossAt923()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual2, 3);
            CollectionAssert.AreEqual(IndividualsResults.result923, result);
        }

        [TestMethod]
        public void TestCrossAt924()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual2, 4);
            CollectionAssert.AreEqual(IndividualsResults.result924, result);
        }

        [TestMethod]
        public void TestCrossAt925()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual2, 5);
            CollectionAssert.AreEqual(IndividualsResults.result925, result);
        }

        [TestMethod]
        public void TestCrossAt926()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual2, 6);
            CollectionAssert.AreEqual(IndividualsResults.result926, result);
        }

        [TestMethod]
        public void TestCrossAt927()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual2, 7);
            CollectionAssert.AreEqual(IndividualsResults.result927, result);
        }

        [TestMethod]
        public void TestCrossAt928()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual2, 8);
            CollectionAssert.AreEqual(IndividualsResults.result928, result);
        }

        [TestMethod]
        public void TestCrossAt929()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual2, 9);
            CollectionAssert.AreEqual(IndividualsResults.result929, result);
        }

        [TestMethod]
        public void TestCrossAt930()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual3, 0);
            CollectionAssert.AreEqual(IndividualsResults.result930, result);
        }

        [TestMethod]
        public void TestCrossAt931()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual3, 1);
            CollectionAssert.AreEqual(IndividualsResults.result931, result);
        }

        [TestMethod]
        public void TestCrossAt932()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual3, 2);
            CollectionAssert.AreEqual(IndividualsResults.result932, result);
        }

        [TestMethod]
        public void TestCrossAt933()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual3, 3);
            CollectionAssert.AreEqual(IndividualsResults.result933, result);
        }

        [TestMethod]
        public void TestCrossAt934()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual3, 4);
            CollectionAssert.AreEqual(IndividualsResults.result934, result);
        }

        [TestMethod]
        public void TestCrossAt935()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual3, 5);
            CollectionAssert.AreEqual(IndividualsResults.result935, result);
        }

        [TestMethod]
        public void TestCrossAt936()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual3, 6);
            CollectionAssert.AreEqual(IndividualsResults.result936, result);
        }

        [TestMethod]
        public void TestCrossAt937()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual3, 7);
            CollectionAssert.AreEqual(IndividualsResults.result937, result);
        }

        [TestMethod]
        public void TestCrossAt938()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual3, 8);
            CollectionAssert.AreEqual(IndividualsResults.result938, result);
        }

        [TestMethod]
        public void TestCrossAt939()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual3, 9);
            CollectionAssert.AreEqual(IndividualsResults.result939, result);
        }

        [TestMethod]
        public void TestCrossAt940()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual4, 0);
            CollectionAssert.AreEqual(IndividualsResults.result940, result);
        }

        [TestMethod]
        public void TestCrossAt941()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual4, 1);
            CollectionAssert.AreEqual(IndividualsResults.result941, result);
        }

        [TestMethod]
        public void TestCrossAt942()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual4, 2);
            CollectionAssert.AreEqual(IndividualsResults.result942, result);
        }

        [TestMethod]
        public void TestCrossAt943()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual4, 3);
            CollectionAssert.AreEqual(IndividualsResults.result943, result);
        }

        [TestMethod]
        public void TestCrossAt944()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual4, 4);
            CollectionAssert.AreEqual(IndividualsResults.result944, result);
        }

        [TestMethod]
        public void TestCrossAt945()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual4, 5);
            CollectionAssert.AreEqual(IndividualsResults.result945, result);
        }

        [TestMethod]
        public void TestCrossAt946()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual4, 6);
            CollectionAssert.AreEqual(IndividualsResults.result946, result);
        }

        [TestMethod]
        public void TestCrossAt947()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual4, 7);
            CollectionAssert.AreEqual(IndividualsResults.result947, result);
        }

        [TestMethod]
        public void TestCrossAt948()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual4, 8);
            CollectionAssert.AreEqual(IndividualsResults.result948, result);
        }

        [TestMethod]
        public void TestCrossAt949()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual4, 9);
            CollectionAssert.AreEqual(IndividualsResults.result949, result);
        }

        [TestMethod]
        public void TestCrossAt950()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual5, 0);
            CollectionAssert.AreEqual(IndividualsResults.result950, result);
        }

        [TestMethod]
        public void TestCrossAt951()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual5, 1);
            CollectionAssert.AreEqual(IndividualsResults.result951, result);
        }

        [TestMethod]
        public void TestCrossAt952()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual5, 2);
            CollectionAssert.AreEqual(IndividualsResults.result952, result);
        }

        [TestMethod]
        public void TestCrossAt953()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual5, 3);
            CollectionAssert.AreEqual(IndividualsResults.result953, result);
        }

        [TestMethod]
        public void TestCrossAt954()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual5, 4);
            CollectionAssert.AreEqual(IndividualsResults.result954, result);
        }

        [TestMethod]
        public void TestCrossAt955()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual5, 5);
            CollectionAssert.AreEqual(IndividualsResults.result955, result);
        }

        [TestMethod]
        public void TestCrossAt956()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual5, 6);
            CollectionAssert.AreEqual(IndividualsResults.result956, result);
        }

        [TestMethod]
        public void TestCrossAt957()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual5, 7);
            CollectionAssert.AreEqual(IndividualsResults.result957, result);
        }

        [TestMethod]
        public void TestCrossAt958()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual5, 8);
            CollectionAssert.AreEqual(IndividualsResults.result958, result);
        }

        [TestMethod]
        public void TestCrossAt959()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual5, 9);
            CollectionAssert.AreEqual(IndividualsResults.result959, result);
        }

        [TestMethod]
        public void TestCrossAt960()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual6, 0);
            CollectionAssert.AreEqual(IndividualsResults.result960, result);
        }

        [TestMethod]
        public void TestCrossAt961()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual6, 1);
            CollectionAssert.AreEqual(IndividualsResults.result961, result);
        }

        [TestMethod]
        public void TestCrossAt962()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual6, 2);
            CollectionAssert.AreEqual(IndividualsResults.result962, result);
        }

        [TestMethod]
        public void TestCrossAt963()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual6, 3);
            CollectionAssert.AreEqual(IndividualsResults.result963, result);
        }

        [TestMethod]
        public void TestCrossAt964()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual6, 4);
            CollectionAssert.AreEqual(IndividualsResults.result964, result);
        }

        [TestMethod]
        public void TestCrossAt965()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual6, 5);
            CollectionAssert.AreEqual(IndividualsResults.result965, result);
        }

        [TestMethod]
        public void TestCrossAt966()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual6, 6);
            CollectionAssert.AreEqual(IndividualsResults.result966, result);
        }

        [TestMethod]
        public void TestCrossAt967()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual6, 7);
            CollectionAssert.AreEqual(IndividualsResults.result967, result);
        }

        [TestMethod]
        public void TestCrossAt968()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual6, 8);
            CollectionAssert.AreEqual(IndividualsResults.result968, result);
        }

        [TestMethod]
        public void TestCrossAt969()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual6, 9);
            CollectionAssert.AreEqual(IndividualsResults.result969, result);
        }

        [TestMethod]
        public void TestCrossAt970()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual7, 0);
            CollectionAssert.AreEqual(IndividualsResults.result970, result);
        }

        [TestMethod]
        public void TestCrossAt971()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual7, 1);
            CollectionAssert.AreEqual(IndividualsResults.result971, result);
        }

        [TestMethod]
        public void TestCrossAt972()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual7, 2);
            CollectionAssert.AreEqual(IndividualsResults.result972, result);
        }

        [TestMethod]
        public void TestCrossAt973()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual7, 3);
            CollectionAssert.AreEqual(IndividualsResults.result973, result);
        }

        [TestMethod]
        public void TestCrossAt974()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual7, 4);
            CollectionAssert.AreEqual(IndividualsResults.result974, result);
        }

        [TestMethod]
        public void TestCrossAt975()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual7, 5);
            CollectionAssert.AreEqual(IndividualsResults.result975, result);
        }

        [TestMethod]
        public void TestCrossAt976()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual7, 6);
            CollectionAssert.AreEqual(IndividualsResults.result976, result);
        }

        [TestMethod]
        public void TestCrossAt977()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual7, 7);
            CollectionAssert.AreEqual(IndividualsResults.result977, result);
        }

        [TestMethod]
        public void TestCrossAt978()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual7, 8);
            CollectionAssert.AreEqual(IndividualsResults.result978, result);
        }

        [TestMethod]
        public void TestCrossAt979()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual7, 9);
            CollectionAssert.AreEqual(IndividualsResults.result979, result);
        }

        [TestMethod]
        public void TestCrossAt980()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual8, 0);
            CollectionAssert.AreEqual(IndividualsResults.result980, result);
        }

        [TestMethod]
        public void TestCrossAt981()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual8, 1);
            CollectionAssert.AreEqual(IndividualsResults.result981, result);
        }

        [TestMethod]
        public void TestCrossAt982()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual8, 2);
            CollectionAssert.AreEqual(IndividualsResults.result982, result);
        }

        [TestMethod]
        public void TestCrossAt983()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual8, 3);
            CollectionAssert.AreEqual(IndividualsResults.result983, result);
        }

        [TestMethod]
        public void TestCrossAt984()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual8, 4);
            CollectionAssert.AreEqual(IndividualsResults.result984, result);
        }

        [TestMethod]
        public void TestCrossAt985()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual8, 5);
            CollectionAssert.AreEqual(IndividualsResults.result985, result);
        }

        [TestMethod]
        public void TestCrossAt986()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual8, 6);
            CollectionAssert.AreEqual(IndividualsResults.result986, result);
        }

        [TestMethod]
        public void TestCrossAt987()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual8, 7);
            CollectionAssert.AreEqual(IndividualsResults.result987, result);
        }

        [TestMethod]
        public void TestCrossAt988()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual8, 8);
            CollectionAssert.AreEqual(IndividualsResults.result988, result);
        }

        [TestMethod]
        public void TestCrossAt989()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual8, 9);
            CollectionAssert.AreEqual(IndividualsResults.result989, result);
        }

        [TestMethod]
        public void TestCrossAt990()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual9, 0);
            CollectionAssert.AreEqual(IndividualsResults.result990, result);
        }

        [TestMethod]
        public void TestCrossAt991()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual9, 1);
            CollectionAssert.AreEqual(IndividualsResults.result991, result);
        }

        [TestMethod]
        public void TestCrossAt992()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual9, 2);
            CollectionAssert.AreEqual(IndividualsResults.result992, result);
        }

        [TestMethod]
        public void TestCrossAt993()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual9, 3);
            CollectionAssert.AreEqual(IndividualsResults.result993, result);
        }

        [TestMethod]
        public void TestCrossAt994()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual9, 4);
            CollectionAssert.AreEqual(IndividualsResults.result994, result);
        }

        [TestMethod]
        public void TestCrossAt995()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual9, 5);
            CollectionAssert.AreEqual(IndividualsResults.result995, result);
        }

        [TestMethod]
        public void TestCrossAt996()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual9, 6);
            CollectionAssert.AreEqual(IndividualsResults.result996, result);
        }

        [TestMethod]
        public void TestCrossAt997()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual9, 7);
            CollectionAssert.AreEqual(IndividualsResults.result997, result);
        }

        [TestMethod]
        public void TestCrossAt998()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual9, 8);
            CollectionAssert.AreEqual(IndividualsResults.result998, result);
        }

        [TestMethod]
        public void TestCrossAt999()
        {
            var result = GeneticAlgorithm.crossAt(TestIndividuals.individual9, TestIndividuals.individual9, 9);
            CollectionAssert.AreEqual(IndividualsResults.result999, result);
        }

    }
}
