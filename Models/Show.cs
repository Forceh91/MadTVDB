using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MadTVDB.Models
{
    [DataContract(Name = "Series", Namespace = "")]
    public class Show
    {
        [DataMember(Name = "id")]
        public int id { get; private set; }

        [DataMember(Name = "Actors")]
        public string actors { get; set; }

        [DataMember(Name = "Airs_DayOfWeek")]
        public string airDay { get; private set; }

        [DataMember(Name = "Airs_Time")]
        public TimeSpan? airTime { get; private set; }

        [DataMember(Name = "AliasNames")]
        public string aliasNames { get; private set; }

        [DataMember(Name = "ContentRating")]
        public string contentRating { get; private set; }

        [DataMember(Name = "FirstAired")]
        public DateTime firstAired { get; private set; }

        [DataMember(Name = "Genre")]
        public string genres { get; private set; }

        [DataMember(Name = "IMDB_ID")]
        public string imdb { get; private set; }

        [DataMember(Name = "Language")]
        public string language { get; private set; }

        [DataMember(Name = "Network")]
        public string network { get; private set; }

        [DataMember(Name = "Overview")]
        public string description { get; private set; }

        [DataMember(Name = "Rating")]
        public double? rating { get; private set; }

        [DataMember(Name = "RatingCount")]
        public int ratingCount { get; private set; }

        [DataMember(Name = "Runtime")]
        public uint episodeRuntime { get; private set; }

        [DataMember(Name = "SeriesID")]
        public uint seriesID { get; private set; }

        [DataMember(Name = "SeriesName")]
        public string name { get; private set; }

        [DataMember(Name = "Status")]
        public string status { get; private set; }

        [DataMember(Name = "banner")]
        public string banner { get; private set; }

        [DataMember(Name = "fanart")]
        public string fanart { get; private set; }

        [DataMember(Name = "lastupdated")]
        public long? lastUpdated { get; private set; }

        [DataMember(Name = "poster")]
        public string poster { get; private set; }
        
        public List<Episode> episodes;
    }
}
