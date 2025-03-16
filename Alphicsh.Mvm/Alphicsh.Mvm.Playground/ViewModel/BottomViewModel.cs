using Alphicsh.Mvm.Playground.Model;
using Alphicsh.Mvm.ViewModels;

namespace Alphicsh.Mvm.Playground.ViewModel;

public class BottomViewModel : BaseViewModel
{
    public BottomViewModel(AppModel model)
    {
        BottomTextProperty = RelayProperty(nameof(BottomText), model.TextSource);
        UppercaseAvailableProperty = RelayProperty(nameof(UppercaseAvailable), model.UppercaseAvailableSource);
    }

    public RelayViewModelProperty<string> BottomTextProperty { get; }
    public string BottomText { get => BottomTextProperty.Value; set => BottomTextProperty.Value = value; }

    public RelayViewModelProperty<bool> UppercaseAvailableProperty { get; }
    public bool UppercaseAvailable { get => UppercaseAvailableProperty.Value; set => UppercaseAvailableProperty.Value = value; }
}
