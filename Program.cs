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
            //NaiveBayes.Example();

            System.Console.Write("Por favor insira a base: ");
            string string1 = Console.ReadLine();
            System.Console.Write("Por favor insira o alvo: ");
            string string2 = System.Console.ReadLine();

            int l = LevenshteinDistance.Entrypoint(string1, string2);
            System.Console.WriteLine(l);
            System.Console.WriteLine("A distancia das duas strings é: {0}", l);
        }
    }
}
