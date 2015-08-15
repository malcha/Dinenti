using System.Web.Mvc;
using MvcApplication2.Manager;
using MvcApplication2.Models;
using System.Linq;
using MvcApplication2.Helpers;

namespace MvcApplication2.Controllers
{
    public class BebesController : Controller
    {
        
        public ActionResult remerascamisas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Remeras y camisas para bebes";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBES)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.REMERAS || x.SubCategory == Clouth.SUBCATEGORY.CAMISAS)
                            .ToList();

            return View("todos", list);
        }

        public ActionResult camperasbuzos()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Camperas y buzos para bebes";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBES)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.CAMPERAS || x.SubCategory == Clouth.SUBCATEGORY.BUZOS)
                            .ToList();

            return View("todos", list);
        }

        public ActionResult Pantalones()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Pantalones para bebes";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBES)
                            .Where(x=> x.SubCategory==Clouth.SUBCATEGORY.PANTALON)
                            .ToList();

            return View("todos",list);
        }

        public ActionResult Abrigos()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Abrigos para bebes";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBES)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.ABRIGOS || x.SubCategory == Clouth.SUBCATEGORY.CHALECOS)
                            .ToList();

            return View("todos", list);
        }
    }
}