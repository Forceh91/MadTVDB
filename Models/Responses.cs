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
}
