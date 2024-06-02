namespace DesignPatterns.AbstractFactory;

public class Novel : Book
{
    private readonly string _name;
    protected string? BookType;

    protected Novel(string name, int pageSize, long isbn, string author) : base(pageSize, isbn, author)
    {
        _name = name;
    }

    public override void PrintBook()
    {
        Console.WriteLine("Type: {0}", BookType);
        Console.WriteLine("Name: {0}", _name);
        Console.WriteLine("Page Size: {0}", PageSize);
        Console.WriteLine("ISBN: {0}", ISBN);
        Console.WriteLine("Author: {0}", Author);
    }
}