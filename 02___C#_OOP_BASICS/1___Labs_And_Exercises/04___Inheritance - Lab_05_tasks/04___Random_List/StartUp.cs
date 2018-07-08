using System;

public class Program
{
    static void Main()
    {
        var randomtext = new RandomList();
        randomtext.Add("petko");
        randomtext.Add("gosho");
        randomtext.Add("ivan");
        randomtext.Add("ivan");
        randomtext.Add("dragan");
        
        Console.WriteLine(randomtext.RandomString());
        Console.WriteLine(randomtext.RandomString());
        foreach (var item in randomtext)
        {
            Console.WriteLine($"{item} left in the list");
        }
    }
}

