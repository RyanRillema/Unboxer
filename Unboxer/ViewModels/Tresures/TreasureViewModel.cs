﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unboxer.ViewModels.Tresures
{
    public partial class TreasureViewModel : ViewModelBase
    {
        [ObservableProperty]
        private int _count;
    }

}
