using Alphicsh.Mvm.Playground.Model;
using Alphicsh.Mvm.ViewModels;

namespace Alphicsh.Mvm.Playground.ViewModel;

public class BottomViewModel : BaseViewModel
{
    public BottomViewModel(AppModel model)
    {
        BottomTextProperty = RelayProperty(nameof(BottomText), model.TextSource);
    }

    public RelayViewModelProperty<string> BottomTextProperty { get; }
    public string BottomText { get => BottomTextProperty.Value; set => BottomTextProperty.Value = value; }
}
