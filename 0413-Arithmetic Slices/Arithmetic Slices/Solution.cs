namespace Arithmetic_Slices
{
    /// <summary>
    /// A zero-indexed array A consisting of N numbers is given. A slice of that array is any pair of integers (P, Q) such that 0 <= P < Q < N.
    /// A slice(P, Q) of the array A is called arithmetic if the sequence:
    /// A[P], A[P + 1], ..., A[Q - 1], A[Q] is arithmetic.In particular, this means that P + 1 < Q.
    /// The function should return the number of arithmetic slices in the array A.
    /// </summary>
    public class Solution
    {
        public int NumberOfArithmeticSlices(int[] A)
        {
            int dp = 0;
            int sum = 0;
            for (int i = 2; i < A.Length; i++)
            {
                if (A[i] - A[i - 1] == A[i - 1] - A[i - 2])
                    sum += ++dp;
                else
                    dp = 0;
            }
            return sum;
        }
    }
}
