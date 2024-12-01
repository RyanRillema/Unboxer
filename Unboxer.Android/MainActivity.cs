using Android.App;
using Android.Content.PM;
using Avalonia;
using Avalonia.Android;
using Avalonia.ReactiveUI;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Unboxer.Interfaces;
using Unboxer.Services;
using Unboxer.ViewModels;

namespace Unboxer.Android;

[Activity(
    Label = "Unboxer.Android",
    Theme = "@style/MyTheme.NoActionBar",
    Icon = "@drawable/icon",
    MainLauncher = true,
    ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.UiMode)]
public class MainActivity : AvaloniaMainActivity<App>
{
    protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
    {
        return base.CustomizeAppBuilder(builder)
            .WithInterFont()
            .UseReactiveUI()
            .AfterSetup(RegisterServices);
                
    }
    private static void RegisterServices(AppBuilder builder)
    {
        var collection = new ServiceCollection();

        collection.AddSingleton<IUnboxerFactory, UnboxerFactory>();
        collection.AddSingleton<MainViewModel>();

        var services = collection.BuildServiceProvider();
        Ioc.Default.ConfigureServices(services);

    }
}
