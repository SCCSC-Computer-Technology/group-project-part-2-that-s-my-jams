using Newtonsoft.Json;
using MVCSportsApp.Models.NBA;
using MVCSportsApp.Models.NFL;

/*This is Sports data API service class
 *Its function is to handle all API calls to SportsData.io
 *all data is locked to 2025 due to license restrictions
 *Author M.McD
 */

namespace MVCSportsApp.Services
{
    public class SportsDataService
    {

        private readonly HttpClient _client;
        private readonly string _apiKey;
        private readonly ILogger<SportsDataService> _logger;

        //variables for the year. this is openended for expansion
        private string Year = "2025";
        private string NFLSeason = "2025REG";

        public SportsDataService(HttpClient client, IConfiguration config, ILogger<SportsDataService> logger)
        {
            _client = client;
            _apiKey = config["SportsData:ApiKey"] ?? "";
            _logger = logger;
        }

        private async Task<T> GetAsync<T>(string url) where T : new()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("Ocp-Apim-Subscription-Key", _apiKey);

            _logger.LogInformation("SportsData API call: {Url}", url);

            HttpResponseMessage response = await _client.SendAsync(request);
            string body = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                _logger.LogError("SportsData API error {StatusCode}: {Body}", (int)response.StatusCode, body);
                throw new HttpRequestException($"SportsData API returned {(int)response.StatusCode}: {body}");
            }

            return JsonConvert.DeserializeObject<T>(body) ?? new T();

        }

        //NBA Api endpoints
        public Task<List<NBATeam>> GetNBATeamsAsync()
            => GetAsync<List<NBATeam>>("https://api.sportsdata.io/v3/nba/scores/json/Teams");
        public Task<List<NBAPlayer>> GetNBAPlayersAsync()
            => GetAsync<List<NBAPlayer>>("https://api.sportsdata.io/v3/nba/scores/json/Players");
        public Task<List<NBAGame>> GetNBAGamesAsync()
            => GetAsync<List<NBAGame>>($"https://api.sportsdata.io/v3/nba/scores/json/Games/{Year}");
        public Task<List<NBAStanding>> GetNBAStandingsAsync()
            => GetAsync<List<NBAStanding>>($"https://api.sportsdata.io/v3/nba/scores/json/Standings/{Year}");
        public Task<List<NBAPlayerSeasonStat>> GetNBAPlayerSeasonStatsAsync()
           => GetAsync<List<NBAPlayerSeasonStat>>($"https://api.sportsdata.io/v3/nba/scores/json/PlayerSeasonStats/{Year}");


        //NFL Api endpoints
        public Task<List<NFLTeam>> GetNFLTeamsAsync()
            => GetAsync<List<NFLTeam>>("https://api.sportsdata.io/v3/nfl/scores/json/Teams");
        public Task<List<NFLPlayer>> GetNFLPlayersAsync()
            => GetAsync<List<NFLPlayer>>("https://api.sportsdata.io/v3/nfl/scores/json/PlayersByAvailable");
        public Task<List<NFLScheduleGame>> GetNFLGamesAsync()
            => GetAsync<List<NFLScheduleGame>>($"https://api.sportsdata.io/v3/nfl/scores/json/Scores/{NFLSeason}");
        public Task<List<NFLStanding>> GetNFLStandingsAsync()
            => GetAsync<List<NFLStanding>>($"https://api.sportsdata.io/v3/nfl/scores/json/Standings/{NFLSeason}");
        public Task<List<NFLPlayerSeasonStat>> GetNFLPlayerSeasonStatsAsync()
            => GetAsync<List<NFLPlayerSeasonStat>>($"https://api.sportsdata.io/v3/nfl/scores/json/PlayerSeasonStats/{NFLSeason}");

    }
}
