namespace _05._Filter_By_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var numOfPeople = int.Parse(Console.ReadLine());
            var people = new Dictionary<string, int>(numOfPeople);
            for (int i = 0; i < numOfPeople; i++)
            {
                var nameAndAgeOfPeople = Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                people.Add(nameAndAgeOfPeople[0], int.Parse(nameAndAgeOfPeople[1]));
            }
            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            var filter = CreateFilter(condition, age);
            var print = CreatePrint(format);
            foreach (var person in people)
            {
                if (filter(person))
                {
                    print(person);
                }
            }
            // the other way to print the final result
            //people.Where(filter).ToList().ForEach(print);
        }
        public static Func<KeyValuePair<string,int>,bool> CreateFilter (string condition,int age)
        {
            if (condition == "younger")
            {
                return p => p.Value < age;
            }
            else
            {
                return p => p.Value >= age;
            }
        }
        public static Action<KeyValuePair<string,int>> CreatePrint(string format)
        {
            switch (format)
            {
                case "name":
                    return p => Console.WriteLine(p.Key);
                    
                case "name age":
                    return p => Console.WriteLine($"{p.Key} - {p.Value}");
                    
                case "age":
                    return p => Console.WriteLine(p.Value);
                    
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
