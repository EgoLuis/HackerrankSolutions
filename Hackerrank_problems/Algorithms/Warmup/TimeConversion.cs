using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hackerrank_problems.Algorithms.Warmup
{
    public class TimeConversion
    {
        public static void TimeConversionApp()
        {
            Console.WriteLine("Este programa convierte una hora de formato 12H a formato 24H");
            Console.WriteLine("¿Cuál es la hora?");
            string s = Console.ReadLine();
            string result = TimeConversionMethod(s);
            Console.WriteLine(result);
        }

        private static string TimeConversionMethod(string s)
        {
            DateTime fecha;
            string resultado="";
            if(DateTime.TryParse(s, out fecha) == true)
            {
                resultado= fecha.ToString("HH:mm:ss");
            }
            return resultado;
        }
    }
}
