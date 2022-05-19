using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class SequenceEquation
    {
        public static void SequenceEquationApp()
        {
            Console.WriteLine("Empieza el programa");
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> p = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(pTemp => Convert.ToInt32(pTemp)).ToList();
            List<int> result = SequenceEquationMethod(p);
            Console.WriteLine(String.Join("\n", result));
        }

        private static List<int> SequenceEquationMethod(List<int> p)
        {
            List<int> indices = new List<int>();
            for (int i = 0; i < p.Count; i++)
            {
                indices.Add(p.IndexOf(i + 1) + 1);
            }
            List<int> indices2 = new List<int>();
            for (int i = 0; i < p.Count; i++)
            {
                indices2.Add(p.IndexOf(indices[i]) + 1);
            }
            return indices2;
        }

    }
}
