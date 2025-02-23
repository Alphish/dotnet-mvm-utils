using System.ComponentModel;

namespace Alphicsh.Mvm.ViewModels;

public interface IViewModel : INotifyPropertyChanged, IDisposable
{
    void RaisePropertyChanged(string propertyName);
}
