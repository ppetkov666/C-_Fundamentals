namespace _05._Applied_Arithmetics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse);
            var command = Console.ReadLine().ToLower().Trim();
            while (command != "end")
            {
                if (command == "add") numbers = ForEach(numbers, n => n + 1);
                else if (command == "subtract") numbers = ForEach(numbers, n => n - 1);
                else if (command == "multiply") numbers = ForEach(numbers, n => n * 2);
                else if (command == "print") Console.WriteLine(string.Join(" ", numbers));
                command = Console.ReadLine().ToLower().Trim();
            }
        }
        public static IEnumerable<int> ForEach(IEnumerable<int> collection, Func<int, int> func)
        {
            return collection.Select(n => func(n));
        }
    }
}
