namespace DesignPatterns.Flyweight;

public class PlatingService
{
    private static readonly Dictionary<string, ITree> Trees = new();

    public static ITree GetTree(string treeType, string color, string location)
    {
        if (Trees.TryGetValue(treeType, out var existingTree))
        {
            Console.WriteLine("Get From Cache: " + treeType);
            return existingTree;
        }

        ITree tree = new Tree();
        tree.Plant(treeType, color, location);
        Trees.Add(treeType, tree);

        return tree;
    }
}