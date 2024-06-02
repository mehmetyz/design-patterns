namespace DesignPatterns.Singleton;

public class Database
{
    private static Database? _instance = null;
    private static readonly object ThreadLocker = new object();

    public string ConnectionString => string.Format("DATABASE_CONNECTION:{0}", DateTime.Now);

    public static Database Instance
    {
        get
        {
            lock (ThreadLocker)
            {
                return _instance ??= new Database();
            }
        }
    }
}