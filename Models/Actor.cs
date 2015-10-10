using System.Xml.Serialization;

namespace MadTVDBPortable.Models
{
    [XmlRoot(ElementName = "Banner")]
    public class Actor
    {
        [XmlElement(ElementName = "Image")]
        public string imageURL { get; set; }

        [XmlElement(ElementName = "Name")]
        public string name { get; set; }

        [XmlElement(ElementName = "Role")]
        public string role { get; set; }
    }
}
