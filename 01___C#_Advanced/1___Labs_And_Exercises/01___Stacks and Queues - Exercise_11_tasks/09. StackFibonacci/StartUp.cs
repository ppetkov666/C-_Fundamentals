namespace _09.StackFibonacci
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var stack = new Stack<long>();
            stack.Push(1);
            stack.Push(1);
            for (int i = 2; i < n; i++)
            {
                var lastNumOut = stack.Pop();
                var previousBeforeLast = stack.Peek();
                stack.Push(lastNumOut);

                var currentFib = lastNumOut + previousBeforeLast;
                stack.Push(currentFib);
            }
            Console.WriteLine(stack.Peek());
        }
    }
}
