namespace _3._Group_Numbers
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var inputN = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] sizes = new int[3];
            foreach (var numbers in inputN)
            {
                var reminder = Math.Abs(numbers % 3);
                sizes[reminder]++;
            }
            int[][] matrix = new int[3][]
            {
                new int[sizes[0]],
                new int[sizes[1]],
                new int[sizes[2]],

            };
            int[] offset = new int[3];
            foreach (var numbers in inputN)
            {
                var reminder = Math.Abs(numbers % 3);
                var index = offset[reminder];
                offset[reminder]++;
                matrix[reminder][index] = numbers;
            }
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
