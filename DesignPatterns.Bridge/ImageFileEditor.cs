namespace DesignPatterns.Bridge;

public class ImageFileEditor : FileEditor
{
    public ImageFileEditor(File file) : base(file)
    {
    }

    public void ChangeBackgroundColor(string color)
    {
        var file = (ImageFile)File;
        file.BackgroundColor = color;
    }
}