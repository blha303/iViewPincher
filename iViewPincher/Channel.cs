using Newtonsoft.Json;
using System.Collections.Generic;

namespace iViewPincher
{
    public class Channel
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty(PropertyName = "banner")]
        public IDictionary<string, object> Banner { get; set; }

        [JsonProperty(PropertyName = "bannerURL")]
        public string BannerURL { get; set; }

        [JsonProperty(PropertyName = "featuredImage")]
        public string FeaturedImage { get; set; }

        [JsonProperty(PropertyName = "carousels")]
        public IList<object> Carousels { get; set; }

        [JsonProperty(PropertyName = "collections")]
        public IList<object> Collections { get; set; }

        [JsonProperty(PropertyName = "socialFooter")]
        public IDictionary<string, object> SocialFooter { get; set; }

        [JsonProperty(PropertyName = "index")]
        public IList<IndexObject> Index { get; set; }
    }
}
