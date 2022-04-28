using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class ElectronicShop
    {
        public static void ElectronicShopApp()
        {
            Console.WriteLine("Empieza el programa");
            string[] bnm = Console.ReadLine().Split(' ');
            int b = Convert.ToInt32(bnm[0]);
            int n = Convert.ToInt32(bnm[1]);
            int m = Convert.ToInt32(bnm[2]);
            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp));
            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp));
            int moneySpent = ElectronicShopMethod(keyboards, drives, b);
            Console.WriteLine(moneySpent);
        }

        private static int ElectronicShopMethod(int[] keyboards, int[] drives, int b)
        {
            int suma = 0;
            for(int i = 0; i < keyboards.Length; i++)
            {
                for(int j = 0; j < drives.Length; j++)
                {
                    if (keyboards[i] + drives[j] > suma && keyboards[i] + drives[j] <= b)
                    {
                        suma = keyboards[i] + drives[j];
                    }
                }
            }
            if(suma == 0)
            {
                return -1;
            }
            else
            {
                return suma;
            }

        }

    }
}
