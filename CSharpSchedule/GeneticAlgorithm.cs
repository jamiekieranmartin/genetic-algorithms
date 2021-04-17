using System;
using System.Collections.Generic;

namespace CAB402.CSharp
{
    public class GeneticAlgorithm
    {
        /// <summary>
        /// Starting with the specified initial population, evolve generation by generation (forever).
        /// For each population, the fitest individual from each generation.
        /// Due to elitism selection, the fitest individual in each succcessive generation should be at least as good as the previous generation. 
        /// </summary>
        /// <param name="fitnessFunction">The fitnessFunction to score an Individual</param>
        /// <param name="initialPopulation">The initial Population</param>
        /// <param name="childPopulationLimit">The limit of the child Population</param>
        /// <returns>Yields the fitest from each generation</returns>
        private static IEnumerable<Tuple<int[], double>> evolveForever(Microsoft.FSharp.Core.FSharpFunc<int[], double> fitnessFunction, Population initialPopulation, int childPopulationLimit)
        {
            Population population = initialPopulation;

            for (; ; )
            {
                yield return population.Fitest().GetTuple();
                population = population.EvolveOneGeneration(fitnessFunction, childPopulationLimit);
            }
        }

        /// <summary>
        /// Generates an initial Population and then yields 
        /// </summary>
        /// <param name="fitnessFunction">The fitnessFunction to score an Individual</param>
        /// <param name="numberOfGenes">The length of the genes</param>
        /// <param name="numerOfIndividuals">The number of Individuals</param>
        /// <returns>Yields the fitest from each generation</returns>
        public static IEnumerable<Tuple<int[], double>> Optimize(Microsoft.FSharp.Core.FSharpFunc<int[], double> fitnessFunction, int numberOfGenes, int numerOfIndividuals)
        {
            Population initialPopulation = Population.RandomIndividuals(fitnessFunction, numberOfGenes, numerOfIndividuals);
            return evolveForever(fitnessFunction, initialPopulation, numerOfIndividuals);
        }
    }
}
