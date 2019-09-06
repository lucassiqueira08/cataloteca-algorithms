using System;
using System.Collections.Generic;
using System.Text;

namespace level.app.LevenshteinDistance
{
    public class LevenstheinCalc
    {
        private readonly string reference = string.Empty;
        private readonly List<string> target;

        public LevenstheinCalc(string reference, List<string> target)
        {
            this.reference = reference;
            this.target = target;
        }

        public void Calculate(string reference, List<string> target)
        {
            Console.WriteLine("Calculando");

        }
    }
}
