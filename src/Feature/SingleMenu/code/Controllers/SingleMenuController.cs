using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Feature.SingleMenu.Models;
namespace Sitecore.Feature.SingleMenu.Controllers
{
    public class SingleMenuController : Controller
    {
        private readonly string[] cssClasses = new string[] { "color-index-1", "color-index-2", "color-index-3", "color-index-4", "color-index-5", "color-index-6" };
        // GET: SingleMenu
        public ActionResult MenuList()
        {
            Item pageItem = Context.Item;
            string pageTitle = pageItem["Title"];
            MultilistField menuItems = pageItem.Fields["Menus"];
            int numberofItems = menuItems.Count;
            int[] classesIndexes = getClassesIndexes(numberofItems);
            int counter = 0;
            List<Models.SingleMenu> singleMenuList = new List<Models.SingleMenu>();
            foreach (Item item in menuItems.GetItems())
            {
                Models.SingleMenu currentMenuItem = new Models.SingleMenu(item["Title"], cssClasses[classesIndexes[counter]]);
                singleMenuList.Add(currentMenuItem);
                counter++;
            }

            //only for testing purposes
            //int[] indexes1 = getClassesIndexes(2);
            //int[] indexes2 = getClassesIndexes(3);
            //int[] indexes3 = getClassesIndexes(4);
            //int[] indexes4 = getClassesIndexes(5);
            //int[] indexes5 = getClassesIndexes(6);
            return View(singleMenuList);
        }

        private int[] getClassesIndexes(int numberofItems)
        {
            List<int> indexes = new List<int>();
            indexes.Add(0);
            if (numberofItems == 1)
            {
                return indexes.ToArray();
            }
            indexes.Add(cssClasses.Length - 1);

            int middleNum = (cssClasses.Length / 2);
            int i = 0;
            bool isPlus = true;
            while(indexes.Count != numberofItems)
            {
                if (isPlus)
                {
                    indexes.Add(middleNum + i);
                    i++;
                    isPlus = false;
                }
                else
                {
                    indexes.Add(middleNum - i);
                    isPlus = true;
                }
            }
            indexes.Sort();
            return indexes.ToArray();
        }
    }
}