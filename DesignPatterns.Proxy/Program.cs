using DesignPatterns.Proxy;

var dbService = new DatabaseService();
var proxy = new ProxyDatabaseService(dbService);

var user = proxy.GetUserById(10);
user.Print();