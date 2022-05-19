using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class JumpingOnClouds
    {
        public static void JumpingOnCloudsApp()
        {
            Console.WriteLine("Empieza el programa");
            string[] nk = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);
            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            int result = JumpingOnCloudsMethod(c, k);
            Console.WriteLine(result);
        }
        private static int JumpingOnCloudsMethod(int[] c, int k)
        {
            int energia = 100;
            int indice = 0;
            int tamano = c.Length;
            do
            {
                indice = (indice + k) % tamano;
                if (c[indice] == 0) energia--;
                else energia = energia - 3;
            } while (indice != 0);
            return energia;
        }
    }
}
