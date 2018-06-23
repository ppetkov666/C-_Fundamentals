namespace _6.Traffic_Jam
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            var NofCarsCanPass = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            var counterofCars = 0;
            var input = Console.ReadLine();
            while (input != "end")
            {                
                if (input == "green")
                {
                    for (int i = 0; i < NofCarsCanPass; i++)
                    {
                        if (queue.Count == 0)
                        {
                            continue;
                        }
                        else
                        {
                            counterofCars++;
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                        }                   
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{counterofCars} cars passed the crossroads.");
        }
    }
}
