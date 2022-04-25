using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class NumberLineJumps
    {
        public static void NumberLineJumpsApp()
        {
            Console.WriteLine("Empieza el programa");
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int x1 = Convert.ToInt32(firstMultipleInput[0]);
            int v1 = Convert.ToInt32(firstMultipleInput[1]);
            int x2 = Convert.ToInt32(firstMultipleInput[2]);
            int v2 = Convert.ToInt32(firstMultipleInput[3]);
            string result = NumberLineJumpsMethod(x1, v1, x2, v2);
            Console.WriteLine(result);
        }
        private static string NumberLineJumpsMethod(int x1, int v1, int x2, int v2)
        {
            string answer = "";
            if (v2 > v1)
            {
                answer = "NO";
            }
            while(x1 < x2)
            {
                x1 = x1 + v1;
                x2 = x2 + v2;
            }
            if (x1 == x2)
            {
                answer = "YES";
            }
            else
            {
                answer = "NO";
            }
            return answer;
        }

    }
}
