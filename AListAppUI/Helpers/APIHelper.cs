using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AListAppUI.Helpers
{
    public class APIHelper
    {
        public HttpClient ApiClient { get; set; }

        private void  InitializeClient()
        {

            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("aplication.json"));
        }

        public async Task Authenticate(string username, string password)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair <string, string>("grant_type", "password"),
                new KeyValuePair <string, string>("username", username),
                new KeyValuePair <string, string>("password", password),

            });

            using (HttpResponseMessage response  =  await ApiClient.PostAsync("/Token", data))
            {

            }
        }
    }
}
