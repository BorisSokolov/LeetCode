using System;

namespace Maximum_Frequency_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //["FreqStack", "push", "push", "push", "push", "push", "push", "pop", "pop", "pop", "pop"],
            //[[],[5],[7],[5],[7],[4],[5],[],[],[],[]]
            //Output: [null,null,null,null,null,null,null,5,7,5,4]
            //        Explanation:
            //After making six.push operations, the stack is [5,7,5,7,4,5] from bottom to top.Then:
            //pop() -> returns 5, as 5 is the most frequent.
            //The stack becomes[5, 7, 5, 7, 4].
            //pop() -> returns 7, as 5 and 7 is the most frequent, but 7 is closest to the top.
            //The stack becomes[5, 7, 5, 4].
            //pop() -> returns 5.
            //The stack becomes[5, 7, 4].
            //pop()->returns 4.
            //The stack becomes[5, 7].
            FreqStack freqStack = new FreqStack();
            freqStack.Push(5);
            freqStack.Push(7);
            freqStack.Push(5);
            freqStack.Push(7);
            freqStack.Push(4);
            freqStack.Push(5);
            Console.WriteLine(freqStack.Pop());
            Console.WriteLine(freqStack.Pop());
            Console.WriteLine(freqStack.Pop());
            Console.WriteLine(freqStack.Pop());
        }
    }
}
