namespace DesignPatterns.Factory;

public interface IOperatingSystem
{
    string GetVersion();
    
    void InstallKernel();
    void InstallDrivers();
    void InstallApplications();
}