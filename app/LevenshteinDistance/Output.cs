using System;
using System.Collections.Generic;
using System.Text;
using level.app.LevenshteinDistance;

namespace level.app.LevenshteinDistance
{
    class Output
    {
        private readonly string reference;
        private List<string> results;

        public Output(string reference, List<string> results)
        {
            this.reference = reference;
            this.results = results;
            System.Console.WriteLine(reference);
            System.Console.WriteLine(results);
        }
    }
}
