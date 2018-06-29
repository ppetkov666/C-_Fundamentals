namespace _04._Add_VAT
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
           .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
           .Select(p => double.Parse(p,System.Globalization.CultureInfo.InvariantCulture))
           .Select(p => p * 1.2)
           .ToList()
           .ForEach(p => Console.WriteLine($"{p:f2}"));
        }
    }
}
