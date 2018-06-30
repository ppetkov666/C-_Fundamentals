namespace _07._Predicate_For_Names
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var nameLenght = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Func<string, bool> filter = p => p.Length <= nameLenght;
            Console.WriteLine(string.Join(Environment.NewLine, names.Where(filter)));       
        }
    }
}
