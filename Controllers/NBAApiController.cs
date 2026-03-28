using Microsoft.AspNetCore.Mvc;
using MVCSportsApp.Services;

namespace MVCSportsApp.Controllers
{
    [Route("api/nba")]
    [ApiController]
    public class NBAApiController : ControllerBase
    {
        private readonly SportsDataService _sportsData;

        public NBAApiController(SportsDataService sportsData)
        {
            _sportsData = sportsData;
        }

        // get nba steams
        [HttpGet("teams")]
        public async Task<IActionResult> GetTeams()
        {
            try
            {
                var teams = await _sportsData.GetNBATeamsAsync();
                return Ok(teams);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(502, new { error = "Failed to fetch NBA teams", detail = ex.Message });
            }
        }

        // get nba standings
        [HttpGet("standings")]
        public async Task<IActionResult> GetStandings()
        {
            try
            {
                var standings = await _sportsData.GetNBAStandingsAsync();
                return Ok(standings);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(502, new { error = "Failed to fetch NBA standings", detail = ex.Message });
            }
        }

        // get nba games
        [HttpGet("games")]
        public async Task<IActionResult> GetGames()
        {
            try
            {
                var games = await _sportsData.GetNBAGamesAsync();
                return Ok(games);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(502, new { error = "Failed to fetch NBA games", detail = ex.Message });
            }
        }

        // get nba players
        [HttpGet("players")]
        public async Task<IActionResult> GetPlayers()
        {
            try
            {
                var players = await _sportsData.GetNBAPlayersAsync();
                return Ok(players);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(502, new { error = "Failed to fetch NBA players", detail = ex.Message });
            }
        }

        // get nba player stats
        [HttpGet("playerstats")]
        public async Task<IActionResult> GetPlayerStats()
        {
            try
            {
                var stats = await _sportsData.GetNBAPlayerSeasonStatsAsync();
                return Ok(stats);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(502, new { error = "Failed to fetch NBA player stats", detail = ex.Message });
            }
        }

        // get nab teams bt abbriv
        [HttpGet("teams/{teamKey}/players")]
        public async Task<IActionResult> GetPlayersByTeam(string teamKey)
        {
            try
            {
                var players = await _sportsData.GetNBAPlayersAsync();
                var filtered = players
                    .Where(p => p.Team != null &&
                                p.Team.Equals(teamKey, StringComparison.OrdinalIgnoreCase))
                    .OrderBy(p => p.LastName)
                    .ToList();
                return Ok(filtered);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(502, new { error = "Failed to fetch NBA players", detail = ex.Message });
            }
        }

        // get nba games by abbriv
        [HttpGet("teams/{teamKey}/games")]
        public async Task<IActionResult> GetGamesByTeam(string teamKey)
        {
            try
            {
                var games = await _sportsData.GetNBAGamesAsync();
                var filtered = games
                    .Where(g => (g.HomeTeam != null && g.HomeTeam.Equals(teamKey, StringComparison.OrdinalIgnoreCase)) ||
                                (g.AwayTeam != null && g.AwayTeam.Equals(teamKey, StringComparison.OrdinalIgnoreCase)))
                    .OrderBy(g => g.DateTime)
                    .ToList();
                return Ok(filtered);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(502, new { error = "Failed to fetch NBA games", detail = ex.Message });
            }
        }
    }
}
