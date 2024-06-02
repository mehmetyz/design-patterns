using DesignPatterns.Bridge;

void Assert<T>(T expected, T actual)
{
    if (!Equals(expected, actual))
    {
        throw new Exception("objects are not same");
    }
}

var date1 = DateTime.Now;
var date2 = date1.Date.AddMonths(-20);
var file = new ImageFile("TEST_IMAGE_FILE", "BLUE", date2, date1, 100000);

Assert("TEST_IMAGE_FILE", file.Name);
Assert("BLUE", file.BackgroundColor);
Assert(date1, file.UpdateDate);
Assert(date2, file.CreateDate);
Assert(100000, file.Size);

var fileEditor = new ImageFileEditor(file);
fileEditor.ChangeFileName("EDITED_IMAGE_FILE");
fileEditor.ChangeBackgroundColor("RED");
fileEditor.ChangeCreateDate(date2.AddMonths(10));
fileEditor.ChangeUpdateDate(date1.AddMonths(1));
fileEditor.ChangeSize(20000);

Assert("EDITED_IMAGE_FILE", file.Name);
Assert("RED", file.BackgroundColor);
Assert(date1.AddMonths(1), file.UpdateDate);
Assert(date2.AddMonths(10), file.CreateDate);
Assert(20000, file.Size);


Console.WriteLine("FILE SUCCESSFULLY EDITED...");