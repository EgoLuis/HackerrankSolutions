using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class DivisibleSumPairs
    {
        public static void DivisibleSumPairsApp()
        {
            Console.WriteLine("Dame el total de valores del arreglo y el número divisible");
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(firstMultipleInput[0]);
            int k = Convert.ToInt32(firstMultipleInput[1]);
            Console.WriteLine("Dame los valores de la lista");
            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
            int result = DivisibleSumPairsMethod(n, k, ar);
            Console.WriteLine(result);
        }
        private static int DivisibleSumPairsMethod(int n, int k, List<int> ar)
        {
            int contador = 0;
            int modulo;
            for(int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++) 
                {
                    modulo = (ar[i] + ar[j]) % k;
                    if (modulo == 0) contador++;
                }
            }
            return contador;
        }
    }
}
