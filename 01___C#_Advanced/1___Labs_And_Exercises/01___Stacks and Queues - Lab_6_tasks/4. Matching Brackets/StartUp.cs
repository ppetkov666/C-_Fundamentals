namespace _4.Matching_Brackets
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var lengthoftheInput = input.Length;
            var stack = new Stack<int>();
            for (int i = 0; i < lengthoftheInput; i++)
            {
                var currentChar = input[i];
                if (currentChar == '(')
                {
                    stack.Push(i);
                }
                else if (currentChar == ')')
                {
                    var startindex = stack.Pop();
                    var lengthOftheString = i - startindex + 1;
                    var finalstring = input.Substring(startindex, lengthOftheString);
                    Console.WriteLine(finalstring);
                }
            }
        }
    }
}
