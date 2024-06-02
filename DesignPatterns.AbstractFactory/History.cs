namespace DesignPatterns.AbstractFactory;

public class History : Book
{
    protected string? Country;

    protected History(int pageSize, long isbn, string author) : base(pageSize, isbn, author)
    {
    }

    public override void PrintBook()
    {
        Console.WriteLine("Country: {0}", Country);
        Console.WriteLine("Page Size: {0}", PageSize);
        Console.WriteLine("ISBN: {0}", ISBN);
        Console.WriteLine("Author: {0}", Author);
    }
}