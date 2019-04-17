using System.Web.Mvc;
using MvcApplication2.Manager;
using MvcApplication2.Models;
using System.Linq;
using MvcApplication2.Helpers;
using System;

namespace MvcApplication2.Controllers
{
    public class MinibebesController : Controller
    {
        public ActionResult All(Guid? type)
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Mini bebes";
            var list = new ClouthManager()
                            .FindAll(type)
                            .Where(x => x.Category == Clouth.CATEGORY.MINIBEBES)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);
        }

        //public ActionResult BodyEnteritos()
        //{
        //    Cookies.WriteCookie();
        //    ViewBag.TitleName = "Body y enteritos para mini bebes";
        //    var list = new ClouthManager()
        //                    .FindAll()
        //                    .Where(x => x.Category == Clouth.CATEGORY.MINIBEBES)
        //                    .Where(x => x.SubCategory == Clouth.SUBCATEGORY.BODY || x.SubCategory == Clouth.SUBCATEGORY.ENTERITOS)
        //                    .ToList();

        //    return View("todos", list);
        //}


    }
}