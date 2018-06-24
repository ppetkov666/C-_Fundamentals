namespace _01.Reverse_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            Stack<int> numbers = new Stack<int>();
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            for (int i = 0; i < input.Count; i++)
            {
                numbers.Push(input[i]);
            }
            for (int i = 0; i < input.Count; i++)
            {
                if (i == input.Count - 1)
                {
                    Console.WriteLine(numbers.Pop());
                }
                else
                {
                    Console.Write(numbers.Pop() + " ");
                }
            }      
        }
    }
}
