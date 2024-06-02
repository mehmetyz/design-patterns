namespace DesignPatterns.AbstractFactory;

public class TurkishHistory : History
{
    public TurkishHistory(int pageSize, long isbn, string author) : base(pageSize, isbn, author)
    {
        Country = "TURKEY";
    }
}