using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank_problems.Algorithms
{
    public class SolveMeFirst
    {
        public static void SolveMeFirstApp()
        {
            Console.WriteLine("Empieza el programa de la suma de dos números");
            Console.WriteLine("Introduce el primer valor");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo valor");
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = SolveMeFirstMethod(val1, val2);
            Console.WriteLine("El resultado es: " + sum);
        }
        private static int SolveMeFirstMethod(int a, int b)
        {
            return a + b;
        }
    }

}
