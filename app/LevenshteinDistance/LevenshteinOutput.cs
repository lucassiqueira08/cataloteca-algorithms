using System;
using System.Collections.Generic;
using System.Text;
using level.app.LevenshteinDistance;

namespace level.app.LevenshteinDistance
{
    class LevenstheinOutput
    {
        private readonly string reference;
        private List<LevenshteinOutputDist> results;

        public LevenstheinOutput(string reference, List<LevenshteinOutputDist> results)
        {
            this.reference = reference;
            this.results = results;
        }
    }
}
