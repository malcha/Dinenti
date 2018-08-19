using System.Web.Mvc;
using MvcApplication2.Manager;
using MvcApplication2.Models;
using System.Linq;
using MvcApplication2.Helpers;

namespace MvcApplication2.Controllers
{
    public class MinibebesController : Controller
    {
        public ActionResult All()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Mini bebes";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.MINIBEBES)
                            .OrderBy(x => x.ShortDescription)
                            .ToList();

            return View("todos", list);
        }

        public ActionResult MiniBebas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Mini bebas y Mini Bebes ";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.MINIBEBES)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.MINIBEBE)
                            .ToList();

            return View("todos", list);
        }

        public ActionResult MiniBebes()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Mini bebes";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.MINIBEBES)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.MINIBEBE)
                            .ToList();

            return View("todos", list);
        }

        public ActionResult Abrigos()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Abrigos";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.MINIBEBES)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.ABRIGOS)
                            .ToList();

            return View("todos", list);
        }


    }
}