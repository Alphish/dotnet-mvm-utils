using Alphicsh.Mvm.Playground.Model;
using Alphicsh.Mvm.ViewModels;

namespace Alphicsh.Mvm.Playground.ViewModel;

public class AppViewModel : BaseViewModel
{
    public AppViewModel(AppModel model)
    {
        Top = new TopViewModel(model);
        Bottom = new BottomViewModel(model);
    }

    public TopViewModel Top { get; }
    public BottomViewModel Bottom { get; }
}
