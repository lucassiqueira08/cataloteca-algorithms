using DuoVia.FuzzyStrings;
using System;
using System.Collections.Generic;
using System.Text;

namespace level.app.LevenshteinDistance
{
    class LevenshteinOutputDist
    {

        public double Similarity(double distance, double divisor)
        {
            var similarity = 100.00 - ((distance * 100.00) / divisor);
            return similarity;
        }

        public double Distance(string reference, string element)
        {
            var distance = reference.LevenshteinDistance(element);
            return distance;
        }
    }
}
