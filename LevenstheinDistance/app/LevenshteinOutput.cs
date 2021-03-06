﻿using System.Collections.Generic;

namespace cataloteca.algorithms.LevenshteinDistance
{
    internal class LevenshteinOutput
    {
        private string _reference;
        private List<Metrics> _result;
        /// <summary>
        /// Responsible for assembling the output
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="result"></param>
        internal LevenshteinOutput(string reference, List<Metrics> result)
        {
            this._reference = reference;
            this._result = result;
        }
        /// <summary>
        /// Responsible for returning a response object with reference string and result list
        /// </summary>
        /// <returns>Response object with reference string and result list</returns>
        internal Response Response()
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
