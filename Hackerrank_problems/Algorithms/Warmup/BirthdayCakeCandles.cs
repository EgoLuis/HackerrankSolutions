using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hackerrank_problems.Algorithms.Warmup
{
    public class BirthdayCakeCandles
    {
        public static void BirthdayCakeCandlesApp()
        {
            Console.WriteLine("Este programa regresa cuantos valores máximos hay en un arreglo");
            Console.WriteLine("¿De qué tamaño es la matriz?");
            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("Escribe los valores del arreglo");
            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();
            int result = BirthdayCakeCandlesMethod(candles);
            Console.WriteLine(result);
        }

        public static int BirthdayCakeCandlesMethod(List<int> candles)
        {
            int valorMax = 0;
            int contador = 0;
            foreach(int iterador in candles)
            {
                if (valorMax < iterador)
                {
                    valorMax = iterador;
                }
            }
            foreach (int iterador in candles)
            {
                if (valorMax == iterador)
                {
                    contador++;
                }
            }
            return contador;
        }

    }
}
