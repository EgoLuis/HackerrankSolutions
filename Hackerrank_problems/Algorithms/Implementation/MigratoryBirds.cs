using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class MigratoryBirds
    {
        public static void MigratoryBirdsApp()
        {
            Console.WriteLine("¿Cuántos elementos tiene la matriz?");
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("¿Qué valores tiene?");
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            int result = MigratoryBirdsMethod(arr);
            Console.WriteLine(result);
        }

        private static int MigratoryBirdsMethod(List<int> arr)
        {
            List<int> totalS1 = arr.FindAll(i => i == 1);
            List<int> totalS2 = arr.FindAll(i => i == 2);
            List<int> totalS3 = arr.FindAll(i => i == 3);
            List<int> totalS4 = arr.FindAll(i => i == 4);
            List<int> totalS5 = arr.FindAll(i => i == 5);

            List<int> totales = new List<int>();

            totales.Add(totalS1.Count);
            totales.Add(totalS2.Count);
            totales.Add(totalS3.Count);
            totales.Add(totalS4.Count);
            totales.Add(totalS5.Count);

            int maximo = totalS1.Count;

            foreach (int iterador in totales)
            {
                if (iterador > maximo) maximo = iterador;
            }
            int resultado = 0;

            for (int i = 4; i > -1; i--)
            {
                if (maximo == totales[i]) resultado = i + 1; 
            }
            return resultado;

        }



        
    }
}
