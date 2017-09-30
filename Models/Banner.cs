using System;
using System.Xml.Serialization;

namespace MadTVDBPortable.Models
{
    public enum BannerType
    {
        Unknown,
        Poster = 1,
        Fanart,
        Series,
        Season,
        All
    }

    public enum BannerType2
    {
        Text,
        Graphical,
        Blank,
        Res1080,
        Res720,
        Unknown
    }

    [XmlRoot(ElementName = "Banner")]
    public class Banner
    {
        [XmlElement(ElementName = "BannerPath")]
        public string bannerPath { get; set; }

        [XmlElement(ElementName = "ThumbnailPath")]
        public string thumbnailPath { get; set; }

        [XmlElement(ElementName = "VignettePath")]
        public string vignettePath { get; set; }

        public BannerType bannerType
        {
            get
            {
                switch (_bannerType)
                {
                    case "poster":
                        return BannerType.Poster;
                    case "fanart":
                        return BannerType.Fanart;
                    case "series":
                        return BannerType.Series;
                    case "season":
                        return BannerType.Season;
                }

                return BannerType.Unknown;
            }
        }

        public BannerType2 bannerType2
        {
            get
            {
                switch (_bannerType2)
                {
                    case "text":
                        return BannerType2.Text;
                    case "graphical":
                        return BannerType2.Graphical;
                    case "blank":
                        return BannerType2.Blank;

                    case "1920x1080":
                        return BannerType2.Res1080;
                    case "1280x720":
                        return BannerType2.Res720;
                }

                return BannerType2.Unknown;
            }
        }

        [XmlElement(ElementName = "BannerType")]
        public string _bannerType { get; set; }

        [XmlElement(ElementName = "BannerType2")]
        public string _bannerType2 { get; set; }

        [XmlElement(ElementName = "Language")]
        public string language { get; set; }

        public uint season
        {
            get
            {
                if (string.IsNullOrEmpty(_season))
                    return 0;
                else
                    return Convert.ToUInt32(_season);
            }
        }

        [XmlElement(ElementName = "Season")]
        public string _season { get; set; }

        public double rating
        {
            get
            {
                if (string.IsNullOrEmpty(_rating))
                    return 0.0;
                else
                    return Convert.ToDouble(_rating);
            }
        }

        [XmlElement(ElementName = "Rating")]
        public string _rating { get; set; }

        [XmlElement(ElementName = "RatingCount")]
        public uint ratingCount { get; set; }
    }
}
