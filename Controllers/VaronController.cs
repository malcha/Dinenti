using System.Web.Mvc;
using MvcApplication2.Manager;
using MvcApplication2.Models;
using System.Linq;
using MvcApplication2.Helpers;


namespace MvcApplication2.Controllers
{
    public class VaronController : Controller
    {
        public ActionResult camperas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Camperas - Pantalones Rústicos";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.VARON)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.CAMPERAS)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);
        }


        public ActionResult remeras()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Remeras - Camisas - Chomba";
            var list = new ClouthManager()
                        .FindAll()
                        .Where(x => x.Category == Clouth.CATEGORY.VARON)
                        .Where(x => x.SubCategory == Clouth.SUBCATEGORY.REMERAS || x.SubCategory == Clouth.SUBCATEGORY.BUZOS || x.SubCategory == Clouth.SUBCATEGORY.CAMISAS)
                        .OrderBy(x => x.Id)
                        .ToList();

            return View("todos", list);
        }


        public ActionResult bermudas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Bermudas - Shorts de baño";
            var list = new ClouthManager()
                        .FindAll()
                        .Where(x => x.Category == Clouth.CATEGORY.VARON)
                        .Where(x => x.SubCategory == Clouth.SUBCATEGORY.BERMUDAS)
                        .OrderBy(x => x.Id)
                        .ToList();

            return View("todos", list);
        }


    }
}