using System;
public class StartUp
{
    public static void Main(string[] args)
    {
        var box = new Box<int>();
        box.Add(1);
        box.Add(2);
        box.Add(3);
        box.Add(4);
        box.Add(5);
        var element = box.Remove();
        Console.WriteLine(element);
        Console.WriteLine(box.Count);

    }
}

