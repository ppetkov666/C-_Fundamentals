using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        try
        {
            List<Person> people = ParsePeople();
            List<Product> productlist = ParseProducts();
            BuyProducts(people, productlist);
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
        catch (ArgumentException exception)
        {

            Console.WriteLine(exception.Message);
        }      
    }

    private static void BuyProducts(List<Person> people, List<Product> productlist)
    {
        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            var splittedCommand = command.Split();
            var personName = splittedCommand[0];
            var productName = splittedCommand[1];
            var person = people.First(p => p.Name == personName);
            var product = productlist.First(p => p.Name == productName);
            var output = person.TryBuyProduct(product);
            Console.WriteLine(output);
        }
        
    }

    private static List<Product> ParseProducts()
    {
        var productsInput = Console.ReadLine()
            .Split(';', StringSplitOptions.RemoveEmptyEntries);

        var productlist = new List<Product>();
        foreach (var products in productsInput)
        {
            var splittedInput = products.Split('=');
            var productName = splittedInput[0];
            var productPrice = decimal.Parse(splittedInput[1]);
            var product = new Product(productName, productPrice);
            productlist.Add(product);
        }
        return productlist;
    }

    private static List<Person> ParsePeople()
    {
        var peopleInput = Console.ReadLine()
            .Split(';', StringSplitOptions.RemoveEmptyEntries);
        var people = new List<Person>();
        foreach (var persons in peopleInput)
        {
            var splittedInput = persons.Split('=');
            var personName = splittedInput[0];
            var personMoney = decimal.Parse(splittedInput[1]);
            var person = new Person(personName, personMoney);
            people.Add(person);
        }
        return people;
    }
}

