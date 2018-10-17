namespace _02___High_Quality_Mistakes
{
    using System;
    class Program
    {
        static void Main()
        {
            Spy spy = new Spy();
            string result = spy.AnalyzeAcessModifiers(typeof(Hacker).FullName);
            Console.WriteLine(result);
        }
    }
}
