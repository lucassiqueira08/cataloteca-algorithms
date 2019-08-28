using System;

public class LevenshteinDistance {
    public static int Entrypoint(string string1, string string2) {

        int string1Lenght = string1.Length;
        int string2Lenght = string2.Length;
        var matrix = new int[string1Lenght + 1, string2Lenght + 1];

        if (string1Lenght == 0) {
            return string2Lenght;
        }

        if (string2Lenght == 0) {
            return string1Lenght;
        }
        for (var i = 0; i <= string1Lenght; matrix[i, 0] = i++){}
        for (var j = 0; j <= string2Lenght; matrix[0, j] = j++){}


   } 

}
