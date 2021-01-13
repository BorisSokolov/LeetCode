using LeetCode.Utils;
namespace Boats_to_Save_People
{
    /// <summary>
    /// The i-th person has weight people[i], and each boat can carry a maximum weight of limit.
    /// Each boat carries at most 2 people at the same time, provided the sum of the weight of those people is at most limit.
    /// Return the minimum number of boats to carry every given person.  (It is guaranteed each person can be carried by a boat.)
    /// </summary>
    public class Solution
    {
        public int NumRescueBoats(int[] people, int limit)
        {
            if (people == null || people.Length < 1)
                return 0;

            //Two pointer approach as each boat can handle at most two people at the same time
            //Changing Array.Sort that uses a Quicksort to more efficient Radix sort
            //Array.Sort(people);
            Sorting.RadixSort(people);

            int start = 0;
            int end = people.Length - 1;
            int boatCount = 0;

            while (start <= end)
            {
                //check if the boat can handle two 
                if (people[start] + people[end] <= limit)
                    start++;

                end--;
                boatCount++;
            }

            return boatCount;
        }
    }
}
