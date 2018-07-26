namespace _02___Generic_Box_of_Integer
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var numOfStrings = int.Parse(Console.ReadLine());

            while (numOfStrings > 0)
            {
                Console.WriteLine(new Box<int>(int.Parse(Console.ReadLine())));

                numOfStrings--;
            }
        }
    }
}
