using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingPopularityFinder
{
    public class GooglePopularityFinderImpl : IPopularityFinder
    {
        private string _clientURL = string.Empty;

        public void SetSearchTerms(string[] terms)
        {
            throw new NotImplementedException();
        }

        public void SetSearchTerms(List<string> terms)
        {
            throw new NotImplementedException();
        }

        public string GetResult()
        {
            throw new NotImplementedException();
        }

        public string GetPopularityFunderName()
        {
            return "BingPopularityFinder";
        }

        public string ClientURL
        {
            get { return _clientURL; }
            set { _clientURL = value; }
        }
    }
}
