using Alphicsh.Mvm.Sources;

namespace Alphicsh.Mvm.Playground.Model;

public class AppModel
{
    public ValueSource<string> TextSource { get; set; }
    public string Text { get => TextSource.Value; set => TextSource.Value = value; }

    public AppModel()
    {
        TextSource = ValueSource.Create("Hello!");
    }
}
