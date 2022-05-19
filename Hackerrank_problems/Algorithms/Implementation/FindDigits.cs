using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class FindDigits
    {
        public static void FindDigitsApp()
        {
            Console.WriteLine("Empieza el programa");
            int t = Convert.ToInt32(Console.ReadLine().Trim());
            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());
                int result = FindDigitsMethod(n);
                Console.WriteLine(result);
            }
        }
        private static int FindDigitsMethod(int n)
        {
            int divisores = 0;
            int digito;
            int valor = n;
            while (valor >= 1)
            {
                digito = valor % 10;
                if (digito != 0)
                {
                    if (n % digito == 0) divisores++;
                }
                valor = valor / 10;
            }
            return divisores;
        }
    }
}
