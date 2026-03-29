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

        public async Task<NBATeamDetails?> GetNBATeamDetailAsync(string teamKey)
        {
            string key = teamKey.ToUpperInvariant();

            var teamsTask = GetNBATeamsAsync();
            var standingsTask = GetNBAStandingsAsync();
            var playersTask = GetNBAPlayersAsync();
            var gamesTask = GetNBAGamesAsync();

            await Task.WhenAll(teamsTask, standingsTask, playersTask, gamesTask);

            var team = teamsTask.Result.FirstOrDefault(t =>
                t.Key.Equals(key, StringComparison.OrdinalIgnoreCase));

            if (team == null) return null;

            var standing = standingsTask.Result.FirstOrDefault(s =>
                s.Key.Equals(key, StringComparison.OrdinalIgnoreCase));

            var players = playersTask.Result
                .Where(p => p.Team.Equals(key, StringComparison.OrdinalIgnoreCase))
                .OrderBy(p => p.LastName)
                .ToList();

            var games = gamesTask.Result
                .Where(g => g.AwayTeam.Equals(key, StringComparison.OrdinalIgnoreCase) ||
                            g.HomeTeam.Equals(key, StringComparison.OrdinalIgnoreCase))
                .OrderBy(g => g.DateTime)
                .ToList();

            return new NBATeamDetails
            {
                Team = team,
                Standing = standing,
                Players = players,
                Games = games
            };
        }

        public async Task<NFLTeamDetails?> GetNFLTeamDetailAsync(string teamKey)
        {
            string key = teamKey.ToUpperInvariant();

            var teamsTask = GetNFLTeamsAsync();
            var standingsTask = GetNFLStandingsAsync();
            var playersTask = GetNFLPlayersAsync();
            var gamesTask = GetNFLGamesAsync();

            await Task.WhenAll(teamsTask, standingsTask, playersTask, gamesTask);

            var team = teamsTask.Result.FirstOrDefault(t =>
                t.Key.Equals(key, StringComparison.OrdinalIgnoreCase));

            if (team == null) return null;

            var standing = standingsTask.Result.FirstOrDefault(s =>
                s.Team != null && s.Team.Equals(key, StringComparison.OrdinalIgnoreCase));

            var players = playersTask.Result
                // Added a check to ensure p.Team is not null before checking what it equals
                .Where(p => p.Team != null && p.Team.Equals(key, StringComparison.OrdinalIgnoreCase))
                .OrderBy(p => p.LastName)
                .ToList();

            var games = gamesTask.Result
                // Added null checks for both AwayTeam and HomeTeam
                .Where(g => (g.AwayTeam != null && g.AwayTeam.Equals(key, StringComparison.OrdinalIgnoreCase)) ||
                            (g.HomeTeam != null && g.HomeTeam.Equals(key, StringComparison.OrdinalIgnoreCase)))
                .OrderBy(g => g.Date)
                .ToList();

            return new NFLTeamDetails
            {
                Team = team,
                Standing = standing,
                Players = players,
                Games = games
            };
        }
    }
}
    

