using DuoVia.FuzzyStrings;
using System;
using System.Collections.Generic;
using System.Text;

namespace level.app.LevenshteinDistance
{
    public class Logic
    {
        private readonly string reference = string.Empty;
        private readonly List<string> target;
        private double divisor;

        public Logic(string reference, List<string> target)
        {
            this.reference = reference;
            this.target = target;

        }

        public object Calculate(string reference, List<string> target)
        {
            var calculator = new Calc();
            var result = List<ModelLev>();

            Console.WriteLine("Ambos");
            foreach (string element in target)
            {
                divisor = GetDivisor(reference, element);
                var distance = calculator.Distance(reference, element);
                var similarity = calculator.Similarity(distance, divisor);

                var model = ModelLev();
                model.distance = distance;
                model.similarity = similarity;

                this.result.Add(model);
            }
            return Output(reference, result);
            // Retorna distancia e similaridade das strings
        }

        public void Distance(string reference, List<string> target)
        {
            var calculator = new Calc();
            var result = List<ModelLev>();

            Console.WriteLine("Distance");
            foreach (string element in target)
            {
                divisor = GetDivisor(reference, element);

                var distance = calculator.Distance(reference, element);

                var model = ModelLev();
                model.distance = distance;

                this.result.Add(model);
            }
            // Retorna distancia das strings
            return Output(reference, result);
        }

        public void Similarity(string reference, List<string> target)
        {
            var calculator = new Calc();
            var result = List<ModelLev>();

            Console.WriteLine("Similarity");
            foreach (string element in target)
            {

                divisor = GetDivisor(reference, element);

                var distance = calculator.Distance(reference, element);
                var similarity = calculator.Similarity(distance, divisor);

                var model = ModelLev();
                model.distance = distance;
                model.similarity = similarity;

                this.result.Add(model);
            }
            // Retorna similaridade das strings
            return Output(reference, result);
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
