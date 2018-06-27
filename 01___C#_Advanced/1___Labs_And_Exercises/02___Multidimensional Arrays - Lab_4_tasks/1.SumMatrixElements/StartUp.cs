namespace _1.SumMatrixElements
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var matrix = new int[input[0], input[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputrows = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = inputrows[column];
                }
            }
            var sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    sum += matrix[row, column];                  
                }                
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
