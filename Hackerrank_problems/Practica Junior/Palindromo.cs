using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank_problems.Practica_Junior
{
    public class Palindromo
    {
        public static void PalindromoApp()
        {
            Console.WriteLine("Introduce el texto");
            string cadena = Console.ReadLine();
            string resultado = PalindromoMethod(cadena);
            Console.WriteLine(resultado);
        }

        private static string PalindromoMethod(string cadena)
        {
            string checkOne = cadena.ToLower().Replace(" ", "");
            string checkTwo = "";
            for(int i = checkOne.Length - 1; i >= 0; i--)
            {
                checkTwo = checkTwo + checkOne[i];
            }
            bool flag = true;
            for(int i = 0; i < checkTwo.Length; i++)
            {
                if(checkTwo[i] != checkOne[i]) flag = false;
            }
            if (flag)
            {
                return "Si es palíndromo";
            }
            else
            {
                return "No es palíndromo";
            }
        }
    }
}
