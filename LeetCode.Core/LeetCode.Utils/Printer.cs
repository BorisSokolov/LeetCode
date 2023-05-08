using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Utils
{
    public static class Printer
    {
        public static string Print<T>(this IEnumerable<IEnumerable<T>> helper)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var line in helper)
                sb.Append($"[{string.Join(", ", line)}]{Environment.NewLine}");

            return sb.ToString();
        }
    }
}
