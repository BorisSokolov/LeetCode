using System;
using System.Collections.Generic;
using System.Linq;

namespace Search_Suggestions_System
{
    public class Solution
    {
        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            Array.Sort(products);
            List<IList<string>> result = new List<IList<string>>();

            for (int i = 1; i <= searchWord.Length; i++)
            {
                result.Add(products.Where(p => p.StartsWith(searchWord[..i])).Take(3).ToList());
            }

            return result;
        }
    }
}
