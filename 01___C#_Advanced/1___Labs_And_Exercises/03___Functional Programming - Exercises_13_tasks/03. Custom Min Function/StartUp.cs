namespace _03._Custom_Min_Function
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {

            var inputNums = Console.ReadLine()
                   .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                   .Select(double.Parse)
                   .ToArray();

            Func<double[], double> minFunc = GetMin;

            var minNumber = minFunc(inputNums);

            Console.WriteLine(minNumber);
        }

        private static double GetMin(double[] numbers)
        {
            var min = double.MaxValue;

            foreach (var num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            return min;
        }
    }
}
