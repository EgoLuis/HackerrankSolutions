using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank_problems.Practica_Junior
{
    public class CambioVariable
    {
        public static void CambioVariableApp()
        {
            Console.WriteLine("Introduce la primera variable");
            int n1 = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("Introduce la segunda variable");
            int n2 = Convert.ToInt32(Console.ReadLine().Trim());
            CambioVariableMethod(n1, n2);
        }
        private static void CambioVariableMethod(int n1, int n2)
        {
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
            Console.WriteLine("Las variables son {0} y {1}", n1, n2);
        }
    }
}
