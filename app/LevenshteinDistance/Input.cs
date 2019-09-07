using System.Collections.Generic;

namespace level.app.LevenshteinDistance
{
    public class Input {

        public string reference = string.Empty;
        public List<string> target;

        public Input(string reference, List<string> target)
        {
            this.reference = reference;
            this.target = target;
        }

        public object CallLevenstheinCalc()
        {
            var levenLogic = new Logic(reference, target);
            return levenLogic.Calculate(reference, target);
        }

        public object CallLevenstheinSimilarity()
        {
            var levenLogic = new Logic(reference, target);
            return levenLogic.Similarity(reference, target);
        }

        public object CallLevenstheinDistance()
        {
            var levenLogic = new Logic(reference, target);
            return levenLogic.Distance(reference, target);
        }
    };

}
