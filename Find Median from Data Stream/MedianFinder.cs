using LeetCode.Domain;
using System.Linq;

namespace Find_Median_from_Data_Stream
{
    public class MedianFinder
    {
        MinHeap<int> upper = new MinHeap<int>();
        MaxHeap<int> lower = new MaxHeap<int>();
        double median;
        /** initialize your data structure here. */
        public MedianFinder()
        {

        }

        public void AddNum(int num)
        {
            if (!lower.Any() || num < lower.GetDominant())
                lower.Add(num);
            else
                upper.Add(num);

            RebalanceHeaps();
            UpdateMedian();
        }

        public double FindMedian()
        {
            return median;
        }

        private void UpdateMedian()
        {
            if (lower.Count == upper.Count)
                median = (lower.GetDominant() + upper.GetDominant()) / 2.0;
            else if (lower.Count > upper.Count)
                median = lower.GetDominant();
            else
                median = upper.GetDominant();
        }

        private void RebalanceHeaps()
        {
            if (lower.Count - upper.Count == 2)
                upper.Add(lower.ExtractDominating());

            else if (upper.Count - lower.Count == 2)
                lower.Add(upper.ExtractDominating());
        }
    }

    /**
     * Your MedianFinder object will be instantiated and called as such:
     * MedianFinder obj = new MedianFinder();
     * obj.AddNum(num);
     * double param_2 = obj.FindMedian();
     */
}
