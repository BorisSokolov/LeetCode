using System;

namespace Check_Array_Formation_Through_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: arr = [85], pieces = [[85]]
            //Output: true
            Console.WriteLine(s.CanFormArray(new[] { 85 }, new int[][] { new[] { 85 } }));

            //Input: arr = [15, 88], pieces = [[88],[15]]
            //Output: true
            //Explanation: Concatenate[15] then[88]
            Console.WriteLine(s.CanFormArray(new[] { 15, 88 }, new int[][] { new[] { 88 }, new[] { 15 } }));

            //Input: arr = [49, 18, 16], pieces = [[16, 18, 49]]
            //Output: false
            //Explanation: Even though the numbers match, we cannot reorder pieces[0].
            Console.WriteLine(s.CanFormArray(new[] { 49, 18, 16 }, new int[][] { new[] { 16, 18, 49 } }));

            //Input: arr = [91, 4, 64, 78], pieces = [[78],[4,64],[91]]
            //Output: true
            //Explanation: Concatenate[91] then[4, 64] then[78]
            Console.WriteLine(s.CanFormArray(new[] { 91, 4, 64, 78 }, new int[][] { new[] { 78 }, new[] { 4, 64 }, new[] { 91 } }));
        }
    }
}
