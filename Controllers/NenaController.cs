using System.Web.Mvc;
using MvcApplication2.Manager;
using MvcApplication2.Models;
using System.Linq;
using MvcApplication2.Helpers;

namespace MvcApplication2.Controllers
{
    public class NenaController : Controller
    {
        public ActionResult remerasbuzos()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Remeras y Buzos para nenas";
            var list = new ClouthManager()
                .FindAll()
                .Where(x => x.Category == Clouth.CATEGORY.NENA)
                .Where(x => x.SubCategory == Clouth.SUBCATEGORY.REMERAS)
                .OrderBy(x => x.Id)
                .ToList();

            return View("todos", list);
        }

        public ActionResult vestidoscamisolas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Vestidos y Camisolas para nenas";
            var list = new ClouthManager()
                .FindAll()
                .Where(x => x.Category == Clouth.CATEGORY.NENA)
                .Where(x => x.SubCategory == Clouth.SUBCATEGORY.VESTIDOS)
                .OrderBy(x => x.Id)
                .ToList();

            return View("todos", list);
        }

        public ActionResult calzaspantalones()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Calzas y Pantalones para nenas";
            var list = new ClouthManager()
                .FindAll()
                .Where(x => x.Category == Clouth.CATEGORY.NENA)
                .Where(x => x.SubCategory == Clouth.SUBCATEGORY.PANTALON || x.SubCategory == Clouth.SUBCATEGORY.CALZAS)
                .OrderBy(x => x.Id)
                .ToList();

            return View("todos", list);
        }
        public ActionResult Camperas()
        {
            ViewBag.TitleName = "Camperas y Abrigos para nenas";
            var list = new ClouthManager()
                .FindAll()
                .Where(x => x.Category == Clouth.CATEGORY.NENA)
                .Where(x => x.SubCategory == Clouth.SUBCATEGORY.CAMPERAS || x.SubCategory == Clouth.SUBCATEGORY.ABRIGOS || x.SubCategory == Clouth.SUBCATEGORY.BUZOS)
                .OrderBy(x => x.Id)
                .ToList();

            return View("todos", list);
        }

        public ActionResult Abrigos()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Abrigos para nenas";
            var list = new ClouthManager()
                .FindAll()
                .Where(x => x.Category == Clouth.CATEGORY.NENA)
                .Where(x => x.SubCategory == Clouth.SUBCATEGORY.ABRIGOS)
                .OrderBy(x => x.Id)
                .ToList();

            return View("todos", list);
        }
    }
}