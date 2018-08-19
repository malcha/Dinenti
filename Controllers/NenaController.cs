using System.Web.Mvc;
using MvcApplication2.Manager;
using MvcApplication2.Models;
using System.Linq;
using MvcApplication2.Helpers;

namespace MvcApplication2.Controllers
{
    public class NenaController : Controller 
    {
        public ActionResult remeras()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Remeras - Camisolas";
            var list = new ClouthManager()
                .FindAll()
                .Where(x => x.Category == Clouth.CATEGORY.NENA)
                .Where(x => x.SubCategory == Clouth.SUBCATEGORY.REMERAS)
                .OrderBy(x => x.Id)
                .ToList();

            return View("todos", list);
        }

        public ActionResult pantalones()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Pantalones - Calzas";
            var list = new ClouthManager()
                .FindAll()
                .Where(x => x.Category == Clouth.CATEGORY.NENA)
                .Where(x => x.SubCategory == Clouth.SUBCATEGORY.PANTALONES || x.SubCategory == Clouth.SUBCATEGORY.CALZAS)
                .OrderBy(x => x.Id)
                .ToList();

            return View("todos", list);
        }
        public ActionResult vestidos()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Vestidos";
            var list = new ClouthManager()
                .FindAll()
                .Where(x => x.Category == Clouth.CATEGORY.NENA)
                .Where(x => x.SubCategory == Clouth.SUBCATEGORY.VESTIDOS)
                .OrderBy(x => x.Id)
                .ToList();

            return View("todos", list);
        }
        public ActionResult Camperas()
        {
            ViewBag.TitleName = "Buzos - Camperas";
            var list = new ClouthManager()
                .FindAll()
                .Where(x => x.Category == Clouth.CATEGORY.NENA)
                .Where(x => x.SubCategory == Clouth.SUBCATEGORY.CAMPERAS || x.SubCategory == Clouth.SUBCATEGORY.ABRIGOS || x.SubCategory == Clouth.SUBCATEGORY.BUZOS)
                .OrderBy(x => x.Id)
                .ToList();

            return View("todos", list);
        }

        public ActionResult enteritos()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Enteritos - Jardineros - Shorts";
            var list = new ClouthManager()
                .FindAll()
                .Where(x => x.Category == Clouth.CATEGORY.NENA)
                .Where(x => x.SubCategory == Clouth.SUBCATEGORY.ENTERITOS)
                .OrderBy(x => x.Id)
                .ToList();

            return View("todos", list);
        }
    }
}