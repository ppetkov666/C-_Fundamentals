namespace _04._Find_Evens_or_Odds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var begining = input[0];
            var end = input[1];
            var evenOrOdd = Console.ReadLine();
            Predicate<int> predicate;

            if (evenOrOdd == "odd")
            {
                predicate = n => n % 2 != 0;
            }
            else if (evenOrOdd == "even")
            {
                predicate = n => n % 2 == 0;
            }
            else
            {
                predicate = null;
            }              

            var result = EvensOrOdds(begining, end, predicate);
            Console.WriteLine(string.Join(" ", result));

        }

        public static Queue<int> EvensOrOdds(int begining, int end, Predicate<int> filter)
        {
            var numbers = new Queue<int>();

            for (int i = begining; i <= end; i++)
            {
                if (filter(i))
                {
                    numbers.Enqueue(i);
                }
            }
            return numbers;
        }
    }
}
