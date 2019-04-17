using System.Web.Mvc;
using MvcApplication2.Manager;
using MvcApplication2.Models;
using System.Linq;
using MvcApplication2.Helpers;
using System;

namespace MvcApplication2.Controllers
{
    public class NenaController : Controller
    {
        public ActionResult all(Guid? type)
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Nenas";
            var list = new ClouthManager()
                .FindAll(type)
                .Where(x => x.Category == Clouth.CATEGORY.NENA)
                .OrderBy(x => x.Id)
                .ToList();

            return View("todos", list);
        }

        public ActionResult vestidos()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Vestidos para nenas";
            var list = new ClouthManager()
                .FindAll()
                .Where(x => x.Category == Clouth.CATEGORY.NENA)
                .Where(x => x.SubCategory == Clouth.SUBCATEGORY.VESTIDOS)
                .OrderBy(x => x.ShortDescription)
                .ToList();

            return View("todos", list);
        }

        public ActionResult calzas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Calzas para nenas";
            var list = new ClouthManager()
                .FindAll()
                .Where(x => x.Category == Clouth.CATEGORY.NENA)
                .Where(x => x.SubCategory == Clouth.SUBCATEGORY.PANTALON || x.SubCategory == Clouth.SUBCATEGORY.CALZAS)
                .OrderBy(x => x.ShortDescription)
                .ToList();

            return View("todos", list);
        }
        public ActionResult CamperasBuzos()
        {
            ViewBag.TitleName = "Camperas Buzos y Chalecos para nenas";
            var list = new ClouthManager()
                .FindAll()
                .Where(x => x.Category == Clouth.CATEGORY.NENA)
                .Where(x => x.SubCategory == Clouth.SUBCATEGORY.CAMPERAS || x.SubCategory == Clouth.SUBCATEGORY.CHALECOS || x.SubCategory == Clouth.SUBCATEGORY.BUZOS)
                .OrderBy(x => x.ShortDescription)
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
                .OrderBy(x => x.ShortDescription)
                .ToList();

            return View("todos", list);
        }
    }
}