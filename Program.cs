using cataloteca.algorithms.LevenshteinDistance;
using System;
using System.Collections.Generic;


namespace cataloteca
{
    public static class Program
    {
        static void Main(string[] args)
        {

            List<string> productsList = new List<string>(new string[] {
        "example 1",
        "example 2",
        "example 3"
            });

            string reference = "example";


            var bothCalc = new LevenshteinInput(reference, productsList);
            var data = bothCalc.CallLevenstheinCalc();

            //var similarityCalc = new Input(reference, productsList);
            //var data = similarityCalc.CallLevenstheinSimilarity();

            //var distanceCalc = new Input(reference, productsList);
            //var data = distanceCalc.CallLevenstheinDistance();

            Console.WriteLine(data.Reference);
            Console.WriteLine("-------------------\n");
            foreach (var item in data.Results)
            {
                Console.WriteLine(item);
                Console.WriteLine("\n");

            }



        }
    }
}
