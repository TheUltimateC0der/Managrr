using Newtonsoft.Json;

namespace Managrr.Services.Radarr.Models
{
    public class RootFolder
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("freespace")]
        public long FreeSpace { get; set; }

    }
}