namespace _02._Knights_of_Honor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" \n\r\t"
                .ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Action<IEnumerable<string>> action = 
                collection => Console.WriteLine
                (string.Join(Environment.NewLine, collection.Select(name => $"Sir {name}")));
            action(input);
        }
        
    }
}
