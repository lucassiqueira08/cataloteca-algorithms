using System;
using System.Collections.Generic;


namespace cataloteca.algorithms.LevenshteinDistance
{
    public static class Program
    {
        static void Main(string[] args)
        {

            List<string> productsList = new List<string>(new string[] {
                "abracadeira regulavel tipo rosca sem fim faixa regulagem 14-22mm largura fita 9mm espessura 0.7mm aco sae 1020 acabamento galvanizado eletrolitico",
                "abracadeira regulavel rosca sem fim faixa regulagem 19-38mm aco inox aisi 316",
                "abracadeira regulavel rosca sem fim faixa regulagem 25-38mm aco sae 1020"
            });

            string reference = "abracadeira regulavel";


            var bothCalc = new Input(reference, productsList);
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
