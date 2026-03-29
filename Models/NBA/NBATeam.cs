using Newtonsoft.Json;

namespace MVCSportsApp.Models.NBA
{
    public class NBATeam
    {
        [JsonProperty("TeamID")]
        public int TeamID { get; set; }

        [JsonProperty("Key")]
        public string Key { get; set; } = "";

        [JsonProperty("City")]
        public string City { get; set; } = "";

        [JsonProperty("Name")]
        public string Name { get; set; } = "";

        [JsonProperty("FullName")]
        public string FullName => $"{City} {Name}";

        [JsonProperty("Conference")]
        public string Conference { get; set; } = "";

        [JsonProperty("Division")]
        public string Division { get; set; } = "";

        [JsonProperty("WikipediaLogoUrl")]
        public string WikipediaLogoUrl { get; set; } = "";

        [JsonProperty("PrimaryColor")]
        public string PrimaryColor { get; set; } = "";

        [JsonProperty("SecondaryColor")]
        public string SecondaryColor { get; set; } = "";

        [JsonProperty("StadiumID")]
        public int? StadiumID { get; set; }
    }
}
