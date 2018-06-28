namespace _9._Crossfire
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            var matrix = ReadandInitializeMatrix();
            matrix = ReadandExecuteCommands(matrix);
            PrintAliveCells(matrix);
        }
        private static void PrintAliveCells(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i].Where(p => p != -1)));
            }
        }

        private static int[][] ReadandExecuteCommands(int[][] matrix)
        {
            var command = Console.ReadLine().Trim();

            while (command != "Nuke it from orbit")
            {
                var commandDetails = command
                    .Split(new string[] {" "},StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var hitRow = commandDetails[0];
                var hitColumn = commandDetails[1];
                var hitWaveRadius = commandDetails[2];

                matrix = DestroyMatrix(matrix, hitRow, hitColumn, hitWaveRadius);

                command = Console.ReadLine();
            }

            return matrix;
        }

        private static int[][] DestroyMatrix(int[][] matrix, int hitRow, int hitCol, int hitWave)
        {
            // Mark destroyed part of the column
            for (int row = hitRow - hitWave; row <= hitRow + hitWave; row++)
            {
                if (IsInMatrix(row, hitCol, matrix))
                {
                    matrix[row][hitCol] = -1;
                }
            }

            // Mark destroyed part of the row
            for (int col = hitCol - hitWave; col <= hitCol + hitWave; col++)
            {
                if (IsInMatrix(hitRow, col, matrix))
                {
                    matrix[hitRow][col] = -1;
                }
            }

            // Remove destroyed cells
            for (int row = 0; row < matrix.Length; row++)
            {
                // Remove destroyed cells if there is ones
                for (int column = 0; column < matrix[row].Length; column++)
                {
                    if (matrix[row][column] < 0)
                    {
                        matrix[row] = matrix[row].Where(p => p > 0).ToArray();
                        break;
                    }
                }

                // Remove empty rows
                if (matrix[row].Count() < 1)
                {
                    matrix = matrix.Take(row).Concat(matrix.Skip(row + 1)).ToArray();
                    row--;
                }
            }

            return matrix;
        }

        private static bool IsInMatrix(int row, int col, int[][] matrix)
        {
           bool isinside =  row >= 0 && col >= 0 && row < matrix.Length && col < matrix[row].Length;
            return isinside;
        }

        private static int[][] ReadandInitializeMatrix()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var currentNum = 1;
            var matrix = new int[dimensions[0]][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[dimensions[1]];

                for (int column = 0; column < matrix[row].Length; column++)
                {
                    matrix[row][column] = currentNum;
                    currentNum++;
                }
            }

            return matrix;
        }
    }
}
