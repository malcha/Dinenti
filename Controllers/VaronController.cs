using System.Web.Mvc;
using MvcApplication2.Manager;
using MvcApplication2.Models;
using System.Linq;
using MvcApplication2.Helpers;


namespace MvcApplication2.Controllers
{
    public class VaronController : Controller
    {
        public ActionResult buzos()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Buzos - Camperas";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.VARON)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.BUZOS)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);
        }


        public ActionResult remeras()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Remeras - Chombas";
            var list = new ClouthManager()
                        .FindAll()
                        .Where(x => x.Category == Clouth.CATEGORY.VARON)
                        .Where(x => x.SubCategory == Clouth.SUBCATEGORY.REMERAS)
                        .OrderBy(x => x.Id)
                        .ToList();

            return View("todos", list);
        }


        public ActionResult Pantalones()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Pantalones";
            var list = new ClouthManager()
                        .FindAll()
                        .Where(x => x.Category == Clouth.CATEGORY.VARON)
                        .Where(x => x.SubCategory == Clouth.SUBCATEGORY.PANTALONES)
                        .OrderBy(x => x.Id)
                        .ToList();

            return View("todos", list);
        }


    }
}