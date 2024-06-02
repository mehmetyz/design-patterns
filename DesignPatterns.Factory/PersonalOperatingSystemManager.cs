namespace DesignPatterns.Factory;

public class PersonalOperatingSystemManager : OperatingSystemManager
{
    protected override IOperatingSystem Install(string operatingSystemType)
    {
        return operatingSystemType switch
        {
            "Windows" => new Windows(),
            "Linux" => new Linux(),
            "Macos" => new MacOS(),
            _ => throw new ArgumentException(nameof(operatingSystemType) + " is not valid!")
        };
    }
}