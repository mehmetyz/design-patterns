namespace DesignPatterns.Composite;

public class Rectangle : IShape
{
    private readonly double _firstEdge;
    private readonly double _secondEdge;

    public Rectangle(double firstEdge, double secondEdge)
    {
        _firstEdge = firstEdge;
        _secondEdge = secondEdge;
    }

    public double CalculateArea()
    {
        return _firstEdge * _secondEdge;
    }
}