using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class SaveThePrisoner
    {
        public static void SaveThePrisonerApp()
        {
            Console.WriteLine("Empieza el programa");
            int t = Convert.ToInt32(Console.ReadLine().Trim());
            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
                int n = Convert.ToInt32(firstMultipleInput[0]);
                int m = Convert.ToInt32(firstMultipleInput[1]);
                int s = Convert.ToInt32(firstMultipleInput[2]);
                int result = SaveThePrisonerMethod(n, m, s);
                Console.WriteLine(result);
            }
        }
        private static int SaveThePrisonerMethod(int n, int m, int s)
        {
            int resultado = m % n + s - 1;
            if (resultado % n != 0) resultado = resultado % n;
            if (resultado == 0) resultado = n;
            return resultado;
        }
    }
}
