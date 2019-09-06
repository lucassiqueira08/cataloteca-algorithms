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

        private List<string> result;

        public LevenstheinCalc(string reference, List<string> target)
        {
            this.reference = reference;
            this.target = target;

        }

        public void Calculate(string reference, List<string> target)
        {
            Console.WriteLine("Ambos");
            foreach (string element in target)
            {

                divisor = GetDivisor(reference, element);

                var calculator = new LevenshteinOutputDist();
                var distance = calculator.Distance(reference, element);
                // Retorna distancia e similaridade das strings
            }
        }
        public void Distance(string reference, List<string> target)
        {
            Console.WriteLine("Distance");
            foreach (string element in target)
            {

                divisor = GetDivisor(reference, element);

                var calculator = new LevenshteinOutputDist();
                var distance = calculator.Distance(reference, element);
                // Retorna distancia das strings
            }


        }
        public void Similarity(string reference, List<string> target)
        {
            Console.WriteLine("Similarity");
            foreach (string element in target)
            {

                divisor = GetDivisor(reference, element);

                var calculator = new LevenshteinOutputDist();
                var distance = calculator.Distance(reference, element);
                // Retorna similaridade das strings
            }
        }

        public double GetDivisor(string reference, string element)
        {
            if (reference.Length > element.Length)
            {

                return Convert.ToDouble(reference.Length);
            }
            else
            {
                return Convert.ToDouble(element.Length);
            };
        }

    }
}
