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

        public UnboxerFactory()
        {
            //_logger = logger;
        }

        public DigSiteViewModel GenerateDigSite()
        {           

            return new DigSiteViewModel(this); 
        }

        public IList<DirtViewModel> GenerateDirt(int SiteCount)
        {
            var dirtSites = new List<DirtViewModel>();
            Random rnd = new Random();

            for (int i = 0;i < SiteCount ;i++)
            {
                int rndNumber = rnd.Next(1, 10);

                if (rndNumber < 5)
                {
                    // Soft dirt
                    dirtSites.Add(new SoftDirtViewModel(this));
                }
                else
                {
                    //Hard dirt
                    dirtSites.Add(new HardDirtViewModel(this));

                }
            }
            return dirtSites;
        }

        public IEnumerable<TreasureViewModel> GenerateTreasures(int boost)
        {
            var treasure = new List<TreasureViewModel>();
            Random rnd = new Random();
            int rndCount = 0;
            int rndNumber = rnd.Next(1, 1000);

            //Add boost
            rndNumber = rndNumber + boost;

            if (rndNumber < 200)
            {
                rndCount = rnd.Next(1, 10);
                treasure.Add(new SkeletonViewModel(rndCount));

            } else if (rndNumber < 400)
            {
                rndCount = rnd.Next(1, 10);
                treasure.Add(new SkeletonViewModel(rndCount));
                rndCount = rnd.Next(1, 10);
                treasure.Add(new GemsViewModel(rndCount));
            }
            else if (rndNumber < 600)
            {
                rndCount = rnd.Next(1, 10);
                treasure.Add(new SkeletonViewModel(rndCount));
                rndCount = rnd.Next(1, 10);
                treasure.Add(new GoldViewModel(rndCount));
            }
            else if (rndNumber < 800)
            {
                rndCount = rnd.Next(1, 10);
                treasure.Add(new GemsViewModel(rndCount));
                rndCount = rnd.Next(1, 10);
                treasure.Add(new GoldViewModel(rndCount));
            } else
            {
                rndCount = rnd.Next(10, 20);
                treasure.Add(new GoldViewModel(rndCount));
            }

            return treasure;
        }
    }
}
