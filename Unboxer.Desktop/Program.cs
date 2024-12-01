using System;
using Avalonia;
using Avalonia.ReactiveUI;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Unboxer.Interfaces;
using Unboxer.Services;
using Unboxer.ViewModels;

namespace Unboxer.Desktop;

sealed class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace()
            .UseReactiveUI()
            .AfterSetup(RegisterServices);
    private static void RegisterServices(AppBuilder builder)
    {
        var collection = new ServiceCollection();

        collection.AddSingleton<IUnboxerFactory, UnboxerFactory>();
        collection.AddSingleton<MainViewModel>();

        var services = collection.BuildServiceProvider();
        Ioc.Default.ConfigureServices(services);

    }
}
