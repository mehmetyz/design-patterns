namespace DesignPatterns.Flyweight;

public class Tree : ITree
{
    public void Plant(string type, string color, string location)
    {
        Console.Write("PLATING");
        Console.Write(" TYPE: " + type);
        Console.Write(" COLOR: " + color);
        Console.Write(" LOCATION: " + location);
        Console.WriteLine();
    }
}