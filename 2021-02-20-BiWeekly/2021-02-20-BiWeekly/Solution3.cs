using System;
using System.Collections.Generic;
using System.Text;

namespace _2021_02_20_BiWeekly
{
    public class Solution3
    {
        public int[][] HighestPeak(int[][] isWater)
        {
            bool changed;

            for (int i = 0; i < isWater.Length; i++)
                for (int j = 0; j < isWater[i].Length; j++)
                    if (isWater[i][j] == 0)
                        isWater[i][j] = 1;
                    else
                        isWater[i][j] = 0;
            do
            {
                changed = false;
                for (int i = 0; i < isWater.Length; i++)
                    for (int j = 0; j < isWater[i].Length; j++)
                    {
                        if (CanIncrement(isWater, i, j))
                        {
                            changed = true;
                            isWater[i][j]++;
                        }
                    }
            }
            while (changed);

            return isWater;
        }

        private bool CanIncrement(int[][] isWater, int i, int j)
        {
            if (isWater[i][j] == 0)
                return false;

            if (i > 0 && isWater[i][j] > isWater[i - 1][j])
                return false;
            if (j > 0 && isWater[i][j] > isWater[i][j - 1])
                return false;
            if (i < isWater.Length - 1 && isWater[i][j] > isWater[i + 1][j])
                return false;
            if (j < isWater[i].Length - 1 && isWater[i][j] > isWater[i][j + 1])
                return false;

            return true;
        }
    }
}
