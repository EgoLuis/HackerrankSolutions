using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hackerrank_problems.Algorithms.Warmup
{
    public class MiniMaxSum
    {
        public static void MiniMaxSumApp()
        {
            Console.WriteLine("Este programa da la menor y la mayor suma de un arreglo de 5 números");
            Console.WriteLine("Introduce los valores de la matriz");
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            MiniMaxSumMethod(arr);
        }

        private static void MiniMaxSumMethod(List<int> arr)
        {
            int minimumV = arr[0];
            int maximumV = arr[0];
            long minimumS = 0;
            long maximumS = 0;
            foreach(int iterador in arr)
            {
                minimumS=minimumS+(long)iterador;
                maximumS=maximumS+(long)iterador;
                if (iterador < minimumV)
                {
                    minimumV = iterador;
                }
                if (iterador > maximumV)
                {
                    maximumV = iterador;
                }
            }
            minimumS = minimumS - (long)maximumV;
            maximumS = maximumS - (long)minimumV;
            Console.WriteLine("{0} {1}", minimumS, maximumS);
        }
    }
}
