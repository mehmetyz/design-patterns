namespace DesignPatterns.Proxy;

public class User
{
    public long Id { get; private set; }
    private readonly string _username;
    private readonly string _email;

    public User(long id, string username, string email)
    {
        Id = id;
        _username = username;
        _email = email;
    }

    public void Print()
    {
        Console.WriteLine("Username: " + _username);
        Console.WriteLine("Email: " + _email);
    }
}