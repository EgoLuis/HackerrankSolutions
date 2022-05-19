using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class CircularArrayRotation
    {
        public static void CircularArrayRotationApp()
        {
            Console.WriteLine("Empieza el programa");
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(firstMultipleInput[0]);
            int k = Convert.ToInt32(firstMultipleInput[1]);
            int q = Convert.ToInt32(firstMultipleInput[2]);
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            List<int> queries = new List<int>();
            for (int i = 0; i < q; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine().Trim());
                queries.Add(queriesItem);
            }
            List<int> result = CircularArrayRotationMethod(a, k, queries);
            Console.WriteLine(String.Join("\n", result));
        }

        private static List<int> CircularArrayRotationMethod(List<int> a, int k, List<int> queries)
        {
            int tamano = a.Count;
            int nQueries = queries.Count;
            List<int> resultado = new List<int>();
            int residuo = k % tamano;
            for (int i = 0; i < nQueries; i++)
            {
                if (queries[i] - residuo > -1) resultado.Add(a[queries[i] - residuo]);
                else resultado.Add(a[tamano + queries[i] - residuo]);
            }
            return resultado;
        }


    }
}
