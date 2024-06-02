namespace DesignPatterns.Prototype;

public class ToyCar : IToy
{
    public string Color { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public int Depth { get; set; }

    public ToyCar(string color, int height, int width, int depth)
    {
        Color = color;
        Height = height;
        Width = width;
        Depth = depth;
    }

    public void Info()
    {
        Console.WriteLine("TOY CAR");
        Console.WriteLine("COLOR: {0}", Color);
        Console.WriteLine("SIZE: {0}", Width * Height * Depth);
    }

    public IToy Clone()
    {
        return new ToyCar(Color, Height, Width, Depth);
    }
}