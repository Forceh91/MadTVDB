using MadTVDBPortable.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MadTVDB.Models
{
    [XmlRoot(ElementName = "Data")]
    public class TVDBSearchResponse
    {
        [XmlElement(ElementName = "Series")]
        public List<SearchResult> searchResults { get; set; }
    }

    [XmlRoot(ElementName = "Data")]
    public class TVDBSeriesResponse
    {
        [XmlElement(ElementName = "Series")]
        public Show show { get; set; }

        [XmlElement(ElementName = "Episode")]
        public List<Episode> episodes { get; set; }
    }

    [XmlRoot(ElementName = "Banners")]
    public class TVDBBannerResponse
    {
        [XmlElement(ElementName = "Banner")]
        public List<Banner> banners { get; set; }
    }

    [XmlRoot(ElementName = "Actors")]
    public class TVDBActorResponse
    {
        [XmlElement(ElementName = "Actor")]
        public List<Actor> actors { get; set; }
    }
}
