namespace DesignPatterns.Prototype;

public interface IToy
{
    IToy Clone();
    void Info();
}