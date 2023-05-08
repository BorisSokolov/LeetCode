using System;

namespace Keys_and_Rooms
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: [[1],[2],[3],[]]
            //Output: true
            //Explanation:  
            //We start in room 0, and pick up key 1.
            //We then go to room 1, and pick up key 2.
            //We then go to room 2, and pick up key 3.
            //We then go to room 3.  Since we were able to go to every room, we return true.
            Console.WriteLine(s.CanVisitAllRooms(new int[][] { new[] { 1 }, new[] { 2 }, new[] { 3 }, new int [] {} }));
            //Input: [[1,3],[3,0,1],[2],[0]]
            //Output: false
            //Explanation: We can't enter the room with number 2.
            Console.WriteLine(s.CanVisitAllRooms(new int[][] { new[] { 1, 3 }, new []{ 3, 0, 1 }, new[] { 2 }, new[] { 0 } }));
        }
    }
}
