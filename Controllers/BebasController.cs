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
            ViewBag.TitleName = "Camperas y Rompevientos para Bebas";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.CAMPERAS)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);

        }
        
        public ActionResult Remerasremerones()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Remeras,  Remerones y Camisolas para Bebas";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.REMERAS || x.SubCategory == Clouth.SUBCATEGORY.REMERON)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);
        }

        public ActionResult Pantalonesshorts()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Pantalones y Shorts para Bebas";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.PANTALON || x.SubCategory == Clouth.SUBCATEGORY.SHORT)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);
        }
        public ActionResult Calzasjardineros()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Pantalones y calzas para Bebas";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.CALZAS)
                            .OrderBy(x => x.Id)
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
                            .OrderBy(x => x.Id)
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
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);
        }
    }
}