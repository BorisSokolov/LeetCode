using System;

namespace Can_Place_Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: flowerbed = [1, 0, 0, 0, 1], n = 1
            //Output: true
            Console.WriteLine(s.CanPlaceFlowers(new[] { 1, 0, 0, 0, 1 }, 1));
            Console.WriteLine(s.CanPlaceFlowers(new[] { 1, 0, 0, 0, 1 }, 2));
            Console.WriteLine(s.CanPlaceFlowers(new[] { 1, 0, 0, 0, 1, 1, 0, 0, 0, 1 }, 2));
            Console.WriteLine(s.CanPlaceFlowers(new[] { 1, 0, 0, 0, 1, 1, 0, 0, 0, 1 }, 3));
            Console.WriteLine(s.CanPlaceFlowers(new[] { 1, 0, 0, 0, 0, 0, 1 }, 2));
        }
    }
}
