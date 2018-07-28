namespace _05___G_c_Count_Method_String
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main()
        {
            var numOfelements = int.Parse(Console.ReadLine());
            var storageList = new List<Box<string>>();

            for (int i = 0; i < numOfelements; i++)
            {
                var element = Console.ReadLine();
                storageList.Add(new Box<string>(element));
            }

            var comparingElement = new Box<string>(Console.ReadLine());
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
