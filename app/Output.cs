﻿using System.Collections.Generic;

namespace cataloteca.algorithms.LevenshteinDistance
{
    public class Output
    {
        private string _reference;
        private List<Metrics> _result;

        public Output(string reference, List<Metrics> result)
        {
            this._reference = reference;
            this._result = result;
        }

        public Response Response()
        {
            var response = new Response()
            {
                Reference = _reference,
                Results = _result
            };

            return response;
        }

    }
}
