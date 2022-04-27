using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class DayOfProgrammer
    {
        public static void DayOfProgrammerApp()
        {
            Console.WriteLine("Introduce el año");
            int year = Convert.ToInt32(Console.ReadLine().Trim());
            string result = DayOfProgrammerMethod(year);
            Console.WriteLine(result);
        }
        private static string DayOfProgrammerMethod(int year)
        {
            DateTime fecha = new DateTime();
            int dia = 13;
            if (year > 1918)
            {
                if (year % 4 == 0)
                {
                    dia = 12;
                    if (year % 100 == 0) dia = 13;
                    if (year % 400 == 0) dia = 12;
                }
            }
            else if (year < 1918)
            {
                if (year % 4 == 0) dia = 12;
            }
            else dia = 26;
            fecha = new DateTime(year, 9, dia);
            return fecha.ToString("dd.MM.yyyy");

        }



    }
}
