namespace _02.BasicStackOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            var stack = new Stack<int>();
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var NelementsforPush = input[0];
            var NelemenetsforPop = input[1];
            var elementforPeek = input[2];
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < NelemenetsforPop; i++)
            {
                stack.Pop();
            }
            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(elementforPeek))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
