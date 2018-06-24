namespace _06.TruckTour
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var petrolPumpIndex = 0;
            var fuel = 0;
            for (int i = 0; i < n; i++)
            {
                var pipeData = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                var amountoffuel = pipeData[0];
                var distance = pipeData[1];
                fuel += amountoffuel - distance ;

                if (fuel < 0)
                {
                    fuel = 0;
                    petrolPumpIndex = i + 1;
                }
            }
            Console.WriteLine(petrolPumpIndex);
        }
    }
}
