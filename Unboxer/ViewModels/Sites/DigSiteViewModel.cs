using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unboxer.Interfaces;
using Unboxer.ViewModels.Dirt;

namespace Unboxer.ViewModels.Sites
{
    public partial class DigSiteViewModel : ViewModelBase
    {
        private readonly IUnboxerFactory _unboxerFactory;

        public DigSiteViewModel(IUnboxerFactory unboxerFactory)
        {
            _unboxerFactory = unboxerFactory;
            int rows = 5;
            int columns = 5;
            int currentCell = 0;
            int sites = rows * columns;
            var localDirtSites = _unboxerFactory.GenerateDirt(sites);

            for (int i = 0; i < rows; i++)
            {
                ObservableCollection<DirtViewModel> cells = new();

                for (int j = 0; j < columns; j++)
                {
                    cells.Add(localDirtSites[currentCell++]);

                }

                DirtSites.Add(cells);
            }
        }

        public ObservableCollection<ObservableCollection<DirtViewModel>> DirtSites { get; } = new();

    }
}
