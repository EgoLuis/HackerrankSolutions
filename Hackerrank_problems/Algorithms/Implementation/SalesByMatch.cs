using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class SalesByMatch
    {
        public static void SalesByMatchApp()
        {
            Console.WriteLine("Comienza el programa");
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
            int result = SalesByMatchMethod(n, ar);
            Console.WriteLine(result);
        }
        private static int SalesByMatchMethod(int n, List<int> ar)
        {
            List<int> provisional = new List<int>();
            int contadorPares = 0;
            for (int i = 1; i <= 100; i++)
            {
                provisional = ar.FindAll(num => num == i);
                contadorPares = contadorPares + provisional.Count / 2;
            }
            return contadorPares;

        }

    }
}
