using System;

public class Rectangle
{
    private string id;
    private double width;
    private double height;
    private double topLeftX;
    private double topLeftY;

    public Rectangle(string id, double width, double height, double topLeftX, double topLeftY)
    {
        this.id = id;
        this.width = Math.Abs(width);
        this.height = Math.Abs(height);
        this.topLeftX = topLeftX;
        this.topLeftY = topLeftY;
    }

    public string Id
    {
        get { return this.id; }
    }

    public bool IsThereIntersection(Rectangle rectangle)
    {
        var isIntersect = this.topLeftX <= rectangle.topLeftX + rectangle.width &&
                          this.topLeftX + this.width >= rectangle.topLeftX &&
                          this.topLeftY - this.height <= rectangle.topLeftY &&
                          this.topLeftY >=  rectangle.topLeftY - rectangle.height ;
        return isIntersect;
    }
}


