namespace DesignPatterns.Builder;

public class Computer
{
    private class ComputerBuilder : IComputerBuilder
    {
        private string? _processor;
        private int _ramSize;
        private int _diskSize;
        private OperatingSystemType _operatingSystem;


        public IComputerBuilder WithProcessor(string processor)
        {
            _processor = processor;
            return this;
        }

        public IComputerBuilder WithRamSize(int ramSize)
        {
            _ramSize = ramSize;
            return this;
        }

        public IComputerBuilder WithDiskSize(int diskSize)
        {
            _diskSize = diskSize;
            return this;
        }

        public IComputerBuilder WithOperatingSystem(OperatingSystemType osType)
        {
            _operatingSystem = osType;
            return this;
        }

        public Computer Build()
        {
            _processor ??= "DEFAULT_PROCESSOR";
            _ramSize = _ramSize == 0 ? 2 : _ramSize;
            _diskSize = _diskSize == 0 ? 100 : _diskSize;

            return new Computer(_processor, _ramSize, _diskSize, _operatingSystem);
        }
    }

    private readonly string _processor;
    private readonly int _ramSize;
    private readonly int _diskSize;
    private readonly OperatingSystemType _operatingSystem;

    private Computer(string processor, int ramSize, int diskSize, OperatingSystemType osType)
    {
        _processor = processor;
        _ramSize = ramSize;
        _diskSize = diskSize;
        _operatingSystem = osType;
    }

    public void PrintComputer()
    {
        Console.WriteLine("PROCESSOR: " + _processor);
        Console.WriteLine("RAM SIZE (GB): " + _ramSize);
        Console.WriteLine("DISK SIZE (GB): " + _diskSize);
        Console.WriteLine("OPERATING SYSTEM: " + GetOperatingSystemStr());
    }

    private string GetOperatingSystemStr()
    {
        return _operatingSystem switch
        {
            OperatingSystemType.LINUX => "Linux",
            OperatingSystemType.MACOS => "MacOS",
            OperatingSystemType.WINDOWS => "Windows 11",
            _ => "Linux"
        };
    }

    public static IComputerBuilder Builder()
    {
        return new ComputerBuilder();
    }
}