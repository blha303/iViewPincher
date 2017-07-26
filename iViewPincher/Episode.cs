using Newtonsoft.Json;
using System.Collections.Generic;

namespace iViewPincher
{
    public class Episode 
    {
        public string PrettyTitle { get; set; }

        [JsonProperty(PropertyName = "seriesTitle")]
        public string SeriesTitle { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }

        [JsonProperty(PropertyName = "channel")]
        public string Channel { get; set; }

        [JsonProperty(PropertyName = "channelTitle")]
        public string ChannelTitle { get; set; }

        [JsonProperty(PropertyName = "pubDate")]
        public string PubDate { get; set; }

        [JsonProperty(PropertyName = "thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty(PropertyName = "episodeHouseNumber")]
        public string EpisodeHouseNumber { get; set; }

        [JsonProperty(PropertyName = "duration")]
        public string Duration { get; set; }

        [JsonProperty(PropertyName = "rating")]
        public string Rating { get; set; }

        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        // Extra fields

        [JsonProperty(PropertyName = "expireDate")]
        public string ExpireDate { get; set; }

        [JsonProperty(PropertyName = "seriesHouseNumber")]
        public string SeriesHouseNumber { get; set; }

        [JsonProperty(PropertyName = "categories")]
        public IList<Category> Categories { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "related")]
        public string Related { get; set; }

        [JsonProperty(PropertyName = "episodeCount")]
        public int EpisodeCount { get; set; }

        [JsonProperty(PropertyName = "availability")]
        public string Availability { get; set; }

        [JsonProperty(PropertyName = "playlist")]
        public IList<PlaylistObject> Playlist { get; set; }

        [JsonProperty(PropertyName = "classAdvice")]
        public string ClassAdvice { get; set; }

        [JsonProperty(PropertyName = "transmitDate")]
        public string TransmitDate { get; set; }

        [JsonProperty(PropertyName = "transmitChannel")]
        public string TransmitChannel { get; set; }

        [JsonProperty(PropertyName = "captions")]
        public bool Captions { get; set; }

        [JsonProperty(PropertyName = "streams")]
        public IDictionary<string, IList<string>> Streams { get; set; }

        [JsonProperty(PropertyName = "share")]
        public string Share { get; set; }
    }
}
