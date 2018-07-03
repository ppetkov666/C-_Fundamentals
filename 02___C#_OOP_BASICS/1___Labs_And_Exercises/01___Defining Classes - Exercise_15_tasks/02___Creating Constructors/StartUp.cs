using System;
class StartUp
{
    static void Main()
    {
        Person person = new Person("gosho",25);
        Console.WriteLine(person.Name);
        Console.WriteLine(person.Age);
    }
}

