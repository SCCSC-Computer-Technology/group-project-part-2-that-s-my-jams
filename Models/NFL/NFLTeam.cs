using Newtonsoft.Json;

namespace MVCSportsApp.Models.NFL
{
    public class NFLTeam
    {
        [JsonProperty("TeamID")]
        public int TeamID { get; set; }

        [JsonProperty("Key")]
        public string Key { get; set; } = "";

        [JsonProperty("City")]
        public string City { get; set; } = "";

        [JsonProperty("Name")]
        public string Name { get; set; } = "";

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

        [JsonProperty("ByeWeek")]
        public int? ByeWeek { get; set; }

        [JsonProperty("HeadCoach")]
        public string HeadCoach { get; set; } = "";
    }
}
