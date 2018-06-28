namespace _6._Target_Practice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var stairs = InitializeMAtrix();
            ShotOnSnake(stairs);
            // Printing the final Result 
            for (int row = 0; row < stairs.Length; row++)
            {
                for (int column = 0; column < stairs[row].Length; column++)
                {
                    Console.Write(stairs[row][column] );
                }
                Console.WriteLine();
            }
        }
        private static void ShotOnSnake(char[][] matrix)
        {
            var shotData = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var impactRow = shotData[0];
            var impactCol = shotData[1];
            var impactRadius = shotData[2];

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int column = 0; column < matrix[row].Length; column++)
                {
                    if (IsCellShooted(row, column, impactRow, impactCol, impactRadius))
                    {
                        matrix[row][column] = ' ';
                    }
                }
            }

            for (int column = 0; column < matrix[0].Length; column++) 
            {
                for (int row = matrix.Length - 1; row > 0; row--)
                {
                    if (matrix[row][column] == ' ' && matrix[row - 1][column] != ' ')
                    {
                        CellFallsDown(matrix, row, column);
                    }
                }
            }
        }

        private static void CellFallsDown(char[][] matrix, int row, int col)
        {
            while (row < matrix.Length)
            {
                if (matrix[row][col] == ' ')
                {
                    var temp = matrix[row - 1][col];
                    matrix[row - 1][col] = matrix[row][col];
                    matrix[row][col] = temp;
                    row++;
                }
                else
                {
                    return;
                }
            }
        }
        private static bool IsCellShooted(int i, int j, int impactRow, int impactCol, int impactRadius)
        {
            var distance = Math.Sqrt((i - impactRow) * (i - impactRow) + (j - impactCol) * (j - impactCol));
            return distance <= impactRadius;
        }

        private static char[][] InitializeMAtrix()
        {
            var dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var matrix = new char[dimensions[0]][]
                .Select(r => r = new char[dimensions[1]])
                .ToArray();

            var snake = new Queue<char>(Console.ReadLine().ToCharArray());

            
            for (int row = matrix.Length - 1; row >= 0; row--)
            {
                for (int column = matrix[row].Length - 1; column >= 0; column--)
                {
                    matrix[row][column] = snake.Dequeue();
                    snake.Enqueue(matrix[row][column]);
                }
                row--;

                if (row < 0)
                {
                    break;
                }

                for (int column = 0; column < matrix[row].Length; column++)
                {
                    matrix[row][column] = snake.Dequeue();
                    snake.Enqueue(matrix[row][column]);
                }
            }

            return matrix;
        }
    }
}
