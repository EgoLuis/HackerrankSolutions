using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank_problems.Practica_Junior
{
    public class ContadorPalabras
    {
        public static void ContadorPalabrasApp()
        {
            string text = "Mi nombre es Luis Alvarez y      estoy en una       entrevista      ";
            text = text.Trim();
            int n = 0;
            for (int i = 1; i < text.Length; i++)
            {
                if(text[i] == ' ' && text[i-1] != ' ')
                {
                    n++;
                }
            }
            Console.WriteLine("La frase tiene " + (n + 1) + " palabras");
        }
    }
}
