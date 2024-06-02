namespace DesignPatterns.Builder;

public interface IComputerBuilder
{
    IComputerBuilder WithProcessor(string processor);
    IComputerBuilder WithRamSize(int ramSize);
    IComputerBuilder WithDiskSize(int diskSize);
    IComputerBuilder WithOperatingSystem(OperatingSystemType osType);

    Computer Build();
}