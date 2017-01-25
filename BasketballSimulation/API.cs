using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BasketballSimulation
{
    /*
     * This class will be used to connect to and query the ProBasketballAPI
     */
    class API
    {
        private string key = "QzwlRb9SneBNuGZortAgmvMIf7pix2ka";
        public API(string api_key)
        {
            this.key = api_key;
        }

        
        public static async Task<int> getPlayerID(string firstName, string lastName)
        {
            string url = "http://api.probasketballapi.com/player";
            using (HttpClient client = new HttpClient())
            {
                Dictionary<string, string> values = new Dictionary<string, string>
                {
                    {"api_key", "QzwlRb9SneBNuGZortAgmvMIf7pix2ka" }, // would be better in future to avoid hardcoding this
                    {"last_name", lastName }
                };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(url, content);
                string responseString = await response.Content.ReadAsStringAsync();
                dynamic deserialized = JsonConvert.DeserializeObject(responseString);
                return deserialized[0].id;  // may run into issues where two different players are returned if both players have the same name

            }
            
        }


        public static async Task<int> getTeamID(string teamName)
        {
            string url = "http://api.probasketballapi.com/team";
            using (HttpClient client = new HttpClient())
            {
                Dictionary<string, string> values = new Dictionary<string, string>
                {
                    {"api_key", "QzwlRb9SneBNuGZortAgmvMIf7pix2ka" }, // would be better in future to avoid hardcoding this
                    {"team_name", teamName}
                };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(url, content);
                string responseString = await response.Content.ReadAsStringAsync();
                dynamic parsed = JsonConvert.DeserializeObject(responseString);
                return parsed[0].id;

            }

        }


    }
}
