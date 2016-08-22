using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Model
{
    public class PopularityFinderProviderModel
    {
        public int ID { get; set; }
        public string DisplayName { get; set; }
        public IPopularityFinder PopularityFinder { get; set; }
    }
}
