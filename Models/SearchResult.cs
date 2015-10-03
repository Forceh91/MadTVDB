using System;
using System.Xml.Serialization;

namespace MadTVDBPortable.Models
{
    [XmlRoot(ElementName = "Series")]
    public class SearchResult
    {
        [XmlElement(ElementName = "seriesid")]
        public uint seriesID { get; set; }

        [XmlElement(ElementName = "language")]
        public string language { get; set; }

        [XmlElement(ElementName = "SeriesName")]
        public string name { get; set; }

        [XmlElement(ElementName = "banner")]
        public string bannerURL { get; set; }

        [XmlElement(ElementName = "Overview")]
        public string description { get; set; }

        [XmlElement(ElementName = "FirstAired")]
        public DateTime? firstAired { get; set; }

        [XmlElement(ElementName = "Network")]
        public string network { get; set; }

        [XmlElement(ElementName = "IMDB_ID")]
        public string imdbID { get; set; }

        [XmlElement(ElementName = "id")]
        public uint tvdbID { get; set; }
    }
}
