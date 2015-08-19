using System.Web.Mvc;
using MvcApplication2.Manager;
using MvcApplication2.Models;
using System.Linq;
using MvcApplication2.Helpers;

namespace MvcApplication2.Controllers
{
    public class NenaController : Controller
    {
        public ActionResult remerascamisas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Remeras y camisas para nenas";
            var list = new ClouthManager()
                .FindAll()
                .Where(x => x.Category == Clouth.CATEGORY.NENA)
                .Where(x => x.SubCategory == Clouth.SUBCATEGORY.REMERAS || x.SubCategory == Clouth.SUBCATEGORY.CAMISAS)
                .ToList();

            return View("todos", list);
        }

        public ActionResult vestidossoleros()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Vestidos y soleros para nenas";
            var list = new ClouthManager()
                .FindAll()
                .Where(x => x.Category == Clouth.CATEGORY.NENA)
                .Where(x => x.SubCategory == Clouth.SUBCATEGORY.VESTIDOS)
                .ToList();

            return View("todos", list);
        }

        public ActionResult calzasshorts()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Calzas y shorts para nenas";
            var list = new ClouthManager()
                .FindAll()
                .Where(x => x.Category == Clouth.CATEGORY.NENA)
                .Where(x => x.SubCategory == Clouth.SUBCATEGORY.SHORT || x.SubCategory == Clouth.SUBCATEGORY.CALZAS)
                .ToList();

            return View("todos", list);
        }
        public ActionResult enteritos()
        {
            ViewBag.TitleName = "Enteritos para nenas";
            var list = new ClouthManager()
                .FindAll()
                .Where(x => x.Category == Clouth.CATEGORY.NENA)
                .Where(x => x.SubCategory == Clouth.SUBCATEGORY.ENTERITOS)
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
                .ToList();

            return View("todos", list);
        }
    }
}