using MadTVDBPortable.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MadTVDB.Models
{
    [XmlRoot(ElementName = "Data")]
    public class TVDBSearchResponse : TVDBError
    {
        [XmlElement(ElementName = "Series")]
        public List<SearchResult> searchResults { get; set; }
    }

    [XmlRoot(ElementName = "Data")]
    public class TVDBSeriesResponse : TVDBError
    {
        [XmlElement(ElementName = "Series")]
        public Show show { get; set; }

        [XmlElement(ElementName = "Episode")]
        public List<Episode> episodes { get; set; }
    }

    [XmlRoot(ElementName = "Banners")]
    public class TVDBBannerResponse : TVDBError
    {
        [XmlElement(ElementName = "Banner")]
        public List<Banner> banners { get; set; }
    }

    [XmlRoot(ElementName = "Actors")]
    public class TVDBActorResponse : TVDBError
    {
        [XmlElement(ElementName = "Actor")]
        public List<Actor> actors { get; set; }
    }

    [XmlRoot(ElementName = "Data")]
    public class TVDBEpisodeResponse : TVDBError
    {
        [XmlElement(ElementName = "Episode")]
        public Episode episode;
    }

    public class TVDBError
    {
        public bool serverUnavailable;
    }
}
