namespace DesignPatterns.AbstractFactory;

public class FrenchHistory : History
{
    public FrenchHistory(int pageSize, long isbn, string author) : base(pageSize, isbn, author)
    {
        Country = "FRANCE";
    }
}