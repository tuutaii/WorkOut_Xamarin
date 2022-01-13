using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WorkOutApp.Models;

namespace WorkOutApp.Services
{
    public class Service
    {
        public async Task<string> LogInUser(string email, string password)
        {
            var acess_token = string.Empty;
           
            await Task.Run(() =>
            {
                try
                {
                    var keyValues = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("userName", email ),
                new KeyValuePair<string, string>("passWord", password ),
                new KeyValuePair<string, string>("grant_type", "password")

            };
                    var request = new HttpRequestMessage(
                        HttpMethod.Post, "http://192.168.1.10/WebAPI_Auth/token");

                    request.Content = new FormUrlEncodedContent(keyValues);

                    var client = new HttpClient();
                    var response = client.SendAsync(request).Result;
                    using (HttpContent content = response.Content)
                    {
                        var json = content.ReadAsStringAsync();
                        JObject jwDynamic = JsonConvert.DeserializeObject<dynamic>(json.Result);
                        var accesstokenExpiration = jwDynamic.Value<DateTime>(".expires");
                        acess_token = jwDynamic.Value<string>("access_token");

                        var Email = jwDynamic.Value<string>("email");
                        var Password = jwDynamic.Value<string>("password");
                        var AccessTokenExpirationDate = accesstokenExpiration;
                        
                    }
                }
                catch (Exception ex)
                {
                }
            });
            return acess_token;
        }
    }
}
