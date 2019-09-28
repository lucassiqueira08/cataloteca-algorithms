using DuoVia.FuzzyStrings;

namespace cataloteca.algorithms.LevenshteinDistance
{
    class LevenshteinCalculator
    {
        /// <summary>
        /// Responsible for calculating similarity
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="divisor"></param>
        /// <returns>Returns percentage value of string similarity</returns>
        internal double Similarity(double distance, double divisor)
        {
            var similarity = 100.00 - ((distance * 100.00) / divisor);
            return similarity;
        }

        /// <summary>
        /// Return value of distance between strings
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="element"></param>
        /// <returns>The value of the distance between strings in double</returns>
        internal double Distance(string reference, string element)
        {
            var distance = 0.00;
            if (reference.Length == 0 || element.Length == 0) {
                distance = 100.00;
            } else {
                distance = reference.LevenshteinDistance(element);
            }
            return distance;
        }
    }
}
