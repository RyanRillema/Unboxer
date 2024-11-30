using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unboxer.Interfaces;
using Unboxer.ViewModels.Dirt;
using Unboxer.ViewModels.Sites;
using Unboxer.ViewModels.Tresures;

namespace Unboxer.Services
{
    public class UnboxerFactory : IUnboxerFactory
    {
        private readonly ILogger _logger;

        public UnboxerFactory(ILogger logger)
        {
            _logger = logger;
        }

        public DigSiteViewModel GenerateDigSite()
        {
            var site = new DigSiteViewModel();
            Random rnd = new Random();
            AttackMelee.Count = rnd.Next(Min, Max + 1);

            return site;

            throw new NotImplementedException();
        }

        public IEnumerable<DirtViewModel> GenerateDirt()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TreasureViewModel> GenerateTreasures(int boost)
        {
            throw new NotImplementedException();
        }
    }
}
