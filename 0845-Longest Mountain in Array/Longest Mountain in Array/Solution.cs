namespace Longest_Mountain_in_Array
{
    public class Solution
    {
        public int LongestMountain(int[] a)
        {
            if (a.Length < 3)
                return 0;

            //starting index of sub-array
            int start = -1;
            //ending index of sub-array
            int end = -1;
            //total size of the longest sub-array
            int size = 0;

            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i + 1] > a[i])
                {
                    //new mountain
                    if (end != -1)
                    {
                        end = -1;
                        start = i;
                    }

                    if (start == -1)
                        start = i;
                }
                else if (a[i + 1] < a[i] && start != -1)
                {
                    end = i + 1;
                }
                else if (a[i] == a[i + 1])
                {
                    start = -1;
                    end = -1;
                }

                if (start != -1 && end != -1 && size < end - start + 1)
                    size = end - start + 1;
            }
            return size;
        }
    }
}
