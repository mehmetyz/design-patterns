namespace DesignPatterns.Decorator;

public class ElectricityCost : CostDecorator
{
    private static readonly double PRICE_PER_KWH = 0.12;
    private readonly double _watt;
    private readonly int _hour;

    public ElectricityCost(ICost cost, double usageWatt, int usageHour) : base(cost)
    {
        _watt = usageWatt;
        _hour = usageHour;
    }

    public new double CalculateCost()
    {
        var cost = base.CalculateCost();
        return cost + _watt * _hour * PRICE_PER_KWH / 1000;
    }
}