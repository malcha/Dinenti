using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using MvcApplication2.Models;
using System.Net.Mail;
using System.Text;

namespace MvcApplication2.Controllers
{
    
    public class MailerController
    {

        //[HttpPost]
        //public ActionResult SendContactUs(DTO.Email email)
        //{
        //    //MailMessage mail = new MailMessage(email.EmailFrom, "malcha@gmail.com");
        //    //SmtpClient client = new SmtpClient();
        //    //client.Port = 25;
        //    //client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //    //client.UseDefaultCredentials = false;
        //    //client.Host = "smtp.google.com";
        //    //mail.Subject = email.Subject;
        //    //mail.Body = email.Message;
        //    //client.Send(mail);



        //    SmtpClient client = new SmtpClient();
        //    client.Host = "smtp.googlemail.com";
        //    client.Port = 587;
        //    client.UseDefaultCredentials = false;
        //    client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //    client.EnableSsl = true;
        //    client.Credentials = new System.Net.NetworkCredential("malcha@gmail.com", "barbar");
        //    MailMessage mm = new MailMessage(email.EmailFrom, "malcha@gmail.com", email.Subject, email.Message);
        //    mm.BodyEncoding = UTF8Encoding.UTF8;
        //    mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

        //    client.Send(mm);
        //    //return RedirectToAction("Details", new { id = 1 });
        //    return View();

        //}

    }
}


