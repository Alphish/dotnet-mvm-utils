using Alphicsh.Mvm.Playground.Model;
using Alphicsh.Mvm.Playground.ViewModel;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace Alphicsh.Mvm.Playground;
public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            var model = new AppModel();
            desktop.MainWindow = new MainWindow()
            {
                DataContext = new AppViewModel(model)
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}