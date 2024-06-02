namespace DesignPatterns.AbstractFactory;

public class DetectiveNovel : Novel
{
    public DetectiveNovel(string name, int pageSize, long isbn, string author) : base(name, pageSize, isbn, author)
    {
        BookType = "DETECTIVE NOVEL";
    }
}