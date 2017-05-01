namespace Sitecore.Feature.PageContent.Controller
{
    using System.Web.Mvc;
    using Sitecore.Mvc.Presentation;
    using Diagnostics;

    public class PageContentController : Controller
    {
        public ActionResult Content()
        {
            var item = RenderingContext.Current.Rendering.Item;

            Log.Info(@"[Content] I WAS HERE", this);
            return View(item);
        }
    }
}