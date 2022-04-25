using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hackerrank_problems.Algorithms.Warmup
{
    public class DiagonalDifference
    {
        public static void DiagonalDifferenceApp()
        {
            Console.WriteLine("Este programa calcula la diferencia entre la suma de las diagonales de una matriz");
            Console.WriteLine("¿De qué tamaño es la matriz?");
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("Escribe los valores");
            List<List<int>> arr = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }
            int result = DiagonalDifferenceMethod(arr);
            Console.WriteLine("El resultado es {0}", result);
        }
        private static int DiagonalDifferenceMethod(List<List<int>> arr)
        {
            int tamano = arr.Count;
            int primeraD = 0;
            int segundaD = 0;
            for(int i=0; i < tamano; i++)
            {
                primeraD = primeraD + arr[i][i];
            }
            for(int i=0; i<tamano; i++)
            {
                segundaD = segundaD + arr[i][tamano - 1 - i];
            }
            int resultado = primeraD - segundaD;
            if (resultado < 0)
            {
                resultado = resultado * -1;
            }
            return resultado;
        }
    }
}
