using System;
using System.Collections.Generic;
using System.Linq;
using DuoVia.FuzzyStrings;

public class LevenshteinDistance {
    public static Dictionary<string, int> Entrypoint(string string1, string string2) {

        var distance = string1.LevenshteinDistance(string2);
        var similarity = 100 - ((distance*100) / string1.Length);

        var dictionary = new Dictionary<string, int>() {
             {"distance", distance},
             {"similarity", similarity}
        };

        return dictionary;
   } 

}
