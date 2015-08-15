using MvcApplication2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcApplication2.Controllers
{
    public class ClouthController : Controller
    {
        //private DinentiEntities ctx;
        //private ClouthRepository couthRepository = new ClouthRepository();
        //
        // GET: /Clouth/

        public ActionResult Index()
        {
            Cookies.WriteCookie();
            return View();
        }

        public ActionResult Babies()
        {
            Cookies.WriteCookie();
            
            //using (ctx= new DinentiEntities())
            //{
                //var babyClouth = ctx.Clouth.Where(i => i.Season.Year == 2013);
                //return View(babyClouth.ToList());    
            //}
            //var babyClouth2 = new _BaseManager().FindAllCLoth();
            //var babyClouth = couthRepository.GetClouthsCouths();
            return View();    

            
        }

        //[HttpPost]
        //public ActionResult SendContacts(Clouth ca)
        ////public ActionResult SendContacts(FormCollection collection)   
        //{

        //    var c = new Clouth();

        //    if (ModelState.IsValid)
        //    {

        //        UpdateModel(c);
        //        couthRepository.GetClouthById(1);
        //        //contactRepository.Create(c);
        //        return RedirectToAction("Index");
        //    }


        //    return RedirectToAction("Index");
        //}
    }
}
