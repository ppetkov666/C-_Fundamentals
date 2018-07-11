using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {

        var numOfPeople = int.Parse(Console.ReadLine());
        var listOfBuyers = new List<IBuyer>();

        for (int i = 0; i < numOfPeople; i++)
        {
            var splittedArgs = Console.ReadLine().Split();

            IBuyer currentBuyer;
            if (splittedArgs.Length == 3)
            {
                currentBuyer = new Rebel(splittedArgs[0], int.Parse(splittedArgs[1]),
                    splittedArgs[2]);
            }
            else
            {
                currentBuyer = new Citizen(splittedArgs[0], int.Parse(splittedArgs[1]),
                    splittedArgs[2], splittedArgs[3]);
            }

            listOfBuyers.Add(currentBuyer);
        }

        string buyerName;
        while ((buyerName = Console.ReadLine()) != "End")
        {
            foreach (var buyer in listOfBuyers.Where(b => b.Name == buyerName))
            {
                buyer.BuyFood();
            }
        }

        var totalAmountOfFood = listOfBuyers.Sum(b => b.Food);
        Console.WriteLine(totalAmountOfFood);
    }
}

