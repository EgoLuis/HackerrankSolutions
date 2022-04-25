using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class GradingStudents
    {
        public static void GradingStudentsApp()
        {
            Console.WriteLine("Este programa sirve para defiir criterios de redondeo");
            Console.WriteLine("¿Cuántas calificaciones son?");
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> grades = new List<int>();
            Console.WriteLine("Escribe las calificaciones");
            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem=Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }
            List<int> result = GradingStudentsMethod(grades);
            Console.WriteLine(String.Join("\n", result));
        }

        private static List<int> GradingStudentsMethod(List<int> grades)
        {
            List<int> finales = new List<int>();
            foreach(int iterador in grades)
            {
                if (iterador < 38)
                {
                    finales.Add(iterador);
                }
                else if(iterador%5 <= 2)
                {
                    finales.Add(iterador);
                }
                else
                {
                    finales.Add(iterador + 5 - iterador % 5);
                }
            }
            return finales;
        }
    }
}
