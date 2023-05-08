using System;
using System.Collections.Generic;
using System.Linq;

namespace Contest_2022_10_29
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(OddString(new[] { "adc", "wzy", "abc" }));
            //Console.WriteLine(OddString(new[] { "aaa", "bob", "ccc", "ddd" }));

            //Console.WriteLine(string.Join(',', TwoEditWords(new[] { "word", "note", "ants", "wood" }, new[] { "wood", "joke", "moat" })));
            //Console.WriteLine(string.Join(',',TwoEditWords(new[] { "yes" }, new[] { "wood", "joke", "not" })));

            Console.WriteLine(DestroyTargets(new[] { 3, 7, 8, 1, 1, 5 }, 2));
            Console.WriteLine(DestroyTargets(new[] { 1, 3, 5, 2, 4, 6 }, 2));
            Console.WriteLine(DestroyTargets(new[] { 6, 2, 5 }, 100));
        }

        public static string OddString(string[] words)
        {
            int[] first = null;
            int[] second = null;
            string w1 = string.Empty;
            string w2 = string.Empty;

            foreach (var w in words)
            {
                var dif = Diff(w);
                if (first == null)
                {
                    first = dif;
                    w1 = w;
                    continue;
                }

                if (dif.SequenceEqual(first))
                {
                    if (second != null)
                        return w2;

                    w2 = "-1";
                    continue;
                }

                if (w2 == "-1")
                    return w;

                if (second == null)
                {
                    second = dif;
                    w2 = w;
                    continue;
                }

                if (dif.SequenceEqual(second))
                {
                    return w1;
                }


            }

            return string.Empty;
        }

        private static int[] Diff(string word)
        {
            var res = new int[word.Length - 1];

            for (int i = 0; i < res.Length; i++)
                res[i] = word[i + 1] - word[i];

            return res;
        }


        public static IList<string> TwoEditWords(string[] queries, string[] dictionary)
        {
            var matches = new List<string>();

            foreach (var q in queries)
            {
                if (TwoEditMatch(q, dictionary))
                    matches.Add(q);
            }

            return matches;
        }

        private static bool TwoEditMatch(string q, string[] dictionary)
        {
            //exact match
            if (dictionary.Contains(q))
                return true;

            foreach (var s in dictionary)
                if (TwoEditMatchWord(q, s))
                    return true;

            return false;
        }

        private static bool TwoEditMatchWord(string q, string s)
        {
            int dif = 0;
            for (int i = 0; i < q.Length; i++)
                if (q[i] != s[i])
                    dif++;

            return dif <= 2;
        }

        public static int DestroyTargets(int[] nums, int space)
        {
            int max = int.MinValue;
            var maxIndex = -1;
            var processed = new HashSet<int>();

            Array.Sort(nums);

            if (space > nums[^1])
                return MostFrequent(nums, nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                if (processed.Add(nums[i]))
                {
                    int result = DestroyTargets(nums, space, i);

                    if (max < result)
                    {
                        maxIndex = i;
                        max = result;
                    }
                }
            }

            return nums[maxIndex];
        }

        private static int DestroyTargets(int[] nums, int space, int i)
        {
            int count = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j)
                    continue;

                int d = nums[j] - nums[i];

                if (d < 0)
                    continue;

                if (d == 0 || d % space == 0)
                    count++;
            }

            return count;
        }

        public static int MostFrequent(int[] arr, int n)
        {
            int maxcount = 0;
            int element_having_max_freq = 0;
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }

                if (count > maxcount)
                {
                    maxcount = count;
                    element_having_max_freq = arr[i];
                }
            }

            return element_having_max_freq;
        }
    }


}
