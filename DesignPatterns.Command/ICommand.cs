namespace DesignPatterns.Command;

interface ICommand
{
    void Undo();
    void Execute();
}