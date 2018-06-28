namespace _3._Squares_in_Matrix
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
            var counter = 0;
            var matrix = new char[matrizsize[0]][];            
            for (int i = 0; i < matrix.Length; i++)
            {       
               matrix[i] = Console.ReadLine()
                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(Char.Parse)
                   .ToArray();
            }
            for (int row = 0; row < matrix.Length -1 ; row++)
            {
                for (int column = 0; column < matrix[row].Length - 1; column++)
                {
                    
                    if (matrix[row][column]==matrix[row][column+1]&&
                        matrix[row+1][column]==matrix[row+1][column+1]&&
                        matrix[row][column]==matrix[row+1][column])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
