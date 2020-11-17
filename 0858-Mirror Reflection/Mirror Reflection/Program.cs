using System;

namespace Mirror_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine($"p = 2, q = 1, result = {s.MirrorReflection(2, 1)}");
            Console.WriteLine($"p = 3, q = 1, result = {s.MirrorReflection(3, 1)}");
            Console.WriteLine($"p = 10, q = 1, result = {s.MirrorReflection(10, 1)}");
            Console.WriteLine($"p = 10, q = 1, result = {s.MirrorReflection(10, 2)}");
            Console.WriteLine($"p = 10, q = 1, result = {s.MirrorReflection(10, 3)}");
            Console.WriteLine($"p = 10, q = 1, result = {s.MirrorReflection(11, 2)}");
        }
    }
}
