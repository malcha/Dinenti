using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Filters
{
    public class DinentiAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
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
                return true;
            }
            else
            {
                return true;
            }
        }

    }
}

