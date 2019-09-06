using System;
using System.Collections.Generic;
using System.Linq;
using DuoVia.FuzzyStrings;


public class LevenstheinDistance
{
    public static Dictionary<string, double> Entrypoint(string string1, string string2)
    {
        double divisor;
        var dictionary = new Dictionary<string, double>();
        if (string1.Length == 0 || string2.Length == 0)
        {
             dictionary.Add("distance", 100.00);
             dictionary.Add("similarity", 0.00);

            return dictionary;
        };

        if (string1.Length > string2.Length)
        {
            
            divisor = Convert.ToDouble(string1.Length);
        }
        else
        {
            divisor = Convert.ToDouble(string2.Length);
        };

        var distance = string1.LevenshteinDistance(string2);
        var similarity = 100.00 - ((distance * 100.00) / divisor);

        dictionary.Add("distance", distance);
        dictionary.Add("similarity", similarity);
        return dictionary;
    }

}
