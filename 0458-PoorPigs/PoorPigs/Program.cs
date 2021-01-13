using System;

namespace PoorPigs
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.PoorPigs(1, 1, 1));
            Console.WriteLine(s.PoorPigs(2, 1, 1));
            Console.WriteLine(s.PoorPigs(10, 3, 9));
            Console.WriteLine(s.PoorPigs(15, 3, 9));

            //Console.WriteLine(s.FastCeil(10.5));
            //Console.WriteLine(s.FastCeil(10.1));
            //Console.WriteLine(s.FastCeil(1));
            //Console.WriteLine(s.FastCeil(2));

        }
    }
}
