using System;

namespace level.app.LevenshteinDistance
{
    public class ModelLev
    {
        public double distance { get; set; }
        public double similarity { get; set; }

        public override string ToString()
        {
            return $"Distance: {distance:F2} | Similarity: {similarity:F2}%";
        }
    }

}