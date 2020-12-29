using System;

namespace Jump_Game_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: arr = [4,2,3,0,3,1,2], start = 5
            //Output: true
            //Explanation: 
            //All possible ways to reach at index 3 with value 0 are: 
            //index 5 -> index 4 -> index 1 -> index 3 
            //index 5 -> index 6 -> index 4 -> index 1 -> index 3 
            Console.WriteLine(s.CanReach(new[] { 4, 2, 3, 0, 3, 1, 2 }, 5));
            ////Input: arr = [3, 0, 2, 1, 2], start = 2
            ////Output: false
            ////Explanation: There is no way to reach at index 1 with value 0.
            Console.WriteLine(s.CanReach(new[] { 3, 0, 2, 1, 2 }, 2));
        }
    }
}
