namespace DesignPatterns.Command;

public class LockDoorCommand : ICommand
{
    private bool _previousState = Home.Shared.ThermostatStatus;

    public void Undo()
    {
        Home.Shared.DoorStatus = _previousState;
    }

    public void Execute()
    {
        _previousState = Home.Shared.DoorStatus;
        Home.Shared.DoorStatus = false;
    }
}