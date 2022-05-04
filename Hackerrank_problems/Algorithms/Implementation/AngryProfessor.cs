using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class AngryProfessor
    {
        public static void AngryProfessorApp()
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());
            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
                int n = Convert.ToInt32(firstMultipleInput[0]);
                int k = Convert.ToInt32(firstMultipleInput[1]);
                List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
                string result = AngryProfessorMethod(k, a);
                Console.WriteLine(result);
            }
        }

        private static string AngryProfessorMethod(int k, List<int> a)
        {
            int tamanoLista = a.Count;
            int alumnosPresentes = 0;
            for (int i = 0; i < tamanoLista; i++)
            {
                if (a[i] <= 0) alumnosPresentes++;
            }
            if (alumnosPresentes < k) return "YES";
            else return "NO";
        }

    }
}
