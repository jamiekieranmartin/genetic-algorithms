using System;

namespace CAB402.CSharp
{
    /// <summary>
    /// The genes of an individual together with an assessment of the fitness of that individual
    /// </summary>
    public class ScoredIndividual : Tuple<Individual, double>
    {
        #region Constructors
        /// <summary>
        /// Initiliases a ScoredIndividual
        /// </summary>
        /// <param name="item1">The Individuals genes</param>
        /// <param name="item2">The score of the Individual</param>
        public ScoredIndividual(Individual item1, double item2) : base(item1, item2) { }
        #endregion
        #region Static Methods
        public Tuple<int[], double> GetTuple() => (Item1.ToArray(), Item2).ToTuple();
        #endregion
    }
}
