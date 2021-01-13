using System;

namespace Boats_to_Save_People
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: people = [1, 2], limit = 3
            //Output: 1
            //Explanation: 1 boat(1, 2)
            Console.WriteLine(s.NumRescueBoats(new[] { 1, 2 }, 3));
            //Input: people = [3, 2, 2, 1], limit = 3
            //Output: 3
            //Explanation: 3 boats(1, 2), (2) and(3)
            Console.WriteLine(s.NumRescueBoats(new[] { 3, 2, 2, 1 }, 3));
            //Input: people = [3, 5, 3, 4], limit = 5
            //Output: 4
            //Explanation: 4 boats(3), (3), (4), (5)
            Console.WriteLine(s.NumRescueBoats(new[] { 3, 5, 3, 4 }, 5));
        }
    }
}
