using System;
using System.Collections.Generic;
using System.Text;

namespace cataloteca.algorithms.LevenshteinDistance
{
    public class Response
    {
        /// <summary>
        /// Template with the object to be returned.
        /// - Reference: String Base Comparison
        /// - Results: List with all compared strings and their respective distances and similarity
        /// </summary>
        public string Reference { get; set; }
        public List<Metrics> Results { get; set; }

    }
}
