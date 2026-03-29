using Newtonsoft.Json;

namespace MVCSportsApp.Models.NFL
{
    public class NFLScheduleGame
    {
        [JsonProperty("GameKey")]
        public string GameKey { get; set; } = "";

        [JsonProperty("ScoreID")]
        public int ScoreID { get; set; }

        [JsonProperty("Season")]
        public int Season { get; set; }

        [JsonProperty("SeasonType")]
        public int SeasonType { get; set; }

        [JsonProperty("Week")]
        public int Week { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; } = "";

        [JsonProperty("Date")]
        public DateTime? Date { get; set; }

        [JsonProperty("AwayTeam")]
        public string AwayTeam { get; set; } = "";

        [JsonProperty("HomeTeam")]
        public string HomeTeam { get; set; } = "";

        [JsonProperty("AwayTeamID")]
        public int AwayTeamID { get; set; }

        [JsonProperty("HomeTeamID")]
        public int HomeTeamID { get; set; }

        [JsonProperty("AwayScore")]
        public int? AwayScore { get; set; }

        [JsonProperty("HomeScore")]
        public int? HomeScore { get; set; }

        [JsonProperty("Channel")]
        public string Channel { get; set; } = "";

        [JsonProperty("StadiumID")]
        public int? StadiumID { get; set; }

        [JsonProperty("IsOvertime")]
        public bool IsOvertime { get; set; }

        [JsonProperty("Quarter")]
        public string Quarter { get; set; } = "";
    }
}
