using System;
using System.Collections.Generic;

namespace Largest_Rectangle_in_Histogram
{
    /// <summary>
    /// Given n non-negative integers representing the histogram's bar height where the width of each bar is 1, find the area of largest rectangle in the histogram.
    /// </summary>
    public class Solution
    {
        public int LargestRectangleArea(int[] heights)
        {
            //Stack of indexes
            var stack = new Stack<int>();
            //End symbol
            stack.Push(-1);

            int length = heights.Length;
            int maxArea = 0;

            for (int i = 0; i < length; i++)
            {
                while ((stack.Peek() != -1) && (heights[stack.Peek()] >= heights[i]))
                {
                    int currentHeight = heights[stack.Pop()];
                    int currentWidth = i - stack.Peek() - 1;
                    maxArea = Math.Max(maxArea, currentHeight * currentWidth);
                }
                stack.Push(i);
            }
            while (stack.Peek() != -1)
            {
                int currentHeight = heights[stack.Pop()];
                int currentWidth = length - stack.Peek() - 1;
                maxArea = Math.Max(maxArea, currentHeight * currentWidth);
            }

            return maxArea;
        }
    }
}
