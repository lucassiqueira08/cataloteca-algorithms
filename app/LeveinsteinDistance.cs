using System;
using System.Collections.Generic;
using System.Linq;
using DuoVia.FuzzyStrings;

public class LevenshteinDistance
{
    public static Dictionary<string, int> Entrypoint(string string1, string string2)
    {
        int divisor;
        var dictionary = new Dictionary<string, int>();
        if (string1.Length == 0 || string2.Length == 0)
        {
             dictionary.Add("distance", 100);
             dictionary.Add("similarity", 0);

            return dictionary;
        };

        if (string1.Length > string2.Length)
        {
            divisor = string1.Length;
        }
        else
        {
            divisor = string2.Length;
        };

        var distance = string1.LevenshteinDistance(string2);
        var similarity = 100 - ((distance * 100) / divisor);

        dictionary.Add("distance", distance);
        dictionary.Add("similarity", similarity);
        return dictionary;
    }

}
