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
        public string _combinedEpisodeNumber { get; set; }
        public double combinedEpisosdeNumber
        {
            get
            {
                if (string.IsNullOrEmpty(_combinedEpisodeNumber))
                    return 0;
                else
                    return Convert.ToDouble(_combinedEpisodeNumber);
            }
        }

        [XmlElement(ElementName = "Combined_season")]
        public string _combinedSeasonNumber { get; set; }
        public double combinedSeasonNumber
        {
            get
            {
                if (string.IsNullOrEmpty(_combinedSeasonNumber))
                    return 0;
                else
                    return Convert.ToDouble(_combinedSeasonNumber);
            }
        }

        [XmlElement(ElementName = "DVD_episodenumber")]
        public string _dvdEpisodeNumber { get; set; }
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

        [XmlElement(ElementName = "DVD_season")]
        public string _dvdSeason { get; set; }
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

        [XmlElement(ElementName = "Director")]
        public string director { get; set; }

        [XmlElement(ElementName = "EpImgFlag")]
        public string _epImgFlag { get; set; }
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


        [XmlElement(ElementName = "EpisodeName")]
        public string episodeName { get; set; }

        [XmlElement(ElementName = "EpisodeNumber")]
        public string _episodeNumber { get; set; }
        public uint episodeNumber
        {
            get
            {
                if (string.IsNullOrEmpty(_episodeNumber))
                    return 0;
                else
                    return Convert.ToUInt32(_episodeNumber);
            }
        }

        [XmlElement(ElementName = "FirstAired")]
        public string _firstAired { get; set; }
        public DateTime firstAired
        {
            get
            {
                if (string.IsNullOrEmpty(_firstAired))
                    return DateTime.MinValue;
                else
                    return Convert.ToDateTime(_firstAired);
            }
        }

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

        [XmlElement(ElementName = "Rating")]
        public string _rating { get; set; }
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

        [XmlElement(ElementName = "RatingCount")]
        public string _ratingCount { get; set; }
        public uint ratingCount { get { return (string.IsNullOrEmpty(_ratingCount) ? 0 : Convert.ToUInt32(_ratingCount)); } }

        [XmlElement(ElementName = "SeasonNumber")]
        public string _seasonNumber { get; set; }
        public uint seasonNumber { get { return (string.IsNullOrEmpty(_seasonNumber) ? 0 : Convert.ToUInt32(_seasonNumber)); } }

        [XmlElement(ElementName = "Writer")]
        public string writer { get; set; }

        [XmlElement(ElementName = "absolute_number")]
        public string _absoluteNumber { get; set; }
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

        [XmlElement(ElementName = "airsafter_season")]
        public string _airsAfterSeason { get; set; }
        public uint airsAfterSeason { get { return (string.IsNullOrEmpty(_airsAfterSeason) ? 0 : Convert.ToUInt32(_airsAfterSeason)); } }

        [XmlElement(ElementName = "airsbefore_season")]
        public string _airsBeforeSeason { get; set; }
        public uint airsBeforeSeason { get { return (string.IsNullOrEmpty(_airsBeforeSeason) ? 0 : Convert.ToUInt32(_airsBeforeSeason)); } }

        [XmlElement(ElementName = "airsafter_episode")]
        public string _airsAfterEpisode { get; set; }
        public uint airsAfterEpisode { get { return (string.IsNullOrEmpty(_airsAfterEpisode) ? 0 : Convert.ToUInt32(_airsAfterEpisode)); } }

        [XmlElement(ElementName = "airsbefore_episode")]
        public string _airsBeforeEpisode { get; set; }
        public uint airsBeforeEpisode { get { return (string.IsNullOrEmpty(_airsBeforeEpisode) ? 0 : Convert.ToUInt32(_airsBeforeEpisode)); } }

        [XmlElement(ElementName = "filename")]
        public string artworkURL { get; set; }

        [XmlElement(ElementName = "lastupdated")]
        public double lastUpdated { get; set; }

        [XmlElement(ElementName = "seasonid")]
        public string _seasonID { get; set; }
        public uint seasonID { get { return (string.IsNullOrEmpty(_seasonID) ? 0 : Convert.ToUInt32(_seasonID)); } }

        [XmlElement(ElementName = "seriesid")]
        public string _seriesID { get; set; }
        public uint seriesID { get { return (string.IsNullOrEmpty(_seriesID) ? 0 : Convert.ToUInt32(_seriesID)); } }

        [XmlElement(ElementName = "thumb_added")]
        public string _thumbAdded { get; set; }
        public DateTime thumbAdded
        {
            get
            {
                DateTime returnValue = DateTime.MinValue;
                DateTime.TryParse(_thumbAdded, out returnValue);

                return returnValue;
            }
        }

        [XmlElement(ElementName = "thumb_height")]
        public string _thumbHeight { get; set; }
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

        [XmlElement(ElementName = "thumb_width")]
        public string _thumbWidth { get; set; }
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
    }
}
