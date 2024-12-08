using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unboxer.ViewModels.Tresures;

namespace Unboxer.ViewModels.Dirt
{
    public abstract partial class DirtViewModel : ViewModelBase
    {
        public ObservableCollection<TreasureViewModel> Treasures { get; } = new ();

        public abstract void PopulateTreasures();

        [RelayCommand]
        public void Dig()
        {
            if (Treasures.Count != 0)
                return;
                    
            PopulateTreasures();
        }
    }
   
}
