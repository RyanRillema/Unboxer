using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unboxer.ViewModels.Dirt;
using Unboxer.ViewModels.Sites;
using Unboxer.ViewModels.Tresures;

namespace Unboxer.Interfaces
{
    public interface IUnboxerFactory
    {
        DigSiteViewModel GenerateDigSite();

        IEnumerable<TreasureViewModel> GenerateTreasures(int boost);

        IList<DirtViewModel> GenerateDirt(int SiteCount);

    }
}
