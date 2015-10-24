using System;
using System.Xml.Serialization;

namespace MadTVDB.Models
{
    [XmlRoot(ElementName = "Series")]
    public class Show
    {
        public TimeSpan airTimeSpan
        {
            get
            {
                DateTime dateTime;
                if (DateTime.TryParse(airTime, out dateTime) == false)
                    return new TimeSpan();
                else
                    return dateTime.TimeOfDay;
            }
        }

        [XmlElement(ElementName = "id")]
        public int id { get; set; }

        [XmlElement(ElementName = "Actors")]
        public string actors { get; set; }

        [XmlElement(ElementName = "Airs_DayOfWeek")]
        public string airDay { get; set; }

        [XmlElement(ElementName = "Airs_Time")]
        public string airTime { get; set; }

        [XmlElement(ElementName = "AliasNames")]
        public string aliasNames { get; set; }

        [XmlElement(ElementName = "ContentRating")]
        public string contentRating { get; set; }

        [XmlElement(ElementName = "FirstAired")]
        public string _firstAired { get; set; }
        public DateTime firstAired { get { return (string.IsNullOrEmpty(_firstAired) ? DateTime.MinValue : Convert.ToDateTime(_firstAired)); } }

        [XmlElement(ElementName = "Genre")]
        public string genres { get; set; }

        [XmlElement(ElementName = "IMDB_ID")]
        public string imdb { get; set; }

        [XmlElement(ElementName = "Language")]
        public string language { get; set; }

        [XmlElement(ElementName = "Network")]
        public string network { get; set; }

        [XmlElement(ElementName = "Overview")]
        public string description { get; set; }

        [XmlElement(ElementName = "Rating")]
        public string _rating { get; set; }
        public double rating { get { return (string.IsNullOrEmpty(_rating) ? 0 : Convert.ToDouble(_rating)); } }

        [XmlElement(ElementName = "RatingCount")]
        public string _ratingCount { get; set; }
        public uint ratingCount { get { return (string.IsNullOrEmpty(_ratingCount) ? 0 : Convert.ToUInt32(_ratingCount)); } }

        [XmlElement(ElementName = "Runtime")]
        public string _episodeRuntime { get; set; }
        public uint episodeRuntime { get { return (string.IsNullOrEmpty(_episodeRuntime) ? 0 : Convert.ToUInt32(_episodeRuntime)); } }

        [XmlElement(ElementName = "SeriesID")]
        public string _seriesID { get; set; }
        public uint seriesID { get { return (string.IsNullOrEmpty(_seriesID) ? 0 : Convert.ToUInt32(_seriesID)); } }

        [XmlElement(ElementName = "SeriesName")]
        public string name { get; set; }

        [XmlElement(ElementName = "Status")]
        public string status { get; set; }

        [XmlElement(ElementName = "banner")]
        public string bannerURL { get; set; }

        [XmlElement(ElementName = "fanart")]
        public string fanartURL { get; set; }

        [XmlElement(ElementName = "lastupdated")]
        public long lastUpdated { get; set; }

        [XmlElement(ElementName = "poster")]
        public string posterURL { get; set; }
    }
}
