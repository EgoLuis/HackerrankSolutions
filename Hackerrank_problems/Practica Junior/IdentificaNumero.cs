using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank_problems.Practica_Junior
{
    public class IdentificaNumero
    {
        public  static void IdentificaNumeroApp()
        {
            string text = "kns  8oVJ998Vs51 b bSG??ALRQ/e55 7#";
            char[] pattern = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int n = 0;
            foreach(char letra in text)
            {
                foreach(char numero in pattern)
                {
                    if (letra == numero) n++;
                }
            }
            Console.WriteLine("El texto tiene {0} números", n);
        }
    }
}
