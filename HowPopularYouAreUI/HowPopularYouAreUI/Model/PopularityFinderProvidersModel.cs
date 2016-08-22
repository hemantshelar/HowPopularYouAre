using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HowPopularYouAreUI.Model
{
    public class PopularityFinderProvidersModel
    {
        public int SelectedID { get; set; }
        public SelectList Providers;
        public string Result { get; set; }
    }
}