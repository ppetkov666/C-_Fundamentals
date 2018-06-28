namespace _4._Maximal_Sum
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            var matrizsize = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var sum = 0;
            var maxsum = int.MinValue;
            var rowindex = 0;
            var columnindex = 0;
            var matrix = new int[matrizsize[0]][];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new string[]{" "}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }
            var dot = 1;
            for (int row = 0; row < matrix.Length - 2; row++)
            {
                for (int column = 0; column < matrix[row].Length - 2; column++)
                {
                    sum = matrix[row][column] + matrix[row][column + 1] + matrix[row][column + 2] +
                          matrix[row+1][column] + matrix[row+1][column + 1] + matrix[row+1][column + 2] +
                          matrix[row+2][column] + matrix[row+2][column + 1] + matrix[row+2][column + 2];
                    if (sum > maxsum)
                    {
                        maxsum = sum;
                        rowindex = row;
                        columnindex = column;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxsum}");
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.Write($"{matrix[rowindex+row][columnindex+column]} ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
