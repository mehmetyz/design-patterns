namespace DesignPatterns.Proxy;

public class ProxyDatabaseService : IService
{
    private readonly IService _baseService;

    public ProxyDatabaseService(IService baseService)
    {
        _baseService = baseService;
    }

    private static bool CheckUserAccess()
    {
        return Random.Shared.Next(0, 2) == 1;
    }

    public User GetUserById(long id)
    {
        if (!CheckUserAccess())
        {
            throw new Exception("User cannot retrieve user details");
        }

        return _baseService.GetUserById(id);
    }
}