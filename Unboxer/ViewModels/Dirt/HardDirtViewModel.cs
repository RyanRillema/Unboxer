using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unboxer.Interfaces;
using Unboxer.Services;

namespace Unboxer.ViewModels.Dirt
{
    public partial class HardDirtViewModel : DirtViewModel
    {
        private readonly IUnboxerFactory _unboxerFactory;

        public HardDirtViewModel(IUnboxerFactory unboxerFactory)
        {
            _unboxerFactory = unboxerFactory;
        }

        public override void PopulateTreasures()
        {
            Treasures.AddRange(_unboxerFactory.GenerateTreasures(200));
        }

    }
}
