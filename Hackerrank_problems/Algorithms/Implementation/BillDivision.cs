using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class BillDivision
    {
        public static void BillDivisionApp()
        {
            Console.WriteLine("Empieza el programa");
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(firstMultipleInput[0]);
            int k = Convert.ToInt32(firstMultipleInput[1]);
            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();
            int b = Convert.ToInt32(Console.ReadLine().Trim());
            BillDivisionMethod(bill, k, b);
        }
        private static void BillDivisionMethod(List<int> bill, int k, int b)
        {
            int suma = 0;
            for (int i = 0; i < bill.Count; i++)
            {
                if (i != k)
                {
                    suma = suma + bill[i];
                }
            }
            suma = suma / 2;
            int diferencia = b - suma;
            if (diferencia == 0)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(diferencia);
            }

        }
    }
}
