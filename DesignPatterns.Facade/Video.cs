namespace DesignPatterns.Facade;

public class Video
{
    private readonly string _name;

    public Video(string name)
    {
        _name = name;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Video " + _name + " is loaded.");
    }
}