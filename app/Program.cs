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
            string[] productsList;

            System.Console.Write("Por favor insira uma palavra: ");
            string string1 = Console.ReadLine();

            productsList = new string[]{
                "Abracadeira Regulavel Tipo Rosca Sem Fim Faixa Regulagem 14-22Mm Largura Fita 9Mm Espessura 0.7Mm Aco Sae 1020 Acabamento Galvanizado Eletrolitico",
                "Abracadeira Regulavel Rosca Sem Fim Faixa Regulagem 19-38Mm Aco Inox Aisi 316",
                "Abracadeira Regulavel Rosca Sem Fim Faixa Regulagem 25-38Mm Aco Sae 1020"
            };

            foreach(var p in productsList){
                var distanceDict = LevenshteinDistance.Entrypoint(string1, p);
                PrintMetrics(p, distanceDict["distance"], distanceDict["similarity"]);
            }


            
           

        }

        public static void PrintMetrics(string product, int distance, int similarity)
        {
            System.Console.WriteLine(' ');
            System.Console.WriteLine(' ');
            System.Console.WriteLine("************************");
            System.Console.WriteLine(product);
            System.Console.WriteLine("************************");
            System.Console.WriteLine("A distância é de {0}", distance);
            System.Console.WriteLine("A similaridade entre as strings é de {0}%", similarity);
            System.Console.WriteLine(' ');
            System.Console.WriteLine(' ');
        }
    }
}
