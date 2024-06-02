namespace DesignPatterns.Command;

public class Home
{
    private static Home? _instance;

    public static Home Shared => _instance ??= new Home();

    public bool LightStatus { get; set; }
    public bool ThermostatStatus { get; set; }
    public bool DoorStatus { get; set; } = true;

    public void Status()
    {
        Console.WriteLine($"Light is {(LightStatus ? "Opened" : "Closed")}");
        Console.WriteLine($"Thermostat is {(ThermostatStatus ? "Adjusted" : "Closed")}");
        Console.WriteLine($"Door is {(DoorStatus ? "Opened" : "Locked")}");
    }
}