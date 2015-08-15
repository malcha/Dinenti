using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication2.Models;
using MvcApplication2.DataLoad;

namespace MvcApplication2.Manager
{
    public class UserManager
    {

        public String GetUserId()
        {

            if (!System.Web.HttpContext.Current.Request.Cookies.AllKeys.Contains("DinentiComHyalCore"))
            {
                Random r = new Random();
                int n = r.Next(1, 100000);
                HttpCookie myCookie = new HttpCookie("DinentiComHyalCore");
                DateTime now = DateTime.Now;

                // Set the cookie value.
                myCookie.Value = n.ToString();
                // Set the cookie expiration date.
                myCookie.Expires = now.AddYears(1);

                // Add the cookie.
                System.Web.HttpContext.Current.Response.Cookies.Add(myCookie);
                return myCookie.Value;
            }
            else
            {
                return System.Web.HttpContext.Current.Request.Cookies["DinentiComHyalCore"].Value;
            }
        }


    }
}