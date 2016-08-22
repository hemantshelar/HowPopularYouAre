using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GooglePopularityFinder
{
    public class GooglePopularityFinderImpl : IPopularityFinder
    {
        public List<string> SearchTerms { get; set; }
        public readonly string BaseURL = "http://www.google.com.au";
        private string _clientURL = string.Empty;

        public void SetSearchTerms(string[] terms)
        {
            SearchTerms = new List<string>();
            this.SearchTerms.AddRange(terms);
        }

        public void SetSearchTerms(List<string> terms)
        {
            SearchTerms.AddRange(terms);
        }

        public string GetResult()
        {
            string url = string.Format("{0}/#q=",BaseURL);
            int nCount = 0;
            foreach (var item in SearchTerms)
            {
                url = url + item;
                nCount++;
                if (nCount < SearchTerms.Count)
                {
                    url = url + "+";
                }
            }
            WebClient webclient = new WebClient();
            var result = webclient.DownloadString(url);
            return result;
        }

        public string GetPopularityFunderName()
        {
            return "GooglePopularityFinder";
        }

        //This is the URL that we need to look for.
        public string ClientURL
        {
            get { return _clientURL; }
            set { _clientURL = value; }
        }
    }
}
