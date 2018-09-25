namespace _07___Equality_Logic
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var sortedPeople = new SortedSet<Person>();
            var hashedPeople = new HashSet<Person>(new PersonEqComparer());
            FillCollections(sortedPeople, hashedPeople);

            Console.WriteLine(sortedPeople.Count);
            Console.WriteLine(hashedPeople.Count);
        }

        private static void FillCollections(SortedSet<Person> sortedPeople, HashSet<Person> hashedPeople)
        {
            var numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                var personInfo = Console.ReadLine().Split();
                var name = personInfo[0];
                var age = int.Parse(personInfo[1]);

                sortedPeople.Add(new Person(name, age));
                hashedPeople.Add(new Person(name, age));
            }
        }
    }
}
