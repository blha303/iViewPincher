using Newtonsoft.Json;
using System.Collections.Generic;

namespace iViewPincher
{
    public class PlaylistObject
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "stream-labels")]
        public IDictionary<string, string> StreamLabels { get; set; }

        [JsonProperty(PropertyName = "streams")]
        public IDictionary<string, IDictionary<string, string>> Streams { get; set; }

        [JsonProperty(PropertyName = "hls-plus")]
        public string HLSPlus { get; set; }

        [JsonProperty(PropertyName = "hls-high")]
        public string HLSHigh { get; set; }

        [JsonProperty(PropertyName = "hls-base")]
        public string HLSBase { get; set; }

        [JsonProperty(PropertyName = "hls-low")]
        public string HLSLow { get; set; }

        [JsonProperty(PropertyName = "hls-metered")]
        public string HLSMetered { get; set; }

        [JsonProperty(PropertyName = "hls-unmetered")]
        public string HLSUnmetered { get; set; }

        [JsonProperty(PropertyName = "warning")]
        public string Warning { get; set; }
    }
}