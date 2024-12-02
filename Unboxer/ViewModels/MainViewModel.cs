using CommunityToolkit.Mvvm.ComponentModel;
using Unboxer.Interfaces;
using Unboxer.ViewModels.Sites;

namespace Unboxer.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private readonly IUnboxerFactory _unboxerFactory;

    public MainViewModel(IUnboxerFactory unboxerFactory)
    {
        _unboxerFactory = unboxerFactory;
        DigSite = _unboxerFactory.GenerateDigSite();
    }

    [ObservableProperty]
    private DigSiteViewModel _digSite;

}
