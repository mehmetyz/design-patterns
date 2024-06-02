using DesignPatterns.Decorator;

var baseCost = new BaseCost(1000);
var electricityCost = new ElectricityCost(baseCost, 500, 300);
var laborCost = new LaborCost(electricityCost, new Dictionary<string, double>
{
    { "Employee1", 1000 },
    { "Employee2", 2000 },
    { "Employee3", 4000 }
});

var materialCost = new MaterialCost(laborCost);

Console.WriteLine("Total Cost: " + materialCost.CalculateCost());