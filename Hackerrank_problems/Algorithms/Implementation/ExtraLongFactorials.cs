using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class ExtraLongFactorials
    {
        public static void ExtraLongFactorialsApp()
        {
            Console.WriteLine("Empieza el programa");
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            ExtraLongFactorialsMethod(n);
        }
        private static void ExtraLongFactorialsMethod(int n)
        {
            BigInteger factorial = 1;
            for (int i = n; i > 0; i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }
    }
}
