using Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class PopularityFinderProviders
    {

        public static List<PopularityFinderProviderModel> _popularityFinderProviders = null;

        public List<PopularityFinderProviderModel> GetPopularityFinderProviders(bool bUsedCached = true)
        {
            List<PopularityFinderProviderModel> result = new List<PopularityFinderProviderModel>();
            if (_popularityFinderProviders == null || bUsedCached == false)
            {
                var popularityProviderList = Utils.GetType<IPopularityFinder>();

                int nIndex = 0;
                foreach (var provider in popularityProviderList)
                {
                    result.Add(new PopularityFinderProviderModel
                    {
                        DisplayName = provider.GetPopularityFunderName(),
                        ID = nIndex++,
                        PopularityFinder = provider
                    });
                }
                _popularityFinderProviders = result;
            }
            else
                result = _popularityFinderProviders;

            return result;
        }
    }
}
