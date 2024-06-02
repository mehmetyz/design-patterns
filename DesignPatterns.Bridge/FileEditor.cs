namespace DesignPatterns.Bridge;

public class FileEditor
{
    protected readonly File File;

    protected FileEditor(File file)
    {
        File = file;
    }

    public void ChangeFileName(string name)
    {
        File.Name = name;
    }

    public void ChangeCreateDate(DateTime createDate)
    {
        File.CreateDate = createDate;
    }

    public void ChangeUpdateDate(DateTime updateDate)
    {
        File.UpdateDate = updateDate;
    }

    public void ChangeSize(long size)
    {
        if (size > 0)
        {
            File.Size = size;
        }
    }
}