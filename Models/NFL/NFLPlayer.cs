using Newtonsoft.Json;

namespace MVCSportsApp.Models.NFL
{
    public class NFLPlayer
    {
        [JsonProperty("PlayerID")]
        public int PlayerID { get; set; }

        [JsonProperty("FirstName")]
        public string FirstName { get; set; } = "";

        [JsonProperty("LastName")]
        public string LastName { get; set; } = "";

        public string FullName => $"{FirstName} {LastName}";

        [JsonProperty("Team")]
        public string Team { get; set; } = "";

        [JsonProperty("Number")]
        public int? Number { get; set; }

        [JsonProperty("Position")]
        public string Position { get; set; } = "";

        [JsonProperty("Height")]
        public string Height { get; set; } = "";

        [JsonProperty("Weight")]
        public int? Weight { get; set; }

        [JsonProperty("BirthDate")]
        public DateTime? BirthDate { get; set; }

        [JsonProperty("College")]
        public string College { get; set; } = "";

        [JsonProperty("Status")]
        public string Status { get; set; } = "";

        [JsonProperty("PhotoUrl")]
        public string PhotoUrl { get; set; } = "";

        [JsonProperty("Experience")]
        public int? Experience { get; set; }

        [JsonProperty("CurrentTeam")]
        public string CurrentTeam { get; set; } = "";
    }
}
