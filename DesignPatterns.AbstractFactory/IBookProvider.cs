namespace DesignPatterns.AbstractFactory;

public interface IBookProvider
{
   Novel GetNovel();
   History GetHistory();
}