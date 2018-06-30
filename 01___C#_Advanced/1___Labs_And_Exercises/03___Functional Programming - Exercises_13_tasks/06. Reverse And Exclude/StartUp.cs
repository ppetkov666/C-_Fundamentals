namespace _06._Reverse_And_Exclude
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
            var divisibleNum = int.Parse(Console.ReadLine());
            Func<int, bool> filter = p => p % divisibleNum != 0;
            var outputNums = numbers.Reverse().Where(filter);
            Console.WriteLine(string.Join(" ", outputNums));
        }
    }
}
