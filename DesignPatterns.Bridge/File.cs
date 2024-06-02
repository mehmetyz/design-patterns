namespace DesignPatterns.Bridge;

public abstract class File
{
    public string Name { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public long Size { get; set; }

    protected File(string name, DateTime createDate, DateTime updateDate, long size)
    {
        Name = name;
        CreateDate = createDate;
        UpdateDate = updateDate;
        Size = size;
    }
}