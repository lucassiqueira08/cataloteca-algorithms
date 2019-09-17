using System.Collections.Generic;

namespace cataloteca.algorithms.LevenshteinDistance
{
    public class Input {

        public string reference = string.Empty;
        public List<string> target;

        public Input(string reference, List<string> target)
        {
            this.reference = reference;
            this.target = target;
        }

        public Response CallLevenstheinCalc()
        {
            var levenLogic = new Logic(reference, target);
            return levenLogic.Calculate();
        }

        public Response CallLevenstheinSimilarity()
        {
            var levenLogic = new Logic(reference, target);
            return levenLogic.Similarity();
        }

        public Response CallLevenstheinDistance()
        {
            var levenLogic = new Logic(reference, target);
            return levenLogic.Distance();
        }
    };

}
