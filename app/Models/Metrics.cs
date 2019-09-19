using System;
using System.Collections.Generic;

namespace cataloteca.algorithms.LevenshteinDistance
{
    public class Metrics
    {
        /// <summary>
        /// Template with the metrics that each result should contain.
        /// - Target: String Compared
        /// - Distance: Double offset of string compared to reference
        /// - Similarity: Double similarity of string compared to reference
        /// </summary>
        public string Target { get; set; }
        public double Distance { get; set; }
        public double Similarity { get; set; }

        public override string ToString()
        {
            return $"{Target}\n" +
                $"Distance: {Distance:F2} | Similarity: {Similarity:F2}%";
        }

    }

}