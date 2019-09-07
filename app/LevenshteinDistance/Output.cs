using System;
using System.Collections.Generic;
using System.Text;
using level.app.LevenshteinDistance;

namespace level.app.LevenshteinDistance
{
    class Output
    {
        private readonly string reference;
        private List<ModelLev> results;

        public Output(string reference, List<ModelLev> results)
        {
            this.reference = reference;
            this.results = results;
            System.Console.WriteLine(reference);
            results.ForEach(Console.WriteLine);
        }
    }
}
