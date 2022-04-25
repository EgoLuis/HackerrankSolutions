using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class SubarrayDivision
    {
        public static void SubarrayDivisionApp()
        {
            Console.WriteLine("¿Cuántos valores tiene el arreglo?");
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("¿Qué valores son?");
            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();
            Console.WriteLine("¿Cuál es el día y el mes de nacimiento?");
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int d = Convert.ToInt32(firstMultipleInput[0]);
            int m = Convert.ToInt32(firstMultipleInput[1]);
            int result = SubarrayDivisionMethod(s, d, m);
            Console.WriteLine(result);
        }

        private static int SubarrayDivisionMethod(List<int> s, int d, int m)
        {
            int suma = 0;
            int contador = 0;
            for (int i = 0; i <= s.Count - m; i++)
            {
                for (int j = i; j < i + m; j++) 
                {
                    suma = suma + s[j];
                }
                if (suma == d) contador++;
                suma = 0;
            }
            return contador;
        }
    }
}
