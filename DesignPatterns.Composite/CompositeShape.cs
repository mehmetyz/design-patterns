namespace DesignPatterns.Composite;

public class CompositeShape : IShape
{
    private readonly List<IShape> _shapes = new();

    public void Add(IShape shape)
    {
        _shapes.Add(shape);
    }

    public void Remove(IShape shape)
    {
        _shapes.Remove(shape);
    }


    public double CalculateArea()
    {
        return _shapes.Sum(shape => shape.CalculateArea());
    }
}