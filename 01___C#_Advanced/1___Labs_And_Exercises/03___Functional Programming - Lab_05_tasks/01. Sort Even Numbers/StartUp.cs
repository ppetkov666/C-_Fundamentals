namespace _01._Sort_Even_Numbers
{
    using System;
    using System.Linq;
    class StartUp
    {
        delegate int Parser(string text);
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                 .Split(new string[] { ", " },StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .Where(n => n % 2 == 0)
                 .OrderBy(n => n)
                 .ToList();           
                Console.WriteLine(string.Join(", ",numbers));
        } 
    }
}
