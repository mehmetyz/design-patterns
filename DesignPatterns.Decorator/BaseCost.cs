namespace DesignPatterns.Decorator;

public class BaseCost : ICost
{
    private readonly double _cost;

    public BaseCost(double cost)
    {
        _cost = cost;
    }

    public double CalculateCost()
    {
        return _cost;
    }
}