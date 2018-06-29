namespace _03._Count_Uppercase_Words
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            Func<string, bool> isUpper = p=>char.IsUpper(p[0]);
            var text = Console.ReadLine()
                .Trim()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(isUpper)
                .ToArray();               
            Console.WriteLine(string.Join(Environment.NewLine + "",text));
        }
    }
}
