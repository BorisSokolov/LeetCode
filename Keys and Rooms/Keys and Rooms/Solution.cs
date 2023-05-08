using System.Collections.Generic;
using System.Linq;

namespace Keys_and_Rooms
{
    public class Solution
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            var keys = new HashSet<int>
            {
                0
            };
            var openRooms = new Stack<int>();
            openRooms.Push(0);

            while (openRooms.Any() && keys.Count < rooms.Count)
            {
                foreach (int key in rooms[openRooms.Pop()])
                {
                    if (keys.Add(key))
                        openRooms.Push(key);
                }
            }

            return keys.Count == rooms.Count;
        }
    }
}
