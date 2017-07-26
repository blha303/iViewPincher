using Newtonsoft.Json;
using System.Collections.Generic;

namespace iViewPincher
{
    public class IndexObject
    {
        [JsonProperty(PropertyName = "title")]
        public string title { get; set; }

        [JsonProperty(PropertyName = "episodes")]
        public IList<Episode> Episodes { get; set; }
    }
}
