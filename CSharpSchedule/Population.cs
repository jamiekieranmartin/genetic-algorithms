using System;
using System.Collections.Generic;

namespace CAB402.CSharp
{
    /// <summary>
    /// A collection of scored individuals that make up a generation
    /// </summary>
    public class Population : List<ScoredIndividual>
    {
        #region Constructors
        /// <summary>
        /// Creates a new empty population
        /// </summary>
        public Population() : base() { }

        /// <summary>
        /// Creates a population with the given ScoredIndividuals 
        /// </summary>
        /// <param name="scoredIndividuals">ScoredIndividuals to initiate with</param>
        public Population(IEnumerable<ScoredIndividual> scoredIndividuals) : base(scoredIndividuals) { }
        #endregion
        #region Methods
        /// <summary>
        /// Retrieves the fitest from the population
        /// </summary>
        /// <returns>The fitest ScoredIndividual</returns>
        public ScoredIndividual Fitest()
        {
            ScoredIndividual fitest = this[0];

            foreach (ScoredIndividual s in this)
            {
                if (fitest.Item2 < s.Item2)
                {
                    fitest = s;
                }
            }

            return fitest;
        }

        /// <summary>
        /// Retrieves the Individual tournament winner
        /// </summary>
        /// <returns>The Individual tournament winner</returns>
        public Individual TournamentWinner() => Fitest().Item1;

        /// <summary>
        /// Selects two random Individuals and returns the fitest
        /// </summary>
        /// <returns>The Individual</returns>
        public Individual TournamentSelect()
        {
            var (a, aScore) = PickRandom();
            var (b, bScore) = PickRandom();

            return aScore >= bScore ? a : b;
        }

        /// <summary>
        /// Creates a new population that consists of all of the children, plus the 10 best individuals from the previous generation.
        /// </summary>
        /// <param name="children">The children Population</param>
        /// <returns>The new Population</returns>
        public Population ElitismSelection(Population children)
        {
            Population sorted = new Population();

            foreach (ScoredIndividual s in this)
                sorted.Add(s);

            sorted.Sort((a, b) => b.Item2.CompareTo(a.Item2));
            List<ScoredIndividual> population = sorted.GetRange(0, 10);
            population.AddRange(children);
            return new Population(population);
        }

        /// <summary>
        /// Generates a child by first randomly choosing two parents using tournament selection,
        /// crossing their genes and then optionally mutate the resulting genes.
        /// </summary>
        /// <param name="fitnessFunction">The fitnessFunction to score an Individual</param>
        /// <returns>The procreated ScoredIndividual</returns>
        public ScoredIndividual Procreate(Microsoft.FSharp.Core.FSharpFunc<int[], double> fitnessFunction)
        {
            Individual a = TournamentSelect();
            Individual b = TournamentSelect();

            return a.Cross(b).PossiblyMutate().Score(fitnessFunction);
        }

        /// <summary>
        /// Creates a new generation by creating the specified number of children through procreation and then 
        /// applying elitism selection to create the population of the next generation
        /// </summary>
        /// <param name="fitnessFunction">The fitnessFunction to score an Individual</param>
        /// <param name="childPopulationLimit">The limit of the new children population</param>
        /// <returns>The evolved child population</returns>
        public Population EvolveOneGeneration(Microsoft.FSharp.Core.FSharpFunc<int[], double> fitnessFunction, int childPopulationLimit)
        {
            Population children = new Population();

            for (int i = 0; i < childPopulationLimit; i++)
            {
                children.Add(Procreate(fitnessFunction));
            }

            return ElitismSelection(children);
        }

        /// <summary>
        /// Picks a random ScoredIndividual from the Population
        /// </summary>
        /// <returns>The random ScoredIndividual</returns>
        public ScoredIndividual PickRandom() => this[CAB402.CSharp.Random.random.Next(Count)];
        #endregion
        #region Static Methods
        /// <summary>
        /// Randomly generate a population containing the specified number of individuals,
        /// each with the specified number of genes.
        /// </summary>
        /// <param name="fitnessFunction">The fitnessFunction to score an Individual</param>
        /// <param name="numberGenes">The number of genes</param>
        /// <param name="numberIndividuals">The number of individuals</param>
        /// <returns>The random Populations</returns>
        public static Population RandomIndividuals(Microsoft.FSharp.Core.FSharpFunc<int[], double> fitnessFunction, int numberGenes, int numberIndividuals)
        {
            Population population = new Population();

            for (int i = 0; i < numberIndividuals; i++)
            {
                ScoredIndividual scoredIndividual = Individual.Random(numberGenes).Score(fitnessFunction);
                population.Add(scoredIndividual);
            }

            return population;
        }
        #endregion
    }
}
