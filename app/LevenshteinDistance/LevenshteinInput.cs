using System.Collections.Generic;

namespace level.app.LevenshteinDistance
{
    public class LevenstheinInput {

        public string reference = string.Empty;
        public List<string> target;

        public LevenstheinInput(string reference, List<string> target)
        {
            this.reference = reference;
            this.target = target;

            CallLevenstheinCalc(reference, target);
        }

        private void CallLevenstheinCalc(string reference, List<string> target)
        {
            var levenCalc = new LevenstheinCalc(reference, target);
            levenCalc.Calculate(reference, target);
        }
    };

}
