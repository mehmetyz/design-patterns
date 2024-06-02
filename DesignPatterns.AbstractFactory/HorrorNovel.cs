namespace DesignPatterns.AbstractFactory;

public class HorrorNovel : Novel
{
    public HorrorNovel(string name, int pageSize, long isbn, string author) :
        base(name, pageSize, isbn, author)
    {
        BookType = "HORROR NOVEL";
    }
}