using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank_problems.Practica_Junior
{
    public class Fibonacci
    {
        public static void FibonacciApp()
        {
            Console.WriteLine("¿Cuántos dígitos de la serie Fibonacci quieres?");
            string respuesta = Console.ReadLine().Trim();
            int n = Convert.ToInt32(respuesta);
            FibonacciMethod(n);
        }
        private static void FibonacciMethod(int n)
        {
            List<int> serie = new List<int>();
            serie.Add(0);
            serie.Add(1);
            for (int i = 2; i < n; i++)
            {
                serie.Add(serie[i - 2] + serie[i - 1]);
            }
            foreach(int iterador in serie)
            {
                Console.Write("{0} ", iterador);
            }
        }
    }
}
