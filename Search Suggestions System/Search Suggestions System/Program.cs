using System;
using LeetCode.Utils;

namespace Search_Suggestions_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: products = ["mobile", "mouse", "moneypot", "monitor", "mousepad"], searchWord = "mouse"
            //Output: [
            //["mobile", "moneypot", "monitor"],
            //["mobile","moneypot","monitor"],
            //["mouse","mousepad"],
            //["mouse","mousepad"],
            //["mouse","mousepad"]
            //]
            //Explanation: products sorted lexicographically = ["mobile","moneypot","monitor","mouse","mousepad"]
            //        After typing m and mo all products match and we show user["mobile", "moneypot", "monitor"]
            //After typing mou, mous and mouse the system suggests["mouse", "mousepad"]
            Console.WriteLine(s.SuggestedProducts(new[] { "mobile", "mouse", "moneypot", "monitor", "mousepad" }, "mouse").Print());
            //Input: products = ["havana"], searchWord = "havana"
            //Output: [["havana"],["havana"],["havana"],["havana"],["havana"],["havana"]]
            Console.WriteLine(s.SuggestedProducts(new[] { "havana" }, "havana").Print());
            //Input: products = ["bags","baggage","banner","box","cloths"], searchWord = "bags"
            //Output: [["baggage","bags","banner"],["baggage","bags","banner"],["baggage","bags"],["bags"]]
            Console.WriteLine(s.SuggestedProducts(new[] { "bags", "baggage", "banner", "box", "cloths" }, "bags").Print());
            //Input: products = ["havana"], searchWord = "tatiana"
            //Output: [[],[],[],[],[],[],[]]
            Console.WriteLine(s.SuggestedProducts(new[] { "havana" }, "tatiana").Print());
        }
    }
}
