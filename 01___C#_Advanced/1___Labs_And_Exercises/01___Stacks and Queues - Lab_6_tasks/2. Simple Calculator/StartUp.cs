namespace _2.SimpleCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var splittedInput = Console.ReadLine().Split(' ').ToArray();
            var StackCalc = new Stack<string>(splittedInput.Reverse());
            while (StackCalc.Count > 1 )
            {
                int firstN = int.Parse(StackCalc.Pop());
                var sign = StackCalc.Pop();
                int secondN = int.Parse(StackCalc.Pop());
                if (sign == "+") StackCalc.Push((firstN + secondN).ToString());
                else if (sign == "-") StackCalc.Push((firstN - secondN).ToString());
            }
            Console.WriteLine(StackCalc.Pop());
        }
    }
}
