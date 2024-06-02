namespace DesignPatterns.AbstractFactory;

public abstract class Book
{
    private int pageSize;
    private long isbn;
    private string author;

    protected int PageSize
    {
        get => pageSize;
        set
        {
            if (value > 0)
                pageSize = value;
        }
    }

    protected long ISBN
    {
        get => isbn;
        set
        {
            if (value > 0)
                isbn = value;
        }
    }

    protected string Author
    {
        get => author;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                author = value;
        }
    }

    protected Book(int pageSize, long isbn, string author)
    {
        this.pageSize = pageSize;
        this.isbn = isbn;
        this.author = author;
    }

    public abstract void PrintBook();
}