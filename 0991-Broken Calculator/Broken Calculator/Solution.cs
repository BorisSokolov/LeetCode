namespace Broken_Calculator
{
    /// <summary>
    /// On a broken calculator that has a number showing on its display, we can perform two operations:
    /// Double: Multiply the number on the display by 2, or;
    /// Decrement: Subtract 1 from the number on the display.
    /// Initially, the calculator is displaying the number X.
    /// Return the minimum number of operations needed to display the number Y.
    /// </summary>
    public class Solution
    {
        public int BrokenCalc(int X, int Y)
        {
            int count = 0;

            while (Y > X)
            {
                count++;

                if (Y % 2 == 1)
                    Y++;
                else
                    Y /= 2;
            }

            return count + X - Y;
        }
    }
}
