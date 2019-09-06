using System;
using System.Collections.Generic;
using System.Text;

namespace level.app.LevenshteinDistance
{
    class LevenshteinOutputDist
    {
        public int distance;
        public double similarity;

        public LevenshteinOutputDist(int distance, double similarity)
        {
            this.distance = distance;
            this.similarity = similarity;
        }
    }
}
