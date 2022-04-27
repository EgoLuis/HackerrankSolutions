using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class CountingValleys
    {
        public static void CountingValleysApp()
        {
            Console.WriteLine("Empieza el programa");
            int steps = Convert.ToInt32(Console.ReadLine().Trim());
            string path = Console.ReadLine();
            int result = CountingValleysMethod(steps, path);
            Console.WriteLine(result);
        }

        private static int CountingValleysMethod(int steps, string path)
        {
            int altitud;
            int valles = 0;
            if(path[0] == 'U')
            {
                altitud = 1;
            }
            else
            {
                altitud = -1;
            }
            for(int i=1; i<steps; i++)
            {
                if(path[i] == 'U')
                {
                    altitud++;
                }
                else
                {
                    altitud--;
                }
                if(altitud == 0 && path[i] == 'U')
                {
                    valles++;
                }
            }
            return valles;

        }
    }
}
