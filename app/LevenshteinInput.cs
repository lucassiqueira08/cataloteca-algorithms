using System.Collections.Generic;

namespace cataloteca.algorithms.LevenshteinDistance
{
    public class LevenshteinInput
    {

        public string reference = string.Empty;
        public List<string> target;

        public LevenshteinInput(string reference, List<string> target)
        {
            this.reference = reference;
            this.target = target;
        }

        public Response CallLevenstheinCalc()
        {
            var levenLogic = new LevenshteinLogic(reference, target);
            return levenLogic.Calculate();
        }

        public Response CallLevenstheinSimilarity()
        {
            var levenLogic = new LevenshteinLogic(reference, target);
            return levenLogic.Similarity();
        }

        public Response CallLevenstheinDistance()
        {
            var levenLogic = new LevenshteinLogic(reference, target);
            return levenLogic.Distance();
        }
    };

}
