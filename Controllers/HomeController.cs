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

        public ActionResult Index()
        {
            Cookies.WriteCookie();
            var cookie = System.Web.HttpContext.Current.Request.Cookies["DinentiComHyalCore"];
            String userId = "NoUSER";
            if (!String.IsNullOrEmpty(cookie.Value))
                userId = cookie.Value;
            else
                userId = cookie.Value;

            //var hyRecommendation= new Hyalcore("http://162.243.105.143:9293").GetRecommendation("/recommendation?api_key=bd54a9bce84f7b6db6d1fa3b3a76e241&user_id=NOUser&section_code=home");
            IEnumerable<string> recommendation;
            string recommendationId = String.Empty;
            //7561,7546,7525,7502
            recommendation = new List<string>() { "recomendacion4", "recomendacion2", "recomendacion1", "recomendacion5" };

            var list = new List<Models.Clouth>();
            list.Add(new Clouth(7801, "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "recomendacion4"));
            list.Add(new Clouth(7801, "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "recomendacion2"));
            list.Add(new Clouth(7801, "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "recomendacion1"));
            list.Add(new Clouth(7801, "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "recomendacion5"));


            var list2 = list.Select(x => new MvcApplication2.Models.HyalcoreClouth { Clouth = x, RecommendationId = recommendationId }).ToList();
            ViewBag.Message = ResourceHome.WelcomeTitle;
            return View(list2);
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
