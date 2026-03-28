using Newtonsoft.Json;

namespace MVCSportsApp.Models.NBA
{
    public class NBAStanding
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

        [JsonProperty("Wins")]
        public int Wins { get; set; }

        [JsonProperty("Losses")]
        public int Losses { get; set; }

        [JsonProperty("Percentage")]
        public decimal Percentage { get; set; }

        [JsonProperty("ConferenceWins")]
        public int ConferenceWins { get; set; }

        [JsonProperty("ConferenceLosses")]
        public int ConferenceLosses { get; set; }

        [JsonProperty("DivisionWins")]
        public int DivisionWins { get; set; }

        [JsonProperty("DivisionLosses")]
        public int DivisionLosses { get; set; }

        [JsonProperty("HomeWins")]
        public int HomeWins { get; set; }

        [JsonProperty("HomeLosses")]
        public int HomeLosses { get; set; }

        [JsonProperty("AwayWins")]
        public int AwayWins { get; set; }

        [JsonProperty("AwayLosses")]
        public int AwayLosses { get; set; }

        [JsonProperty("GamesBack")]
        public decimal GamesBack { get; set; }

        [JsonProperty("PointsPerGameFor")]
        public decimal PointsPerGameFor { get; set; }

        [JsonProperty("PointsPerGameAgainst")]
        public decimal PointsPerGameAgainst { get; set; }

        [JsonProperty("Streak")]
        public int Streak { get; set; }

        [JsonProperty("StreakDescription")]
        public string StreakDescription { get; set; } = "";
    }
}
