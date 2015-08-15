using MvcApplication2.Providers.Recommender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Helpers
{
    public class Cookies
    {
        public static void WriteCookie()
        {

            var a = new Hyalcore("http://192.168.0.102:4567");
            var test = a.GetMostViewByCategory();

            Random r = new Random();
            int n = r.Next(1, 100000);
            if (!System.Web.HttpContext.Current.Request.Cookies.AllKeys.Contains("DinentiComHyalCore"))
            {
                HttpCookie myCookie = new HttpCookie("DinentiComHyalCore");
                DateTime now = DateTime.Now;

                // Set the cookie value.
                myCookie.Value = n.ToString();
                // Set the cookie expiration date.
                myCookie.Expires = now.AddYears(1);

                // Add the cookie.
                System.Web.HttpContext.Current.Response.Cookies.Add(myCookie);
            }
        }
    }
}