using System;

namespace Minimum_Operations_to_Make_Array_Equal
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: n = 3
            //Output: 2
            //Explanation: arr = [1, 3, 5]
            //First operation choose x = 2 and y = 0, this leads arr to be[2, 3, 4]
            //In the second operation choose x = 2 and y = 0 again, thus arr = [3, 3, 3].
            Console.WriteLine(s.MinOperations(3));
            //Input: n = 6
            //Output: 9
            Console.WriteLine(s.MinOperations(6));
        }
    }
}
