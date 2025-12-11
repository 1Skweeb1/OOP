using ClassLibrary;

public class Circle : IFigure
{
    public double X { get; }
    public double Y { get; }
    public double Radius { get; }
    public string Color { get; } 

    public Circle(double x, double y, double radius, string color)
    {
        X = x;
        Y = y;
        Radius = radius;
        Color = color;
    }

    public string GetInfo() => $"Circle: Center({X},{Y}) Radius={Radius} Color={Color} Area={Area}";

    public double Area => Math.PI * Radius * Radius;

    public double CircleLength() => 2 * Math.PI * Radius;

    public double this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Radius,
        _ => throw new IndexOutOfRangeException()
    };
}
