using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hackerrank_problems.Algorithms.Warmup
{
    public class Staircase
    {
        public static void StaircaseApp()
        {
            Console.WriteLine("Este programa dibuja una escalera");
            Console.WriteLine("¿Cuántos escalones tiene la escalera?");
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            StaircaseMethod(n);
        }
        private static void StaircaseMethod(int n)
        {
            for(int i = n-1; i > -1; i--)
            {
                for(int j = 0; j < n; j++)
                {
                    if (i <= j)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
