namespace DesignPatterns.Factory;

public abstract class OperatingSystem : IOperatingSystem
{
    protected string? OperatingSystemName { get; init; }

    public string GetVersion()
    {
        return OperatingSystemName + " / " + DateTime.Now;
    }

    public void InstallKernel()
    {
        Console.WriteLine($"Installing {OperatingSystemName}: KERNEL");
    }

    public void InstallDrivers()
    {
        Console.WriteLine($"Installing {OperatingSystemName}: DRIVERS");
    }

    public void InstallApplications()
    {
        Console.WriteLine($"Installing {OperatingSystemName}: APPLICATIONS");
    }
}