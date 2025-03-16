using Alphicsh.Mvm.Sources;

namespace Alphicsh.Mvm.Playground.Model;

public class AppModel
{
    public ValueSource<string> TextSource { get; set; }
    public string Text { get => TextSource.Value; set => TextSource.Value = value; }

    public ValueSource<bool> UppercaseAvailableSource { get; set; }
    public bool UppercaseAvailable { get => UppercaseAvailableSource.Value; set => UppercaseAvailableSource.Value = value; }

    public AppModel()
    {
        TextSource = ValueSource.Create("Hello!");
        UppercaseAvailableSource = ValueSource.Create(false);
    }

    public void UppercaseText()
    {
        Text = Text.ToUpperInvariant();
    }
}
