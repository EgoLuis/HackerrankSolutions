using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class BetweenTwoSets
    {
        public static void BetweenTwoSetsApp()
        {
            Console.WriteLine("Empieza el programa");
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(firstMultipleInput[0]);
            int m = Convert.ToInt32(firstMultipleInput[1]);
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();
            int total = BetweenTwoSetsMethod(arr, brr);
            Console.WriteLine(total);
        }
        private static int BetweenTwoSetsMethod(List<int> a, List<int> b)
        {
            int maxA = a[0];
            int minB = b[0];
            int contador = 0;
            foreach(int iterador in a)
            {
                if(iterador > maxA) maxA= iterador;
            }
            foreach(int iterador in b)
            {
                if(iterador < minB) minB= iterador;
            }
            bool flag;
            for(int i=maxA; i<=minB; i++)
            {
                flag = true;
                foreach(int iterador in a)
                {
                    if(i%iterador != 0) flag = false;
                }
                foreach(int iterador in b)
                {
                    if (iterador%i != 0) flag = false;
                }
                if (flag == true) contador++;
            }
            return contador;

        }
    }
}
