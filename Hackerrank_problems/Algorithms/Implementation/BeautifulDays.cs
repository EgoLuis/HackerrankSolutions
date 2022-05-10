using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class BeautifulDays
    {
        public static void BeautifulDaysApp()
        {
            Console.WriteLine("Empieza el programa");
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int i = Convert.ToInt32(firstMultipleInput[0]);
            int j = Convert.ToInt32(firstMultipleInput[1]);
            int k = Convert.ToInt32(firstMultipleInput[2]);
            int result = BeautifulDaysMethod(i, j, k);
            Console.WriteLine(result);
        }

        private static int BeautifulDaysMethod(int i, int j, int k)
        {
            int reverse = 0;
            int provisional = 0;
            int resta;
            int beautiful = 0;

            for (int x = i; x <= j; x++)
            {
                provisional = x;
                while (provisional > 0)
                {
                    reverse = reverse*10 + provisional % 10;
                    provisional = provisional / 10;
                }
                resta = x - reverse;
                if (resta < 0) resta = resta * -1;
                if (resta % k == 0) beautiful++;
                reverse = 0;
            }

            return beautiful;
        }
    }
}
