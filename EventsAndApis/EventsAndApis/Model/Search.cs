using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EventsAndApis.Model
{
    public class Search
    {
        public Meta meta { get; set; }
        public Response response { get; set; }

        public static async Task<Response> SearchRequest(double lat, double lng, int radius, string query, int limit = 3)
        {
            string url = $"https://api.foursquare.com/v2/venues/search?ll={lat},{lng}&radius={radius}&query={query}&limit={limit}&client_id={Helpers.Constants.FOURSQR_CLIENT_ID}&client_secret={Helpers.Constants.FOURSQR_CLIENT_SECRET}&v={DateTime.Now.ToString("yyyyMMdd")}";

            // added using System.Net.Http;
            using (HttpClient client = new HttpClient())
            {
                // made the method async
                string json = await client.GetStringAsync(url);

                // added using Newtonsoft.Json;
                return JsonConvert.DeserializeObject<Search>(json).response;
            }
        }
    }
}
