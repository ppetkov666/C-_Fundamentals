using System;
public class StartUp
{
    public static void Main()
    {
        var addCollection = new AddCollection<string>();
        var addRemoveCollection = new AddRemoveCollection<string>();
        var myList = new MyList<string>();

        var addIndicesAddCollection = String.Empty;
        var addIndicesAddRemoveCollection = String.Empty;
        var addIndicesMyList = String.Empty;

        var elements = Console.ReadLine().Split();

        int AddIndex;
        foreach (var element in elements)
        {
            AddIndex = addCollection.Add(element);
            addIndicesAddCollection += $"{AddIndex} ";

            AddIndex = addRemoveCollection.Add(element);
            addIndicesAddRemoveCollection += $"{AddIndex} ";

            AddIndex = myList.Add(element);
            addIndicesMyList += $"{AddIndex} ";
        }

        var amountOfRemoves = int.Parse(Console.ReadLine());

        var removedItemFromAddRemoveCollection = String.Empty;
        var removedItemFromMyList = String.Empty;

        var removedItem = string.Empty;
        for (int i = 0; i < amountOfRemoves; i++)
        {
            removedItem = addRemoveCollection.Remove();
            removedItemFromAddRemoveCollection += $"{removedItem} ";

            removedItem = myList.Remove();
            removedItemFromMyList += $"{removedItem} ";
        }

        Console.WriteLine(addIndicesAddCollection.TrimEnd());
        Console.WriteLine(addIndicesAddRemoveCollection.TrimEnd());
        Console.WriteLine(addIndicesMyList.TrimEnd());
        Console.WriteLine(removedItemFromAddRemoveCollection.TrimEnd());
        Console.WriteLine(removedItemFromMyList.TrimEnd());
    }
}

