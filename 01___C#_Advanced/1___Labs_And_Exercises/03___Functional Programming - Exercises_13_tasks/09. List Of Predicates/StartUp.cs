namespace _09._List_Of_Predicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var endNumberOfRange = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse);
                
            Queue<int> numbers = new Queue<int>();
            var predicates = dividers
                .Select(div => (Func<int, bool>)(n => n % div == 0))
                .ToArray();

            for (int i = 1; i <= endNumberOfRange; i++)
            {
                if (CanBeDivided(predicates, i))
                {
                    numbers.Enqueue(i);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        private static bool CanBeDivided(Func<int, bool>[] predicates, int index)
        {
            foreach (var predicate in predicates)
            {
                if (!predicate(index))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
