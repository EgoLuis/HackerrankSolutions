using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class DesignerPDFViewer
    {
        public static void DesignerPDFViewerApp()
        {
            Console.WriteLine("Empieza el programa");
            List<int> h = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(hTemp => Convert.ToInt32(hTemp)).ToList();
            string word = Console.ReadLine();
            int result = DesignerPDFViewerMethod(h, word);
            Console.WriteLine(result);
        }
        private static int DesignerPDFViewerMethod(List<int> h, string word)
        {
            int ancho = word.Length;
            int altura = 0;
            char[] abecedario = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            for (int j = 0; j < 26; j++)
            {
                for (int i = 0; i < ancho; i++)
                {
                    if (word[i] == abecedario[j])
                    {
                        if (altura < h[j])
                        {
                            altura = h[j];
                        }
                    }
                }
            }
            int area = ancho * altura;
            return area;
        }
    }
}
