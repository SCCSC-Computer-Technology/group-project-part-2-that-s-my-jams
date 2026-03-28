using Newtonsoft.Json;

namespace MVCSportsApp.Models.NFL
{
    public class NFLPlayerSeasonStat
    {
        [JsonProperty("PlayerID")]
        public int PlayerID { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; } = "";

        [JsonProperty("Team")]
        public string Team { get; set; } = "";

        [JsonProperty("Position")]
        public string Position { get; set; } = "";

        [JsonProperty("Played")]
        public int Played { get; set; }

        // Passing
        [JsonProperty("PassingCompletions")]
        public decimal PassingCompletions { get; set; }

        [JsonProperty("PassingAttempts")]
        public decimal PassingAttempts { get; set; }

        [JsonProperty("PassingYards")]
        public decimal PassingYards { get; set; }

        [JsonProperty("PassingTouchdowns")]
        public decimal PassingTouchdowns { get; set; }

        [JsonProperty("PassingInterceptions")]
        public decimal PassingInterceptions { get; set; }

        [JsonProperty("PassingRating")]
        public decimal PassingRating { get; set; }

        // Rushing
        [JsonProperty("RushingAttempts")]
        public decimal RushingAttempts { get; set; }

        [JsonProperty("RushingYards")]
        public decimal RushingYards { get; set; }

        [JsonProperty("RushingTouchdowns")]
        public decimal RushingTouchdowns { get; set; }

        // Receiving
        [JsonProperty("Receptions")]
        public decimal Receptions { get; set; }

        [JsonProperty("ReceivingYards")]
        public decimal ReceivingYards { get; set; }

        [JsonProperty("ReceivingTouchdowns")]
        public decimal ReceivingTouchdowns { get; set; }

        [JsonProperty("ReceivingTargets")]
        public decimal ReceivingTargets { get; set; }

        // Defense
        [JsonProperty("Tackles")]
        public decimal Tackles { get; set; }

        [JsonProperty("Sacks")]
        public decimal Sacks { get; set; }

        [JsonProperty("Interceptions")]
        public decimal Interceptions { get; set; }

        [JsonProperty("FumblesRecovered")]
        public decimal FumblesRecovered { get; set; }

        // General
        [JsonProperty("Touchdowns")]
        public decimal Touchdowns { get; set; }

        [JsonProperty("FantasyPoints")]
        public decimal FantasyPoints { get; set; }

        [JsonProperty("FumblesLost")]
        public decimal FumblesLost { get; set; }
    }
}
