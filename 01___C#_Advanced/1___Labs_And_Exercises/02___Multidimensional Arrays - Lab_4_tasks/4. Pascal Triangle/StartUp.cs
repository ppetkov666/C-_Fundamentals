namespace _4._Pascal_Triangle
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            var height = int.Parse(Console.ReadLine());
            var pascal = new long[height][];
            for (int row = 0; row < height; row++)
            {
                pascal[row] = new long[row + 1];
                pascal[row][0] = 1;
                pascal[row][pascal[row].Length - 1] = 1;
                if (row > 1)
                {
                    for (int column = 1; column < pascal[row].Length - 1; column++)
                    {
                        pascal[row][column] = pascal[row - 1][column-1] + pascal[row - 1][column];
                    }
                }
            }
            for (int row = 0; row < pascal.Length; row++)
            {
                var current = pascal[row];
                for (int column = 0; column < current.Length; column++)
                {
                    if (column == current.Length-1)
                    {
                        Console.Write($"{current[column]}");
                    }
                    else
                    {
                        Console.Write($"{current[column]} ");
                    }                  
                }
                Console.WriteLine();
            }
        }
    }
}
