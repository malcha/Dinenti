﻿using System.Web.Mvc;
using MvcApplication2.Manager;
using MvcApplication2.Models;
using System.Linq;
using MvcApplication2.Helpers;
using System;

namespace MvcApplication2.Controllers
{
    public class BebesController : Controller
    {
        
        public ActionResult all(Guid? type)
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Bebes";
            var list = new ClouthManager()
                            .FindAll(type)
                            .Where(x => x.Category == Clouth.CATEGORY.BEBES)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("todos", list);
        }

        public ActionResult camisas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Camisas para bebes";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBES)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.CAMISAS)
                            .OrderBy(x => x.ShortDescription)
                            .ToList();

            return View("todos", list);
        }

        public ActionResult camperas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Camperas y Buzos para bebes";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBES)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.CAMPERAS )
                            .OrderBy(x => x.ShortDescription)
                            .ToList();

            return View("todos", list);
        }

        public ActionResult pantalones()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Pantalones y Jardineros para bebes";
            var list = new ClouthManager()
                            .FindAll()
                            .Where(x => x.Category == Clouth.CATEGORY.BEBES)
                            .Where(x => x.SubCategory == Clouth.SUBCATEGORY.PANTALON)
                            .OrderBy(x => x.ShortDescription)
                            .ToList();

            return View("todos",list);
        }

    }
}