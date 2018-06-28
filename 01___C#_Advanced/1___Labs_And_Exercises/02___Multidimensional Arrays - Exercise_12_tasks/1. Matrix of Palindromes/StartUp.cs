namespace _1._Matrix_of_Palindromes
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;

    class Matrix_of_Palindromes
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var letters = new StringBuilder();
            var timer = new Stopwatch();
            
            for (int row = 0; row < input[0]; row++)
            {
                for (int column = 0; column < input[1]; column++)
                {
                    char firstLetter = (char)('a' + row);
                    char secondLetter = (char)(firstLetter + column);
                    char thirdletter = (char)(firstLetter);
                    letters.Append($"{firstLetter}{secondLetter}{thirdletter} ");
                }
                if (row != input[0] - 1)
                {
                    letters.Append(Environment.NewLine);
                }
            }
            Console.WriteLine(letters.ToString());
            
            
        }
    }
}
