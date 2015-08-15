﻿using System;
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

        public ActionResult Index()
        {
            Cookies.WriteCookie();
            var list = new ClouthManager().FindAll().Where(x=> x.Id ==6834 ||x.Id ==6881 || x.Id ==6820 ||x.Id ==6861 ||x.Id ==6899).ToList();
            ViewBag.Message = ResourceHome.WelcomeTitle;
            return View(list);
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