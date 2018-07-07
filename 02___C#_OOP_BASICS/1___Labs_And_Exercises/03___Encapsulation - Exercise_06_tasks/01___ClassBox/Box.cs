
class Box
{
    private double Length { get; set; }
    private double Width { get; set; }
    private double Height { get; set; }

    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }
    public double SurfaceArea()
    {
        return 2 * this.Length * this.Width + 
               2 * this.Length * this.Height + 
               2 * this.Width * this.Height;
    }

    public double LateralSurfaceArea()
    {
        return 2 * this.Length * this.Height + 
               2 * this.Width * this.Height;
    }

    public double Volume()
    {
        return this.Length * this.Width * this.Height;
    }
}

