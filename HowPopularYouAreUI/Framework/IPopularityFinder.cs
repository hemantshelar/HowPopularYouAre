using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public interface IPopularityFinder
    {
        string ClientURL { get; set; }
        string GetPopularityFunderName();
        void SetSearchTerms(string[] terms);
        void SetSearchTerms(List<String> terms);
        string GetResult();
    }
}
