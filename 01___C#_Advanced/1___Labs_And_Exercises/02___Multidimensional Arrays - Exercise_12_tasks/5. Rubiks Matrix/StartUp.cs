namespace _5._Rubiks_Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Rubiks_Matrix
    {       
        static void Main()
        {
            var matrix = ReadAndInitializeMatrix();
            ReadandExecutionofCommands(matrix);
            Console.Write(GetRearangementSwaps(matrix));
        }
        private static string GetRearangementSwaps(int[][] matrix)
        {
            var sb = new StringBuilder();
            var expectedValue = 1;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] != expectedValue)
                    {
                        sb.Append(Swap(matrix, i, j, expectedValue));
                    }
                    else
                    {
                        sb.Append($"No swap required{Environment.NewLine}");
                    }

                    expectedValue++;
                }
            }

            return sb.ToString();
        }
        private static string Swap(int[][] matrix, int row, int col, int expectedValue)
        {
            for (int i = row; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == expectedValue)
                    {
                        var temp = matrix[i][j];
                        matrix[i][j] = matrix[row][col];
                        matrix[row][col] = temp;

                        return $"Swap ({row}, {col}) with ({i}, {j}){Environment.NewLine}";
                    }
                }
            }

            return string.Empty;
        }

        private static void ReadandExecutionofCommands(int[][] matrix)
        {
            var numberofCommands = int.Parse(Console.ReadLine());


            for (int i = 0; i < numberofCommands; i++)
            {
                var command = Console.ReadLine().Split();
                var roworColumns = int.Parse(command[0]);
                var directions = command[1];
                var moves = int.Parse(command[2]);
                RotateMatrix(matrix, roworColumns, directions, moves);              
            }                          
        }

        private static void RotateMatrix(int[][] matrix, int roworColumns, string directions, int moves)
        {
            switch (directions)
            {
                case "up":
                    var rowBecomingFirst = moves % matrix.Length;

                    if (rowBecomingFirst != 0)
                    {
                        RotateColumn(matrix, roworColumns, rowBecomingFirst);
                    }

                    break;
                case "down":
                    rowBecomingFirst = (moves % matrix.Length == 0)
                        ? 0
                        : matrix.Length - (moves % matrix.Length);

                    if (rowBecomingFirst != 0)
                    {
                        RotateColumn(matrix, roworColumns, rowBecomingFirst);
                    }

                    break;
                case "left":
                    var colBecomingFirst = moves % matrix[roworColumns].Length;

                    if (colBecomingFirst != 0)
                    {
                        RotateRow(matrix, roworColumns, colBecomingFirst);
                    }

                    break;
                case "right":
                    colBecomingFirst = (moves % matrix[roworColumns].Length == 0)
                        ? 0
                        : matrix[roworColumns].Length - (moves % matrix[roworColumns].Length);

                    if (colBecomingFirst != 0)
                    {
                        RotateRow(matrix, roworColumns, colBecomingFirst);
                    }

                    break;
                default:
                    break;
            }
        }
        private static void RotateRow(int[][] matrix, int row, int col)
        {
            var newValues = new Queue<int>(matrix[row].Length);

            for (int j = 0; j < matrix[row].Length; j++)
            {
                if (col == matrix[row].Length)
                {
                    col = 0;
                }

                newValues.Enqueue(matrix[row][col]);
                col++;
            }

            matrix[row] = newValues.ToArray();
        }

        private static void RotateColumn(int[][] matrix, int col, int row)
        {
            var newValues = new Queue<int>(matrix.Length);

            while (newValues.Count < matrix.Length)
            {
                if (row == matrix.Length)
                {
                    row = 0;
                }

                newValues.Enqueue(matrix[row][col]);
                row++;
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i][col] = newValues.Dequeue();
            }
        }
        private static int[][] ReadAndInitializeMatrix()
        {
            var sizeoftheMatrix = Console.ReadLine()
                .Split(new string[] {" "},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var matrix = new int[sizeoftheMatrix[0]][];
            var counter = 1;

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[sizeoftheMatrix[1]];
                for (int column = 0; column < matrix[row].Length; column++)
                {
                    matrix[row][column] = counter;
                    counter++;
                }
            }
            return matrix;
        }

    }
}
