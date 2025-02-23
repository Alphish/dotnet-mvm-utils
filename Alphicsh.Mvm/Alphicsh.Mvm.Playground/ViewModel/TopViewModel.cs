using Alphicsh.Mvm.Playground.Model;
using Alphicsh.Mvm.ViewModels;

namespace Alphicsh.Mvm.Playground.ViewModel;

public class TopViewModel : BaseViewModel
{
    public TopViewModel(AppModel model)
    {
        TopTextProperty = RelayProperty(nameof(TopText), model.TextSource);
    }

    public RelayViewModelProperty<string> TopTextProperty { get; }
    public string TopText { get => TopTextProperty.Value; set => TopTextProperty.Value = value; }
}
