using System;
using System.Collections.Generic;
using System.Linq;
using Samples.Dynamic.Trainers.MulticlassClassification;

namespace Algorithms
{
    public static class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Por favor insira a base: ");
            string string1 = Console.ReadLine();
            System.Console.Write("Por favor insira o alvo: ");
            string string2 = System.Console.ReadLine();

            var distanceDict = LevenshteinDistance.Entrypoint(string1, string2);
            System.Console.WriteLine("A distância é de {0}", distanceDict["distance"]);
            System.Console.WriteLine("A similaridade entre as strings é de {0}%", distanceDict["similarity"]);


        }
    }
}
