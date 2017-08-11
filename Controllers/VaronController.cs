using System.Web.Mvc;
using MvcApplication2.Manager;
using MvcApplication2.Models;
using System.Linq;
using MvcApplication2.Helpers;


namespace MvcApplication2.Controllers
{
    public class VaronController : Controller
    {
        public ActionResult abrigos()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Abrigos para varones";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.VARON)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.ABRIGOS)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);
        }


        public ActionResult remeras()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Remeras, Buzos y Camisas para varones";
            var list = new ClouthManager()
                        .FindAll()
                        .Where(x => x.Category == Clouth.CATEGORY.VARON)
                        .Where(x => x.SubCategory == Clouth.SUBCATEGORY.REMERAS || x.SubCategory == Clouth.SUBCATEGORY.BUZOS || x.SubCategory == Clouth.SUBCATEGORY.CAMISAS)
                        .OrderBy(x => x.Id)
                        .ToList();

            return View("todos", list);
        }


        public ActionResult camperaspantalones()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Camperas y Pantalones para varones";
            var list = new ClouthManager()
                        .FindAll()
                        .Where(x => x.Category == Clouth.CATEGORY.VARON)
                        .Where(x => x.SubCategory == Clouth.SUBCATEGORY.PANTALON || x.SubCategory == Clouth.SUBCATEGORY.CAMPERAS)
                        .OrderBy(x => x.Id)
                        .ToList();

            return View("todos", list);
        }


    }
}