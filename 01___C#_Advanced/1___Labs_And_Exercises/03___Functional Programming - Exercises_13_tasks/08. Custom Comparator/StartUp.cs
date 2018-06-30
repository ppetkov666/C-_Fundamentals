namespace _08._Custom_Comparator
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var inputNums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int, int, int> compareFunktion = (n1, n2) =>
            (n1 % 2 == 0 && n2 % 2 != 0) ? -1 :
            (n1 % 2 != 0 && n2 % 2 == 0) ? 1 :
            n1.CompareTo(n2);

            Array.Sort<int>(inputNums, new Comparison<int>(compareFunktion));

            Console.WriteLine(string.Join(" ", inputNums));
        }
    }
}
