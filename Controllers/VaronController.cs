using System.Web.Mvc;
using MvcApplication2.Manager;
using MvcApplication2.Models;
using System.Linq;
using MvcApplication2.Helpers;


namespace MvcApplication2.Controllers
{
    public class VaronController : Controller
    {
        public ActionResult remerascamisas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Remeras y camisas para varones";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.VARON)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.REMERAS || x.SubCategory == Clouth.SUBCATEGORY.CAMISAS)
                            .ToList();

            return View("todos", list);
        }

        public ActionResult PantalonesShorts()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Pantalones y shorts de baño para varones";
            var list = new ClouthManager()
                        .FindAll()
                        .Where(x => x.Category == Clouth.CATEGORY.VARON)
                        .Where(x => x.SubCategory == Clouth.SUBCATEGORY.PANTALON || x.SubCategory == Clouth.SUBCATEGORY.SHORT)
                        .ToList();

            return View("todos", list);
        }


    }
}