namespace DesignPatterns.Decorator;

public abstract class CostDecorator : ICost
{
    protected readonly ICost _cost;

    protected CostDecorator(ICost cost)
    {
        _cost = cost;
    }

    public double CalculateCost()
    {
        return _cost.CalculateCost();
    }
}