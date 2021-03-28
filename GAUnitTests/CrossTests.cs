using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using CAB402.FSharp;

namespace GeneticAlgorithmUnitTests
{
    [TestClass]
    public class CrossTests
    {
        [TestMethod]
        public void TestCross000()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1000, result);
        }

        [TestMethod]
        public void TestCross001()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1001, result);
        }

        [TestMethod]
        public void TestCross002()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1002, result);
        }

        [TestMethod]
        public void TestCross003()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1003, result);
        }

        [TestMethod]
        public void TestCross004()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1004, result);
        }

        [TestMethod]
        public void TestCross005()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1005, result);
        }

        [TestMethod]
        public void TestCross006()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1006, result);
        }

        [TestMethod]
        public void TestCross007()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1007, result);
        }

        [TestMethod]
        public void TestCross008()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1008, result);
        }

        [TestMethod]
        public void TestCross009()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1009, result);
        }

        [TestMethod]
        public void TestCross010()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1010, result);
        }

        [TestMethod]
        public void TestCross011()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1011, result);
        }

        [TestMethod]
        public void TestCross012()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1012, result);
        }

        [TestMethod]
        public void TestCross013()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1013, result);
        }

        [TestMethod]
        public void TestCross014()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1014, result);
        }

        [TestMethod]
        public void TestCross015()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1015, result);
        }

        [TestMethod]
        public void TestCross016()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1016, result);
        }

        [TestMethod]
        public void TestCross017()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1017, result);
        }

        [TestMethod]
        public void TestCross018()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1018, result);
        }

        [TestMethod]
        public void TestCross019()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1019, result);
        }

        [TestMethod]
        public void TestCross020()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1020, result);
        }

        [TestMethod]
        public void TestCross021()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1021, result);
        }

        [TestMethod]
        public void TestCross022()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1022, result);
        }

        [TestMethod]
        public void TestCross023()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1023, result);
        }

        [TestMethod]
        public void TestCross024()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1024, result);
        }

        [TestMethod]
        public void TestCross025()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1025, result);
        }

        [TestMethod]
        public void TestCross026()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1026, result);
        }

        [TestMethod]
        public void TestCross027()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1027, result);
        }

        [TestMethod]
        public void TestCross028()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1028, result);
        }

        [TestMethod]
        public void TestCross029()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1029, result);
        }

        [TestMethod]
        public void TestCross030()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1030, result);
        }

        [TestMethod]
        public void TestCross031()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1031, result);
        }

        [TestMethod]
        public void TestCross032()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1032, result);
        }

        [TestMethod]
        public void TestCross033()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1033, result);
        }

        [TestMethod]
        public void TestCross034()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1034, result);
        }

        [TestMethod]
        public void TestCross035()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1035, result);
        }

        [TestMethod]
        public void TestCross036()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1036, result);
        }

        [TestMethod]
        public void TestCross037()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1037, result);
        }

        [TestMethod]
        public void TestCross038()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1038, result);
        }

        [TestMethod]
        public void TestCross039()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1039, result);
        }

        [TestMethod]
        public void TestCross040()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1040, result);
        }

        [TestMethod]
        public void TestCross041()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1041, result);
        }

        [TestMethod]
        public void TestCross042()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1042, result);
        }

        [TestMethod]
        public void TestCross043()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1043, result);
        }

        [TestMethod]
        public void TestCross044()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1044, result);
        }

        [TestMethod]
        public void TestCross045()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1045, result);
        }

        [TestMethod]
        public void TestCross046()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1046, result);
        }

        [TestMethod]
        public void TestCross047()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1047, result);
        }

        [TestMethod]
        public void TestCross048()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1048, result);
        }

        [TestMethod]
        public void TestCross049()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1049, result);
        }

        [TestMethod]
        public void TestCross050()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1050, result);
        }

        [TestMethod]
        public void TestCross051()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1051, result);
        }

        [TestMethod]
        public void TestCross052()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1052, result);
        }

        [TestMethod]
        public void TestCross053()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1053, result);
        }

        [TestMethod]
        public void TestCross054()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1054, result);
        }

        [TestMethod]
        public void TestCross055()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1055, result);
        }

        [TestMethod]
        public void TestCross056()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1056, result);
        }

        [TestMethod]
        public void TestCross057()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1057, result);
        }

        [TestMethod]
        public void TestCross058()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1058, result);
        }

        [TestMethod]
        public void TestCross059()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1059, result);
        }

        [TestMethod]
        public void TestCross060()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1060, result);
        }

        [TestMethod]
        public void TestCross061()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1061, result);
        }

        [TestMethod]
        public void TestCross062()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1062, result);
        }

        [TestMethod]
        public void TestCross063()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1063, result);
        }

        [TestMethod]
        public void TestCross064()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1064, result);
        }

        [TestMethod]
        public void TestCross065()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1065, result);
        }

        [TestMethod]
        public void TestCross066()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1066, result);
        }

        [TestMethod]
        public void TestCross067()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1067, result);
        }

        [TestMethod]
        public void TestCross068()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1068, result);
        }

        [TestMethod]
        public void TestCross069()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1069, result);
        }

        [TestMethod]
        public void TestCross070()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1070, result);
        }

        [TestMethod]
        public void TestCross071()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1071, result);
        }

        [TestMethod]
        public void TestCross072()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1072, result);
        }

        [TestMethod]
        public void TestCross073()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1073, result);
        }

        [TestMethod]
        public void TestCross074()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1074, result);
        }

        [TestMethod]
        public void TestCross075()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1075, result);
        }

        [TestMethod]
        public void TestCross076()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1076, result);
        }

        [TestMethod]
        public void TestCross077()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1077, result);
        }

        [TestMethod]
        public void TestCross078()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1078, result);
        }

        [TestMethod]
        public void TestCross079()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1079, result);
        }

        [TestMethod]
        public void TestCross080()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1080, result);
        }

        [TestMethod]
        public void TestCross081()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1081, result);
        }

        [TestMethod]
        public void TestCross082()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1082, result);
        }

        [TestMethod]
        public void TestCross083()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1083, result);
        }

        [TestMethod]
        public void TestCross084()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1084, result);
        }

        [TestMethod]
        public void TestCross085()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1085, result);
        }

        [TestMethod]
        public void TestCross086()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1086, result);
        }

        [TestMethod]
        public void TestCross087()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1087, result);
        }

        [TestMethod]
        public void TestCross088()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1088, result);
        }

        [TestMethod]
        public void TestCross089()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1089, result);
        }

        [TestMethod]
        public void TestCross090()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1090, result);
        }

        [TestMethod]
        public void TestCross091()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1091, result);
        }

        [TestMethod]
        public void TestCross092()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1092, result);
        }

        [TestMethod]
        public void TestCross093()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1093, result);
        }

        [TestMethod]
        public void TestCross094()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1094, result);
        }

        [TestMethod]
        public void TestCross095()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1095, result);
        }

        [TestMethod]
        public void TestCross096()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1096, result);
        }

        [TestMethod]
        public void TestCross097()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1097, result);
        }

        [TestMethod]
        public void TestCross098()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1098, result);
        }

        [TestMethod]
        public void TestCross099()
        {
            var result = RandomMonad.evaluateWith(new System.Random(0), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1099, result);
        }

        [TestMethod]
        public void TestCross100()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1100, result);
        }

        [TestMethod]
        public void TestCross101()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1101, result);
        }

        [TestMethod]
        public void TestCross102()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1102, result);
        }

        [TestMethod]
        public void TestCross103()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1103, result);
        }

        [TestMethod]
        public void TestCross104()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1104, result);
        }

        [TestMethod]
        public void TestCross105()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1105, result);
        }

        [TestMethod]
        public void TestCross106()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1106, result);
        }

        [TestMethod]
        public void TestCross107()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1107, result);
        }

        [TestMethod]
        public void TestCross108()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1108, result);
        }

        [TestMethod]
        public void TestCross109()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1109, result);
        }

        [TestMethod]
        public void TestCross110()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1110, result);
        }

        [TestMethod]
        public void TestCross111()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1111, result);
        }

        [TestMethod]
        public void TestCross112()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1112, result);
        }

        [TestMethod]
        public void TestCross113()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1113, result);
        }

        [TestMethod]
        public void TestCross114()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1114, result);
        }

        [TestMethod]
        public void TestCross115()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1115, result);
        }

        [TestMethod]
        public void TestCross116()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1116, result);
        }

        [TestMethod]
        public void TestCross117()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1117, result);
        }

        [TestMethod]
        public void TestCross118()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1118, result);
        }

        [TestMethod]
        public void TestCross119()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1119, result);
        }

        [TestMethod]
        public void TestCross120()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1120, result);
        }

        [TestMethod]
        public void TestCross121()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1121, result);
        }

        [TestMethod]
        public void TestCross122()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1122, result);
        }

        [TestMethod]
        public void TestCross123()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1123, result);
        }

        [TestMethod]
        public void TestCross124()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1124, result);
        }

        [TestMethod]
        public void TestCross125()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1125, result);
        }

        [TestMethod]
        public void TestCross126()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1126, result);
        }

        [TestMethod]
        public void TestCross127()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1127, result);
        }

        [TestMethod]
        public void TestCross128()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1128, result);
        }

        [TestMethod]
        public void TestCross129()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1129, result);
        }

        [TestMethod]
        public void TestCross130()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1130, result);
        }

        [TestMethod]
        public void TestCross131()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1131, result);
        }

        [TestMethod]
        public void TestCross132()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1132, result);
        }

        [TestMethod]
        public void TestCross133()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1133, result);
        }

        [TestMethod]
        public void TestCross134()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1134, result);
        }

        [TestMethod]
        public void TestCross135()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1135, result);
        }

        [TestMethod]
        public void TestCross136()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1136, result);
        }

        [TestMethod]
        public void TestCross137()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1137, result);
        }

        [TestMethod]
        public void TestCross138()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1138, result);
        }

        [TestMethod]
        public void TestCross139()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1139, result);
        }

        [TestMethod]
        public void TestCross140()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1140, result);
        }

        [TestMethod]
        public void TestCross141()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1141, result);
        }

        [TestMethod]
        public void TestCross142()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1142, result);
        }

        [TestMethod]
        public void TestCross143()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1143, result);
        }

        [TestMethod]
        public void TestCross144()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1144, result);
        }

        [TestMethod]
        public void TestCross145()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1145, result);
        }

        [TestMethod]
        public void TestCross146()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1146, result);
        }

        [TestMethod]
        public void TestCross147()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1147, result);
        }

        [TestMethod]
        public void TestCross148()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1148, result);
        }

        [TestMethod]
        public void TestCross149()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1149, result);
        }

        [TestMethod]
        public void TestCross150()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1150, result);
        }

        [TestMethod]
        public void TestCross151()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1151, result);
        }

        [TestMethod]
        public void TestCross152()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1152, result);
        }

        [TestMethod]
        public void TestCross153()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1153, result);
        }

        [TestMethod]
        public void TestCross154()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1154, result);
        }

        [TestMethod]
        public void TestCross155()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1155, result);
        }

        [TestMethod]
        public void TestCross156()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1156, result);
        }

        [TestMethod]
        public void TestCross157()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1157, result);
        }

        [TestMethod]
        public void TestCross158()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1158, result);
        }

        [TestMethod]
        public void TestCross159()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1159, result);
        }

        [TestMethod]
        public void TestCross160()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1160, result);
        }

        [TestMethod]
        public void TestCross161()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1161, result);
        }

        [TestMethod]
        public void TestCross162()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1162, result);
        }

        [TestMethod]
        public void TestCross163()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1163, result);
        }

        [TestMethod]
        public void TestCross164()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1164, result);
        }

        [TestMethod]
        public void TestCross165()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1165, result);
        }

        [TestMethod]
        public void TestCross166()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1166, result);
        }

        [TestMethod]
        public void TestCross167()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1167, result);
        }

        [TestMethod]
        public void TestCross168()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1168, result);
        }

        [TestMethod]
        public void TestCross169()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1169, result);
        }

        [TestMethod]
        public void TestCross170()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1170, result);
        }

        [TestMethod]
        public void TestCross171()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1171, result);
        }

        [TestMethod]
        public void TestCross172()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1172, result);
        }

        [TestMethod]
        public void TestCross173()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1173, result);
        }

        [TestMethod]
        public void TestCross174()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1174, result);
        }

        [TestMethod]
        public void TestCross175()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1175, result);
        }

        [TestMethod]
        public void TestCross176()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1176, result);
        }

        [TestMethod]
        public void TestCross177()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1177, result);
        }

        [TestMethod]
        public void TestCross178()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1178, result);
        }

        [TestMethod]
        public void TestCross179()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1179, result);
        }

        [TestMethod]
        public void TestCross180()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1180, result);
        }

        [TestMethod]
        public void TestCross181()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1181, result);
        }

        [TestMethod]
        public void TestCross182()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1182, result);
        }

        [TestMethod]
        public void TestCross183()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1183, result);
        }

        [TestMethod]
        public void TestCross184()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1184, result);
        }

        [TestMethod]
        public void TestCross185()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1185, result);
        }

        [TestMethod]
        public void TestCross186()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1186, result);
        }

        [TestMethod]
        public void TestCross187()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1187, result);
        }

        [TestMethod]
        public void TestCross188()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1188, result);
        }

        [TestMethod]
        public void TestCross189()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1189, result);
        }

        [TestMethod]
        public void TestCross190()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1190, result);
        }

        [TestMethod]
        public void TestCross191()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1191, result);
        }

        [TestMethod]
        public void TestCross192()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1192, result);
        }

        [TestMethod]
        public void TestCross193()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1193, result);
        }

        [TestMethod]
        public void TestCross194()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1194, result);
        }

        [TestMethod]
        public void TestCross195()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1195, result);
        }

        [TestMethod]
        public void TestCross196()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1196, result);
        }

        [TestMethod]
        public void TestCross197()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1197, result);
        }

        [TestMethod]
        public void TestCross198()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1198, result);
        }

        [TestMethod]
        public void TestCross199()
        {
            var result = RandomMonad.evaluateWith(new System.Random(1), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1199, result);
        }

        [TestMethod]
        public void TestCross200()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1200, result);
        }

        [TestMethod]
        public void TestCross201()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1201, result);
        }

        [TestMethod]
        public void TestCross202()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1202, result);
        }

        [TestMethod]
        public void TestCross203()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1203, result);
        }

        [TestMethod]
        public void TestCross204()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1204, result);
        }

        [TestMethod]
        public void TestCross205()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1205, result);
        }

        [TestMethod]
        public void TestCross206()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1206, result);
        }

        [TestMethod]
        public void TestCross207()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1207, result);
        }

        [TestMethod]
        public void TestCross208()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1208, result);
        }

        [TestMethod]
        public void TestCross209()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1209, result);
        }

        [TestMethod]
        public void TestCross210()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1210, result);
        }

        [TestMethod]
        public void TestCross211()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1211, result);
        }

        [TestMethod]
        public void TestCross212()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1212, result);
        }

        [TestMethod]
        public void TestCross213()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1213, result);
        }

        [TestMethod]
        public void TestCross214()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1214, result);
        }

        [TestMethod]
        public void TestCross215()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1215, result);
        }

        [TestMethod]
        public void TestCross216()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1216, result);
        }

        [TestMethod]
        public void TestCross217()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1217, result);
        }

        [TestMethod]
        public void TestCross218()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1218, result);
        }

        [TestMethod]
        public void TestCross219()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1219, result);
        }

        [TestMethod]
        public void TestCross220()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1220, result);
        }

        [TestMethod]
        public void TestCross221()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1221, result);
        }

        [TestMethod]
        public void TestCross222()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1222, result);
        }

        [TestMethod]
        public void TestCross223()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1223, result);
        }

        [TestMethod]
        public void TestCross224()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1224, result);
        }

        [TestMethod]
        public void TestCross225()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1225, result);
        }

        [TestMethod]
        public void TestCross226()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1226, result);
        }

        [TestMethod]
        public void TestCross227()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1227, result);
        }

        [TestMethod]
        public void TestCross228()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1228, result);
        }

        [TestMethod]
        public void TestCross229()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1229, result);
        }

        [TestMethod]
        public void TestCross230()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1230, result);
        }

        [TestMethod]
        public void TestCross231()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1231, result);
        }

        [TestMethod]
        public void TestCross232()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1232, result);
        }

        [TestMethod]
        public void TestCross233()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1233, result);
        }

        [TestMethod]
        public void TestCross234()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1234, result);
        }

        [TestMethod]
        public void TestCross235()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1235, result);
        }

        [TestMethod]
        public void TestCross236()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1236, result);
        }

        [TestMethod]
        public void TestCross237()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1237, result);
        }

        [TestMethod]
        public void TestCross238()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1238, result);
        }

        [TestMethod]
        public void TestCross239()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1239, result);
        }

        [TestMethod]
        public void TestCross240()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1240, result);
        }

        [TestMethod]
        public void TestCross241()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1241, result);
        }

        [TestMethod]
        public void TestCross242()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1242, result);
        }

        [TestMethod]
        public void TestCross243()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1243, result);
        }

        [TestMethod]
        public void TestCross244()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1244, result);
        }

        [TestMethod]
        public void TestCross245()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1245, result);
        }

        [TestMethod]
        public void TestCross246()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1246, result);
        }

        [TestMethod]
        public void TestCross247()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1247, result);
        }

        [TestMethod]
        public void TestCross248()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1248, result);
        }

        [TestMethod]
        public void TestCross249()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1249, result);
        }

        [TestMethod]
        public void TestCross250()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1250, result);
        }

        [TestMethod]
        public void TestCross251()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1251, result);
        }

        [TestMethod]
        public void TestCross252()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1252, result);
        }

        [TestMethod]
        public void TestCross253()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1253, result);
        }

        [TestMethod]
        public void TestCross254()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1254, result);
        }

        [TestMethod]
        public void TestCross255()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1255, result);
        }

        [TestMethod]
        public void TestCross256()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1256, result);
        }

        [TestMethod]
        public void TestCross257()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1257, result);
        }

        [TestMethod]
        public void TestCross258()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1258, result);
        }

        [TestMethod]
        public void TestCross259()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1259, result);
        }

        [TestMethod]
        public void TestCross260()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1260, result);
        }

        [TestMethod]
        public void TestCross261()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1261, result);
        }

        [TestMethod]
        public void TestCross262()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1262, result);
        }

        [TestMethod]
        public void TestCross263()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1263, result);
        }

        [TestMethod]
        public void TestCross264()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1264, result);
        }

        [TestMethod]
        public void TestCross265()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1265, result);
        }

        [TestMethod]
        public void TestCross266()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1266, result);
        }

        [TestMethod]
        public void TestCross267()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1267, result);
        }

        [TestMethod]
        public void TestCross268()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1268, result);
        }

        [TestMethod]
        public void TestCross269()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1269, result);
        }

        [TestMethod]
        public void TestCross270()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1270, result);
        }

        [TestMethod]
        public void TestCross271()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1271, result);
        }

        [TestMethod]
        public void TestCross272()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1272, result);
        }

        [TestMethod]
        public void TestCross273()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1273, result);
        }

        [TestMethod]
        public void TestCross274()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1274, result);
        }

        [TestMethod]
        public void TestCross275()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1275, result);
        }

        [TestMethod]
        public void TestCross276()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1276, result);
        }

        [TestMethod]
        public void TestCross277()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1277, result);
        }

        [TestMethod]
        public void TestCross278()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1278, result);
        }

        [TestMethod]
        public void TestCross279()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1279, result);
        }

        [TestMethod]
        public void TestCross280()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1280, result);
        }

        [TestMethod]
        public void TestCross281()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1281, result);
        }

        [TestMethod]
        public void TestCross282()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1282, result);
        }

        [TestMethod]
        public void TestCross283()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1283, result);
        }

        [TestMethod]
        public void TestCross284()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1284, result);
        }

        [TestMethod]
        public void TestCross285()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1285, result);
        }

        [TestMethod]
        public void TestCross286()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1286, result);
        }

        [TestMethod]
        public void TestCross287()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1287, result);
        }

        [TestMethod]
        public void TestCross288()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1288, result);
        }

        [TestMethod]
        public void TestCross289()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1289, result);
        }

        [TestMethod]
        public void TestCross290()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1290, result);
        }

        [TestMethod]
        public void TestCross291()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1291, result);
        }

        [TestMethod]
        public void TestCross292()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1292, result);
        }

        [TestMethod]
        public void TestCross293()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1293, result);
        }

        [TestMethod]
        public void TestCross294()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1294, result);
        }

        [TestMethod]
        public void TestCross295()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1295, result);
        }

        [TestMethod]
        public void TestCross296()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1296, result);
        }

        [TestMethod]
        public void TestCross297()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1297, result);
        }

        [TestMethod]
        public void TestCross298()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1298, result);
        }

        [TestMethod]
        public void TestCross299()
        {
            var result = RandomMonad.evaluateWith(new System.Random(2), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1299, result);
        }

        [TestMethod]
        public void TestCross300()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1300, result);
        }

        [TestMethod]
        public void TestCross301()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1301, result);
        }

        [TestMethod]
        public void TestCross302()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1302, result);
        }

        [TestMethod]
        public void TestCross303()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1303, result);
        }

        [TestMethod]
        public void TestCross304()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1304, result);
        }

        [TestMethod]
        public void TestCross305()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1305, result);
        }

        [TestMethod]
        public void TestCross306()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1306, result);
        }

        [TestMethod]
        public void TestCross307()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1307, result);
        }

        [TestMethod]
        public void TestCross308()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1308, result);
        }

        [TestMethod]
        public void TestCross309()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1309, result);
        }

        [TestMethod]
        public void TestCross310()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1310, result);
        }

        [TestMethod]
        public void TestCross311()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1311, result);
        }

        [TestMethod]
        public void TestCross312()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1312, result);
        }

        [TestMethod]
        public void TestCross313()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1313, result);
        }

        [TestMethod]
        public void TestCross314()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1314, result);
        }

        [TestMethod]
        public void TestCross315()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1315, result);
        }

        [TestMethod]
        public void TestCross316()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1316, result);
        }

        [TestMethod]
        public void TestCross317()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1317, result);
        }

        [TestMethod]
        public void TestCross318()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1318, result);
        }

        [TestMethod]
        public void TestCross319()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1319, result);
        }

        [TestMethod]
        public void TestCross320()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1320, result);
        }

        [TestMethod]
        public void TestCross321()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1321, result);
        }

        [TestMethod]
        public void TestCross322()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1322, result);
        }

        [TestMethod]
        public void TestCross323()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1323, result);
        }

        [TestMethod]
        public void TestCross324()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1324, result);
        }

        [TestMethod]
        public void TestCross325()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1325, result);
        }

        [TestMethod]
        public void TestCross326()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1326, result);
        }

        [TestMethod]
        public void TestCross327()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1327, result);
        }

        [TestMethod]
        public void TestCross328()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1328, result);
        }

        [TestMethod]
        public void TestCross329()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1329, result);
        }

        [TestMethod]
        public void TestCross330()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1330, result);
        }

        [TestMethod]
        public void TestCross331()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1331, result);
        }

        [TestMethod]
        public void TestCross332()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1332, result);
        }

        [TestMethod]
        public void TestCross333()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1333, result);
        }

        [TestMethod]
        public void TestCross334()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1334, result);
        }

        [TestMethod]
        public void TestCross335()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1335, result);
        }

        [TestMethod]
        public void TestCross336()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1336, result);
        }

        [TestMethod]
        public void TestCross337()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1337, result);
        }

        [TestMethod]
        public void TestCross338()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1338, result);
        }

        [TestMethod]
        public void TestCross339()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1339, result);
        }

        [TestMethod]
        public void TestCross340()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1340, result);
        }

        [TestMethod]
        public void TestCross341()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1341, result);
        }

        [TestMethod]
        public void TestCross342()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1342, result);
        }

        [TestMethod]
        public void TestCross343()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1343, result);
        }

        [TestMethod]
        public void TestCross344()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1344, result);
        }

        [TestMethod]
        public void TestCross345()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1345, result);
        }

        [TestMethod]
        public void TestCross346()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1346, result);
        }

        [TestMethod]
        public void TestCross347()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1347, result);
        }

        [TestMethod]
        public void TestCross348()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1348, result);
        }

        [TestMethod]
        public void TestCross349()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1349, result);
        }

        [TestMethod]
        public void TestCross350()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1350, result);
        }

        [TestMethod]
        public void TestCross351()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1351, result);
        }

        [TestMethod]
        public void TestCross352()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1352, result);
        }

        [TestMethod]
        public void TestCross353()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1353, result);
        }

        [TestMethod]
        public void TestCross354()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1354, result);
        }

        [TestMethod]
        public void TestCross355()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1355, result);
        }

        [TestMethod]
        public void TestCross356()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1356, result);
        }

        [TestMethod]
        public void TestCross357()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1357, result);
        }

        [TestMethod]
        public void TestCross358()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1358, result);
        }

        [TestMethod]
        public void TestCross359()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1359, result);
        }

        [TestMethod]
        public void TestCross360()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1360, result);
        }

        [TestMethod]
        public void TestCross361()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1361, result);
        }

        [TestMethod]
        public void TestCross362()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1362, result);
        }

        [TestMethod]
        public void TestCross363()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1363, result);
        }

        [TestMethod]
        public void TestCross364()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1364, result);
        }

        [TestMethod]
        public void TestCross365()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1365, result);
        }

        [TestMethod]
        public void TestCross366()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1366, result);
        }

        [TestMethod]
        public void TestCross367()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1367, result);
        }

        [TestMethod]
        public void TestCross368()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1368, result);
        }

        [TestMethod]
        public void TestCross369()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1369, result);
        }

        [TestMethod]
        public void TestCross370()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1370, result);
        }

        [TestMethod]
        public void TestCross371()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1371, result);
        }

        [TestMethod]
        public void TestCross372()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1372, result);
        }

        [TestMethod]
        public void TestCross373()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1373, result);
        }

        [TestMethod]
        public void TestCross374()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1374, result);
        }

        [TestMethod]
        public void TestCross375()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1375, result);
        }

        [TestMethod]
        public void TestCross376()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1376, result);
        }

        [TestMethod]
        public void TestCross377()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1377, result);
        }

        [TestMethod]
        public void TestCross378()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1378, result);
        }

        [TestMethod]
        public void TestCross379()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1379, result);
        }

        [TestMethod]
        public void TestCross380()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1380, result);
        }

        [TestMethod]
        public void TestCross381()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1381, result);
        }

        [TestMethod]
        public void TestCross382()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1382, result);
        }

        [TestMethod]
        public void TestCross383()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1383, result);
        }

        [TestMethod]
        public void TestCross384()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1384, result);
        }

        [TestMethod]
        public void TestCross385()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1385, result);
        }

        [TestMethod]
        public void TestCross386()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1386, result);
        }

        [TestMethod]
        public void TestCross387()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1387, result);
        }

        [TestMethod]
        public void TestCross388()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1388, result);
        }

        [TestMethod]
        public void TestCross389()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1389, result);
        }

        [TestMethod]
        public void TestCross390()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1390, result);
        }

        [TestMethod]
        public void TestCross391()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1391, result);
        }

        [TestMethod]
        public void TestCross392()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1392, result);
        }

        [TestMethod]
        public void TestCross393()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1393, result);
        }

        [TestMethod]
        public void TestCross394()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1394, result);
        }

        [TestMethod]
        public void TestCross395()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1395, result);
        }

        [TestMethod]
        public void TestCross396()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1396, result);
        }

        [TestMethod]
        public void TestCross397()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1397, result);
        }

        [TestMethod]
        public void TestCross398()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1398, result);
        }

        [TestMethod]
        public void TestCross399()
        {
            var result = RandomMonad.evaluateWith(new System.Random(3), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1399, result);
        }

        [TestMethod]
        public void TestCross400()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1400, result);
        }

        [TestMethod]
        public void TestCross401()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1401, result);
        }

        [TestMethod]
        public void TestCross402()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1402, result);
        }

        [TestMethod]
        public void TestCross403()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1403, result);
        }

        [TestMethod]
        public void TestCross404()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1404, result);
        }

        [TestMethod]
        public void TestCross405()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1405, result);
        }

        [TestMethod]
        public void TestCross406()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1406, result);
        }

        [TestMethod]
        public void TestCross407()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1407, result);
        }

        [TestMethod]
        public void TestCross408()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1408, result);
        }

        [TestMethod]
        public void TestCross409()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1409, result);
        }

        [TestMethod]
        public void TestCross410()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1410, result);
        }

        [TestMethod]
        public void TestCross411()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1411, result);
        }

        [TestMethod]
        public void TestCross412()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1412, result);
        }

        [TestMethod]
        public void TestCross413()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1413, result);
        }

        [TestMethod]
        public void TestCross414()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1414, result);
        }

        [TestMethod]
        public void TestCross415()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1415, result);
        }

        [TestMethod]
        public void TestCross416()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1416, result);
        }

        [TestMethod]
        public void TestCross417()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1417, result);
        }

        [TestMethod]
        public void TestCross418()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1418, result);
        }

        [TestMethod]
        public void TestCross419()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1419, result);
        }

        [TestMethod]
        public void TestCross420()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1420, result);
        }

        [TestMethod]
        public void TestCross421()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1421, result);
        }

        [TestMethod]
        public void TestCross422()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1422, result);
        }

        [TestMethod]
        public void TestCross423()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1423, result);
        }

        [TestMethod]
        public void TestCross424()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1424, result);
        }

        [TestMethod]
        public void TestCross425()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1425, result);
        }

        [TestMethod]
        public void TestCross426()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1426, result);
        }

        [TestMethod]
        public void TestCross427()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1427, result);
        }

        [TestMethod]
        public void TestCross428()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1428, result);
        }

        [TestMethod]
        public void TestCross429()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1429, result);
        }

        [TestMethod]
        public void TestCross430()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1430, result);
        }

        [TestMethod]
        public void TestCross431()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1431, result);
        }

        [TestMethod]
        public void TestCross432()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1432, result);
        }

        [TestMethod]
        public void TestCross433()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1433, result);
        }

        [TestMethod]
        public void TestCross434()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1434, result);
        }

        [TestMethod]
        public void TestCross435()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1435, result);
        }

        [TestMethod]
        public void TestCross436()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1436, result);
        }

        [TestMethod]
        public void TestCross437()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1437, result);
        }

        [TestMethod]
        public void TestCross438()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1438, result);
        }

        [TestMethod]
        public void TestCross439()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1439, result);
        }

        [TestMethod]
        public void TestCross440()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1440, result);
        }

        [TestMethod]
        public void TestCross441()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1441, result);
        }

        [TestMethod]
        public void TestCross442()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1442, result);
        }

        [TestMethod]
        public void TestCross443()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1443, result);
        }

        [TestMethod]
        public void TestCross444()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1444, result);
        }

        [TestMethod]
        public void TestCross445()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1445, result);
        }

        [TestMethod]
        public void TestCross446()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1446, result);
        }

        [TestMethod]
        public void TestCross447()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1447, result);
        }

        [TestMethod]
        public void TestCross448()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1448, result);
        }

        [TestMethod]
        public void TestCross449()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1449, result);
        }

        [TestMethod]
        public void TestCross450()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1450, result);
        }

        [TestMethod]
        public void TestCross451()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1451, result);
        }

        [TestMethod]
        public void TestCross452()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1452, result);
        }

        [TestMethod]
        public void TestCross453()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1453, result);
        }

        [TestMethod]
        public void TestCross454()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1454, result);
        }

        [TestMethod]
        public void TestCross455()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1455, result);
        }

        [TestMethod]
        public void TestCross456()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1456, result);
        }

        [TestMethod]
        public void TestCross457()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1457, result);
        }

        [TestMethod]
        public void TestCross458()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1458, result);
        }

        [TestMethod]
        public void TestCross459()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1459, result);
        }

        [TestMethod]
        public void TestCross460()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1460, result);
        }

        [TestMethod]
        public void TestCross461()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1461, result);
        }

        [TestMethod]
        public void TestCross462()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1462, result);
        }

        [TestMethod]
        public void TestCross463()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1463, result);
        }

        [TestMethod]
        public void TestCross464()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1464, result);
        }

        [TestMethod]
        public void TestCross465()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1465, result);
        }

        [TestMethod]
        public void TestCross466()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1466, result);
        }

        [TestMethod]
        public void TestCross467()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1467, result);
        }

        [TestMethod]
        public void TestCross468()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1468, result);
        }

        [TestMethod]
        public void TestCross469()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1469, result);
        }

        [TestMethod]
        public void TestCross470()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1470, result);
        }

        [TestMethod]
        public void TestCross471()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1471, result);
        }

        [TestMethod]
        public void TestCross472()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1472, result);
        }

        [TestMethod]
        public void TestCross473()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1473, result);
        }

        [TestMethod]
        public void TestCross474()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1474, result);
        }

        [TestMethod]
        public void TestCross475()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1475, result);
        }

        [TestMethod]
        public void TestCross476()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1476, result);
        }

        [TestMethod]
        public void TestCross477()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1477, result);
        }

        [TestMethod]
        public void TestCross478()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1478, result);
        }

        [TestMethod]
        public void TestCross479()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1479, result);
        }

        [TestMethod]
        public void TestCross480()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1480, result);
        }

        [TestMethod]
        public void TestCross481()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1481, result);
        }

        [TestMethod]
        public void TestCross482()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1482, result);
        }

        [TestMethod]
        public void TestCross483()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1483, result);
        }

        [TestMethod]
        public void TestCross484()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1484, result);
        }

        [TestMethod]
        public void TestCross485()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1485, result);
        }

        [TestMethod]
        public void TestCross486()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1486, result);
        }

        [TestMethod]
        public void TestCross487()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1487, result);
        }

        [TestMethod]
        public void TestCross488()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1488, result);
        }

        [TestMethod]
        public void TestCross489()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1489, result);
        }

        [TestMethod]
        public void TestCross490()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1490, result);
        }

        [TestMethod]
        public void TestCross491()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1491, result);
        }

        [TestMethod]
        public void TestCross492()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1492, result);
        }

        [TestMethod]
        public void TestCross493()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1493, result);
        }

        [TestMethod]
        public void TestCross494()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1494, result);
        }

        [TestMethod]
        public void TestCross495()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1495, result);
        }

        [TestMethod]
        public void TestCross496()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1496, result);
        }

        [TestMethod]
        public void TestCross497()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1497, result);
        }

        [TestMethod]
        public void TestCross498()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1498, result);
        }

        [TestMethod]
        public void TestCross499()
        {
            var result = RandomMonad.evaluateWith(new System.Random(4), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1499, result);
        }

        [TestMethod]
        public void TestCross500()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1500, result);
        }

        [TestMethod]
        public void TestCross501()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1501, result);
        }

        [TestMethod]
        public void TestCross502()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1502, result);
        }

        [TestMethod]
        public void TestCross503()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1503, result);
        }

        [TestMethod]
        public void TestCross504()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1504, result);
        }

        [TestMethod]
        public void TestCross505()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1505, result);
        }

        [TestMethod]
        public void TestCross506()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1506, result);
        }

        [TestMethod]
        public void TestCross507()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1507, result);
        }

        [TestMethod]
        public void TestCross508()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1508, result);
        }

        [TestMethod]
        public void TestCross509()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1509, result);
        }

        [TestMethod]
        public void TestCross510()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1510, result);
        }

        [TestMethod]
        public void TestCross511()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1511, result);
        }

        [TestMethod]
        public void TestCross512()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1512, result);
        }

        [TestMethod]
        public void TestCross513()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1513, result);
        }

        [TestMethod]
        public void TestCross514()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1514, result);
        }

        [TestMethod]
        public void TestCross515()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1515, result);
        }

        [TestMethod]
        public void TestCross516()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1516, result);
        }

        [TestMethod]
        public void TestCross517()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1517, result);
        }

        [TestMethod]
        public void TestCross518()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1518, result);
        }

        [TestMethod]
        public void TestCross519()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1519, result);
        }

        [TestMethod]
        public void TestCross520()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1520, result);
        }

        [TestMethod]
        public void TestCross521()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1521, result);
        }

        [TestMethod]
        public void TestCross522()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1522, result);
        }

        [TestMethod]
        public void TestCross523()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1523, result);
        }

        [TestMethod]
        public void TestCross524()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1524, result);
        }

        [TestMethod]
        public void TestCross525()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1525, result);
        }

        [TestMethod]
        public void TestCross526()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1526, result);
        }

        [TestMethod]
        public void TestCross527()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1527, result);
        }

        [TestMethod]
        public void TestCross528()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1528, result);
        }

        [TestMethod]
        public void TestCross529()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1529, result);
        }

        [TestMethod]
        public void TestCross530()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1530, result);
        }

        [TestMethod]
        public void TestCross531()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1531, result);
        }

        [TestMethod]
        public void TestCross532()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1532, result);
        }

        [TestMethod]
        public void TestCross533()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1533, result);
        }

        [TestMethod]
        public void TestCross534()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1534, result);
        }

        [TestMethod]
        public void TestCross535()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1535, result);
        }

        [TestMethod]
        public void TestCross536()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1536, result);
        }

        [TestMethod]
        public void TestCross537()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1537, result);
        }

        [TestMethod]
        public void TestCross538()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1538, result);
        }

        [TestMethod]
        public void TestCross539()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1539, result);
        }

        [TestMethod]
        public void TestCross540()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1540, result);
        }

        [TestMethod]
        public void TestCross541()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1541, result);
        }

        [TestMethod]
        public void TestCross542()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1542, result);
        }

        [TestMethod]
        public void TestCross543()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1543, result);
        }

        [TestMethod]
        public void TestCross544()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1544, result);
        }

        [TestMethod]
        public void TestCross545()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1545, result);
        }

        [TestMethod]
        public void TestCross546()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1546, result);
        }

        [TestMethod]
        public void TestCross547()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1547, result);
        }

        [TestMethod]
        public void TestCross548()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1548, result);
        }

        [TestMethod]
        public void TestCross549()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1549, result);
        }

        [TestMethod]
        public void TestCross550()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1550, result);
        }

        [TestMethod]
        public void TestCross551()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1551, result);
        }

        [TestMethod]
        public void TestCross552()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1552, result);
        }

        [TestMethod]
        public void TestCross553()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1553, result);
        }

        [TestMethod]
        public void TestCross554()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1554, result);
        }

        [TestMethod]
        public void TestCross555()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1555, result);
        }

        [TestMethod]
        public void TestCross556()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1556, result);
        }

        [TestMethod]
        public void TestCross557()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1557, result);
        }

        [TestMethod]
        public void TestCross558()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1558, result);
        }

        [TestMethod]
        public void TestCross559()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1559, result);
        }

        [TestMethod]
        public void TestCross560()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1560, result);
        }

        [TestMethod]
        public void TestCross561()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1561, result);
        }

        [TestMethod]
        public void TestCross562()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1562, result);
        }

        [TestMethod]
        public void TestCross563()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1563, result);
        }

        [TestMethod]
        public void TestCross564()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1564, result);
        }

        [TestMethod]
        public void TestCross565()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1565, result);
        }

        [TestMethod]
        public void TestCross566()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1566, result);
        }

        [TestMethod]
        public void TestCross567()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1567, result);
        }

        [TestMethod]
        public void TestCross568()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1568, result);
        }

        [TestMethod]
        public void TestCross569()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1569, result);
        }

        [TestMethod]
        public void TestCross570()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1570, result);
        }

        [TestMethod]
        public void TestCross571()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1571, result);
        }

        [TestMethod]
        public void TestCross572()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1572, result);
        }

        [TestMethod]
        public void TestCross573()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1573, result);
        }

        [TestMethod]
        public void TestCross574()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1574, result);
        }

        [TestMethod]
        public void TestCross575()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1575, result);
        }

        [TestMethod]
        public void TestCross576()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1576, result);
        }

        [TestMethod]
        public void TestCross577()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1577, result);
        }

        [TestMethod]
        public void TestCross578()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1578, result);
        }

        [TestMethod]
        public void TestCross579()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1579, result);
        }

        [TestMethod]
        public void TestCross580()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1580, result);
        }

        [TestMethod]
        public void TestCross581()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1581, result);
        }

        [TestMethod]
        public void TestCross582()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1582, result);
        }

        [TestMethod]
        public void TestCross583()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1583, result);
        }

        [TestMethod]
        public void TestCross584()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1584, result);
        }

        [TestMethod]
        public void TestCross585()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1585, result);
        }

        [TestMethod]
        public void TestCross586()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1586, result);
        }

        [TestMethod]
        public void TestCross587()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1587, result);
        }

        [TestMethod]
        public void TestCross588()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1588, result);
        }

        [TestMethod]
        public void TestCross589()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1589, result);
        }

        [TestMethod]
        public void TestCross590()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1590, result);
        }

        [TestMethod]
        public void TestCross591()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1591, result);
        }

        [TestMethod]
        public void TestCross592()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1592, result);
        }

        [TestMethod]
        public void TestCross593()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1593, result);
        }

        [TestMethod]
        public void TestCross594()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1594, result);
        }

        [TestMethod]
        public void TestCross595()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1595, result);
        }

        [TestMethod]
        public void TestCross596()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1596, result);
        }

        [TestMethod]
        public void TestCross597()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1597, result);
        }

        [TestMethod]
        public void TestCross598()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1598, result);
        }

        [TestMethod]
        public void TestCross599()
        {
            var result = RandomMonad.evaluateWith(new System.Random(5), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1599, result);
        }

        [TestMethod]
        public void TestCross600()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1600, result);
        }

        [TestMethod]
        public void TestCross601()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1601, result);
        }

        [TestMethod]
        public void TestCross602()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1602, result);
        }

        [TestMethod]
        public void TestCross603()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1603, result);
        }

        [TestMethod]
        public void TestCross604()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1604, result);
        }

        [TestMethod]
        public void TestCross605()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1605, result);
        }

        [TestMethod]
        public void TestCross606()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1606, result);
        }

        [TestMethod]
        public void TestCross607()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1607, result);
        }

        [TestMethod]
        public void TestCross608()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1608, result);
        }

        [TestMethod]
        public void TestCross609()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1609, result);
        }

        [TestMethod]
        public void TestCross610()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1610, result);
        }

        [TestMethod]
        public void TestCross611()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1611, result);
        }

        [TestMethod]
        public void TestCross612()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1612, result);
        }

        [TestMethod]
        public void TestCross613()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1613, result);
        }

        [TestMethod]
        public void TestCross614()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1614, result);
        }

        [TestMethod]
        public void TestCross615()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1615, result);
        }

        [TestMethod]
        public void TestCross616()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1616, result);
        }

        [TestMethod]
        public void TestCross617()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1617, result);
        }

        [TestMethod]
        public void TestCross618()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1618, result);
        }

        [TestMethod]
        public void TestCross619()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1619, result);
        }

        [TestMethod]
        public void TestCross620()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1620, result);
        }

        [TestMethod]
        public void TestCross621()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1621, result);
        }

        [TestMethod]
        public void TestCross622()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1622, result);
        }

        [TestMethod]
        public void TestCross623()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1623, result);
        }

        [TestMethod]
        public void TestCross624()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1624, result);
        }

        [TestMethod]
        public void TestCross625()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1625, result);
        }

        [TestMethod]
        public void TestCross626()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1626, result);
        }

        [TestMethod]
        public void TestCross627()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1627, result);
        }

        [TestMethod]
        public void TestCross628()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1628, result);
        }

        [TestMethod]
        public void TestCross629()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1629, result);
        }

        [TestMethod]
        public void TestCross630()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1630, result);
        }

        [TestMethod]
        public void TestCross631()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1631, result);
        }

        [TestMethod]
        public void TestCross632()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1632, result);
        }

        [TestMethod]
        public void TestCross633()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1633, result);
        }

        [TestMethod]
        public void TestCross634()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1634, result);
        }

        [TestMethod]
        public void TestCross635()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1635, result);
        }

        [TestMethod]
        public void TestCross636()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1636, result);
        }

        [TestMethod]
        public void TestCross637()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1637, result);
        }

        [TestMethod]
        public void TestCross638()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1638, result);
        }

        [TestMethod]
        public void TestCross639()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1639, result);
        }

        [TestMethod]
        public void TestCross640()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1640, result);
        }

        [TestMethod]
        public void TestCross641()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1641, result);
        }

        [TestMethod]
        public void TestCross642()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1642, result);
        }

        [TestMethod]
        public void TestCross643()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1643, result);
        }

        [TestMethod]
        public void TestCross644()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1644, result);
        }

        [TestMethod]
        public void TestCross645()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1645, result);
        }

        [TestMethod]
        public void TestCross646()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1646, result);
        }

        [TestMethod]
        public void TestCross647()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1647, result);
        }

        [TestMethod]
        public void TestCross648()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1648, result);
        }

        [TestMethod]
        public void TestCross649()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1649, result);
        }

        [TestMethod]
        public void TestCross650()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1650, result);
        }

        [TestMethod]
        public void TestCross651()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1651, result);
        }

        [TestMethod]
        public void TestCross652()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1652, result);
        }

        [TestMethod]
        public void TestCross653()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1653, result);
        }

        [TestMethod]
        public void TestCross654()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1654, result);
        }

        [TestMethod]
        public void TestCross655()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1655, result);
        }

        [TestMethod]
        public void TestCross656()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1656, result);
        }

        [TestMethod]
        public void TestCross657()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1657, result);
        }

        [TestMethod]
        public void TestCross658()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1658, result);
        }

        [TestMethod]
        public void TestCross659()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1659, result);
        }

        [TestMethod]
        public void TestCross660()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1660, result);
        }

        [TestMethod]
        public void TestCross661()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1661, result);
        }

        [TestMethod]
        public void TestCross662()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1662, result);
        }

        [TestMethod]
        public void TestCross663()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1663, result);
        }

        [TestMethod]
        public void TestCross664()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1664, result);
        }

        [TestMethod]
        public void TestCross665()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1665, result);
        }

        [TestMethod]
        public void TestCross666()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1666, result);
        }

        [TestMethod]
        public void TestCross667()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1667, result);
        }

        [TestMethod]
        public void TestCross668()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1668, result);
        }

        [TestMethod]
        public void TestCross669()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1669, result);
        }

        [TestMethod]
        public void TestCross670()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1670, result);
        }

        [TestMethod]
        public void TestCross671()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1671, result);
        }

        [TestMethod]
        public void TestCross672()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1672, result);
        }

        [TestMethod]
        public void TestCross673()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1673, result);
        }

        [TestMethod]
        public void TestCross674()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1674, result);
        }

        [TestMethod]
        public void TestCross675()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1675, result);
        }

        [TestMethod]
        public void TestCross676()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1676, result);
        }

        [TestMethod]
        public void TestCross677()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1677, result);
        }

        [TestMethod]
        public void TestCross678()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1678, result);
        }

        [TestMethod]
        public void TestCross679()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1679, result);
        }

        [TestMethod]
        public void TestCross680()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1680, result);
        }

        [TestMethod]
        public void TestCross681()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1681, result);
        }

        [TestMethod]
        public void TestCross682()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1682, result);
        }

        [TestMethod]
        public void TestCross683()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1683, result);
        }

        [TestMethod]
        public void TestCross684()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1684, result);
        }

        [TestMethod]
        public void TestCross685()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1685, result);
        }

        [TestMethod]
        public void TestCross686()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1686, result);
        }

        [TestMethod]
        public void TestCross687()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1687, result);
        }

        [TestMethod]
        public void TestCross688()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1688, result);
        }

        [TestMethod]
        public void TestCross689()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1689, result);
        }

        [TestMethod]
        public void TestCross690()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1690, result);
        }

        [TestMethod]
        public void TestCross691()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1691, result);
        }

        [TestMethod]
        public void TestCross692()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1692, result);
        }

        [TestMethod]
        public void TestCross693()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1693, result);
        }

        [TestMethod]
        public void TestCross694()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1694, result);
        }

        [TestMethod]
        public void TestCross695()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1695, result);
        }

        [TestMethod]
        public void TestCross696()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1696, result);
        }

        [TestMethod]
        public void TestCross697()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1697, result);
        }

        [TestMethod]
        public void TestCross698()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1698, result);
        }

        [TestMethod]
        public void TestCross699()
        {
            var result = RandomMonad.evaluateWith(new System.Random(6), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1699, result);
        }

        [TestMethod]
        public void TestCross700()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1700, result);
        }

        [TestMethod]
        public void TestCross701()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1701, result);
        }

        [TestMethod]
        public void TestCross702()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1702, result);
        }

        [TestMethod]
        public void TestCross703()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1703, result);
        }

        [TestMethod]
        public void TestCross704()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1704, result);
        }

        [TestMethod]
        public void TestCross705()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1705, result);
        }

        [TestMethod]
        public void TestCross706()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1706, result);
        }

        [TestMethod]
        public void TestCross707()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1707, result);
        }

        [TestMethod]
        public void TestCross708()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1708, result);
        }

        [TestMethod]
        public void TestCross709()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1709, result);
        }

        [TestMethod]
        public void TestCross710()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1710, result);
        }

        [TestMethod]
        public void TestCross711()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1711, result);
        }

        [TestMethod]
        public void TestCross712()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1712, result);
        }

        [TestMethod]
        public void TestCross713()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1713, result);
        }

        [TestMethod]
        public void TestCross714()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1714, result);
        }

        [TestMethod]
        public void TestCross715()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1715, result);
        }

        [TestMethod]
        public void TestCross716()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1716, result);
        }

        [TestMethod]
        public void TestCross717()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1717, result);
        }

        [TestMethod]
        public void TestCross718()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1718, result);
        }

        [TestMethod]
        public void TestCross719()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1719, result);
        }

        [TestMethod]
        public void TestCross720()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1720, result);
        }

        [TestMethod]
        public void TestCross721()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1721, result);
        }

        [TestMethod]
        public void TestCross722()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1722, result);
        }

        [TestMethod]
        public void TestCross723()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1723, result);
        }

        [TestMethod]
        public void TestCross724()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1724, result);
        }

        [TestMethod]
        public void TestCross725()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1725, result);
        }

        [TestMethod]
        public void TestCross726()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1726, result);
        }

        [TestMethod]
        public void TestCross727()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1727, result);
        }

        [TestMethod]
        public void TestCross728()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1728, result);
        }

        [TestMethod]
        public void TestCross729()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1729, result);
        }

        [TestMethod]
        public void TestCross730()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1730, result);
        }

        [TestMethod]
        public void TestCross731()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1731, result);
        }

        [TestMethod]
        public void TestCross732()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1732, result);
        }

        [TestMethod]
        public void TestCross733()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1733, result);
        }

        [TestMethod]
        public void TestCross734()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1734, result);
        }

        [TestMethod]
        public void TestCross735()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1735, result);
        }

        [TestMethod]
        public void TestCross736()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1736, result);
        }

        [TestMethod]
        public void TestCross737()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1737, result);
        }

        [TestMethod]
        public void TestCross738()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1738, result);
        }

        [TestMethod]
        public void TestCross739()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1739, result);
        }

        [TestMethod]
        public void TestCross740()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1740, result);
        }

        [TestMethod]
        public void TestCross741()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1741, result);
        }

        [TestMethod]
        public void TestCross742()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1742, result);
        }

        [TestMethod]
        public void TestCross743()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1743, result);
        }

        [TestMethod]
        public void TestCross744()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1744, result);
        }

        [TestMethod]
        public void TestCross745()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1745, result);
        }

        [TestMethod]
        public void TestCross746()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1746, result);
        }

        [TestMethod]
        public void TestCross747()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1747, result);
        }

        [TestMethod]
        public void TestCross748()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1748, result);
        }

        [TestMethod]
        public void TestCross749()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1749, result);
        }

        [TestMethod]
        public void TestCross750()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1750, result);
        }

        [TestMethod]
        public void TestCross751()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1751, result);
        }

        [TestMethod]
        public void TestCross752()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1752, result);
        }

        [TestMethod]
        public void TestCross753()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1753, result);
        }

        [TestMethod]
        public void TestCross754()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1754, result);
        }

        [TestMethod]
        public void TestCross755()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1755, result);
        }

        [TestMethod]
        public void TestCross756()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1756, result);
        }

        [TestMethod]
        public void TestCross757()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1757, result);
        }

        [TestMethod]
        public void TestCross758()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1758, result);
        }

        [TestMethod]
        public void TestCross759()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1759, result);
        }

        [TestMethod]
        public void TestCross760()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1760, result);
        }

        [TestMethod]
        public void TestCross761()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1761, result);
        }

        [TestMethod]
        public void TestCross762()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1762, result);
        }

        [TestMethod]
        public void TestCross763()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1763, result);
        }

        [TestMethod]
        public void TestCross764()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1764, result);
        }

        [TestMethod]
        public void TestCross765()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1765, result);
        }

        [TestMethod]
        public void TestCross766()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1766, result);
        }

        [TestMethod]
        public void TestCross767()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1767, result);
        }

        [TestMethod]
        public void TestCross768()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1768, result);
        }

        [TestMethod]
        public void TestCross769()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1769, result);
        }

        [TestMethod]
        public void TestCross770()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1770, result);
        }

        [TestMethod]
        public void TestCross771()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1771, result);
        }

        [TestMethod]
        public void TestCross772()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1772, result);
        }

        [TestMethod]
        public void TestCross773()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1773, result);
        }

        [TestMethod]
        public void TestCross774()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1774, result);
        }

        [TestMethod]
        public void TestCross775()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1775, result);
        }

        [TestMethod]
        public void TestCross776()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1776, result);
        }

        [TestMethod]
        public void TestCross777()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1777, result);
        }

        [TestMethod]
        public void TestCross778()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1778, result);
        }

        [TestMethod]
        public void TestCross779()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1779, result);
        }

        [TestMethod]
        public void TestCross780()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1780, result);
        }

        [TestMethod]
        public void TestCross781()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1781, result);
        }

        [TestMethod]
        public void TestCross782()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1782, result);
        }

        [TestMethod]
        public void TestCross783()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1783, result);
        }

        [TestMethod]
        public void TestCross784()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1784, result);
        }

        [TestMethod]
        public void TestCross785()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1785, result);
        }

        [TestMethod]
        public void TestCross786()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1786, result);
        }

        [TestMethod]
        public void TestCross787()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1787, result);
        }

        [TestMethod]
        public void TestCross788()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1788, result);
        }

        [TestMethod]
        public void TestCross789()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1789, result);
        }

        [TestMethod]
        public void TestCross790()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1790, result);
        }

        [TestMethod]
        public void TestCross791()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1791, result);
        }

        [TestMethod]
        public void TestCross792()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1792, result);
        }

        [TestMethod]
        public void TestCross793()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1793, result);
        }

        [TestMethod]
        public void TestCross794()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1794, result);
        }

        [TestMethod]
        public void TestCross795()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1795, result);
        }

        [TestMethod]
        public void TestCross796()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1796, result);
        }

        [TestMethod]
        public void TestCross797()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1797, result);
        }

        [TestMethod]
        public void TestCross798()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1798, result);
        }

        [TestMethod]
        public void TestCross799()
        {
            var result = RandomMonad.evaluateWith(new System.Random(7), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1799, result);
        }

        [TestMethod]
        public void TestCross800()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1800, result);
        }

        [TestMethod]
        public void TestCross801()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1801, result);
        }

        [TestMethod]
        public void TestCross802()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1802, result);
        }

        [TestMethod]
        public void TestCross803()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1803, result);
        }

        [TestMethod]
        public void TestCross804()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1804, result);
        }

        [TestMethod]
        public void TestCross805()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1805, result);
        }

        [TestMethod]
        public void TestCross806()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1806, result);
        }

        [TestMethod]
        public void TestCross807()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1807, result);
        }

        [TestMethod]
        public void TestCross808()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1808, result);
        }

        [TestMethod]
        public void TestCross809()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1809, result);
        }

        [TestMethod]
        public void TestCross810()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1810, result);
        }

        [TestMethod]
        public void TestCross811()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1811, result);
        }

        [TestMethod]
        public void TestCross812()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1812, result);
        }

        [TestMethod]
        public void TestCross813()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1813, result);
        }

        [TestMethod]
        public void TestCross814()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1814, result);
        }

        [TestMethod]
        public void TestCross815()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1815, result);
        }

        [TestMethod]
        public void TestCross816()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1816, result);
        }

        [TestMethod]
        public void TestCross817()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1817, result);
        }

        [TestMethod]
        public void TestCross818()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1818, result);
        }

        [TestMethod]
        public void TestCross819()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1819, result);
        }

        [TestMethod]
        public void TestCross820()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1820, result);
        }

        [TestMethod]
        public void TestCross821()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1821, result);
        }

        [TestMethod]
        public void TestCross822()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1822, result);
        }

        [TestMethod]
        public void TestCross823()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1823, result);
        }

        [TestMethod]
        public void TestCross824()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1824, result);
        }

        [TestMethod]
        public void TestCross825()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1825, result);
        }

        [TestMethod]
        public void TestCross826()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1826, result);
        }

        [TestMethod]
        public void TestCross827()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1827, result);
        }

        [TestMethod]
        public void TestCross828()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1828, result);
        }

        [TestMethod]
        public void TestCross829()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1829, result);
        }

        [TestMethod]
        public void TestCross830()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1830, result);
        }

        [TestMethod]
        public void TestCross831()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1831, result);
        }

        [TestMethod]
        public void TestCross832()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1832, result);
        }

        [TestMethod]
        public void TestCross833()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1833, result);
        }

        [TestMethod]
        public void TestCross834()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1834, result);
        }

        [TestMethod]
        public void TestCross835()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1835, result);
        }

        [TestMethod]
        public void TestCross836()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1836, result);
        }

        [TestMethod]
        public void TestCross837()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1837, result);
        }

        [TestMethod]
        public void TestCross838()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1838, result);
        }

        [TestMethod]
        public void TestCross839()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1839, result);
        }

        [TestMethod]
        public void TestCross840()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1840, result);
        }

        [TestMethod]
        public void TestCross841()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1841, result);
        }

        [TestMethod]
        public void TestCross842()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1842, result);
        }

        [TestMethod]
        public void TestCross843()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1843, result);
        }

        [TestMethod]
        public void TestCross844()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1844, result);
        }

        [TestMethod]
        public void TestCross845()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1845, result);
        }

        [TestMethod]
        public void TestCross846()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1846, result);
        }

        [TestMethod]
        public void TestCross847()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1847, result);
        }

        [TestMethod]
        public void TestCross848()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1848, result);
        }

        [TestMethod]
        public void TestCross849()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1849, result);
        }

        [TestMethod]
        public void TestCross850()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1850, result);
        }

        [TestMethod]
        public void TestCross851()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1851, result);
        }

        [TestMethod]
        public void TestCross852()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1852, result);
        }

        [TestMethod]
        public void TestCross853()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1853, result);
        }

        [TestMethod]
        public void TestCross854()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1854, result);
        }

        [TestMethod]
        public void TestCross855()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1855, result);
        }

        [TestMethod]
        public void TestCross856()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1856, result);
        }

        [TestMethod]
        public void TestCross857()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1857, result);
        }

        [TestMethod]
        public void TestCross858()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1858, result);
        }

        [TestMethod]
        public void TestCross859()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1859, result);
        }

        [TestMethod]
        public void TestCross860()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1860, result);
        }

        [TestMethod]
        public void TestCross861()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1861, result);
        }

        [TestMethod]
        public void TestCross862()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1862, result);
        }

        [TestMethod]
        public void TestCross863()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1863, result);
        }

        [TestMethod]
        public void TestCross864()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1864, result);
        }

        [TestMethod]
        public void TestCross865()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1865, result);
        }

        [TestMethod]
        public void TestCross866()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1866, result);
        }

        [TestMethod]
        public void TestCross867()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1867, result);
        }

        [TestMethod]
        public void TestCross868()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1868, result);
        }

        [TestMethod]
        public void TestCross869()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1869, result);
        }

        [TestMethod]
        public void TestCross870()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1870, result);
        }

        [TestMethod]
        public void TestCross871()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1871, result);
        }

        [TestMethod]
        public void TestCross872()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1872, result);
        }

        [TestMethod]
        public void TestCross873()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1873, result);
        }

        [TestMethod]
        public void TestCross874()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1874, result);
        }

        [TestMethod]
        public void TestCross875()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1875, result);
        }

        [TestMethod]
        public void TestCross876()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1876, result);
        }

        [TestMethod]
        public void TestCross877()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1877, result);
        }

        [TestMethod]
        public void TestCross878()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1878, result);
        }

        [TestMethod]
        public void TestCross879()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1879, result);
        }

        [TestMethod]
        public void TestCross880()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1880, result);
        }

        [TestMethod]
        public void TestCross881()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1881, result);
        }

        [TestMethod]
        public void TestCross882()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1882, result);
        }

        [TestMethod]
        public void TestCross883()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1883, result);
        }

        [TestMethod]
        public void TestCross884()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1884, result);
        }

        [TestMethod]
        public void TestCross885()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1885, result);
        }

        [TestMethod]
        public void TestCross886()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1886, result);
        }

        [TestMethod]
        public void TestCross887()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1887, result);
        }

        [TestMethod]
        public void TestCross888()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1888, result);
        }

        [TestMethod]
        public void TestCross889()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1889, result);
        }

        [TestMethod]
        public void TestCross890()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1890, result);
        }

        [TestMethod]
        public void TestCross891()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1891, result);
        }

        [TestMethod]
        public void TestCross892()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1892, result);
        }

        [TestMethod]
        public void TestCross893()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1893, result);
        }

        [TestMethod]
        public void TestCross894()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1894, result);
        }

        [TestMethod]
        public void TestCross895()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1895, result);
        }

        [TestMethod]
        public void TestCross896()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1896, result);
        }

        [TestMethod]
        public void TestCross897()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1897, result);
        }

        [TestMethod]
        public void TestCross898()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1898, result);
        }

        [TestMethod]
        public void TestCross899()
        {
            var result = RandomMonad.evaluateWith(new System.Random(8), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1899, result);
        }

        [TestMethod]
        public void TestCross900()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1900, result);
        }

        [TestMethod]
        public void TestCross901()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1901, result);
        }

        [TestMethod]
        public void TestCross902()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1902, result);
        }

        [TestMethod]
        public void TestCross903()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1903, result);
        }

        [TestMethod]
        public void TestCross904()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1904, result);
        }

        [TestMethod]
        public void TestCross905()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1905, result);
        }

        [TestMethod]
        public void TestCross906()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1906, result);
        }

        [TestMethod]
        public void TestCross907()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1907, result);
        }

        [TestMethod]
        public void TestCross908()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1908, result);
        }

        [TestMethod]
        public void TestCross909()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual0, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1909, result);
        }

        [TestMethod]
        public void TestCross910()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1910, result);
        }

        [TestMethod]
        public void TestCross911()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1911, result);
        }

        [TestMethod]
        public void TestCross912()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1912, result);
        }

        [TestMethod]
        public void TestCross913()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1913, result);
        }

        [TestMethod]
        public void TestCross914()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1914, result);
        }

        [TestMethod]
        public void TestCross915()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1915, result);
        }

        [TestMethod]
        public void TestCross916()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1916, result);
        }

        [TestMethod]
        public void TestCross917()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1917, result);
        }

        [TestMethod]
        public void TestCross918()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1918, result);
        }

        [TestMethod]
        public void TestCross919()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual1, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1919, result);
        }

        [TestMethod]
        public void TestCross920()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1920, result);
        }

        [TestMethod]
        public void TestCross921()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1921, result);
        }

        [TestMethod]
        public void TestCross922()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1922, result);
        }

        [TestMethod]
        public void TestCross923()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1923, result);
        }

        [TestMethod]
        public void TestCross924()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1924, result);
        }

        [TestMethod]
        public void TestCross925()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1925, result);
        }

        [TestMethod]
        public void TestCross926()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1926, result);
        }

        [TestMethod]
        public void TestCross927()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1927, result);
        }

        [TestMethod]
        public void TestCross928()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1928, result);
        }

        [TestMethod]
        public void TestCross929()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual2, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1929, result);
        }

        [TestMethod]
        public void TestCross930()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1930, result);
        }

        [TestMethod]
        public void TestCross931()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1931, result);
        }

        [TestMethod]
        public void TestCross932()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1932, result);
        }

        [TestMethod]
        public void TestCross933()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1933, result);
        }

        [TestMethod]
        public void TestCross934()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1934, result);
        }

        [TestMethod]
        public void TestCross935()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1935, result);
        }

        [TestMethod]
        public void TestCross936()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1936, result);
        }

        [TestMethod]
        public void TestCross937()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1937, result);
        }

        [TestMethod]
        public void TestCross938()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1938, result);
        }

        [TestMethod]
        public void TestCross939()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual3, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1939, result);
        }

        [TestMethod]
        public void TestCross940()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1940, result);
        }

        [TestMethod]
        public void TestCross941()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1941, result);
        }

        [TestMethod]
        public void TestCross942()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1942, result);
        }

        [TestMethod]
        public void TestCross943()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1943, result);
        }

        [TestMethod]
        public void TestCross944()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1944, result);
        }

        [TestMethod]
        public void TestCross945()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1945, result);
        }

        [TestMethod]
        public void TestCross946()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1946, result);
        }

        [TestMethod]
        public void TestCross947()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1947, result);
        }

        [TestMethod]
        public void TestCross948()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1948, result);
        }

        [TestMethod]
        public void TestCross949()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual4, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1949, result);
        }

        [TestMethod]
        public void TestCross950()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1950, result);
        }

        [TestMethod]
        public void TestCross951()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1951, result);
        }

        [TestMethod]
        public void TestCross952()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1952, result);
        }

        [TestMethod]
        public void TestCross953()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1953, result);
        }

        [TestMethod]
        public void TestCross954()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1954, result);
        }

        [TestMethod]
        public void TestCross955()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1955, result);
        }

        [TestMethod]
        public void TestCross956()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1956, result);
        }

        [TestMethod]
        public void TestCross957()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1957, result);
        }

        [TestMethod]
        public void TestCross958()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1958, result);
        }

        [TestMethod]
        public void TestCross959()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual5, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1959, result);
        }

        [TestMethod]
        public void TestCross960()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1960, result);
        }

        [TestMethod]
        public void TestCross961()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1961, result);
        }

        [TestMethod]
        public void TestCross962()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1962, result);
        }

        [TestMethod]
        public void TestCross963()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1963, result);
        }

        [TestMethod]
        public void TestCross964()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1964, result);
        }

        [TestMethod]
        public void TestCross965()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1965, result);
        }

        [TestMethod]
        public void TestCross966()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1966, result);
        }

        [TestMethod]
        public void TestCross967()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1967, result);
        }

        [TestMethod]
        public void TestCross968()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1968, result);
        }

        [TestMethod]
        public void TestCross969()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual6, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1969, result);
        }

        [TestMethod]
        public void TestCross970()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1970, result);
        }

        [TestMethod]
        public void TestCross971()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1971, result);
        }

        [TestMethod]
        public void TestCross972()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1972, result);
        }

        [TestMethod]
        public void TestCross973()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1973, result);
        }

        [TestMethod]
        public void TestCross974()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1974, result);
        }

        [TestMethod]
        public void TestCross975()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1975, result);
        }

        [TestMethod]
        public void TestCross976()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1976, result);
        }

        [TestMethod]
        public void TestCross977()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1977, result);
        }

        [TestMethod]
        public void TestCross978()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1978, result);
        }

        [TestMethod]
        public void TestCross979()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual7, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1979, result);
        }

        [TestMethod]
        public void TestCross980()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1980, result);
        }

        [TestMethod]
        public void TestCross981()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1981, result);
        }

        [TestMethod]
        public void TestCross982()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1982, result);
        }

        [TestMethod]
        public void TestCross983()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1983, result);
        }

        [TestMethod]
        public void TestCross984()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1984, result);
        }

        [TestMethod]
        public void TestCross985()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1985, result);
        }

        [TestMethod]
        public void TestCross986()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1986, result);
        }

        [TestMethod]
        public void TestCross987()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1987, result);
        }

        [TestMethod]
        public void TestCross988()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1988, result);
        }

        [TestMethod]
        public void TestCross989()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual8, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1989, result);
        }

        [TestMethod]
        public void TestCross990()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual0));
            CollectionAssert.AreEqual(IndividualsResults.result1990, result);
        }

        [TestMethod]
        public void TestCross991()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual1));
            CollectionAssert.AreEqual(IndividualsResults.result1991, result);
        }

        [TestMethod]
        public void TestCross992()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual2));
            CollectionAssert.AreEqual(IndividualsResults.result1992, result);
        }

        [TestMethod]
        public void TestCross993()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual3));
            CollectionAssert.AreEqual(IndividualsResults.result1993, result);
        }

        [TestMethod]
        public void TestCross994()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual4));
            CollectionAssert.AreEqual(IndividualsResults.result1994, result);
        }

        [TestMethod]
        public void TestCross995()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual5));
            CollectionAssert.AreEqual(IndividualsResults.result1995, result);
        }

        [TestMethod]
        public void TestCross996()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual6));
            CollectionAssert.AreEqual(IndividualsResults.result1996, result);
        }

        [TestMethod]
        public void TestCross997()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual7));
            CollectionAssert.AreEqual(IndividualsResults.result1997, result);
        }

        [TestMethod]
        public void TestCross998()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual8));
            CollectionAssert.AreEqual(IndividualsResults.result1998, result);
        }

        [TestMethod]
        public void TestCross999()
        {
            var result = RandomMonad.evaluateWith(new System.Random(9), GeneticAlgorithm.cross(TestIndividuals.individual9, TestIndividuals.individual9));
            CollectionAssert.AreEqual(IndividualsResults.result1999, result);
        }

    }
}
