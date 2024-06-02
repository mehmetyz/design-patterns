namespace DesignPatterns.Composite;

public class Square : IShape
{
    private readonly double _edge;

    public Square(double edge)
    {
        _edge = edge;
    }

    public double CalculateArea()
    {
        return _edge * _edge;
    }
}