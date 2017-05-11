using Sitecore.Data;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sitecore.Habitat.Website.Controllers
{
    public class ThemeController : Controller
    {
        private readonly ID habitatItemID = new ID("{725A45E3-E307-4B95-B363-2782B059DF06}");
        // GET: Theme
        public ActionResult Index()
        {
            Database contextDb = Context.Database;
            Item habitatItem = contextDb.GetItem(habitatItemID);
            string cssThemePath = habitatItem.Fields["{8A6F0F84-E80A-4E98-BA0C-22A0564B2AEA}"].Item["{1BD5C4FF-8865-45B3-82D9-380B8225F156}"];
            string test = "";

            //Get a multilist field from the current item
            Sitecore.Data.Fields.MultilistField multilistField = habitatItem.Fields["{8A6F0F84-E80A-4E98-BA0C-22A0564B2AEA}"];
            if (multilistField != null)
            {
                //Iterate over all the selected items by using the property TargetIDs
                foreach (ID id in multilistField.TargetIDs)
                {
                    Item targetItem = contextDb.Items[id];
                    // Do something with the target items
                    test = targetItem["{1BD5C4FF-8865-45B3-82D9-380B8225F156}"];
                    // ...
                }
            }

            return View(new MvcHtmlString("<link rel=\"stylesheet\" href=\""+ test + "\">"));
        }
    }
}