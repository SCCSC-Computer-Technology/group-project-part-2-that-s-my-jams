using Newtonsoft.Json;
using System;

namespace MVCSportsApp.Models.NBA
{
    public class NBAPlayer
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

        [JsonProperty("Jersey")]
        public int? Jersey { get; set; }

        [JsonProperty("Position")]
        public string Position { get; set; } = "";

        [JsonProperty("Height")]
        public int? Height { get; set; }

        [JsonProperty("Weight")]
        public int? Weight { get; set; }

        [JsonProperty("BirthDate")]
        public DateTime? BirthDate { get; set; }

        [JsonProperty("BirthCity")]
        public string BirthCity { get; set; } = "";

        [JsonProperty("BirthState")]
        public string BirthState { get; set; } = "";

        [JsonProperty("College")]
        public string College { get; set; } = "";

        [JsonProperty("Status")]
        public string Status { get; set; } = "";

        [JsonProperty("PhotoUrl")]
        public string PhotoUrl { get; set; } = "";

        [JsonProperty("Experience")]
        public int? Experience { get; set; }

        // --- Stats merged from the Controller ---
        public double Points { get; set; } = 0;
        public double Rebounds { get; set; } = 0;
        public double Assists { get; set; } = 0;
    }
}