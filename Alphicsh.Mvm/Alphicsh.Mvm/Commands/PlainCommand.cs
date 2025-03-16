using System.Windows.Input;

namespace Alphicsh.Mvm.Commands;

public class PlainCommand : ICommand
{
    private Action<object?> ExecutionAction { get; }

    // --------
    // Creation
    // --------

    public PlainCommand(Action<object?> executionAction)
    {
        ExecutionAction = executionAction;
    }

    public PlainCommand(Action executionAction)
    {
        ExecutionAction = (object? parameter) => executionAction();
    }

    // -----------------------
    // ICommand implementation
    // -----------------------

    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        ExecutionAction(parameter);
    }
}