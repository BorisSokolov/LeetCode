namespace Next_Greater_Element_III
{
    /// <summary>
    /// Given a positive integer n, find the smallest integer which has exactly the same digits existing in the integer n and is greater in value than n. If no such positive integer exists, return -1.
    /// Note that the returned integer should fit in 32-bit integer, if there is a valid answer but it does not fit in 32-bit integer, return -1.
    /// </summary>
    public class Solution
    {
        public int NextGreaterElement(int n)
        {
            char[] a = n.ToString().ToCharArray();
            int i = a.Length - 2;

            while (i >= 0 && a[i + 1] <= a[i])
                i--;

            if (i < 0)
                return -1;

            int j = a.Length - 1;

            while (j >= 0 && a[j] <= a[i])
                j--;

            Swap(a, i, j);
            Reverse(a, i + 1);


            return int.TryParse(a, out int result) ? result : -1;
        }

        private void Reverse(char[] a, int start)
        {
            int i = start, j = a.Length - 1;

            while (i < j)
            {
                Swap(a, i, j);
                i++;
                j--;
            }
        }
        private void Swap(char[] a, int i, int j)
        {
            char temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}
