using Newtonsoft.Json;

namespace Managrr.Services.Radarr.Models
{
    public class Quality
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}