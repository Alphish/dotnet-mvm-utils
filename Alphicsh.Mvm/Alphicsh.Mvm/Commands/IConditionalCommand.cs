using System.Windows.Input;

namespace Alphicsh.Mvm.Commands;

public interface IConditionalCommand : ICommand
{
    void RaiseCanExecuteChanged();
}
