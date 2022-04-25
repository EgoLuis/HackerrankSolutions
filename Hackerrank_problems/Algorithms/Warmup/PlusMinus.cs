using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hackerrank_problems.Algorithms.Warmup
{
    public class PlusMinus
    {
        public static void PlusMinusApp()
        {
            Console.WriteLine("Este programa calcula el porcentaje de números positivos, negativos y ceros");
            Console.WriteLine("¿Cuantos elementos tiene la matriz?");
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("Escribe los valores de la matriz");
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            PlusMinusMethod(arr);
        }
        private static void PlusMinusMethod (List<int> arr)
        {
            double contadorP = 0, contadorN = 0, contadorZ = 0;
            double tamano = arr.Count;
            for(int i = 0; i < tamano; i++)
            {
                if(arr[i] > 0)
                {
                    contadorP++;
                }
                else if(arr[i] < 0)
                {
                    contadorN++;
                }
                else
                {
                    contadorZ++;
                }
               
            }
            Console.WriteLine("{0:N6}", contadorP / tamano);
            Console.WriteLine("{0:N6}", contadorN / tamano);
            Console.WriteLine("{0:N6}", contadorZ / tamano);
        }
            
    }
}
