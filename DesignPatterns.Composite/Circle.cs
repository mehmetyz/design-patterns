namespace DesignPatterns.Composite;

public class Circle : IShape
{
    private static readonly double PI = 3.14;
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double CalculateArea()
    {
        return _radius * _radius * PI;
    }
}