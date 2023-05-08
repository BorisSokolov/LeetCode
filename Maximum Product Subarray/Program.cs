using System;
using System.Linq;

namespace Maximum_Product_Subarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxProduct(new []{ 2, 3, -2, 4}));
        }

        public static int MaxProduct(int[] nums)
        {
            if (nums?.Any() != true)
                return 0;

            int max = nums[0];
            int min = nums[0];
            int result = nums[0];

            foreach (int n in nums[1..])
            {
                (max, min) = (Math.Max(n, Math.Max(max * n, min * n)), Math.Min(n, Math.Min(max * n, min * n)));

                result = Math.Max(max, result);
            }

            return result;
        }
    }
}
