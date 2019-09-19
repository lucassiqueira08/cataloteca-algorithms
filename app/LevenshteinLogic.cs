using System;
using System.Collections.Generic;

namespace cataloteca.algorithms.LevenshteinDistance
{
    internal class LevenshteinLogic
    {
        private readonly string _reference = string.Empty;
        private readonly List<string> _target;
        private double _divisor;

        /// <summary>
        /// Responsible for the logic of calculation
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="target"></param>
        internal LevenshteinLogic(string reference, List<string> target)
        {
            _reference = reference;
            _target = target;

        }

        /// <summary>
        ///  Responsible for calling the distance and similarity calculation and setting the response
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="similarity"></param>
        /// <returns></returns>
        internal Response Calculate(bool distance = true, bool similarity = true)
        {
            var calculator = new LevenshteinCalculator();
            List<Metrics> result = new List<Metrics>();

            foreach (string element in _target)
            {
                _divisor = GetDivisor(_reference, element);
                var distanceValue = calculator.Distance(_reference, element);
                var similarityValue = calculator.Similarity(distanceValue, _divisor);

                var model = new Metrics
                {
                    Target = element
                };

                if (distance)
                {
                    model.Distance = distanceValue;
                }

                if (similarity)
                {
                    model.Similarity = similarityValue;
                }


                result.Add(model);
            }
            var output = new LevenshteinOutput(_reference, result);
            return output.Response();
        }
 
        /// <summary>
        /// Responsible for obtaining the divisor used to calculate similarity
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="element"></param>
        /// <returns>A divisor value converted to double</returns>
        internal double GetDivisor(string reference, string element)
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
