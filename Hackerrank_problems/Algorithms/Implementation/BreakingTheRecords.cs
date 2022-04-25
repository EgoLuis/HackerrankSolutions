using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class BreakingTheRecords
    {
        public static void BreakingTheRecordsApp()
        {
            Console.WriteLine("Empieza el programa");
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();
            List<int> result = BreakingTheRecordsMethod(scores);
            foreach(int iterador in result)
            {
                Console.WriteLine(iterador);
            }
        }
        private static List<int> BreakingTheRecordsMethod(List<int> scores)
        {
            int max = scores[0];
            int min = scores[0];
            int countMax = 0;
            int countMin = 0;
            foreach(int iterador in scores)
            {
                if(iterador > max)
                {
                    countMax++;
                    max = iterador;
                }
                if (iterador < min)
                {
                    countMin++;
                    min = iterador;
                }
            }
            List<int> resultados = new List<int>();
            resultados.Add(countMax);
            resultados.Add(countMin);
            return resultados;
        }
    }
}
