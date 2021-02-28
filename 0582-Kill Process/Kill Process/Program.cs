using System;

namespace Kill_Process
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input:
            //pid =  [1, 3, 10, 5]
            //ppid = [3, 0, 5, 3]
            //kill = 5
            //Output: [5, 10]
            //Explanation:
            //            3
            //          /   \
            //        1     5
            //             /
            //            10
            //Kill 5 will also kill 10.
            Console.WriteLine(string.Join(',', s.KillProcess(new[] { 1, 3, 10, 5 }, new[] { 3, 0, 5, 3 }, 5)));
        }
    }
}
