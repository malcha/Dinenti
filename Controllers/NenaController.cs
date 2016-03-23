﻿using System.Web.Mvc;
using MvcApplication2.Manager;
using MvcApplication2.Models;
using System.Linq;
using MvcApplication2.Helpers;

namespace MvcApplication2.Controllers
{
    public class NenaController : Controller
    {
        public ActionResult remerascamisas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Remeras y camisas para nenas";
            var list = new ClouthManager()
                .FindAll()
                .Where(x => x.Category == Clouth.CATEGORY.NENA)
                .Where(x => x.SubCategory == Clouth.SUBCATEGORY.REMERAS || x.SubCategory == Clouth.SUBCATEGORY.CAMISAS)
                .OrderBy(x => x.ShortDescription)
                .ToList();

            return View("todos", list);
        }

        public ActionResult vestidos()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Vestidos para nenas";
            var list = new ClouthManager()
                .FindAll()
                .Where(x => x.Category == Clouth.CATEGORY.NENA)
                .Where(x => x.SubCategory == Clouth.SUBCATEGORY.VESTIDOS)
                .OrderBy(x => x.ShortDescription)
                .ToList();

            return View("todos", list);
        }

        public ActionResult calzas()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Calzas para nenas";
            var list = new ClouthManager()
                .FindAll()
                .Where(x => x.Category == Clouth.CATEGORY.NENA)
                .Where(x => x.SubCategory == Clouth.SUBCATEGORY.PANTALON || x.SubCategory == Clouth.SUBCATEGORY.CALZAS)
                .OrderBy(x => x.ShortDescription)
                .ToList();

            return View("todos", list);
        }
        public ActionResult CamperasBuzos()
        {
            ViewBag.TitleName = "Camperas Buzos y Chalecos para nenas";
            var list = new ClouthManager()
                .FindAll()
                .Where(x => x.Category == Clouth.CATEGORY.NENA)
                .Where(x => x.SubCategory == Clouth.SUBCATEGORY.CAMPERAS || x.SubCategory == Clouth.SUBCATEGORY.CHALECOS || x.SubCategory == Clouth.SUBCATEGORY.BUZOS)
                .OrderBy(x => x.ShortDescription)
                .ToList();

            return View("todos", list);
        }

        public ActionResult Abrigos()
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Abrigos para nenas";
            var list = new ClouthManager()
                .FindAll()
                .Where(x => x.Category == Clouth.CATEGORY.NENA)
                .Where(x => x.SubCategory == Clouth.SUBCATEGORY.ABRIGOS)
                .OrderBy(x => x.ShortDescription)
                .ToList();

            return View("todos", list);
        }
    }
}