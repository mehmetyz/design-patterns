namespace DesignPatterns.Command;

public class AdjustThermostatCommand : ICommand
{
    private bool _previousState = Home.Shared.ThermostatStatus;

    public void Undo()
    {
        Home.Shared.ThermostatStatus = _previousState;
    }

    public void Execute()
    {
        _previousState = Home.Shared.ThermostatStatus;
        Home.Shared.ThermostatStatus = true;
    }
}