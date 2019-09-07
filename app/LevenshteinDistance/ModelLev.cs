using System;
using System.Collections.Generic;

namespace level.app.LevenshteinDistance
{
    public class ModelLev
    {
        public string target { get; set; }
        public double distance { get; set; }
        public double similarity { get; set; }

        public override string ToString()
        {
            return $"{target}\n" +
                $"Distance: {distance:F2} | Similarity: {similarity:F2}%";
        }

    }

    public class ModelResponse
    {
        public string reference { get; set; }
        public List<ModelLev> results { get; set; }

    }

}