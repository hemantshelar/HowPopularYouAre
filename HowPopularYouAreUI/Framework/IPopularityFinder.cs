using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public interface IPopularityFinder
    {
        void SetSearchTerms(string[] terms);
        void SetSearchTerms(List<String> terms);
        string GetResult();
    }
}
