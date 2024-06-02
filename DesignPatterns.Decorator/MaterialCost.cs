namespace DesignPatterns.Decorator;

public class MaterialCost : CostDecorator
{
    private static readonly Dictionary<string, double> MaterialCosts = new()
    {
        { "Coffee", 10000 },
        { "Milk", 1400 },
        { "Cup", 1200 }
    };

    public MaterialCost(ICost cost) : base(cost)
    {
    }

    public new double CalculateCost()
    {
        return base.CalculateCost() + MaterialCosts.Values.Sum();
    }
}