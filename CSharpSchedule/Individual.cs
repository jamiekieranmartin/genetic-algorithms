using System;
using System.Collections.Generic;

namespace CAB402.CSharp
{
    /// <summary>
    /// The genes of one individual within the population. Each gene is an integer.
    /// </summary>
    public class Individual
    {
        private List<int> genes { get; set; }

        #region Constructors
        /// <summary>
        /// Initialises an Individual with an empty gene sequence
        /// </summary>
        public Individual()
        {
            genes = new List<int>();
        }

        /// <summary>
        /// Initialises an Individual using the given genes
        /// </summary>
        /// <param name="this">The genes</param>
        public Individual(IEnumerable<int> genes)
        {
            this.genes = new List<int>(genes);
        }
        #endregion
        #region Methods
        /// <summary>
        /// Combine the genes of this Individual and a partner at a randonly choosen splitpoint.
        /// The splitpoint is chosen so that both parents provide at least one gene to the child
        /// </summary>
        /// <param name="partner">The Individual to cross with</param>
        /// <returns>The crossed Individual</returns>
        public Individual Cross(Individual partner)
        {
            int splitPoint = CAB402.CSharp.Random.random.Next(1, partner.Count());
            return crossAt(partner, splitPoint);
        }

        /// <summary>
        /// Combine the genes of this Individual and a partner based on the given splitPoint
        /// </summary>
        /// <param name="partner">The Individual to cross with</param>
        /// <param name="splitPoint">The split point to split at</param>
        /// <returns>The crossed Individual</returns>
        private Individual crossAt(Individual partner, int splitPoint)
        {
            Individual child = new Individual(genes.GetRange(0, splitPoint));

            foreach (int gene in partner)
                if (child.TrueForAll(x => x != gene))
                    child.Add(gene);

            return child;
        }

        /// <summary>
        /// Perform a reverse mutation based on two randomly chosen split points
        /// </summary>
        /// <returns>The mutated Individual</returns>
        public Individual ReverseMutate()
        {
            int firstIndex = CAB402.CSharp.Random.random.Next(0, genes.Count - 1);
            int secondIndex = CAB402.CSharp.Random.random.Next(firstIndex + 1, genes.Count);
            return reverseMutateAt(firstIndex, secondIndex);
        }

        /// <summary>
        /// Return a mutated version of the original genes.
        /// The sequence of genes is split into 3 sections, a start, middle and end, based on the 2 provided indexes
        /// </summary>
        /// <param name="firstIndex">The first index</param>
        /// <param name="secondIndex">The second index</param>
        /// <returns>The mutated Individual</returns>
        private Individual reverseMutateAt(int firstIndex, int secondIndex)
        {
            List<int> head = genes.GetRange(0, firstIndex);
            List<int> mid = genes.GetRange(firstIndex, secondIndex - firstIndex);
            List<int> tail = genes.GetRange(secondIndex, genes.Count - head.Count - mid.Count);

            mid.Reverse();
            head.AddRange(mid);
            head.AddRange(tail);

            return new Individual(head);
        }

        /// <summary>
        /// Perform a reverse mutation of the given genes with probability 0.15,
        /// otherwise leave the sequence unaltered.
        /// </summary>
        /// <returns>The possibly mutated Individual</returns>
        public Individual PossiblyMutate()
        {
            double MutateProbability = 0.15;
            return CAB402.CSharp.Random.random.NextDouble() <= MutateProbability ? ReverseMutate() : this;
        }

        /// <summary>
        /// Creates a scored individual by applying the fitness function to assess the fitness of the given genes.
        /// </summary>
        /// <param name="fitnessFunction">The fitnessFunction to score an Individual</param>
        /// <returns>The ScoredIndividual</returns>
        public ScoredIndividual Score(Microsoft.FSharp.Core.FSharpFunc<int[], double> fitnessFunction)
        {
            return new ScoredIndividual(this, fitnessFunction.Invoke(ToArray()));
        }

        /// <summary>
        /// Returns genes count
        /// </summary>
        /// <returns>The Count</returns>
        public int Count() => genes.Count;

        /// <summary>
        /// Returns an array of the genes list
        /// </summary>
        /// <returns>The array of genes</returns>
        public int[] ToArray() => genes.ToArray();

        /// <summary>
        /// Adds a gene to the list
        /// </summary>
        /// <param name="gene">The gene to add</param>
        public void Add(int gene) => genes.Add(gene);

        /// <summary>
        /// Returns the index of a given gene
        /// </summary>
        /// <param name="gene">The gene to search for</param>
        /// <returns>The index of i</returns>
        public int IndexOf(int gene) => genes.IndexOf(gene);

        /// <summary>
        /// Passes the GetEnumerator to the genes list
        /// </summary>
        /// <returns>The Enumerator of genes</returns>
        public IEnumerator<int> GetEnumerator() => genes.GetEnumerator();

        /// <summary>
        /// Applies the given Predicate to each gene in genes. Returns true if all items succeed
        /// </summary>
        /// <param name="func">The Predicate function</param>
        /// <returns>True if all items pass, otherwise false</returns>
        public bool TrueForAll(Predicate<int> func) => genes.TrueForAll(func);
        #endregion
        #region Static Methods
        /// <summary>
        /// Generates a random Individual
        /// </summary>
        /// <param name="numberGenes">The length of the genes</param>
        /// <returns>The new Individual</returns>
        public static Individual Random(int numberGenes)
        {
            Individual individual = new Individual();

            while (individual.Count() != numberGenes)
            {
                int i = CAB402.CSharp.Random.random.Next(0, numberGenes);

                if (individual.IndexOf(i) != -1) continue;

                individual.Add(i);
            }

            return individual;
        }
        #endregion
    }
}
