using System.Web.Mvc;
using MvcApplication2.Manager;
using MvcApplication2.Models;
using System.Linq;
using MvcApplication2.Helpers;


namespace MvcApplication2.Controllers
{
    public class VaronController : Controller
    {
        public ActionResult remerascamisas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Remeras y Musculosas para varones";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.VARON)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.REMERAS)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);
        }


        public ActionResult buzoscamperas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Camisas y Camperas para varones";
            var list = new ClouthManager()
                        .FindAll()
                        .Where(x => x.Category == Clouth.CATEGORY.VARON)
                        .Where(x => x.SubCategory == Clouth.SUBCATEGORY.BUZOS || x.SubCategory == Clouth.SUBCATEGORY.CAMPERAS || x.SubCategory == Clouth.SUBCATEGORY.CAMISAS)
                        .OrderBy(x => x.Id)
                        .ToList();

            return View("todos", list);
        }


        public ActionResult PantalonesShorts()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Bermudas y Shorts de baño para varones";
            var list = new ClouthManager()
                        .FindAll()
                        .Where(x => x.Category == Clouth.CATEGORY.VARON)
                        .Where(x => x.SubCategory == Clouth.SUBCATEGORY.PANTALON || x.SubCategory == Clouth.SUBCATEGORY.SHORTDEBANO)
                        .OrderBy(x => x.Id)
                        .ToList();

            return View("todos", list);
        }


    }
}