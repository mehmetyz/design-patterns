namespace DesignPatterns.AbstractFactory;

public class BookStore : IBookProvider
{
    public Novel GetNovel()
    {
        var pageSize = Random.Shared.Next(200, 1000);
        var isbn = Random.Shared.NextInt64(1000 * 1000, 1000 * 1000 * 10);
        return new HorrorNovel("Horror Novel Example", pageSize, isbn, "Novel Author 1");
    }

    public History GetHistory()
    {
        var pageSize = Random.Shared.Next(200, 1000);
        var isbn = Random.Shared.NextInt64(1000 * 1000, 1000 * 1000 * 10);
        return new TurkishHistory(pageSize, isbn, "History Writer 1");
    }
}