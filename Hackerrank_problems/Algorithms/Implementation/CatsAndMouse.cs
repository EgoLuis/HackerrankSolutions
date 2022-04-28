using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class CatsAndMouse
    {
        public static void CatsAndMouseApp()
        {
            Console.WriteLine("Empieza el programa");
            int q = Convert.ToInt32(Console.ReadLine());
            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');
                int x = Convert.ToInt32(xyz[0]);
                int y = Convert.ToInt32(xyz[1]);
                int z = Convert.ToInt32(xyz[2]);
                string result = CatsAndMouseMethod(x, y, z);
                Console.WriteLine(result);
            }
        }

        private static string CatsAndMouseMethod(int x, int y, int z)
        {
            int distCatA = z - x;
            if (distCatA < 0) distCatA = distCatA * -1;
            int distCatB = z - y;
            if (distCatB < 0) distCatB = distCatB * -1;
            if (distCatA < distCatB) return "Cat A";
            else if (distCatA > distCatB) return "Cat B";
            else return "Mouse C";

        }
    }
}
