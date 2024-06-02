namespace DesignPatterns.AbstractFactory;

public class Library : IBookProvider
{
    public Novel GetNovel()
    {
        var pageSize = Random.Shared.Next(200, 1000);
        var isbn = Random.Shared.NextInt64(1000 * 1000, 1000 * 1000 * 10);
        return new DetectiveNovel("Detective Novel Example", pageSize, isbn, "Novel Author 2");
    }

    public History GetHistory()
    {
        var pageSize = Random.Shared.Next(200, 1000);
        var isbn = Random.Shared.NextInt64(1000 * 1000, 1000 * 1000 * 10);
        return new FrenchHistory(pageSize, isbn, "History Writer 2");
    }
}