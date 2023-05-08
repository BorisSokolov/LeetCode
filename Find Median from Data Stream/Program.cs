using System;

namespace Find_Median_from_Data_Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            var mf = new MedianFinder();

            mf.AddNum(1);
            mf.AddNum(2);
            Console.WriteLine(mf.FindMedian());
            mf.AddNum(3);
            Console.WriteLine(mf.FindMedian());
        }
    }
}
