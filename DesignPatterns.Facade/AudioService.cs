namespace DesignPatterns.Facade;

public class AudioService : IService
{
    public void Run()
    {
        Console.WriteLine("Audio Service is running");
    }
}