using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class FormingMagicSquare
    {
        public static void FormingMagicSquareApp()
        {
            Console.WriteLine("Empieza el programa");
            List<List<int>> s = new List<List<int>>();
            for (int i = 0; i < 10; i++)
            {
                s.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList());
            }
            int result = FormingMagicSquareMethod(s);
            Console.WriteLine(result);
        }

        private static int FormingMagicSquareMethod(List<List<int>> s)
        {
            int[] magicOne = new int[] { 8, 3, 4, 1, 5, 9, 6, 7, 2 };
            int[] magicTwo = new int[] { 6, 7, 2, 1, 5, 9, 8, 3, 4 };
            int[] magicThree = new int[] { 4, 3, 8, 9, 5, 1, 2, 7, 6 };
            int[] magicFour = new int[] { 2, 7, 6, 9, 5, 1, 4, 3, 8 };
            int[] magicFive = new int[] { 2, 9, 4, 7, 5, 3, 6, 1, 8 };
            int[] magicSix = new int[] { 6, 1, 8, 7, 5, 3, 2, 9, 4 };
            int[] magicSeven = new int[] { 4, 9, 2, 3, 5, 7, 8, 1, 6 };
            int[] magicEight = new int[] { 8, 1, 6, 3, 5, 7, 4, 9, 2 };

            int[] cuadro = new int[9];
            int i = 0;
            foreach(List<int> iterador in s)
            {
                foreach(int iterador2 in iterador)
                {
                    cuadro[i] = iterador2;
                    i++;
                }
            }
            int resta1 = 0, resta2 = 0, resta3 = 0, resta4 = 0, resta5 = 0, resta6 = 0, resta7 = 0, resta8 = 0;
            int temp = 0;

            for (int j = 0; j < 9; j++)
            {
                temp = magicOne[j] - cuadro[j];
                if (temp < 0) temp = temp * -1;
                resta1 = resta1 + temp;
            }
            for (int j = 0; j < 9; j++)
            {
                temp = magicTwo[j] - cuadro[j];
                if (temp < 0) temp = temp * -1;
                resta2 = resta2 + temp;
            }
            for (int j = 0; j < 9; j++)
            {
                temp = magicThree[j] - cuadro[j];
                if (temp < 0) temp = temp * -1;
                resta3 = resta3 + temp;
            }
            for (int j = 0; j < 9; j++)
            {
                temp = magicFour[j] - cuadro[j];
                if (temp < 0) temp = temp * -1;
                resta4 = resta4 + temp;
            }
            for (int j = 0; j < 9; j++)
            {
                temp = magicFive[j] - cuadro[j];
                if (temp < 0) temp = temp * -1;
                resta5 = resta5 + temp;
            }
            for (int j = 0; j < 9; j++)
            {
                temp = magicSix[j] - cuadro[j];
                if (temp < 0) temp = temp * -1;
                resta6 = resta6 + temp;
            }
            for (int j = 0; j < 9; j++)
            {
                temp = magicSeven[j] - cuadro[j];
                if (temp < 0) temp = temp * -1;
                resta7 = resta7 + temp;
            }
            for (int j = 0; j < 9; j++)
            {
                temp = magicEight[j] - cuadro[j];
                if (temp < 0) temp = temp * -1;
                resta8 = resta8 + temp;
            }

            int[] resultados = new int[] { resta1, resta2, resta3, resta4, resta5, resta6, resta7, resta8 };
            int minimo = resultados[0];
            foreach(int iterador in resultados)
            {
                if (iterador < minimo) minimo= iterador;
            }
            return minimo;
        }
    }
}
