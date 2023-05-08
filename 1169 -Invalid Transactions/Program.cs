using System;
using System.Collections.Generic;
using System.Linq;

namespace _1169__Invalid_Transactions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" | ", InvalidTransactions(new[] { "alice,20,800,mtv", "alice,50,100,beijing" })));
            Console.WriteLine(string.Join(" | ", InvalidTransactions(new[] { "alice,20,800,mtv", "alice,50,1200,mtv" })));
            Console.WriteLine(string.Join(" | ", InvalidTransactions(new[] { "alice,20,800,mtv", "bob,50,1200,mtv" })));
            Console.WriteLine(string.Join(" | ", InvalidTransactions(new[] { "bob,689,1910,barcelona", "alex,696,122,bangkok", "bob,832,1726,barcelona", "bob,820,596,bangkok", "chalicefy,217,669,barcelona", "bob,175,221,amsterdam" })));
        }

        public static IList<string> InvalidTransactions(string[] transactions)
        {
            Array.Sort(transactions, (s1, s2) => int.Parse(s1.Split(',')[1]).CompareTo(int.Parse(s2.Split(',')[1])));

            var dict = new Dictionary<string, List<(int time, string city, string val)>>();
            var res = new HashSet<string>();
            var duplicates = new List<string>();
            var prev = string.Empty;

            foreach (var tr in transactions)
            {
                var s = tr.Split(',');

                string name = s[0];
                int time = int.Parse(s[1]);
                int amount = int.Parse(s[2]);
                string city = s[3];

                if (prev.Equals(tr))
                   duplicates.Add(prev);

                if (amount > 1000)
                    res.Add(tr);
                if (dict.ContainsKey(name))
                {
                    for (int i = 1; i <= dict[name].Count; i++)
                    {
                        if ((time - dict[name][^i].time) > 60)
                            break;

                        if (dict[name][^i].city != city)
                        {
                            res.Add(dict[name][^i].val);
                            res.Add(tr);
                        }
                    }
                    dict[name].Add((time, city, tr));
                }
                else
                {
                    dict[name] = new List<(int time, string city, string val)>
                    {
                        (time, city, tr)
                    };
                }

                prev = tr;
            }

            duplicates.AddRange(res.ToList());

            return duplicates;
        }
    }
}
