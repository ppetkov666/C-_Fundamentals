namespace _01._Action_Print
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            var inputOfNames = Console.ReadLine().Split();
            Action<string[]> printNames = p => 
            Console.WriteLine(string.Join(Environment.NewLine, p));
            printNames(inputOfNames);            
        }  
    }
}
