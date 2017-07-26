using Newtonsoft.Json;

namespace iViewPincher
{
    public class Category
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }
    }
}
