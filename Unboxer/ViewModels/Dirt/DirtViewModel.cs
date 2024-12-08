using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unboxer.ViewModels.Tresures;

namespace Unboxer.ViewModels.Dirt
{
    public abstract partial class DirtViewModel : ViewModelBase
    {
        public List<TreasureViewModel> Treasures { get; } = new ();

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
