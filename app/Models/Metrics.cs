using System;
using System.Collections.Generic;

namespace cataloteca.algorithms.LevenshteinDistance
{
    public class Metrics
    {
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