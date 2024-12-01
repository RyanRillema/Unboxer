using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unboxer.Interfaces;

namespace Unboxer.ViewModels.Dirt
{
    public partial class SoftDirtViewModel : DirtViewModel
    {
        private readonly IUnboxerFactory _unboxerFactory;

        public SoftDirtViewModel(IUnboxerFactory unboxerFactory)
        {
            _unboxerFactory = unboxerFactory;
        }
    }
}
