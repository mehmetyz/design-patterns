namespace DesignPatterns.Adapter;

public class CsvToJsonConverter
{
    private string _jsonData = "";

    public void ProcessCsvData(string data)
    {
        _jsonData += "[";
        foreach (var line in data.Split("\n"))
        {
            _jsonData += "{\n\t";

            var splitData = line.Split(',');
            _jsonData += $"\"id\":{splitData[0]},\n\t";
            _jsonData += $"\"name\":\"{splitData[1]}\",\n\t";
            _jsonData += $"\"surname\":\"{splitData[2]}\",\n";
            _jsonData += "},";
        }

        _jsonData += "]";
    }

    public string GetJsonData()
    {
        return _jsonData;
    }
}