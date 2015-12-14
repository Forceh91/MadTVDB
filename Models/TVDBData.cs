using MadTVDBPortable.Models;
using System;
using System.IO;
using System.Linq;
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
            string tvdbResponse = string.Empty;

            TVDBSearchResponse tvdbSearchResponse = new TVDBSearchResponse();
            try
            {
                tvdbResponse = await GetHTTPString(new Uri(apiCallURL));
            }
            catch(HttpRequestException)
            {
                tvdbSearchResponse.serverUnavailable = true;
                return tvdbSearchResponse;
            }

            // return an empty list if there was an empty response
            if (string.IsNullOrEmpty(tvdbResponse))
                return null;

            // read the response in through a memory stream and use the xml serializer
            using (MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(tvdbResponse)))
            {
                var serializer = new XmlSerializer(typeof(TVDBSearchResponse));
                tvdbSearchResponse = (serializer.Deserialize(memoryStream) as TVDBSearchResponse);
            }

            // we should have some info now so return it
            return tvdbSearchResponse;
        }

        public async Task<TVDBSeriesResponse> SeriesInformation(uint tvdbID)
        {
            string apiCallURL = string.Format("{0}/api/{1}/series/{2}/all?language=en", _baseURL, _apiKey, tvdbID);
            string tvdbResponse = string.Empty;

            TVDBSeriesResponse tvdbSeriesResponse = new TVDBSeriesResponse();
            try
            {
                tvdbResponse = await GetHTTPString(new Uri(apiCallURL));
            }
            catch (HttpRequestException)
            {
                tvdbSeriesResponse.serverUnavailable = true;
                return tvdbSeriesResponse;
            }

            // return an empty response if the the tvdb was dead
            if (string.IsNullOrEmpty(tvdbResponse))
                return null;

            // read the response in through a memory stream and use the xml serializer
            using (MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(tvdbResponse)))
            {
                var serializer = new XmlSerializer(typeof(TVDBSeriesResponse));
                tvdbSeriesResponse = (serializer.Deserialize(memoryStream) as TVDBSeriesResponse);
            }

            // we should have some info now so return it
            return tvdbSeriesResponse;
        }

        public async Task<TVDBBannerResponse> SeriesBannerInformation(uint tvdbID, BannerType bannerType)
        {
            string apiCallURL = string.Format("{0}/api/{1}/series/{2}/banners.xml", _baseURL, _apiKey, tvdbID);
            string tvdbResponse = string.Empty;

            TVDBBannerResponse tvdbBannerResponse = new TVDBBannerResponse();
            try
            {
                tvdbResponse = await GetHTTPString(new Uri(apiCallURL));
            }
            catch (HttpRequestException)
            {
                tvdbBannerResponse.serverUnavailable = true;
                return tvdbBannerResponse;
            }

            // return an empty response if the the tvdb was dead
            if (string.IsNullOrEmpty(tvdbResponse))
                return null;

            // read the response in through a memory stream and use the xml serializer
            using (MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(tvdbResponse)))
            {
                var serializer = new XmlSerializer(typeof(TVDBBannerResponse));
                tvdbBannerResponse = (serializer.Deserialize(memoryStream) as TVDBBannerResponse);
            }

            // we want all of them so just return this
            if (bannerType == BannerType.All)
                return tvdbBannerResponse;

            // otherwise we need to make a new list
            tvdbBannerResponse.banners = tvdbBannerResponse.banners.Where(banner => banner.bannerType == bannerType).ToList();

            // and return said list
            return tvdbBannerResponse;
        }

        public async Task<TVDBActorResponse> SeriesActorInformation(uint tvdbID)
        {
            string apiCallURL = string.Format("{0}/api/{1}/series/{2}/actors.xml", _baseURL, _apiKey, tvdbID);
            string tvdbResponse = string.Empty;

            TVDBActorResponse tvdbActorResponse = new TVDBActorResponse();
            try
            {
                tvdbResponse = await GetHTTPString(new Uri(apiCallURL));
            }
            catch (HttpRequestException)
            {
                tvdbActorResponse.serverUnavailable = true;
                return tvdbActorResponse;
            }

            // return an empty response if the the tvdb was dead
            if (string.IsNullOrEmpty(tvdbResponse))
                return null;

            // read the response in through a memory stream and use the xml serializer
            using (MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(tvdbResponse)))
            {
                var serializer = new XmlSerializer(typeof(TVDBActorResponse));
                tvdbActorResponse = (serializer.Deserialize(memoryStream) as TVDBActorResponse);
            }

            // we should have some info now so return it
            return tvdbActorResponse;
        }

        public async Task<TVDBEpisodeResponse> EpisodeInformation(uint tvdbEpisodeID)
        {
            string apiCallURL = string.Format("{0}/api/{1}/episodes/{2}", _baseURL, _apiKey, tvdbEpisodeID);
            string tvdbResponse = string.Empty;

            TVDBEpisodeResponse tvdbEpisodeResponse = new TVDBEpisodeResponse();
            try
            {
                tvdbResponse = await GetHTTPString(new Uri(apiCallURL));
            }
            catch (HttpRequestException)
            {
                tvdbEpisodeResponse.serverUnavailable = true;
                return tvdbEpisodeResponse;
            }

            // return an empty response if the the tvdb was dead
            if (string.IsNullOrEmpty(tvdbResponse))
                return null;

            // read the response in through a memory stream and use the xml serializer
            using (MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(tvdbResponse)))
            {
                var serializer = new XmlSerializer(typeof(TVDBEpisodeResponse));
                tvdbEpisodeResponse = (serializer.Deserialize(memoryStream) as TVDBEpisodeResponse);
            }

            // we should have some info now so return it
            return tvdbEpisodeResponse;
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
