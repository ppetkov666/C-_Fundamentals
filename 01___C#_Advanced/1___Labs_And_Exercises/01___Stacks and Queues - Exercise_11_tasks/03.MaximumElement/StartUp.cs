namespace _03.MaximumElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    class StartUp
    {
        static void Main()
        {
            var stack = new Stack<int>();
            var stackofMaxElements = new Stack<int>();
            stackofMaxElements.Push(int.MinValue);
            var finalresult = new StringBuilder();
            var number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                var command = Console.ReadLine();
                if (command.Length > 1)
                {
                    var splittedCommand = command.Split(' ').Select(int.Parse).ToArray();
                    var elementforPush = splittedCommand[1];
                    stack.Push(elementforPush);
                    if (elementforPush >= stackofMaxElements.Peek())
                    {
                        stackofMaxElements.Push(elementforPush);
                    }
                }
                else if (command == "2")
                {
                    var elementToDelete = stack.Pop();
                    if (elementToDelete == stackofMaxElements.Peek())
                    {
                        stackofMaxElements.Pop();
                    }
                }
                else if (command == "3")
                {
                    finalresult.Append($"{stackofMaxElements.Peek()}{Environment.NewLine}");
                }
            }           
            Console.Write(finalresult.ToString());
        }
    }
}
