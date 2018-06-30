namespace _13._TriFunction
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var charSumNumberGoal = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split().ToArray();

            Func<string, int, bool> WordInTheSearchedLimit = (name, num) => name.ToCharArray()
                .Select(character => (int)character).Sum() >= num;

            Func<string[], int, Func<string, int, bool>, string> firstValidName = 
                (arr, num, func) => arr
                .FirstOrDefault(str => func(str, num));

            var finalOutput = firstValidName(names, charSumNumberGoal, WordInTheSearchedLimit);
            Console.WriteLine(finalOutput);
            
        }
    }
}
