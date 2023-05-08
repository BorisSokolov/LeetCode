using System;
using System.Collections.Generic;

namespace _1583_CountUnhappyFriends
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            var preferences = new int[][]
            {
                new int[]{ 1, 2, 3 },
                new int[]{ 3, 2, 0 },
                new int[]{ 3, 1, 0 },
                new int[]{ 1, 2, 0 }
            };
            var pairs = new int[][]
            {
                new []{0, 1 },
                new []{2, 3 }
            };
            Console.WriteLine(UnhappyFriends(n, preferences, pairs));
        }

        public static int UnhappyFriends(int n, int[][] preferences, int[][] pairs)
        {
            int ans = 0;
            var matches = new int[n];
            var prefer = new Dictionary<int, int>[n];

            foreach (var pair in pairs)
            {
                int x = pair[0];
                int y = pair[1];
                matches[x] = y;
                matches[y] = x;
            }

            for (int i = 0; i < n; i++)
            {
                prefer[i] = new Dictionary<int, int>();
                for (int j = 0; j < n - 1; j++)
                    prefer[i][j] = preferences[i][j];
            }

            for (int x = 0; x < n; x++)
                foreach (int u in preferences[x])
                {
                    int y = matches[x];
                    int v = matches[u];
                    if (u < n && prefer[x][u] < prefer[x][y] && prefer[u][x] < prefer[u][v])
                    {
                        ans++;
                        break;
                    }
                }

            return ans;
        }
    }
}
