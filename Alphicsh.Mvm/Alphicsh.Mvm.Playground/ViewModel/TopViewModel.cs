using Alphicsh.Mvm.Commands;
using Alphicsh.Mvm.Playground.Model;
using Alphicsh.Mvm.ViewModels;

namespace Alphicsh.Mvm.Playground.ViewModel;

public class TopViewModel : BaseViewModel
{
    public TopViewModel(AppModel model)
    {
        TopTextProperty = RelayProperty(nameof(TopText), model.TextSource);
        UppercaseText = Command.From(() => model.UppercaseAvailable, model.UppercaseText);

        model.UppercaseAvailableSource.ValueChanged += (sender, e) => UppercaseText.RaiseCanExecuteChanged();
    }

    public RelayViewModelProperty<string> TopTextProperty { get; }
    public string TopText { get => TopTextProperty.Value; set => TopTextProperty.Value = value; }

    public IConditionalCommand UppercaseText { get; }
}
