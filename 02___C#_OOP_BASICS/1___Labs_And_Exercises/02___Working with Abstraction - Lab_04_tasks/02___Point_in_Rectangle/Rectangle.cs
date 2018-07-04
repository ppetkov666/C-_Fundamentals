using System;
using System.Collections.Generic;
using System.Text;

class Rectangle
{
    public Point TopLeft { get; set; }
    public Point BottomRight { get; set; }

    public Rectangle (int topLeftX, int topLeftY, int bottomRightX, int bottomRightY )
    {
        TopLeft = new Point(topLeftX, topLeftY);
        BottomRight = new Point(bottomRightX, bottomRightY);
    }
    public bool Contain(Point point)
    {
        var contain = point.X >= TopLeft.X && point.X <= BottomRight.X
            && point.Y >= TopLeft.Y && point.Y <= BottomRight.Y;
        return contain;
    }

}

