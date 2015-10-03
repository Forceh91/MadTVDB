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
        public DateTime? firstAired { get; set; }

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
        public double? rating { get; set; }

        [XmlElement(ElementName = "RatingCount")]
        public int ratingCount { get; set; }

        [XmlElement(ElementName = "Runtime")]
        public uint episodeRuntime { get; set; }

        [XmlElement(ElementName = "SeriesID")]
        public uint seriesID { get; set; }

        [XmlElement(ElementName = "SeriesName")]
        public string name { get; set; }

        [XmlElement(ElementName = "Status")]
        public string status { get; set; }

        [XmlElement(ElementName = "banner")]
        public string bannerURL { get; set; }

        [XmlElement(ElementName = "fanart")]
        public string fanartURL { get; set; }

        [XmlElement(ElementName = "lastupdated")]
        public long? lastUpdated { get; set; }

        [XmlElement(ElementName = "poster")]
        public string posterURL { get; set; }
    }
}
