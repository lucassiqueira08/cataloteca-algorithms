using DuoVia.FuzzyStrings;
using System;
using System.Collections.Generic;
using System.Text;

namespace level.app.LevenshteinDistance
{
    class Calc
    {

        public double Similarity(double distance, double divisor)
        {
            var similarity = 100.00 - ((distance * 100.00) / divisor);
            return similarity;
        }

        public double Distance(string reference, string element)
        {
            if (reference.Length == 0 || element.Length == 0) {
                var distance = 100.00;
            } else {
                var distance = reference.LevenshteinDistance(element);
            }
            return distance;
        }
    }
}
