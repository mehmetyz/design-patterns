namespace DesignPatterns.Facade;

public class VideoService : IService
{
    private readonly Video _source;

    public VideoService(Video source)
    {
        _source = source;
    }
    public void Run()
    {
        _source.PrintInfo();
        Console.WriteLine("Video Service is running");
    }
}