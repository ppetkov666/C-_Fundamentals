namespace _06___G_c_Count_Method_Double
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main()
        {
            int numOfelements = int.Parse(Console.ReadLine());
            List<Box<double>> storageList = new List<Box<double>>();

            for (int i = 0; i < numOfelements; i++)
            {
                double element = double.Parse(Console.ReadLine());
                storageList.Add(new Box<double>(element));
            }

            var comparingElement = new Box<double>(double.Parse((Console.ReadLine())));
            Console.WriteLine
                (GetCountOfElements(storageList, comparingElement));
        }

        private static int GetCountOfElements<T>
                (IEnumerable<T> collection, T value)
                where T : IComparable<T>
        {
            var count = 0;

            foreach (var item in collection)
            {
                if (item.CompareTo(value) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
