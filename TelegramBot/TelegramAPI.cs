using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using RestSharp;

namespace TelegramBot
{
    class TelegramAPI
    {
        private const String API_KEY = "769427152:AAFURhx7Ar9bqmrpVENcEgQ27-vhmOV4ebQ";
        private const String API_URL = "https://api.telegram.org/bot" + API_KEY + "/";

        private RestClient rc = new RestClient();

        public TelegramAPI()
        {
            rc.Proxy = new WebProxy("162.243.108.141", 8080);
        }

        public void SendApiRequest(String apiMethod)
        {
            //var url = API_URL + apiMethod;
            //var request = new RestRequest(url);
            var request = new RestRequest("https://yandex.ru/");
            //var request = new RestRequest("");
            Console.WriteLine("requesting");
            var responce = rc.Get(request);
            Console.WriteLine("requested");
            Console.WriteLine(responce.Content);
        }
    }
}
