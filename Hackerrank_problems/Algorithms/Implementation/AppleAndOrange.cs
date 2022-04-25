using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class AppleAndOrange
    {
        public static void AppleAndOrangeApp()
        {
            Console.WriteLine("Este programa determina si un número cae dentro de un rango especficado");
            Console.WriteLine("Escribe el rango de la casa");
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int s = Convert.ToInt32(firstMultipleInput[0]);
            int t = Convert.ToInt32(firstMultipleInput[1]);
            Console.WriteLine("Escribe la ubicación de los árboles");
            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int a = Convert.ToInt32(secondMultipleInput[0]);
            int b = Convert.ToInt32(secondMultipleInput[1]);
            Console.WriteLine("Escribe la cantidad de manzanas y naranjas");
            string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int m = Convert.ToInt32(thirdMultipleInput[0]);
            int n = Convert.ToInt32(thirdMultipleInput[1]);
            Console.WriteLine("Escribe las ubicaciones de las manzanas");
            List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();
            Console.WriteLine("Escribe las ubicaciones de las naranjas");
            List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();
            AppleAndOrangeMethod(s, t, a, b, apples, oranges);
        }
        public static void AppleAndOrangeMethod(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int cManzanas = 0;
            int cNaranjas = 0;
            List<int> ubiMan = new List<int>();
            List<int> ubiNar = new List<int>();
            foreach(int iterador in apples)
            {
                ubiMan.Add(iterador + a);
            }
            foreach(int iterador in oranges)
            {
                ubiNar.Add(iterador + b);
            }
            foreach(int iterador in ubiMan)
            {
                if(iterador>=s && iterador <= t)
                {
                    cManzanas++;
                }
            }
            foreach (int iterador in ubiNar)
            {
                if (iterador >= s && iterador <= t)
                {
                    cNaranjas++;
                }
            }
            Console.WriteLine(cManzanas);
            Console.WriteLine(cNaranjas);
        }
        
    }
}
