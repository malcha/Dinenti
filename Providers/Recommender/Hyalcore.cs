using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using MvcApplication2.Helpers.Mvc;
using MvcApplication2.Providers.DTO;
using MvcApplication2.Providers.Recommender;
using Newtonsoft.Json;
using log4net;
using MvcApplication2.Controllers;
using System.Text;
using System.Net;

namespace MvcApplication2.Providers.Recommender
{
    public interface IRecommendationClient
    {
        //FoxAccessUser GetUserInfo(string username);
        //IDictionary<string, bool> GetUserPermissions(string username);
    }



    public class Hyalcore : IRecommendationClient
    {
        private string _url;
        private string _app;
        private string _username;
        private string _password;
        private TimeSpan _timeout;
        static readonly ILog loguer = LogManager.GetLogger(typeof(HyalcoreController));
        public Hyalcore(string url, string username="", string password="", TimeSpan? timeout= null)
        {
            if (timeout == null)
                timeout = new TimeSpan(0,0,0,30);

            this._url = url.TrimEnd('/');
            this._username = username;
            this._password = password;
            this._timeout = timeout.Value;
        }

        public Recommendation GetMostViewByCategory()
        {
            var aux = Call<Recommendation>("recommend/most-viewed-by-category");
            
            return aux;
        }

        public Recommendation GetRecommendation(string actionParameters)
        {

            return Call<Recommendation>(actionParameters);
        }

        public void AddUser()
        {
            
            var aux = Call<Recommendation>("recommend/most-viewed-by-category");
        }

        public void ViewInteraction(String userId, String itemId)
        {
            var interactionName = "view";
            Post(String.Format("/interactions?user_id={0}&interaction_name={1}&item_id={2}", userId, interactionName, itemId));
        }

        public void AddItemsToHyalcore()
        {
            var aux = Call<Recommendation>("/additem");
        }

        //public IDictionary<string, bool> GetUserPermissions(string username)
        //{
        //    return Call<Dictionary<string, bool>>("user/allpermissionstatus", username: username);
        //}


        private void Post<TResult> (string action)
        {
            var request = (HttpWebRequest)WebRequest.Create("http://url");
            request.ContentType = "text/json";
            request.Method = "POST";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(streamWriter);
                //string json = new JavaScriptSerializer().Serialize(new
                //{
                //    user = "Foo",
                //    password = "Baz"
                //});

                streamWriter.Write(json);
            }
        }

        public void Post(string action, string json) {
            var url = this._url + "/" + action;
            var request = (HttpWebRequest)WebRequest.Create(url);

            var data = Encoding.ASCII.GetBytes(json);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

        }

        public void Post(string action)
        {
            var url = this._url + "/" + action;

            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch (Exception ex)
            {
                loguer.Error(String.Format("Invalid JSON. {0}", ex.Message));
                throw new FormatException("Invalid JSON. {0}", ex.Message);
            }

        }


        private TResult Call<TResult>(string action)
        {
            var url = this._url + "/" + action;

            System.Net.HttpWebRequest wr = (System.Net.HttpWebRequest) System.Net.WebRequest.Create(url);
            wr.Method = "GET";
            wr.Accept = "application/json";
            wr.Timeout = (int) this._timeout.TotalMilliseconds;
            try
            {
                var json = wr.ReadAllResponseString();
                var test = JsonConvert.DeserializeObject<TResult>(json);
                return JsonConvert.DeserializeObject<TResult>(json);
            }
            catch (System.Net.WebException wex)
            {

                loguer.Error(String.Format("WebException. {0}", wex.Message));
                throw new FormatException("WebException. {0}", wex.Message);
            }
            catch (JsonSerializationException ex)
            {
                loguer.Error(String.Format("WebException. {0}", ex.Message));
                throw new FormatException("WebException. {0}", ex.Message);
            }
        }

        public class FormatException : Exception
        {
            public FormatException(string message, params object[] args)
                : base(string.Format(message, args))
            {
            }
        }
    }

    //public class Hyalcore
    //{
    //}
}