using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sitecore.Habitat.Website.Controllers
{
    public class GeneralScriptsController : Controller
    {
        private readonly ID globalScriptsItemID = new ID("{8FA37AE9-CA7F-4D69-BA54-1AE031C18F55}");
        // GET: GeneralScripts
        public ActionResult LoadScript() //This is the global one
        {
            Item globalScriptsItem = Sitecore.Context.Database.GetItem(globalScriptsItemID);
            MvcHtmlString publicScript = new MvcHtmlString(globalScriptsItem["PublicScripts"]);

            return View(publicScript);
        }

        public ActionResult LoadScriptSpecificPages()
        {
            Item globalScriptsItem = Sitecore.Context.Database.GetItem(globalScriptsItemID);
            Item currentPageItem = Context.Item;
            List<MvcHtmlString> scripts = new List<MvcHtmlString>();

            MvcHtmlString inlinePageScript = new MvcHtmlString(currentPageItem["Script"]);
            if (inlinePageScript != null)
            {
                scripts.Add(inlinePageScript);
            }

            IEnumerable<Item> specificScripts = globalScriptsItem.GetChildren();
            foreach (var item in specificScripts)
            {
                MvcHtmlString currentScript = new MvcHtmlString(item["Script"]);
                MultilistField pagesItems = item.Fields["Pages"];

                foreach (TemplateItem pageTemplate in pagesItems.GetItems())
                {
                    if (currentPageItem.TemplateID == pageTemplate.ID)
                    {
                        scripts.Add(currentScript);
                    }
                }

            }

            return View(scripts);
        }
    }
}