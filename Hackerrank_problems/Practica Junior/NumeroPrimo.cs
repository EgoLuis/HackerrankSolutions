using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank_problems.Practica_Junior
{
    public class NumeroPrimo
    {
        public static void NumeroPrimoApp()
        {
            Console.WriteLine("Introduce un número entero");
            string cadena = Console.ReadLine().TrimEnd();
            int n = Convert.ToInt32(cadena);
            string resultado = NumeroPrimoMethod(n);
            Console.Write(resultado);
        }
        private static string NumeroPrimoMethod(int n)
        {
            bool flag = true;
            string resultado= "";
            
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0) flag = false;
                }
            
            if (flag)
            {
                resultado = "El número es primo";
            }
            else
            {
                resultado = "El número no es primo";
            }
            return resultado;
        }
    }
}
