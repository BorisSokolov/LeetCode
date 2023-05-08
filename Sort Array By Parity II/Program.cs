using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_Array_By_Parity_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Solution
    {
        public int[] SortArrayByParityII(int[] nums)
        {
            var even = new Queue<int>();
            var odd = new Queue<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                bool numIsEven = nums[i] % 2 == 0;
                bool iIsEven = i % 2 == 0;

                if (numIsEven == iIsEven)
                    continue;

                if (numIsEven)
                {
                    if (odd.Any())
                    {
                        int j = odd.Dequeue();
                        (nums[i], nums[j]) = (nums[j], nums[i]);
                    }
                    else
                    {
                        even.Enqueue(i);
                    }
                }
                else
                {
                    if (even.Any())
                    {
                        int j = even.Dequeue();
                        (nums[i], nums[j]) = (nums[j], nums[i]);
                    }
                    else
                    {
                        odd.Enqueue(i);
                    }
                }
            }

            return nums;
        }
    }
}
