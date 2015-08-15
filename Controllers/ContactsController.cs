//using System.Web.Mvc;
//using Model;
//using MvcApplication2.ViewModel;


//namespace MvcApplication2.Controllers
//{
//    public class ContactsController : Controller
//    {

//        ContactRepository contactRepository = new ContactRepository();
//        ClouthRepository clouthRepository = new ClouthRepository();
//        public ActionResult Index()
//        {
//            var c2 = new Contact();
//            //var c2 = new ClientViewModel();
//            return View(c2);
//        }

//        [HttpPost]
//        public ActionResult SendContacts(Contact ca)
//        //public ActionResult SendContacts(FormCollection collection)   
//        {
//            var c = new Contact();
            
//            if (ModelState.IsValid)
//            {

//                UpdateModel(c);
//                clouthRepository.GetClouthById(1);
//                contactRepository.GetContactsById(1);
//                //contactRepository.Create(c);
//                return RedirectToAction("Index");
//            }
                

//            return RedirectToAction("Index");
//        }

//        //[HttpPost]
//        //public ActionResult Index(ClientViewModel ca)
//        ////public ActionResult SendContacts(FormCollection collection)   
//        //{
//        //    var c = new ClientViewModel();

//        //    if (ModelState.IsValid)
//        //        return RedirectToAction("Index");
//        //    //return View("Index", ca);
//        //    //return View("Index", ca);
//        //    return RedirectToAction("Index");
//        //}

//        //[HttpPost]
//        //public ActionResult SendContacts(ClientViewModel ca)
//        //{
//        //    throw new System.NotImplementedException();
//        //}
//    }
//}