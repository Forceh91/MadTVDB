using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MadTVDB.Models
{
    public class TVDBData
    {
        private string _apiKey;
        private string _baseURL;

        public TVDBData(string apiKey, string baseURL = "http://thetvdb.com")
        {
            _apiKey = apiKey;
            _baseURL = baseURL;
        }

        public async Task<TVDBSearchResponse> Search(string query)
        {
            string apiCallURL = string.Format("{0}/api/GetSeries.php?seriesname={1}", _baseURL, query);
            string tvdbResponse = await GetHTTPString(new Uri(apiCallURL));

            // return an empty list if there was an empty response
            if (string.IsNullOrEmpty(tvdbResponse))
                return null;

            TVDBSearchResponse tvdbSearchResponse = new TVDBSearchResponse();
            tvdbResponse = tvdbResponse.ToString();
            using (MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(tvdbResponse)))
            {
                var serializer = new XmlSerializer(typeof(TVDBSearchResponse));
                tvdbSearchResponse = (serializer.Deserialize(memoryStream) as TVDBSearchResponse);
            }

            // otherwise we need to parse the response into a show object
            return tvdbSearchResponse;
        }

        private async Task<string> GetHTTPString(Uri requestUri)
        {
            HttpClient httpclient = new HttpClient();
            HttpResponseMessage responseMessage = await httpclient.GetAsync(requestUri);

            if (responseMessage.IsSuccessStatusCode)
                return await responseMessage.Content.ReadAsStringAsync();
            else
                return string.Empty;
        }
    }
}
