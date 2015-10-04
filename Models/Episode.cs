using System;
using System.Xml.Serialization;

namespace MadTVDB.Models
{
    public enum EpImg
    {
        UNKNOWN_FLAG = 0,
        FOURBYTHREEASPECT = 1,
        SIXTEENBYNINEASPECT,
        INVALID_ASPECT,
        IMAGE_TOO_SMALL,
        BLACK_BARS,
        IMPROPER_ACTION_SHOT
    }

    [XmlRoot(ElementName = "Episode")]
    public class Episode
    {
        [XmlElement(ElementName = "id")]
        public uint id { get; set; }

        [XmlElement(ElementName = "Combined_episodenumber")]
        public double combinedEpisodeNumber { get; set; }

        [XmlElement(ElementName = "Combined_season")]
        public double combinedSeasonNumber { get; set; }

        public double dvdEpisodeNumber
        {
            get
            {
                if (string.IsNullOrEmpty(_dvdEpisodeNumber))
                    return 0;
                else
                    return Convert.ToDouble(_dvdEpisodeNumber);
            }
        }

        [XmlElement(ElementName = "DVD_episodenumber")]
        public string _dvdEpisodeNumber { get; set; }

        public uint dvdSeason
        {
            get
            {
                if (string.IsNullOrEmpty(_dvdSeason))
                    return 0;
                else
                    return Convert.ToUInt32(_dvdSeason);
            }
        }

        [XmlElement(ElementName = "DVD_season")]
        public string _dvdSeason { get; set; }

        [XmlElement(ElementName = "Director")]
        public string director { get; set; }

        public EpImg epImgFlag
        {
            get
            {
                if (string.IsNullOrEmpty(_epImgFlag))
                    return EpImg.UNKNOWN_FLAG;
                else
                    return (EpImg)Convert.ToUInt32(_epImgFlag);
            }
        }

        [XmlElement(ElementName = "EpImgFlag")]
        public string _epImgFlag { get; set; }

        [XmlElement(ElementName = "EpisodeName")]
        public string episodeName { get; set; }

        [XmlElement(ElementName = "EpisodeNumber")]
        public uint episodeNumber { get; set; }

        [XmlElement(ElementName = "FirstAired")]
        public DateTime? firstAired { get; set; }

        [XmlElement(ElementName = "GuestStars")]
        public string guestStars { get; set; }

        [XmlElement(ElementName = "IMDB_ID")]
        public string imdbID { get; set; }

        [XmlElement(ElementName = "Language")]
        public string language { get; set; }

        [XmlElement(ElementName = "Overview")]
        public string description { get; set; }

        [XmlElement(ElementName = "ProductionCode")]
        public string productionCode { get; set; }

        public double rating
        {
            get
            {
                if (string.IsNullOrEmpty(_rating))
                    return 0.0f;
                else
                    return Convert.ToDouble(_rating);
            }
        }

        [XmlElement(ElementName = "Rating")]
        public string _rating { get; set; }

        [XmlElement(ElementName = "RatingCount")]
        public uint ratingCount { get; set; }

        [XmlElement(ElementName = "SeasonNumber")]
        public uint seasonNumber { get; set; }

        [XmlElement(ElementName = "Writer")]
        public string writer { get; set; }

        public uint absoluteNumber
        {
            get
            {
                if (string.IsNullOrEmpty(_absoluteNumber))
                    return 0;
                else
                    return Convert.ToUInt32(_absoluteNumber);
            }
        }

        [XmlElement(ElementName = "absolute_number")]
        public string _absoluteNumber { get; set; }

        [XmlElement(ElementName = "airsafter_season")]
        public uint airsAfterSeason { get; set; }

        [XmlElement(ElementName = "airsbefore_season")]
        public uint airsBeforeSeason { get; set; }

        [XmlElement(ElementName = "airsafter_episode")]
        public uint airsAfterEpisode { get; set; }

        [XmlElement(ElementName = "airsbefore_episode")]
        public uint airsBeforeEpisode { get; set; }

        [XmlElement(ElementName = "filename")]
        public string artworkURL { get; set; }

        [XmlElement(ElementName = "lastupdated")]
        public double lastUpdated { get; set; }

        [XmlElement(ElementName = "seasonid")]
        public uint seasonID { get; set; }

        [XmlElement(ElementName = "seriesid")]
        public uint seriesID { get; set; }

        public DateTime thumbAdded
        {
            get
            {
                DateTime returnValue = DateTime.MinValue;
                DateTime.TryParse(_thumbAdded, out returnValue);

                return returnValue;
            }
        }

        [XmlElement(ElementName = "thumb_added")]
        public string _thumbAdded { get; set; }

        public uint thumbHeight
        {
            get
            {
                if (string.IsNullOrEmpty(_thumbHeight))
                    return 0;
                else
                    return Convert.ToUInt32(_thumbHeight);
            }
        }

        [XmlElement(ElementName = "thumb_height")]
        public string _thumbHeight { get; set; }

        public uint thumbWidth
        {
            get
            {
                if (string.IsNullOrEmpty(_thumbWidth))
                    return 0;
                else
                    return Convert.ToUInt32(_thumbWidth);
            }
        }

        [XmlElement(ElementName = "thumb_width")]
        public string _thumbWidth { get; set; }
    }
}
