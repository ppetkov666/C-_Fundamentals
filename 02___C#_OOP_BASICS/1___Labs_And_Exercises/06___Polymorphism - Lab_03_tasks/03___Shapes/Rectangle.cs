using System;
public class Rectangle : Shape
{
    private double height;
    private double width;

    public Rectangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;

    }
    
    public double Height
    {
        get
        {
            return this.height;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(this.height), "Height must be non-zero and positive");
            }
            this.height = value;
        }
    }

    public double Width
    {
        get
        {
            return this.width;
        }
        set
        {
            if (true)
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(this.width), "Width must be non-zero and positive");
                }
                this.width = value;
            }
        }
    }

    public override double CalculateArea()
    {
        double result = this.Height * this.Width;
        return result;
    }

    public override double CalculatePerimeter()
    {
        double result = 2 * (this.Height + this.Width);
        return result;
    }
    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}

