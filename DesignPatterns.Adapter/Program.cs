using DesignPatterns.Adapter;

const string userData = "1,name1,surname1\n" +
                        "2,name2,surname2\n" +
                        "3,name3,surname3";


var converter = new CsvToJsonConverter();
converter.ProcessCsvData(userData);

IProcessor processor = new JsonDataProcessor(converter);
processor.Process();