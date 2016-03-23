using System.Web.Mvc;
using MvcApplication2.Manager;
using MvcApplication2.Models;
using System.Linq;
using MvcApplication2.Helpers;

namespace MvcApplication2.Controllers
{
    public class BebasController : Controller
    {
//        REMERAS - REMERONES  ----------
//VESTIDOS
//ENTERITOS
//CALZAS - SHORTS - PANTALON
//CAMPERA RUSTICA
//CAMISAS

        public ActionResult Camperas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Camperas para Bebas";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.CAMPERAS)
                            .OrderBy(x => x.ShortDescription)
                            .ToList();

            return View("todos", list);

        }
        
        public ActionResult Remerasremerones()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Remeras y remerones para Bebas";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.REMERAS || x.SubCategory == Clouth.SUBCATEGORY.REMERON)
                            .OrderBy(x => x.ShortDescription)
                            .ToList();

            return View("todos", list);
        }

        public ActionResult PantalonesCalzas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Pantalones y calzas para Bebas";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.PANTALON || x.SubCategory == Clouth.SUBCATEGORY.CALZAS || x.SubCategory == Clouth.SUBCATEGORY.SHORT)
                            .OrderBy(x => x.ShortDescription)
                            .ToList();

            return View("todos", list);
        }
        
        public ActionResult Camisas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Camisas para Bebas";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.CAMISAS)
                            .OrderBy(x => x.ShortDescription)
                            .ToList();

            return View("todos", list);
        }

        public ActionResult Vestidos()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Vestidos para Bebas";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.VESTIDOS)
                            .OrderBy(x => x.ShortDescription)
                            .ToList();

            return View("todos", list);
        }
    }
}