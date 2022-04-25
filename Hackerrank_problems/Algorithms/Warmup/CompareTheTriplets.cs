using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hackerrank_problems.Algorithms.Warmup
{
    public class CompareTheTriplets
    {
        public static void CompareTheTripletsApp()
        {
            Console.WriteLine("En este programa se comparan dos matrices");
            Console.WriteLine("Escribe los resultados de la primer matriz");
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            Console.WriteLine("Escribe los resultados de la segunda matriz");
            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            List<int> result = CompareTheTripletsMethod(a, b);
            Console.WriteLine("Los resultados son: {0}", String.Join(" ", result));
        }

        private static List<int> CompareTheTripletsMethod(List<int> a, List<int> b)
        {
            int Alice = 0;
            int Bob = 0;
            for (int i=0; i <a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    Alice++;
                }
                else if (a[i] < b[i])
                {
                    Bob++;
                }
            }
            List<int> resultados = new List<int>();
            resultados.Add(Alice);
            resultados.Add(Bob);
            return resultados;
        }
    }
}
