using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class ViralAdvertising
    {
        public static void ViralAdvertisingApp()
        {
            Console.WriteLine("Empieza el programa");
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            int result = ViralAdvertisingMethod(n);
            Console.WriteLine(result);
        }

        private static int ViralAdvertisingMethod(int n)
        {
            int shared = 5;
            int liked = 0;
            int cumulative = 0;
            for (int i = 1; i <= n; i++)
            {
                liked = shared / 2;
                cumulative = cumulative + liked;
                shared = liked * 3;
            }
            return cumulative;
        }
    }
}
