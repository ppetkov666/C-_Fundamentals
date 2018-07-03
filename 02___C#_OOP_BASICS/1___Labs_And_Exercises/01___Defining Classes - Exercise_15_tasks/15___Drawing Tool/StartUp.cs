using System;
class StartUp
{
    static void Main()
    {
        var inputShape = Console.ReadLine();
        var width = double.Parse(Console.ReadLine());
        double height ;

        if (inputShape == "Square")
        {
            height = width;
        }
        else
        {
            height = double.Parse(Console.ReadLine());
        }
        var figureToDraw = new Draw(width, height);
        var figure = (figureToDraw);
        Console.WriteLine(figure.DrawTheFigure());
    }
}

