﻿public abstract class Shape
{
    public abstract double CalculatePerimeter();
    public abstract double CalculateArea();
    public virtual string Draw()
    {
        var result = "Drawing ";
        return result;
    }
}

