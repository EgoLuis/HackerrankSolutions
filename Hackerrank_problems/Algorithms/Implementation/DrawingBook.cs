using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class DrawingBook
    {
        public static void DrawingBookApp()
        {
            Console.WriteLine("Comienza el programa");
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            int p = Convert.ToInt32(Console.ReadLine().Trim());
            int result = DrawingBookMethod(n, p);
            Console.WriteLine(result);
        }
        private static int DrawingBookMethod (int n, int p)
        {
            int totalIzq = p / 2;
            int totalDer = n / 2 - p / 2;
            if (totalIzq < totalDer)
            {
                return totalIzq;
            }
            else
            {
                return totalDer;
            }
        }

    }
}
