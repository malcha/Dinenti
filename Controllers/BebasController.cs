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
            ViewBag.TitleName = "Camperas - Buzos";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.BUZOS)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);
        }

        public ActionResult Abrigos()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Camperas de abrigos";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.ABRIGOS)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);
        }

        public ActionResult Remeras()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Remeras - Camisas";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.REMERAS || x.SubCategory == Clouth.SUBCATEGORY.REMERON)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);
        }
        public ActionResult Pantalones()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Pantalones - Calzas - Jardineros";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.PANTALONES)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);
        }

        public ActionResult Buzos()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Buzos - Camperas";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.ENTERITOS)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);
        }
        public ActionResult Vestidos()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Vestidos - Jumpers";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.VESTIDOS )
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);
        }
        
        
    }
}