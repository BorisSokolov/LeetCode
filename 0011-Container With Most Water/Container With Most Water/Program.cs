using System;

namespace Container_With_Most_Water
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: height = [1, 8, 6, 2, 5, 4, 8, 3, 7]
            //Output: 49
            //Explanation: The above vertical lines are represented by array[1, 8, 6, 2, 5, 4, 8, 3, 7]. In this case, the max area of water(blue section) the container can contain is 49.
            Console.WriteLine(s.MaxArea(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
            //Input: height = [1, 1]
            //Output: 1
            Console.WriteLine(s.MaxArea(new[] { 1, 1 }));
            //Input: height = [4, 3, 2, 1, 4]
            //Output: 16
            Console.WriteLine(s.MaxArea(new[] { 4, 3, 2, 1, 4 }));
            //Input: height = [1, 2, 1]
            //Output: 2
            Console.WriteLine(s.MaxArea(new[] { 1, 2, 1 }));
        }
    }
}
