using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hackerrank_problems.Algorithms.Implementation
{
    public class ClimbingTheLeaderboard
    {
        public static void ClimbingTheLeaderboardApp()
        {
            Console.WriteLine("Comienza el programa");
            int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();
            int playerCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();
            List<int> result = ClimbingTheLeaderboardMethod(ranked, player);
            Console.WriteLine(String.Join("\n", result));
        }

        private static List<int> ClimbingTheLeaderboardMethod(List<int> ranked, List<int> player)
        {
            int tamanoRank = ranked.Count;
            int tamanoPlayer = player.Count;
            List<int> nuevaPosicion = new List<int>();
            List<int> posiciones = new List<int>();
            int posicion = 1;
            posiciones.Add(posicion);
            for (int i = 1; i < tamanoRank; i++)
            {
                if (ranked[i] != ranked[i - 1]) posicion++;
                posiciones.Add(posicion);
            }
            int ubicacion;
            for (int i = 0; i < tamanoPlayer; i++)
            {
                if (player[i] >= ranked[0]) nuevaPosicion.Add(1);
                else if (player[i] == ranked[tamanoRank - 1]) nuevaPosicion.Add(posiciones[tamanoRank - 1]);
                else if (player[i] < ranked[tamanoRank - 1]) nuevaPosicion.Add(posiciones[tamanoRank - 1] + 1);
                else
                {
                    ubicacion = binarySearch(ranked, player[i]);
                    if (player[i] == ranked[ubicacion]) nuevaPosicion.Add(posiciones[ubicacion]);
                    else nuevaPosicion.Add(posiciones[ubicacion] + 1);
                }
            }
            return nuevaPosicion;
        }
        private static int binarySearch(List<int> s, int puntuacion)
        {
            int inicio = 0;
            int final = s.Count - 1; 
            int indice = 0;
            while (inicio <= final)
            {
                int mid = (inicio + final) / 2; 
                if (puntuacion == s[mid])
                {
                    indice = mid;
                    inicio = s.Count;
                }
                else if (puntuacion > s[mid])
                {
                    if (puntuacion <= s[mid - 1])
                    {
                        indice = mid - 1;
                        inicio = s.Count;
                    }
                    else
                    {
                        final = mid;
                    }
                }
                else
                {
                    if (puntuacion >= s[mid + 1])
                    {
                        indice = mid;
                        inicio = s.Count;
                    }
                    else
                    {
                        inicio = mid;
                    }
                }
            }
            return indice;
        }
    }

}
  
