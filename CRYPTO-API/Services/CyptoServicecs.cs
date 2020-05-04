using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace CRYPTO_API.Services
{
    public class CyptoServicecs
    {

        public object getTopCurrencies()
        {
            var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/quotes/latest");

            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["id"] = "1";



            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", "213dc5e9-0623-4527-81c9-4f46b93546c0");
            client.Headers.Add("Accepts", "application/json");
           
            string data=client.DownloadString(URL.ToString());

            //var json = JObject.Parse(data);

            return data;

        }
    }
}
