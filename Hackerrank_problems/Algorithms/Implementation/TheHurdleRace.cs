using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class TheHurdleRace
    {
        public static void TheHurdleRaceApp()
        {
            Console.WriteLine("Comienza el programa");
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(firstMultipleInput[0]);
            int k = Convert.ToInt32(firstMultipleInput[1]);
            List<int> height = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(heightTemp => Convert.ToInt32(heightTemp)).ToList();
            int result = TheHurdleRaceMethod(k, height);
            Console.WriteLine(result);
        }

        private static int TheHurdleRaceMethod(int k, List<int> height)
        {
            int maximo = 0;
            foreach(int iterador in height)
            {
                if(iterador > maximo) maximo = iterador;
            }
            if (k > maximo) return 0;
            else return maximo - k;
        }

    }
}
