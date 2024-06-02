namespace DesignPatterns.Decorator;

public class LaborCost : CostDecorator
{
    private readonly Dictionary<string, double> _employeeSalary;

    public LaborCost(ICost cost, Dictionary<string, double> employeeSalary) : base(cost)
    {
        _employeeSalary = employeeSalary;
    }

    public new double CalculateCost()
    {
        return base.CalculateCost() + _employeeSalary.Sum(employee => employee.Value);
    }
}