using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        var cats = GetCats();
        PrintCat(cats); 
        
    }
    private static void PrintCat(List<Cat> cats)
    {
        var cat = Console.ReadLine();
        var searchedCat = cats.FirstOrDefault(p => p.Name == cat);
        Console.WriteLine(searchedCat.ToString());
    }
    private static List<Cat> GetCats()
    {
        var cats = new List<Cat>();
        var catInfo = Console.ReadLine().Split();

        while (catInfo[0] != "End")
        {
            var breed = catInfo[0];
            var name = catInfo[1];
            var characteristicValue = double.Parse(catInfo[2]);
            cats.Add(new Cat(name, breed, characteristicValue));

            catInfo = Console.ReadLine().Split();
        }
        return cats;
    }
}

