namespace DesignPatterns.Bridge;

public class ImageFile : File
{
    public string BackgroundColor { get; set; }

    public ImageFile(string name, string backgroundColor, DateTime createDate, DateTime updateDate, long size) :
        base(name, createDate, updateDate, size)
    {
        BackgroundColor = backgroundColor;
    }
}