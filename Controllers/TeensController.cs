using System.Web.Mvc;
using MvcApplication2.Manager;
using MvcApplication2.Models;
using System.Linq;
using MvcApplication2.Helpers;

namespace MvcApplication2.Controllers
{
    public class TeensController: Controller
    {
        public ActionResult Ellas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Ellas";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.TEENS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.NENA)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);
        }

        public ActionResult Ellos()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Ellos";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.TEENS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.NENE)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);
        }

    }
}