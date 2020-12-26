using System;

namespace Next_Greater_Element_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: n = 12
            //Output: 21
            Console.WriteLine(s.NextGreaterElement(12));
            //Input: n = 21
            //Output: -1
            Console.WriteLine(s.NextGreaterElement(21));
        }
    }
}
