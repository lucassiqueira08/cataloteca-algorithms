﻿using System;
using System.Collections.Generic;

namespace cataloteca.algorithms.LevenshteinDistance
{
    public class LevenshteinLogic
    {
        private readonly string _reference = string.Empty;
        private readonly List<string> _target;
        private double _divisor;

        public LevenshteinLogic(string reference, List<string> target)
        {
            this._reference = reference;
            this._target = target;

        }

        public Response Calculate()
        {
            var calculator = new LevenshteinCalculator();
            List<Metrics> result = new List<Metrics>();

            foreach (string element in _target)
            {
                _divisor = GetDivisor(_reference, element);
                var distance = calculator.Distance(_reference, element);
                var similarity = calculator.Similarity(distance, _divisor);

                var model = new Metrics
                {
                    Distance = distance,
                    Similarity = similarity,
                    Target = element
                };

                result.Add(model);
            }
            var output = new LevenshteinOutput(_reference, result);
            return output.Response();
        }

        public Response Distance()
        {
            var calculator = new LevenshteinCalculator();
            var result = new List<Metrics>();

            foreach (string element in _target)
            {
                _divisor = GetDivisor(_reference, element);

                var distance = calculator.Distance(_reference, element);

                var model = new Metrics
                {
                    Distance = distance
                };

                result.Add(model);
            }
            var output = new LevenshteinOutput(_reference, result);
            return output.Response();
        }

        public Response Similarity()
        {
            var calculator = new LevenshteinCalculator();
            var result = new List<Metrics>();

            foreach (string element in _target)
            {

                _divisor = GetDivisor(_reference, element);

                var distance = calculator.Distance(_reference, element);
                var similarity = calculator.Similarity(distance, _divisor);

                var model = new Metrics
                {
                    Similarity = similarity
                };

                result.Add(model);
            }
            var output = new LevenshteinOutput(_reference, result);
            return output.Response();
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