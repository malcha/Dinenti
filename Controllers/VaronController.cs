using System.Web.Mvc;
using MvcApplication2.Manager;
using MvcApplication2.Models;
using System.Linq;
using MvcApplication2.Helpers;
using System;

namespace MvcApplication2.Controllers
{
    public class VaronController : Controller
    {
        public ActionResult all(Guid? type)
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Varones";
            var list = new ClouthManager()
                            .FindAll(type)
                            .Where(x => x.Category == Clouth.CATEGORY.VARON)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);
        }


        public ActionResult buzoscamperas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Buzos camperas y chalecos para varones";
            var list = new ClouthManager()
                        .FindAll()
                        .Where(x => x.Category == Clouth.CATEGORY.VARON)
                        .Where(x => x.SubCategory == Clouth.SUBCATEGORY.BUZOS || x.SubCategory == Clouth.SUBCATEGORY.CAMPERAS || x.SubCategory == Clouth.SUBCATEGORY.CHALECOS)
                        .OrderBy(x => x.ShortDescription)
                        .ToList();

            return View("todos", list);
        }


        public ActionResult PantalonesShorts()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Pantalones para varones";
            var list = new ClouthManager()
                        .FindAll()
                        .Where(x => x.Category == Clouth.CATEGORY.VARON)
                        .Where(x => x.SubCategory == Clouth.SUBCATEGORY.PANTALON || x.SubCategory == Clouth.SUBCATEGORY.SHORT)
                        .OrderBy(x => x.ShortDescription)
                        .ToList();

            return View("todos", list);
        }


    }
}