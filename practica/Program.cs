using System;

namespace practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] p = new int[][]
            {
                new int[] {0,11},
                new int[] {-7,1},
                new int[]{-5,-3}
            };
            double minor = solution(p);
            Console.WriteLine(minor);
            
        }
        public static double solution(int[][] p)
        {
            int num = 0;
            foreach (int[] iterador in p)
            {
                num++;
            }

            double minor = Math.Sqrt(Math.Pow(((double)p[0][0] - (double)p[1][0]), 2) + Math.Pow(((double)p[0][1] - (double)p[1][1]), 2));
            Console.WriteLine(minor);
            double distance;

            for (int i = 0; i < num - 1; i++)
            {
                for (int j = i+1; j < num; j++)
                {
                    distance = Math.Sqrt(Math.Pow(((double)p[i][0] - (double)p[j][0]), 2) + Math.Pow(((double)p[i][1] - (double)p[j][1]), 2));
                    if (distance < minor)
                    {
                        minor = distance;
                    }
                }
            }
            return minor;

        }
    }
}
