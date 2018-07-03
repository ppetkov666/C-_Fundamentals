using System.Text;

class Draw
{
    private double width;
    private double height;

    public Draw(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    public double Width => width;
    public double Height => width;

    public string DrawTheFigure()
    {
        var sb = new StringBuilder();
        sb.Append('|');
        sb.Append(new string('-', (int)this.width));
        sb.AppendLine("|");

        for (int i = (int)this.height - 2; i > 0; i--)
        {
            sb.Append('|');
            sb.Append(new string(' ', (int)this.width));
            sb.AppendLine("|");
        }

        sb.Append('|');
        sb.Append(new string('-', (int)this.width));
        sb.Append("|");
        return sb.ToString();
    }
}
