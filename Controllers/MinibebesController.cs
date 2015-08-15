using System.Web.Mvc;
using MvcApplication2.Manager;
using MvcApplication2.Models;
using System.Linq;
using MvcApplication2.Helpers;

namespace MvcApplication2.Controllers
{
    public class MinibebesController : Controller
    {
        public ActionResult Todos()
        {
            Cookies.WriteCookie();
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.MINIBEBES)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.BODY || x.SubCategory == Clouth.SUBCATEGORY.ENTERITOS)
                            .ToList();

            return View(list);
        }

        public ActionResult BodyEnteritos()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Body y enteritos para mini bebes";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.MINIBEBES)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.BODY || x.SubCategory == Clouth.SUBCATEGORY.ENTERITOS)
                            .ToList();

            return View("todos",list);
        }

        public ActionResult CamperasAbrigos()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Camperas y abrigos para mini bebes";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.MINIBEBES)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.CAMPERAS || x.SubCategory == Clouth.SUBCATEGORY.ABRIGOS)
                            .ToList();

            return View("todos", list);
        }


    }
}