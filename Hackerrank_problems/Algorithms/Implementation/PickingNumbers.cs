using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class PickingNumbers
    {
        public static void PickingNumbersApp()
        {
            Console.WriteLine("Empieza el programa");
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            int result = PickingNumbersMethod(a);
            Console.WriteLine(result);
        }

        private static int PickingNumbersMethod(List<int> a)
        {
            int maximo = 0;
            int temp = 0;
            int temp2 = 0;
            for(int i=0; i<a.Count-1; i++)
            {
                for(int j=0; j<a.Count; j++)
                {
                    if (a[i] - a[j] == 1 || a[i] - a[j] == 0) 
                    {
                        temp++;
                    }
                    if ( a[i] - a[j] == -1 || a[i] - a[j] == 0)
                    {
                        temp2++;
                    }
                }

                if (temp > maximo) maximo = temp;
                if (temp2 > maximo) maximo = temp2;
                temp = 0;
                temp2= 0;
            }
            return maximo;

        }
    }
}
