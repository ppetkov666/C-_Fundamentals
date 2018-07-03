using System;
using System.Collections.Generic;
using System.Linq;
public class StartUp
{
    public static void Main()
    {
        var input = Console.ReadLine().Split();
        var numOfRectangles = int.Parse(input[0]);
        var intersectCheck = int.Parse(input[1]);
        var rectangles = SetRectangles(numOfRectangles);
        CheckIntersections(intersectCheck, rectangles);
    }
    public static void CheckIntersections
        (int intersectCheck, List<Rectangle> rectangles)
    {
        for (int i = 0; i < intersectCheck; i++)
        {
            var idCheck = Console.ReadLine().Split();
            var firstRect = rectangles.Where(r => r.Id == idCheck[0]).FirstOrDefault();
            var secondRect = rectangles.Where(r => r.Id == idCheck[1]).FirstOrDefault();

            Console.WriteLine(firstRect.IsThereIntersection(secondRect) ? "true" : "false"); 
        }
    }
    public static List<Rectangle> SetRectangles(int numOfRectangles)
    {
        var rectangles = new List<Rectangle>(numOfRectangles);

        for (int i = 0; i < numOfRectangles; i++)
        {
            var input = Console.ReadLine().Split();
            rectangles.Add(new Rectangle(input[0], double.Parse(input[1]),
                double.Parse(input[2]), double.Parse(input[3]), double.Parse(input[4])));
        }
        return rectangles;
    }
}

