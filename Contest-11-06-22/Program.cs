using System;
using System.Collections.Generic;

namespace Contest_11_06_22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(StrongPasswordCheckerII("IloveLe3tcode!").ToString());
            //Console.WriteLine(StrongPasswordCheckerII("Me+You--IsMyDream").ToString());
            //Console.WriteLine(StrongPasswordCheckerII("11A!A!Aa").ToString());

            //Console.WriteLine(string.Join(',', SuccessfulPairs(new []{ 5, 1, 3 }, new []{ 1, 2, 3, 4, 5 }, 7)));
            //Console.WriteLine(string.Join(',', SuccessfulPairs(new[] { 3, 1, 2 }, new[] { 8, 5, 8 }, 16)));
            Console.WriteLine(string.Join(',', SuccessfulPairs(new[] { 40, 11, 24, 28, 40, 22, 26, 38, 28, 10, 31, 16, 10, 37, 13, 21, 9, 22, 21, 18, 34, 2, 40, 40, 6, 16, 9, 14, 14, 15, 37, 15, 32, 4, 27, 20, 24, 12, 26, 39, 32, 39, 20, 19, 22, 33, 2, 22, 9, 18, 12, 5 }, new[] { 31, 40, 29, 19, 27, 16, 25, 8, 33, 25, 36, 21, 7, 27, 40, 24, 18, 26, 32, 25, 22, 21, 38, 22, 37, 34, 15, 36, 21, 22, 37, 14, 31, 20, 36, 27, 28, 32, 21, 26, 33, 37, 27, 39, 19, 36, 20, 23, 25, 39, 40 }, 600)));
        }

        public static bool StrongPasswordCheckerII(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
                return false;

            bool lower = false;
            bool upper = false;
            bool digit = false;
            bool special = false;
            char? previous = null;
            var specialChars = "!@#$%^&*()-+";

            foreach (char c in password)
            {
                if (previous.HasValue && c == previous)
                    return false;

                previous = c;

                if (!lower && char.IsLower(c))
                    lower = true;
                else if (!upper && char.IsUpper(c))
                    upper = true;
                else if (!digit && char.IsDigit(c))
                    digit = true;
                else if (!special && specialChars.Contains(c))
                    special = true;
            }

            return lower && upper && digit && special;
        }

        public static int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            var result = new int[spells.Length];

            Array.Sort(potions);
            var cache = new Dictionary<int, int>();

            for (int i = 0; i < spells.Length; i++)
            {
                if (cache.ContainsKey(spells[i]))
                {
                    result[i] = cache[spells[i]];
                    continue;
                }

                result[i] = potions.Length - SearchInsert(potions, spells[i], success);
                cache[spells[i]] = result[i];

                //for (int j = 0; j < potions.Length; j++)
                //{
                //    if (spells[i] >= success || potions[j] >= success ||
                //    ((long)spells[i] * potions[j]) >= success)
                //    {
                //        result[i] += potions.Length - j;
                //        cache[spells[i]] = result[i];
                //        break;
                //    }
                //}


            }

            return result;
        }

        public static int SearchInsert(int[] nums, int mult, long target)
        {
            int pivot, left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                pivot = left + (right - left) / 2;
                if ((long)nums[pivot] * mult == target)
                {
                    while (pivot > 1 && (long)nums[pivot - 1] * mult == target)
                        pivot--;

                    return pivot;
                }
                if (target < (long)nums[pivot] * mult) 
                    right = pivot - 1;
                else left = pivot + 1;
            }
            return left;
        }

    }
}
