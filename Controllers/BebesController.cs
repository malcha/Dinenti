using System.Web.Mvc;
using MvcApplication2.Manager;
using MvcApplication2.Models;
using System.Linq;
using MvcApplication2.Helpers;

namespace MvcApplication2.Controllers
{
    public class BebesController : Controller
    {
        
        public ActionResult remeraschombas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Remeras y chombas para bebes";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBES)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.REMERAS || x.SubCategory == Clouth.SUBCATEGORY.CHOMBAS)
                            .ToList();

            return View("todos", list);
        }

        public ActionResult camisas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Camisas para bebes";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBES)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.CAMISAS)
                            .ToList();

            return View("todos", list);
        }

        public ActionResult camperas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Camperas para bebes";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBES)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.CAMPERAS )
                            .ToList();

            return View("todos", list);
        }

        public ActionResult pantalonesshorts()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Pantalones y shorts de baño para bebes";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBES)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.PANTALON || x.SubCategory == Clouth.SUBCATEGORY.SHORTDEBANO)
                            .ToList();

            return View("todos",list);
        }

    }
}