using System;
using System.Collections.Generic;

class StartUp
{
    static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var persons = new List<Person>();
        for (int i = 0; i < lines; i++)
        {
            var cmdArgs = Console.ReadLine().Split();
            try
            {
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
                persons.Add(person);
            }
            catch (ArgumentException argExc)
            {

                Console.WriteLine(argExc.Message);
            }
        }
        var bonus = decimal.Parse(Console.ReadLine());
        // 3 different Options to perform Foreach with Method !
        //foreach (var person in persons)
        //{
        //    person.IncreaseSalary(bonus);
        //}
        //foreach (var person in persons)
        //{
        //    Console.WriteLine(person);
        //}
        //persons.ForEach(p =>
        //{
        //    p.IncreaseSalary(bonus);
        //    Console.WriteLine(p);
        //});
        persons.ForEach(p => p.IncreaseSalary(bonus));
        persons.ForEach(p => Console.WriteLine(p));
    }
}

