namespace _11.PoisonousPlants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            var numOfPlants = int.Parse(Console.ReadLine());
            var plants = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)                
                .ToArray();

            var dayofDeadForEachPlant = new int[numOfPlants];
            var previousindex = new Stack<int>();
            previousindex.Push(0);
            for (int i = 1; i < numOfPlants; i++)
            {
                int maxdiedplants = 0;

                while (previousindex.Count > 0 
                    && plants[previousindex.Peek()] >= plants[i])
                {
                    maxdiedplants = Math.Max
                        (maxdiedplants, dayofDeadForEachPlant[previousindex.Pop()]);
                    
                }
                if (previousindex.Count > 0)
                {
                    dayofDeadForEachPlant[i] = maxdiedplants + 1;
                }
                
                previousindex.Push(i);
            }
            Console.WriteLine(dayofDeadForEachPlant.Max());
        }
    }
}
