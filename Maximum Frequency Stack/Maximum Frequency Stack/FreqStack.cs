using System.Collections.Generic;

namespace Maximum_Frequency_Stack
{
    /// <summary>
    /// Implement FreqStack, a class which simulates the operation of a stack-like data structure.
    /// </summary>
    public class FreqStack
    {
        private Dictionary<int, int> frequency = new Dictionary<int, int>();
        private Dictionary<int, Stack<int>> groups = new Dictionary<int, Stack<int>>();
        private int maxFrequency = 0;

        public FreqStack()
        {

        }

        /// <summary>
        /// pushes an integer <paramref name="x"/> onto the stack.
        /// </summary>
        /// <param name="x"></param>
        public void Push(int x)
        {
            if (frequency.ContainsKey(x))
                frequency[x]++;
            else
                frequency[x] = 1;

            if (!groups.ContainsKey(frequency[x]))
                groups[frequency[x]] = new Stack<int>();

            groups[frequency[x]].Push(x);

            if (maxFrequency < frequency[x])
                maxFrequency = frequency[x];
        }

        /// <summary>
        /// removes and returns the most frequent element in the stack.
        /// If there is a tie for most frequent element, the element closest to the top of the stack is removed and returned.
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            int x = groups[maxFrequency].Pop();
            frequency[x]--;

            if (groups[maxFrequency].Count == 0)
                maxFrequency--;

            return x;
        }
    }
}
