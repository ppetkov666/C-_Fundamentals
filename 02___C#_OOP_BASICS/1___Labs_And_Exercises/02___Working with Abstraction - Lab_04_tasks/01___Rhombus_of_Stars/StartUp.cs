using System;
class StartUp
{
    static void Main()
    {
        var rhombusSize = int.Parse(Console.ReadLine());
        for (int rowSize = 1; rowSize < rhombusSize; rowSize++)
        {
            PrintRow(rhombusSize, rowSize);
        }
        for (int rowSize = rhombusSize ; rowSize > 0; rowSize--)
        {
            PrintRow(rhombusSize, rowSize);
        }

    }
    static void PrintRow(int rhombusSize, int rowSize)
    {
        for (int i = 0; i < (rhombusSize-rowSize); i++)
        {
            Console.Write(' ');
        }
        for (int i = 0; i < rowSize; i++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
}

