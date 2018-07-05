using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        var bag = new Dictionary<string, Dictionary<string, long>>();

        long bagCapacity = long.Parse(Console.ReadLine());
        string[] itemswithQuantities = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Treasure treasure = new Treasure();
        TakeTreasureAndPutItIntoTheBag(bag, bagCapacity, itemswithQuantities, treasure);

        PrintTheOuput(bag);
    }

    private static void TakeTreasureAndPutItIntoTheBag(Dictionary<string, Dictionary<string, long>> bag, long bagCapacity, string[] itemswithQuantities, Treasure treasure)
    {
        for (int i = 0; i < itemswithQuantities.Length; i += 2)
        {
            string itemName = itemswithQuantities[i];
            long itemQuantity = long.Parse(itemswithQuantities[i + 1]);

            string item = string.Empty;

            if (itemName.Length == 3)
            {
                item = "Cash";
            }
            else if (itemName.ToLower().EndsWith("gem"))
            {
                item = "Gem";
            }
            else if (itemName.ToLower() == "gold")
            {
                item = "Gold";
            }

            if (item == "")
            {
                continue;
            }
            else if (bagCapacity < bag.Values.Select(x => x.Values.Sum()).Sum() + itemQuantity)
            {
                continue;
            }

            switch (item)
            {
                case "Gem":
                    if (!bag.ContainsKey(item))
                    {
                        if (bag.ContainsKey("Gold"))
                        {
                            if (itemQuantity > bag["Gold"].Values.Sum())
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (bag[item].Values.Sum() + itemQuantity > bag["Gold"].Values.Sum())
                    {
                        continue;
                    }
                    break;
                case "Cash":
                    if (!bag.ContainsKey(item))
                    {
                        if (bag.ContainsKey("Gem"))
                        {
                            if (itemQuantity > bag["Gem"].Values.Sum())
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (bag[item].Values.Sum() + itemQuantity > bag["Gem"].Values.Sum())
                    {
                        continue;
                    }
                    break;
            }

            if (!bag.ContainsKey(item))
            {
                bag[item] = new Dictionary<string, long>();
            }

            if (!bag[item].ContainsKey(itemName))
            {
                bag[item][itemName] = 0;
            }

            bag[item][itemName] += itemQuantity;
            if (item == "Gold")
            {
                treasure.Gold += itemQuantity;
            }
            else if (item == "Gem")
            {
                treasure.Gem += itemQuantity;
            }
            else if (item == "Cash")
            {
                treasure.Cash += itemQuantity;
            }
        }
    }

    private static void PrintTheOuput(Dictionary<string, Dictionary<string, long>> bag)
    {
        foreach (var items in bag)
        {
            Console.WriteLine($"<{items.Key}> ${items.Value.Values.Sum()}");
            foreach (var item2 in items.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
            {
                Console.WriteLine($"##{item2.Key} - {item2.Value}");
            }
        }
    }
}

