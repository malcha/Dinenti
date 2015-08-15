using MvcApplication2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class BabiesController : Controller
    {
        //
        // GET: /Babies/

        public ActionResult Index()
        {
            Cookies.WriteCookie();
            return View();
        }

        public ActionResult Remeras()
        {
            Cookies.WriteCookie();
            return View();
        }

    }
}
