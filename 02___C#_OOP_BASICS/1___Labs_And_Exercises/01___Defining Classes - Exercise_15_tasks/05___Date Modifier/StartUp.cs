using System;
public class StartUp
{
    static void Main()
    {
        var firstDate = Console.ReadLine();
        var secondDate = Console.ReadLine();
        var differenceInDays = DateModifier.GetDaysDifference(firstDate, secondDate);
        Console.WriteLine(differenceInDays);

    }
}

