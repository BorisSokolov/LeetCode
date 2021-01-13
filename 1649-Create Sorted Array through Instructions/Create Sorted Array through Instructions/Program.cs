using System;

namespace Create_Sorted_Array_through_Instructions
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: instructions = [1, 5, 6, 2]
            //Output: 1
            //Explanation: Begin with nums = [].
            //Insert 1 with cost min(0, 0) = 0, now nums = [1].
            //Insert 5 with cost min(1, 0) = 0, now nums = [1, 5].
            //Insert 6 with cost min(2, 0) = 0, now nums = [1, 5, 6].
            //Insert 2 with cost min(1, 2) = 1, now nums = [1, 2, 5, 6].
            //The total cost is 0 + 0 + 0 + 1 = 1.
            Console.WriteLine(s.CreateSortedArray(new[] { 1, 5, 6, 2 }));
            //Input: instructions = [1, 2, 3, 6, 5, 4]
            //Output: 3
            //Explanation: Begin with nums = [].
            //Insert 1 with cost min(0, 0) = 0, now nums = [1].
            //Insert 2 with cost min(1, 0) = 0, now nums = [1, 2].
            //Insert 3 with cost min(2, 0) = 0, now nums = [1, 2, 3].
            //Insert 6 with cost min(3, 0) = 0, now nums = [1, 2, 3, 6].
            //Insert 5 with cost min(3, 1) = 1, now nums = [1, 2, 3, 5, 6].
            //Insert 4 with cost min(3, 2) = 2, now nums = [1, 2, 3, 4, 5, 6].
            //The total cost is 0 + 0 + 0 + 0 + 1 + 2 = 3.
            Console.WriteLine(s.CreateSortedArray(new[] { 1, 2, 3, 6, 5, 4 }));
            //Input: instructions = [1, 3, 3, 3, 2, 4, 2, 1, 2]
            //Output: 4
            //Explanation: Begin with nums = [].
            //Insert 1 with cost min(0, 0) = 0, now nums = [1].
            //Insert 3 with cost min(1, 0) = 0, now nums = [1, 3].
            //Insert 3 with cost min(1, 0) = 0, now nums = [1, 3, 3].
            //Insert 3 with cost min(1, 0) = 0, now nums = [1, 3, 3, 3].
            //Insert 2 with cost min(1, 3) = 1, now nums = [1, 2, 3, 3, 3].
            //Insert 4 with cost min(5, 0) = 0, now nums = [1, 2, 3, 3, 3, 4].
            //​​​​​​​Insert 2 with cost min(1, 4) = 1, now nums = [1, 2, 2, 3, 3, 3, 4].
            //​​​​​​​Insert 1 with cost min(0, 6) = 0, now nums = [1, 1, 2, 2, 3, 3, 3, 4].
            //​​​​​​​Insert 2 with cost min(2, 4) = 2, now nums = [1, 1, 2, 2, 2, 3, 3, 3, 4].
            //The total cost is 0 + 0 + 0 + 0 + 1 + 0 + 1 + 0 + 2 = 4.
            Console.WriteLine(s.CreateSortedArray(new[] { 1, 3, 3, 3, 2, 4, 2, 1, 2 }));
        }
    }
}
