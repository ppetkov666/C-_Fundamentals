namespace _03___Gen._Swap_Method_String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var numOfStrings = int.Parse(Console.ReadLine());
            var listOfBoxes = new List<Box<string>>();

            for (int i = 0; i < numOfStrings; i++)
            {
                var value = Console.ReadLine();
                listOfBoxes.Add(new Box<string>(value));
            }

            var swapIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Swap(listOfBoxes, swapIndexes[0], swapIndexes[1]);
            // -- first option 
            //listOfBoxes.ForEach(s => Console.WriteLine(s));
            // -- second option
            foreach (var box in listOfBoxes)
            {
                Console.WriteLine(box);
            }
        }
        private static void Swap<T>(IList<T> collection, int indexToSwap, int swapWithIndex)
        {
            var temp = collection[indexToSwap];
            collection[indexToSwap] = collection[swapWithIndex];
            collection[swapWithIndex] = temp;
        }
    }
}
