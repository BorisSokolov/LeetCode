namespace Basic_Calculator_II
{
    /// <summary>
    /// Implement a basic calculator to evaluate a simple expression string.
    /// The expression string contains only non-negative integers, +, -, *, / operators and empty spaces.The integer division should truncate toward zero.
    /// </summary>
    public class Solution
    {
        public int Calculate(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;

            int length = s.Length;
            int currentNumber = 0;
            int lastNumber = 0;
            int result = 0;
            char operation = '+';

            for (int i = 0; i < length; i++)
            {
                char currentChar = s[i];
                if (char.IsDigit(currentChar))
                {
                    currentNumber = (currentNumber * 10) + (currentChar - '0');
                }
                if (!char.IsDigit(currentChar) && !char.IsWhiteSpace(currentChar) || i == length - 1)
                {
                    switch (operation)
                    {
                        case '+':
                        case '-':
                            result += lastNumber;
                            lastNumber = (operation == '+') ? currentNumber : -currentNumber;
                            break;
                        case '*':
                            lastNumber *= currentNumber;
                            break;
                        case '/':
                            lastNumber /= currentNumber;
                            break;
                    }
                    operation = currentChar;
                    currentNumber = 0;
                }
            }
            result += lastNumber;

            return result;
        }
    }
}
