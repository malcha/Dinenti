﻿using System.Web.Mvc;
using MvcApplication2.Manager;
using MvcApplication2.Models;
using System.Linq;
using MvcApplication2.Helpers;

namespace MvcApplication2.Controllers
{
    public class BebesController : Controller
    {
        public ActionResult remeras()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Remeras, chombas y camisas para bebes";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBES)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.REMERAS || x.SubCategory == Clouth.SUBCATEGORY.CHOMBAS)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);
        }

        //public ActionResult camisas()
        //{
        //    Cookies.WriteCookie();
        //    ViewBag.TitleName = "Camisas para bebes";
        //    var list = new ClouthManager()
        //                    .FindAll()
        //                    .Where(x => x.Category == Clouth.CATEGORY.BEBES)
        //                    .Where(x => x.SubCategory == Clouth.SUBCATEGORY.CAMISAS)
        //                    .OrderBy(x => x.Id)
        //                    .ToList();

        //    return View("todos", list);
        //}

        public ActionResult camperas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Camperas y Abrigos para bebes";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBES)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.CAMPERAS || x.SubCategory == Clouth.SUBCATEGORY.ABRIGOS)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);
        }

        public ActionResult pantalones()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Pantalones y Buzosde baño para bebes";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBES)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.PANTALON || x.SubCategory == Clouth.SUBCATEGORY.BUZOS)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos",list);
        }

    }
}