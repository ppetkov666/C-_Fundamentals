namespace _08.RecursiveFibonacci
{
    using System;
    class StartUp
    {
        private static long[] fibonachiNUm;
        static void Main()
        {
            var nthnumber = int.Parse(Console.ReadLine());
            fibonachiNUm = new long[nthnumber];
            var finalresult = GetFibonachiNumber(nthnumber);
            Console.WriteLine(finalresult);
        }
        private static long GetFibonachiNumber(int number)
        {
            if (number <= 2)
            {
                return 1;
            }
            if (fibonachiNUm[number-1] != 0)
            {
                return fibonachiNUm[number - 1];
            }
            return fibonachiNUm[number-1] = 
                GetFibonachiNumber(number - 1) + GetFibonachiNumber(number - 2);
        }
    }
}
