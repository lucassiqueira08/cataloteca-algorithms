using System.Collections.Generic;

namespace cataloteca.algorithms.LevenshteinDistance
{
    public class LevenshteinInput
    {

        public string reference = string.Empty;
        public List<string> target;

        /// <summary>
        /// Sets the entry point for the application.
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="target"></param>
        public LevenshteinInput(string reference, List<string> target)
        {
            this.reference = reference;
            this.target = target;
        }

        /// <summary>
        /// Function that returns the Levenshtein calculation returning distance and similarity
        /// </summary>
        /// <param name="similarity"></param>
        /// <param name="distance"></param>
        /// <returns>Object with reference and all distance and similarity results</returns>
        public Response CallLevenstheinCalc(bool distance = true, bool similarity = true)
        {
            var levenLogic = new LevenshteinLogic(reference, target);
            return levenLogic.Calculate(distance, similarity);
        }

    };

}
