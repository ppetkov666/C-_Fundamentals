using System;
using System.Linq;
class StartUp
{
    static void Main()
    {
        var rectangleCordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var rectangle = new Rectangle(rectangleCordinates[0], rectangleCordinates[1],
            rectangleCordinates[2], rectangleCordinates[3]);
        var numofPoints = int.Parse(Console.ReadLine());
        for (int i = 0; i < numofPoints; i++)
        {
            var inputPoint = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var point = new Point(inputPoint[0], inputPoint[1]);
            var output = rectangle.Contain(point);
            Console.WriteLine(output);
        }
    }
}

