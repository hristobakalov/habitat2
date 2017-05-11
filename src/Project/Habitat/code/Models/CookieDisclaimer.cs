using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Habitat.Website.Models
{
    public class CookieDisclaimer
    {
        public string Message { get; set; }
        public string ButtonText { get; set; }
        public string PopUpBackgroundColor { get; set; }
        public string TextColor { get; set; }
        public string ButtonBackgroundColor { get; set; }

        public CookieDisclaimer(string m, string b, string p, string t, string bc)
        {
            if (string.IsNullOrEmpty(m))
            {
                m = "Accept our cookies, peasant!";
            }
            if (string.IsNullOrEmpty(b))
            {
                b = "Okay boss, don't shout!";
            }
            if (string.IsNullOrEmpty(p))
            {
                p = "#aa0000";
            }
            if (string.IsNullOrEmpty(t))
            {
                t = "#ffdddd";
            }
            if (string.IsNullOrEmpty(bc))
            {
                bc = "#ff0000";
            }
            Message = m;
            ButtonText = b;
            PopUpBackgroundColor = p;
            TextColor = t;
            ButtonBackgroundColor = bc;
        }
    }
}