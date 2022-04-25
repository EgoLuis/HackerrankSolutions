using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Hackerrank_problems.Algorithms.Warmup
{
    public class AVeryBigSum
    {
        public static void AVeryBigSumApp()
        {
            Console.WriteLine("En este programa se suman los elementos de una matriz de valor muy grande");
            Console.WriteLine("¿Cuántos valores tiene tu matriz?");
            int arCount=Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("Escribe los valores de la matriz");
            List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();
            long result = AVeryBigSumMethod(ar);
            Console.WriteLine("El resltado es {0}", result);
        }

        private static long AVeryBigSumMethod(List<long> ar)
        {
            long resultado = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                resultado=resultado+ar[i];
            }
            return resultado;
        }
    }
}
