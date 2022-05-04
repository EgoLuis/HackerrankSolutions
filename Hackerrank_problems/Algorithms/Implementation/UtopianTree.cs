using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class UtopianTree
    {
        public static void UtopianTreeApp()
        {
            Console.WriteLine("Empieza el programa");
            int t = Convert.ToInt32(Console.ReadLine().Trim());
            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());
                int result = UtopianTreeMethod(n);
                Console.WriteLine(result);
            }
        }
        private static int UtopianTreeMethod(int n)
        {
            int altura = 1;
            int contador = 1;
            if (n == 0) return altura;
            else
            {
                while (contador <= n)
                {
                    if (contador % 2 == 1)
                    {
                        altura = altura * 2;
                        contador++;
                    }
                    else
                    {
                        altura++;
                        contador++;
                    }
                }
            }
            return altura;
        }

    }
}
