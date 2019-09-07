using System;
using System.Collections.Generic;
using System.Text;
using level.app.LevenshteinDistance;

namespace level.app.LevenshteinDistance
{
    public class Output
    {
        public string reference;
        private List<ModelLev> result;

        public Output(string reference, List<ModelLev> result)
        {
            this.reference = reference;
            this.result = result;
        }

        public object Response()
        {
            var response = new ModelResponse();
            response.reference = reference;
            response.results = result;

            return response;
        }

    }
}
