namespace _11___Threeuple
{
    using System;
    class StartUp
    {
        static void Main()
        {
            
            var input = Console.ReadLine().Split();
            var name = $"{input[0]} {input[1]}";
            var address = input[2];
            var town = input[3];
            Console.WriteLine(new Threeuple<string, string, string>(name, address, town));

            input = Console.ReadLine().Split();
            name = input[0];
            var beerLiterrs = int.Parse(input[1]);
            var drunkOrNot = input[2] == "drunk";
            Console.WriteLine(new Threeuple<string, int, bool>(name, beerLiterrs, drunkOrNot));
    
            input = Console.ReadLine().Split();
            name = input[0];
            var accountBalance = double.Parse(input[1]); // Judge expects Double and there is not evaluation for Decimal
            var bankName = input[2];
            Console.WriteLine(new Threeuple<string, double, string>(name, accountBalance, bankName));
        }
    }
}
