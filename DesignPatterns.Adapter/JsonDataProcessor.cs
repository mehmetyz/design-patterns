namespace DesignPatterns.Adapter;

public class JsonDataProcessor : IProcessor
{
    private readonly CsvToJsonConverter _csvToJsonConverter;

    public JsonDataProcessor(CsvToJsonConverter csvToJsonConverter)
    {
        _csvToJsonConverter = csvToJsonConverter;
    }

    public void Process()
    {
        Console.WriteLine("JSON PROCESSOR RUNNING...");
        Console.WriteLine("JSON Output: ");
        Console.WriteLine(_csvToJsonConverter.GetJsonData());
    }
}