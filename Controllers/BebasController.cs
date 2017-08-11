using System.Web.Mvc;
using MvcApplication2.Manager;
using MvcApplication2.Models;
using System.Linq;
using MvcApplication2.Helpers;

namespace MvcApplication2.Controllers
{
    public class BebasController : Controller
    {
        //BEBA
        //1 - Remeras - Remerones - Camisolas
        //2 - (Calzas - Jardinero (Calzas)
        //    Shorts - Pantalon rustico  (Pantalon)) POR AHORA TODOS JUNTOS
        //3 - Campera rustica - Rompeviento
        //4 - Vestidos - Enteritos
        public ActionResult Camperas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Camperas para Bebas";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.CAMPERAS)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);

        }
        
        public ActionResult RemerasBuzos()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Remeras y Buzos para Bebas";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.REMERAS || x.SubCategory == Clouth.SUBCATEGORY.REMERON)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);
        }

        public ActionResult pantalonescalzas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Pantalones y Calzas para Bebas";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.PANTALON || x.SubCategory == Clouth.SUBCATEGORY.CALZAS)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);
        }
        public ActionResult vestidoscamisolas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Vestidos y Camisolas para Bebas";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.VESTIDOS )
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);
        }

        public ActionResult Abrigos()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Abrigos para Bebas";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.ABRIGOS)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);
        }
        
    }
}