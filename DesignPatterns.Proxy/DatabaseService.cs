namespace DesignPatterns.Proxy;

public class DatabaseService : IService
{
    public User GetUserById(long id)
    {
        return new User(id, "TEST_USER", "test@test.com");
    }
}