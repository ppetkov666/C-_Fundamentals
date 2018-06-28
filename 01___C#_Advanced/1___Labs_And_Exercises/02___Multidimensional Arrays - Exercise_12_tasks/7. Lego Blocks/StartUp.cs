namespace _7._Lego_Blocks
{
    using System;
    using System.Linq;
    using System.Text;

    class StartUp
    {
        static void Main()
        {
            var rowNumbers = int.Parse(Console.ReadLine());
            var firstMatrix = InitializetheMatrix(rowNumbers);
            var secondMatrix = InitializetheMatrix(rowNumbers)
                .Select(p => p.Reverse()
                .ToArray())
                .ToArray();
             
            PrintResult(firstMatrix, secondMatrix);
        }
        private static void PrintResult(int[][] firstMatrix, int[][] secondMatrix)
        {
            if (MatchingBothMatrix(firstMatrix, secondMatrix))
            {
                for (int i = 0; i < firstMatrix.Length; i++)
                {
                    
                    Console.WriteLine($"[{string.Join(", ", firstMatrix[i].Concat(secondMatrix[i]))}]");
                }
            }
            else
            {
                Console.WriteLine($"The total number of cells is: {CellsCount(firstMatrix, secondMatrix)}");
            }
        }
        private static object CellsCount(int[][] firstMatrix, int[][] secondMatrix)
        {
            var countofCells = 0;

            for (int i = 0; i < firstMatrix.Length; i++)
            {
                countofCells += firstMatrix[i].Length + secondMatrix[i].Length;
            }

            return countofCells;
        }

        private static bool MatchingBothMatrix(int[][] firstMatrix, int[][] secondMatrix)
        {
            for (int i = 0; i < firstMatrix.Length - 1; i++)
            {
                if (firstMatrix[i].Length + secondMatrix[i].Length !=
                    firstMatrix[i + 1].Length + secondMatrix[i + 1].Length)
                {
                    return false;
                }
            }

            return true;
        }
        private static int[][] InitializetheMatrix(int numberofrows)
        {
            var matrix = new int[numberofrows][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }
            return matrix;
        }
    }
}
