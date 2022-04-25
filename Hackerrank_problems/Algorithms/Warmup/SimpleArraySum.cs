using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hackerrank_problems.Algorithms.Warmup
{
    public class SimpleArraySum
    {
        public static void SimpleArraySumApp()
        {
            Console.WriteLine("Este programa suma los valores enteros de una matriz");
            Console.WriteLine("¿Cuantos valores tiene tu matriz?");
            int arCount=Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("Escribe los valores");
            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
            int result = SimpleArraySumMethod(ar);
            Console.WriteLine("El resultado es {0}", result);
        }

        private static int SimpleArraySumMethod(List<int> ar)
        {
            int suma = 0;
            for (int i=0; i<ar.Count; i++)
            {
                suma = suma + ar[i];
            }
            return suma;
        }
    }
}
