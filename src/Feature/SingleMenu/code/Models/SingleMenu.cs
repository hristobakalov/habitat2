using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feature.SingleMenu.Models
{
    public class SingleMenu
    {
        public string Title { get; set; }
        public string CssClass { get; set; }

        public SingleMenu(string t, string c)
        {
            Title = t;
            CssClass = c;
        }
    }
}