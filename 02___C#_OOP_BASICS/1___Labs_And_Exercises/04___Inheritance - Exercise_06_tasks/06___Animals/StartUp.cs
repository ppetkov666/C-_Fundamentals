using System;
using System.Collections.Generic;
public class StartUp
{
    static void Main()
    {
        
        List<Animal> animals = new List<Animal>();
        string animalType;
        while ((animalType = Console.ReadLine()) != "Beast!")
        {
            try
            {
                ReadAndCreateAnimals(animals, animalType);
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }    
        }
        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
    }
    private static void ReadAndCreateAnimals(List<Animal> animals, string animalType)
    {
        var splittedInput = Console.ReadLine()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        var name = splittedInput[0];
        var age = int.Parse(splittedInput[1]);
        string gender = null;
        if (splittedInput.Length == 3)
        {
            gender = splittedInput[2];
        }
        switch (animalType)
        {
            case "Cat":
                Cat cat = new Cat(name, age, gender);
                animals.Add(cat);
                break;
            case "Dog":
                Dog dog = new Dog(name, age, gender);
                animals.Add(dog);
                break;
            case "Frog":
                Frog frog = new Frog(name, age, gender);
                animals.Add(frog);
                break;
            case "Kitten":
                Kitten kitten = new Kitten(name, age);
                animals.Add(kitten);
                break;
            case "Tomcat":
                Tomcat tomcat = new Tomcat(name, age);
                animals.Add(tomcat);
                break;
            default:
                throw new ArgumentException("Invalid input!");    
        }
    }
}

