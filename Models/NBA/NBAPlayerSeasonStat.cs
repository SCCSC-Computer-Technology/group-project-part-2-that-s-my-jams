using Newtonsoft.Json;

namespace MVCSportsApp.Models.NBA
{
    public class NBAPlayerSeasonStat
    {
        [JsonProperty("PlayerID")]
        public int PlayerID { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; } = "";

        [JsonProperty("Team")]
        public string Team { get; set; } = "";

        [JsonProperty("Position")]
        public string Position { get; set; } = "";

        [JsonProperty("Games")]
        public int Games { get; set; }

        [JsonProperty("Minutes")]
        public int Minutes { get; set; }

        [JsonProperty("Points")]
        public decimal Points { get; set; }

        [JsonProperty("Assists")]
        public decimal Assists { get; set; }

        [JsonProperty("Rebounds")]
        public decimal Rebounds { get; set; }

        [JsonProperty("OffensiveRebounds")]
        public decimal OffensiveRebounds { get; set; }

        [JsonProperty("DefensiveRebounds")]
        public decimal DefensiveRebounds { get; set; }

        [JsonProperty("Steals")]
        public decimal Steals { get; set; }

        [JsonProperty("BlockedShots")]
        public decimal BlockedShots { get; set; }

        [JsonProperty("Turnovers")]
        public decimal Turnovers { get; set; }

        [JsonProperty("FieldGoalsMade")]
        public decimal FieldGoalsMade { get; set; }

        [JsonProperty("FieldGoalsAttempted")]
        public decimal FieldGoalsAttempted { get; set; }

        [JsonProperty("FieldGoalsPercentage")]
        public decimal FieldGoalsPercentage { get; set; }

        [JsonProperty("ThreePointersMade")]
        public decimal ThreePointersMade { get; set; }

        [JsonProperty("ThreePointersAttempted")]
        public decimal ThreePointersAttempted { get; set; }

        [JsonProperty("ThreePointersPercentage")]
        public decimal ThreePointersPercentage { get; set; }

        [JsonProperty("FreeThrowsMade")]
        public decimal FreeThrowsMade { get; set; }

        [JsonProperty("FreeThrowsAttempted")]
        public decimal FreeThrowsAttempted { get; set; }

        [JsonProperty("FreeThrowsPercentage")]
        public decimal FreeThrowsPercentage { get; set; }

        [JsonProperty("PersonalFouls")]
        public decimal PersonalFouls { get; set; }
    }
}
