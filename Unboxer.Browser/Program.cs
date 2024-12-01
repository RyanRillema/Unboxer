using System.Runtime.Versioning;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Browser;
using Avalonia.ReactiveUI;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Unboxer;
using Unboxer.Interfaces;
using Unboxer.Services;
using Unboxer.ViewModels;

internal sealed partial class Program
{
    private static Task Main(string[] args) => BuildAvaloniaApp()
            .WithInterFont()
            .StartBrowserAppAsync("out");

    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>().UseReactiveUI().AfterSetup(RegisterServices);
    private static void RegisterServices(AppBuilder builder)
    {
        var collection = new ServiceCollection();

        collection.AddSingleton<IUnboxerFactory, UnboxerFactory>();
        collection.AddSingleton<MainViewModel>();

        var services = collection.BuildServiceProvider();
        Ioc.Default.ConfigureServices(services);

    }
}