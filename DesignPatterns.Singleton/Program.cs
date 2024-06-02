using DesignPatterns.Singleton;

var db1 = Database.Instance;
var db2 = Database.Instance;

Console.WriteLine(db1.ConnectionString);
Console.WriteLine(db2.ConnectionString);