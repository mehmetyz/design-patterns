namespace DesignPatterns.Factory;

public abstract class OperatingSystemManager
{
    protected abstract IOperatingSystem Install(string operatingSystemType);

    public void InstallOperatingSystem(string operatingSystemType)
    {
        var os = Install(operatingSystemType);

        os.InstallKernel();
        os.InstallDrivers();
        os.InstallApplications();

        Console.WriteLine(os.GetVersion());
    }
}