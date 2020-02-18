using Newtonsoft.Json;

using System.Collections.Generic;

namespace Managrr.Services.Radarr.Models
{
    public class Movie
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("sortTitle")]
        public string SortTitle { get; set; }

        [JsonProperty("sizeOnDisk")]
        public double SizeOnDisk { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("inCinemas")]
        public string InCinemas { get; set; }

        [JsonProperty("physicalRelease")]
        public string PhysicalRelease { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("downloaded")]
        public bool Downloaded { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("hasFile")]
        public bool HasFile { get; set; }

        [JsonProperty("youTubeTrailerId")]
        public string YouTubeTrailerId { get; set; }

        [JsonProperty("studio")]
        public string Studio { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("profileId")]
        public int ProfileId { get; set; }

        [JsonProperty("minimumAvailability")]
        public string MinimumAvailability { get; set; }

        [JsonProperty("monitored")]
        public bool Monitored { get; set; }

        [JsonProperty("runtime")]
        public int Runtime { get; set; }

        [JsonProperty("lastInfoSync")]
        public string LastInfoSync { get; set; }

        [JsonProperty("cleanTitle")]
        public string CleanTitle { get; set; }

        [JsonProperty("imdbId")]
        public string ImdbId { get; set; }

        [JsonProperty("tmdbId")]
        public int TmdbId { get; set; }

        [JsonProperty("titleSlug")]
        public string TitleSlug { get; set; }

        [JsonProperty("genres")]
        public List<string> Genres { get; set; }

        [JsonProperty("tags")]
        public List<object> Tags { get; set; }

        [JsonProperty("added")]
        public string Added { get; set; }

        [JsonProperty("qualityProfileId")]
        public int QualityProfileId { get; set; }
    }
}