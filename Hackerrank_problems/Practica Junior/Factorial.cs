using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank_problems.Practica_Junior
{
    public class Factorial
    {
        public static void FactorialApp()
        {
            Console.WriteLine("Introduce un número");
            int n = Convert.ToInt32(Console.ReadLine());
            long resultado = FactorialMethod(n);
            Console.WriteLine("Su factorial es {0}", resultado);
        }
        private static long FactorialMethod(int n)
        {
            long resultado = (long)n;
            for (long i = (long)n - 1; i >= 1; i--)
            {
                resultado = resultado * i;
            }
            return resultado;
        }
    }
}
