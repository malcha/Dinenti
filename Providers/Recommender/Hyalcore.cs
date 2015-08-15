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


namespace MvcApplication2.Providers.Recommender
{
    public interface IRecommendationClient
    {
        //FoxAccessUser GetUserInfo(string username);
        //IDictionary<string, bool> GetUserPermissions(string username);
    }

    //public class ClassTest
    //{
    //     public IEnumerable<int> data   { get; set; }
    //}


    public class Hyalcore : IRecommendationClient
    {
        private string _url;
        private string _app;
        private string _username;
        private string _password;
        private TimeSpan _timeout;

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


        public void AddUser()
        {
            
            var aux = Call<Recommendation>("recommend/most-viewed-by-category");
        }


        public void AddItem()
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
                JsonConvert.SerializeObject(object);
                //string json = new JavaScriptSerializer().Serialize(new
                //{
                //    user = "Foo",
                //    password = "Baz"
                //});

                //streamWriter.Write(json);
            }
        }


        private TResult Call<TResult>(string action)
        {
            var url = this._url + "/" + action;

            System.Net.HttpWebRequest wr = (System.Net.HttpWebRequest) System.Net.WebRequest.Create(url);
            wr.Method = "GET";
            wr.Accept = "application/json";
            //wr.ContentType = "application/x-www-form-urlencoded";
            wr.Timeout = (int) this._timeout.TotalMilliseconds;
            //wr.Headers["USERNAME_REST"] = this._username;
            //wr.Headers["PASSWORD_REST"] = this._password;
            //using (var writer = new StreamWriter(wr.GetRequest()))
            //using (WebResponse response = wr.GetResponse())
            //{
                
            //    var test2 = response.ResponseUri;
            //    //response.Write(string.Format("{0}={1}", Uri.EscapeDataString("app"), Uri.EscapeDataString(this._app)));
            //    //if (username != null)
            //    //    writer.Write(string.Format("&{0}={1}", Uri.EscapeDataString("username"),
            //    //        Uri.EscapeDataString(username)));
            //}

            try
            {
                var json = wr.ReadAllResponseString();
                var test = JsonConvert.DeserializeObject<TResult>(json);
                return JsonConvert.DeserializeObject<TResult>(json);
            }
            catch (System.Net.WebException wex)
            {
                throw new FormatException("WebException. {0}", wex.Message);
            }
            catch (JsonSerializationException ex)
            {
                throw new FormatException("Invalid JSON. {0}", ex.Message);
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