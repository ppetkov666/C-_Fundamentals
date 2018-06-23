namespace _3.Decimal_to_Binary_Converter
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            var inputDecimalNumber  = int.Parse(Console.ReadLine());
            var stackHexNumber = new Stack<int>();
            if (inputDecimalNumber == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (inputDecimalNumber != 0)
                {
                    stackHexNumber.Push(inputDecimalNumber % 2);
                    inputDecimalNumber = inputDecimalNumber / 2;
                }
                while (stackHexNumber.Count != 0)
                {
                    Console.Write(stackHexNumber.Pop());
                }
                Console.WriteLine();
            }         
        }
    }
}
