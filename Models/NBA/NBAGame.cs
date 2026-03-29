using Newtonsoft.Json;

namespace MVCSportsApp.Models.NBA
{
    public class NBAGame
    {
        [JsonProperty("GameID")]
        public int GameID { get; set; }

        [JsonProperty("Season")]
        public int Season { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; } = "";

        [JsonProperty("DateTime")]
        public DateTime? DateTime { get; set; }

        [JsonProperty("AwayTeam")]
        public string AwayTeam { get; set; } = "";

        [JsonProperty("HomeTeam")]
        public string HomeTeam { get; set; } = "";

        [JsonProperty("AwayTeamID")]
        public int AwayTeamID { get; set; }

        [JsonProperty("HomeTeamID")]
        public int HomeTeamID { get; set; }

        [JsonProperty("AwayTeamScore")]
        public int? AwayTeamScore { get; set; }

        [JsonProperty("HomeTeamScore")]
        public int? HomeTeamScore { get; set; }

        [JsonProperty("Channel")]
        public string Channel { get; set; } = "";

        [JsonProperty("Quarter")]
        public string Quarter { get; set; } = "";

        [JsonProperty("TimeRemainingMinutes")]
        public int? TimeRemainingMinutes { get; set; }

        [JsonProperty("TimeRemainingSeconds")]
        public int? TimeRemainingSeconds { get; set; }

        [JsonProperty("StadiumID")]
        public int? StadiumID { get; set; }

        [JsonProperty("IsClosed")]
        public bool IsClosed { get; set; }
    }
}
