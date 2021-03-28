using Microsoft.FSharp.Core;
using CAB402.FSharp;

namespace GeneticAlgorithmUnitTests
{
    public class TestFitnessFunctions
    {
        static public TSP.City[] cities10 = RandomMonad.evaluateWith(new System.Random(0), TSP.generateRandomCities(10));
        static public FSharpFunc<int[],double> fitness10 = TSP.TSPCost(cities10);
    }
}
