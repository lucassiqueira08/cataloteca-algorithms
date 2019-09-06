using DuoVia.FuzzyStrings;
using System;
using System.Collections.Generic;
using System.Text;

namespace level.app.LevenshteinDistance
{
    public class LevenstheinCalc
    {
        private readonly string reference = string.Empty;
        private readonly List<string> target;
        private double divisor;

        public LevenstheinCalc(string reference, List<string> target)
        {
            this.reference = reference;
            this.target = target;

        }

        public void Calculate(string reference, List<string> target)
        {
            Console.WriteLine("Calculando");
            foreach (string element in target)
            {
                if (reference.Length == 0 || element.Length == 0)
                {
                  // Retorna distancia 100% e similaridade 0%
                };

                if (reference.Length > element.Length)
                {

                    divisor = Convert.ToDouble(reference.Length);
                }
                else
                {
                    divisor = Convert.ToDouble(element.Length);
                };

                var calculator = new LevenshteinOutputDist();

                var distance = calculator.Distance(reference, element);
                var similarity = calculator.Similarity(distance, divisor);

                // Retorna distancia e similaridade das strings
            }

          
        }
    }
}
