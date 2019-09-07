using System;
using System.Collections.Generic;

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
            List<ModelLev> result = new List<ModelLev>();

            Console.WriteLine("Ambos");
            Console.WriteLine("--------------------");
            foreach (string element in target)
            {
                divisor = GetDivisor(reference, element);
                var distance = calculator.Distance(reference, element);
                var similarity = calculator.Similarity(distance, divisor);

                var model = new ModelLev();
                model.distance = distance;
                model.similarity = similarity;

                result.Add(model);
            }
            var output = new Output(reference, result);
            return output;
            // Retorna distancia e similaridade das strings
        }

        public object Distance(string reference, List<string> target)
        {
            var calculator = new Calc();
            var result = new List<ModelLev>();

            Console.WriteLine("Distance");
            foreach (string element in target)
            {
                divisor = GetDivisor(reference, element);

                var distance = calculator.Distance(reference, element);

                var model = new ModelLev();
                model.distance = distance;

                result.Add(model);
            }
            // Retorna distancia das strings
            var output = new Output(reference, result);
            return output;
        }

        public object Similarity(string reference, List<string> target)
        {
            var calculator = new Calc();
            var result = new List<ModelLev>();

            Console.WriteLine("Similarity");
            foreach (string element in target)
            {

                divisor = GetDivisor(reference, element);

                var distance = calculator.Distance(reference, element);
                var similarity = calculator.Similarity(distance, divisor);

                var model = new ModelLev();
                model.distance = distance;
                model.similarity = similarity;

                result.Add(model);
            }
            // Retorna similaridade das strings
            var output = new Output(reference, result);
            return output;
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
