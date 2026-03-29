using Newtonsoft.Json;

namespace MVCSportsApp.Models.NFL
{
    public class NFLStanding
    {
        [JsonProperty("TeamID")]
        public int TeamID { get; set; }
        // The "Team" property is not part of the JSON response, but we can use it to store the team name for easier access in our views.
        public string Team { get; set; }

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

        [JsonProperty("Ties")]
        public int Ties { get; set; }

        [JsonProperty("Percentage")]
        public decimal Percentage { get; set; }

        [JsonProperty("PointsFor")]
        public int PointsFor { get; set; }

        [JsonProperty("PointsAgainst")]
        public int PointsAgainst { get; set; }

        [JsonProperty("DivisionWins")]
        public int DivisionWins { get; set; }

        [JsonProperty("DivisionLosses")]
        public int DivisionLosses { get; set; }

        [JsonProperty("ConferenceWins")]
        public int ConferenceWins { get; set; }

        [JsonProperty("ConferenceLosses")]
        public int ConferenceLosses { get; set; }

        [JsonProperty("HomeWins")]
        public int HomeWins { get; set; }

        [JsonProperty("HomeLosses")]
        public int HomeLosses { get; set; }

        [JsonProperty("AwayWins")]
        public int AwayWins { get; set; }

        [JsonProperty("AwayLosses")]
        public int AwayLosses { get; set; }

        [JsonProperty("NetPoints")]
        public int NetPoints { get; set; }

        [JsonProperty("Touchdowns")]
        public int Touchdowns { get; set; }

        [JsonProperty("Streak")]
        public int Streak { get; set; }

        [JsonProperty("StreakDescription")]
        public string StreakDescription { get; set; } = "";
    }
}
