using System.Collections.Generic;

namespace Check_Array_Formation_Through_Concatenation
{
    /// <summary>
    /// You are given an array of distinct integers arr and an array of integer arrays pieces, where the integers in pieces are distinct. Your goal is to form arr by concatenating the arrays in pieces in any order. However, you are not allowed to reorder the integers in each array pieces[i].
    /// Return true if it is possible to form the array arr from pieces.Otherwise, return false.
    /// </summary>
    public class Solution
    {
        public bool CanFormArray(int[] arr, int[][] pieces)
        {
            var mapping = new Dictionary<int, int[]>();

            foreach (var p in pieces)
            {
                mapping.Add(p[0], p);
            }

            int i = 0;
            while (i < arr.Length)
            {
                // find target piece
                if (!mapping.ContainsKey(arr[i]))
                {
                    return false;
                }
                // check target piece
                int[] targetPiece = mapping[arr[i]];
                foreach (int x in targetPiece)
                {
                    if (x != arr[i])
                    {
                        return false;
                    }

                    i++;
                }
            }
            return true;
        }
    }
}
