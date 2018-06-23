namespace _1.Reverse_Strings
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine();               
            var inputStack = new Stack<char>();           
            for (int i = 0; i <input.Length ; i++)
            {
                inputStack.Push(input[i]);
            }
            while (inputStack.Count != 0)
            {
                Console.Write(inputStack.Pop());
            }
            Console.WriteLine();
        }
    }
}
