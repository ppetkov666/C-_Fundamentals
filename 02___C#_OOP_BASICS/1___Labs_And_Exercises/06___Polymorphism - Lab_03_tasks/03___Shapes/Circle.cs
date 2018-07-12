using System;
public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.Radius = radius;
    }
    public double Radius
    {
        get
        {
            return this.radius;
        }
        set
        {
            if (value <= 0 )
            {
                throw new ArgumentOutOfRangeException(nameof(this.radius),
                    "Cyrcle cannot have a zero or negative radius");
            }
            this.radius = value;
        }
    }
    public override double CalculateArea()
    {
        double area = Math.PI * this.Radius * this.Radius;
        return area;
    }

    public override double CalculatePerimeter()
    {
        var perimeter = 2 * Math.PI * Radius;
        return perimeter;
    }
    public override string Draw()
    {
        return base.Draw() + "Circle";
    }
}

