using System.Web.Mvc;
using MvcApplication2.Manager;
using MvcApplication2.Models;
using System.Linq;
using MvcApplication2.Helpers;

namespace MvcApplication2.Controllers
{
    public class BebasController : Controller
    {

        public ActionResult BuzosCamperas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Buzos y camperas de frisa para Bebas";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.BUZOS || x.SubCategory == Clouth.SUBCATEGORY.CAMPERAS)
                            .ToList();

            return View("todos", list);

        }

        public ActionResult Remeras()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Remeras para Bebas";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.REMERAS)
                            .ToList();

            return View("todos", list);
        }

        public ActionResult PantalonesCalzas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Pantalones y calzas para Bebas";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.PANTALON || x.SubCategory == Clouth.SUBCATEGORY.CALZAS)
                            .ToList();

            return View("todos", list);
        }

        public ActionResult Abrigos()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Abrigos para Bebas";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.ABRIGOS)
                            .ToList();

            return View("todos", list);
        }

        public ActionResult VestidosJumpers()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Vestidos y jumpers para Bebas";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.VESTIDOS || x.SubCategory == Clouth.SUBCATEGORY.JUMPER)
                            .ToList();

            return View("todos", list);
        }
    }
}