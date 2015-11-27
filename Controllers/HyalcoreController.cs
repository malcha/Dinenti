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
using MvcApplication2.Providers.Recommender;
using Newtonsoft;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
namespace MvcApplication2.Controllers
{
    [DinentiAuthorizeAttribute]
    public class HyalcoreController : Controller
    {
        private static readonly ILog loguer = LogManager.GetLogger(typeof(HyalcoreController));

        private Hyalcore hyalcore;
        private string apikey;
        
        public HyalcoreController()
        {
            hyalcore = new Hyalcore("http://162.243.105.143:9293");
            apikey = "bd54a9bce84f7b6db6d1fa3b3a76e241";
        }
        //[HttpPost]
        public void Interaction(string id, bool recommendation)
        {
            var cookie = System.Web.HttpContext.Current.Request.Cookies["DinentiComHyalCore"];
            String userId ="NoUSER";
            if (!String.IsNullOrEmpty(cookie.Value))
                userId = cookie.Value;
            
            //"USERID ID ISRECOMMENDATION"
            loguer.Info(String.Format("{0} | {1} | {2}", userId, id, recommendation.ToString().ToLower()));
            hyalcore.ViewInteraction(userId, id);


        }



        private string validKey = "1234";

        public void ReportItems(string key)
        { 
            if (String.Compare(key,validKey)!=0)
            {
                return;
            }

            var list= new ClouthManager().FindAll();
            int i=0;
            int errors = 0;
            foreach (var item in list)
            {
                var formData = String.Format("id={0}&api_key={1}&active=true&model_attributes[][name]=category&model_attributes[][type_name]=array&model_attributes[][value]=[{2},{3}]&model_attributes[][name]=Description&model_attributes[][type_name]=string&model_attributes[][value]={4}", item.Id.ToString(), apikey, item.getCategory(), item.getSubCategory(), item.Description);
                //var aaa2 = new { 
                //    id=item.Id,
                //    api_key = apikey,
                //    model_attributes = array
                //};
                //var aux2 = new JavaScriptSerializer().Serialize(aaa2);
                try
                {
                    hyalcore.Post("items", formData);
                    i++;
                }
                catch (Exception e)
                {
                    errors++;
                    var ex = e;
                    //throw;
                }
                
            }
        }
    }

    public class ModelAttribute {
        public string name { get; set; }
        public string type_name { get; set; }
        public string value { get; set; }
    }
}