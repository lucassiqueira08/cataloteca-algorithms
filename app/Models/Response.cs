using System;
using System.Collections.Generic;
using System.Text;

namespace cataloteca.algorithms.LevenshteinDistance
{
    public class Response
    {
        public string Reference { get; set; }
        public List<Metrics> Results { get; set; }

    }
}
