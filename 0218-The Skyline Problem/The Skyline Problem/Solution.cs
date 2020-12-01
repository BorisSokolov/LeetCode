using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Skyline_Problem
{
    public class Solution
    {
        public IList<IList<int>> GetSkyline(int[][] buildings)
        {
            int n = buildings.Length;
            var output = new List<IList<int>>();

            // The base cases
            if (n == 0)
                return output;
            if (n == 1)
            {
                int xStart = buildings[0][0];
                int xEnd = buildings[0][1];
                int y = buildings[0][2];

                output.Add(new List<int>() { xStart, y });
                output.Add(new List<int>() { xEnd, 0 });
                return output;
            }

            // If there is more than one building,
            // recursively divide the input into two subproblems.
            var leftSkyline = GetSkyline(buildings.Take(n / 2).ToArray());
            var rightSkyline = GetSkyline(buildings.Skip(n / 2).ToArray());

            // Merge the results of subproblem together.
            return MergeSkylines(leftSkyline, rightSkyline);
        }

        /// <summary>
        /// Merge two skylines together.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public IList<IList<int>> MergeSkylines(IList<IList<int>> left, IList<IList<int>> right)
        {
            int nL = left.Count;
            int nR = right.Count;
            int pL = 0;
            int pR = 0;
            int currY = 0;
            int leftY = 0;
            int rightY = 0;
            int x, maxY;
            var output = new List<IList<int>>();

            // while we're in the region where both skylines are present
            while ((pL < nL) && (pR < nR))
            {
                var pointL = left[pL];
                var pointR = right[pR];
                // pick up the smallest x
                if (pointL[0] < pointR[0])
                {
                    x = pointL[0];
                    leftY = pointL[1];
                    pL++;
                }
                else
                {
                    x = pointR[0];
                    rightY = pointR[1];
                    pR++;
                }
                // max height (i.e. y) between both skylines
                maxY = Math.Max(leftY, rightY);
                // update output if there is a skyline change
                if (currY != maxY)
                {
                    UpdateOutput(output, x, maxY);
                    currY = maxY;
                }
            }

            // there is only left skyline
            AppendSkyline(output, left, pL, nL, currY);

            // there is only right skyline
            AppendSkyline(output, right, pR, nR, currY);

            return output;
        }

        /// <summary>
        /// Update the final output with the new element.
        /// </summary>
        /// <param name="output"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void UpdateOutput(IList<IList<int>> output, int x, int y)
        {
            // if skyline change is not vertical -
            // add the new point
            if (!output.Any() || output[output.Count - 1][0] != x)
                output.Add(new List<int>() { x, y });
            // if skyline change is vertical -
            // update the last point
            else
                output[output.Count - 1][1] = y;
        }

        /// <summary>
        /// Append the rest of the skyline elements with indice (p, n) to the final output.
        /// </summary>
        /// <param name="output"></param>
        /// <param name="skyline"></param>
        /// <param name="p"></param>
        /// <param name="n"></param>
        /// <param name="currY"></param>
        public void AppendSkyline(IList<IList<int>> output, IList<IList<int>> skyline, int p, int n, int currY)
        {
            while (p < n)
            {
                IList<int> point = skyline[p];
                int x = point[0];
                int y = point[1];
                p++;

                // update output
                // if there is a skyline change
                if (currY != y)
                {
                    UpdateOutput(output, x, y);
                    currY = y;
                }
            }
        }
    }
}
