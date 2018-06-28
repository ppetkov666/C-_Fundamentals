namespace _2._Diagonal_Difference
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var matrixSize = int.Parse(Console.ReadLine());
            var matrix = new int[matrixSize][];
            var primaryDiagonalSum = 0;
            var secondaryDiagonalSum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new string[] {" "},StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            }
            // calculate primary Diagonal 
            for (int i = 0; i < matrix.Length; i++)
            {
                primaryDiagonalSum += matrix[i][i];
            }
            // calculate secondary Diagonal 
            for (int i = 0; i < matrix.Length; i++)
            {
                secondaryDiagonalSum += matrix[i][matrix.Length - 1 - i];
            }
            Console.WriteLine(Math.Abs(primaryDiagonalSum-secondaryDiagonalSum));
        }
    }
}
