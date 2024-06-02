namespace DesignPatterns.Command;

public class TurnOnLightCommand : ICommand
{
    private bool _previousState = Home.Shared.LightStatus;

    public void Undo()
    {
        Home.Shared.LightStatus = _previousState;
    }

    public void Execute()
    {
        _previousState = Home.Shared.LightStatus;
        Home.Shared.LightStatus = true;
    }
}