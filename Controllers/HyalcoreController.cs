using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Resource;
using MvcApplication2.Manager;
using System.Net.Mail;
using log4net;
using MvcApplication2.Filters;

namespace MvcApplication2.Controllers
{
    [DinentiAuthorizeAttribute]
    public class HyalcoreController : Controller
    {
        private static readonly ILog loguer = LogManager.GetLogger(typeof(HyalcoreController));

        //[HttpPost]
        public void Interaction(string id, bool recommendation)
        {
            var cookie = System.Web.HttpContext.Current.Request.Cookies["DinentiComHyalCore"];

            String userId ="NoUSER";
            if (!String.IsNullOrEmpty(cookie.Value))
                userId = cookie.Value;
            
            //"USERID ID ISRECOMMENDATION"
            loguer.Debug(String.Format("{0} | {1} | {2}", userId, id, recommendation.ToString().ToLower()));
        }


    }
}