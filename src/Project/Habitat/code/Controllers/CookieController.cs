using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Habitat.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sitecore.Habitat.Website.Controllers
{
    public struct CookieDisclaimerFields
    {
        public static readonly ID Message = new ID("{C27D71C6-01C5-47D8-B1FD-FFD32CBFF736}");
        public static readonly ID ButtonText = new ID("{9A820013-F337-4FC9-87E9-19B3EFBDAD63}");
        public static readonly ID PopUpBackgroundColor = new ID("{87461BFA-6605-4773-B201-B5F022D80737}");
        public static readonly ID TextColor = new ID("{90E38A9C-089F-4D12-A9D4-6B35E44DF849}");
        public static readonly ID ButtonBackgroundColor = new ID("{E32FADCA-1740-45B2-AC71-4F19EADEDC4A}");
    }
    public class CookieController : Controller
    {
        private readonly ID CookieDisclaimerID = new ID("{158F739E-7618-4585-94D7-28B227B84B18}"); 


        // GET: Cookie
        public ActionResult Index()
        {
            Database contextDb = Context.Database;
            Item cookieDislaimerItem = contextDb.GetItem(CookieDisclaimerID);

            CookieDisclaimer cookie = new CookieDisclaimer(
                cookieDislaimerItem[CookieDisclaimerFields.Message],
                cookieDislaimerItem[CookieDisclaimerFields.ButtonText],
                cookieDislaimerItem[CookieDisclaimerFields.PopUpBackgroundColor],
                cookieDislaimerItem[CookieDisclaimerFields.TextColor],
                cookieDislaimerItem[CookieDisclaimerFields.ButtonBackgroundColor]
                );
            //string cookievalue;
            //if (Request.Cookies["isCookieAccepted"] != null)
            //{
            //    cookievalue = Request.Cookies["isCookieAccepted"].ToString();
            //}
            //else
            //{
            //    Response.Cookies["isCookieAccepted"].Value = "cookie value";
            //    Response.Cookies["cookie"].Expires = DateTime.Now.AddMinutes(1); // add expiry time
            //}


            return View(cookie);
        }

        //[HttpPost]
        //public ActionResult Index(string decline, string allow)
        //{
        //    string declineValue = decline;
        //    string allowValue = allow;
        //    return View();
        //}
    }
}