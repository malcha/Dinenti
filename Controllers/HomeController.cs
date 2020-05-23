using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Providers.Recommender;
using MvcApplication2.Resource;
using MvcApplication2.Manager;
using System.Net.Mail;
using MvcApplication2.Filters;
using MvcApplication2.Helpers;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    [DinentiAuthorizeAttribute]
    public class HomeController : Controller
    {

        //public void WriteCookie()
        //{

        //    var a = new Hyalcore("http://192.168.0.102:4567");
        //    var test= a.GetMostViewByCategory();

        //    Random r = new Random();
        //    int n = r.Next(1, 100000);
        //    if (!System.Web.HttpContext.Current.Request.Cookies.AllKeys.Contains("DinentiComHyalCore"))
        //    {
        //        HttpCookie myCookie = new HttpCookie("DinentiComHyalCore");
        //        DateTime now = DateTime.Now;

        //        // Set the cookie value.
        //        myCookie.Value = n.ToString();
        //        // Set the cookie expiration date.
        //        myCookie.Expires = now.AddYears(1);

        //        // Add the cookie.
        //        System.Web.HttpContext.Current.Response.Cookies.Add(myCookie);
        //    }
        //}

        public ActionResult Varones(Guid? type)
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Varones";
            var list = new ClouthManager()
                            .FindAll(type)
                            .Where(x => x.Category == Clouth.CATEGORY.VARON)
                            .OrderBy(x => x.Id)
                            .ToList();

            return type == TypeLocalConPrecio
                ? View("VentaLocal", list)
                : View("todos", list);
        }

        public ActionResult Nenas(Guid? type)
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Nenas";
            var list = new ClouthManager()
                .FindAll(type)
                .Where(x => x.Category == Clouth.CATEGORY.NENA)
                .OrderBy(x => x.Id)
                .ToList();

            return type == TypeLocalConPrecio
                ? View("VentaLocal", list)
                : View("todos", list);
        }

        public ActionResult Bebas(Guid? type)
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Bebas";
            var list = new ClouthManager()
                            .FindAll(type)
                            .Where(x => x.Category == Clouth.CATEGORY.BEBAS)
                            .OrderBy(x => x.Id)
                            .ToList();

            return type == TypeLocalConPrecio
                ? View("VentaLocal", list)
                : View("todos", list);
        }

        public ActionResult Bebes(Guid? type)
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Bebes";
            var list = new ClouthManager()
                            .FindAll(type)
                            .Where(x => x.Category == Clouth.CATEGORY.BEBES)
                            .OrderBy(x => x.Id)
                            .ToList();

            return type == TypeLocalConPrecio
                ? View("VentaLocal", list)
                : View("todos", list);

        }

        //[Route("Home/Contact")]
        public ActionResult MiniBebes(Guid? type)
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Mini bebes";
            
            var list = new ClouthManager()
                            .FindAll(type)
                            .Where(x => x.Category == Clouth.CATEGORY.MINIBEBES)
                            .OrderBy(x => x.Id)
                            .ToList();

            return type==TypeLocalConPrecio
                ? View("VentaLocal", list)
                : View("todos", list);
            
        }
        public Guid TypeLocalConPrecio => new Guid("15c2bc84-b67e-406b-9e0a-0b8330ebbfec");
        public ActionResult VentaEnLocal(Guid? type)
        {
            if (type == null)
            {
                var nameValues = HttpUtility.ParseQueryString(Request.QueryString.ToString());
                nameValues.Set("type", TypeLocalConPrecio.ToString());
                string url = Request.Url.AbsolutePath;

                Response.Redirect(url + "?" + nameValues);
            }
            Cookies.WriteCookie();
            ViewBag.TitleName = "Venta en el Local";
            var list = new ClouthManager()
                            .FindAll(type)
                            .OrderBy(x => x.Category)
                            .ToList();

            return View("VentaLocal", list);
            
        }

        //public ActionResult VentaEnLocalVaron()
        //{
        //    Cookies.WriteCookie();
        //    ViewBag.TitleName = "Venta en el Local - Varon";
        //    var list = new ClouthManager()
        //                    .FindAll(TypeLocalConPrecio)
        //                    .Where(x => x.Category == Clouth.CATEGORY.VARON)
        //                    .OrderByDescending(x => x.Id)
        //                    .ToList();

        //    return View("VentaLocal", list);
        //}

        //public ActionResult VentaEnLocalNenas()
        //{
        //    Cookies.WriteCookie();
        //    ViewBag.TitleName = "Venta en el Local - Nenas";
        //    var list = new ClouthManager()
        //                    .FindAll(TypeLocalConPrecio)
        //                    .Where(x => x.Category == Clouth.CATEGORY.NENA)
        //                    .OrderByDescending(x => x.Id)
        //                    .ToList();

        //    return View("VentaLocal", list);
        //}
        //public ActionResult VentaEnLocalBebes()
        //{
        //    Cookies.WriteCookie();
        //    ViewBag.TitleName = "Venta en el Local - Nenas";
        //    var list = new ClouthManager()
        //                    .FindAll(TypeLocalConPrecio)
        //                    .Where(x => x.Category == Clouth.CATEGORY.NENA)
        //                    .OrderByDescending(x => x.Id)
        //                    .ToList();

        //    return View("VentaLocal", list);
        //}


        public ActionResult all(Guid? type)
        {
            //var listToExclude = new List<int>() { 8020, 8022 };
            Cookies.WriteCookie();
            ViewBag.TitleName = "Todos";
            var list = new ClouthManager()
                            .FindAll(type)
                            .OrderBy(x => x.Id)
                            .ToList();

            return type == TypeLocalConPrecio
                ? View("VentaLocal", list)
                : View("todos", list);

        }

        public ActionResult Index(Guid? type)
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Todos";
            var list = new ClouthManager()
                            .FindAll(type)
                            .OrderBy(x => x.Id)
                            .ToList();
            return type == TypeLocalConPrecio
                ? View("VentaLocal", list)
                : View("todos", list);
        }

        public ActionResult Talles(Guid? type)
        {

            return View("talles");
        }

        public ActionResult IndexLocal(Guid? type)
        {
            Cookies.WriteCookie();
            ViewBag.TitleName = "Todos";
            var list = new ClouthManager()
                            .FindAll(type)
                            .OrderBy(x => x.Id)
                            .ToList();

            return View("local-pormayorymenor", list);
        }

        public ActionResult Babies()
        {
            Cookies.WriteCookie();
            return View();
        }

        public ActionResult Nena()
        {
            Cookies.WriteCookie();
            return View();
        }

        [HttpPost]
        public ActionResult SendContactUs(DTO.Email email)
        {
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.googlemail.com";
            client.Port = 587;
            client.UseDefaultCredentials = false;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("webdinenti@gmail.com", "cani1234");
            var mensajes = String.Format("Mail de La pagina de Dinenti FROM: {0} {1} MENSAJE: {2}", email.EmailFrom, Environment.NewLine, email.Message);

            MailMessage mm = new MailMessage(email.EmailFrom, "dinenti@gmail.com", email.Subject, mensajes);
            mm.BodyEncoding = System.Text.UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mm);
            //return RedirectToAction("Details", new { id = 1 });
            return RedirectToAction("index");

        }
    }
}
