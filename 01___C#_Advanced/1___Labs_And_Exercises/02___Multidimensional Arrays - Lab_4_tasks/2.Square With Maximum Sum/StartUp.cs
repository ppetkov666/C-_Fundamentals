namespace _2.Square_With_Maximum_Sum
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var matrixsize = Console.ReadLine()
                .Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[][] matrix = new int[matrixsize[0]][];
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine()
                .Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            }
            var maxsquarerow = 0;
            var maxsquarecolumn = 0;
            var sum = int.MinValue;
            for (int row = 0; row < matrix.Length-1; row++)
            {
                for (int column = 0; column < matrix[row].Length - 1; column++)
                {
                    var currentSum = matrix[row][column] + matrix[row][column + 1]
                        + matrix[row + 1][column] + matrix[row + 1][column + 1];
                    if (currentSum > sum)
                    {
                        sum = currentSum;
                        maxsquarerow = row;
                        maxsquarecolumn = column;
                    }
                }
            }
            Console.WriteLine($"{matrix[maxsquarerow][maxsquarecolumn]} {matrix[maxsquarerow][maxsquarecolumn + 1]}" +
                $"\n{matrix[maxsquarerow+1][maxsquarecolumn]} {matrix[maxsquarerow+1][maxsquarecolumn+1]}");
            Console.WriteLine(sum);
        }
    }
}
