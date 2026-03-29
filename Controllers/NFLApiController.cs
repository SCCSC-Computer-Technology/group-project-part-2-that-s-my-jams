using Microsoft.AspNetCore.Mvc;
using MVCSportsApp.Services;

namespace MVCSportsApp.Controllers
{
    [Route("api/nfl")]
    [ApiController]
    public class NFLApiController : ControllerBase
    {
        private readonly SportsDataService _sportsData;

        public NFLApiController(SportsDataService sportsData)
        {
            _sportsData = sportsData;
        }

        // get nba teams
        [HttpGet("teams")]
        public async Task<IActionResult> GetTeams()
        {
            try
            {
                var teams = await _sportsData.GetNFLTeamsAsync();
                return Ok(teams);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(502, new { error = "Failed to fetch NFL teams", detail = ex.Message });
            }
        }

        // get nba standings
        [HttpGet("standings")]
        public async Task<IActionResult> GetStandings()
        {
            try
            {
                var standings = await _sportsData.GetNFLStandingsAsync();
                return Ok(standings);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(502, new { error = "Failed to fetch NFL standings", detail = ex.Message });
            }
        }

        // get nfl games
        [HttpGet("games")]
        public async Task<IActionResult> GetGames()
        {
            try
            {
                var games = await _sportsData.GetNFLGamesAsync();
                return Ok(games);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(502, new { error = "Failed to fetch NFL games", detail = ex.Message });
            }
        }

        // get nfl players
        [HttpGet("players")]
        public async Task<IActionResult> GetPlayers()
        {
            try
            {
                var players = await _sportsData.GetNFLPlayersAsync();
                return Ok(players);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(502, new { error = "Failed to fetch NFL players", detail = ex.Message });
            }
        }

        // get nfl player stats
        [HttpGet("playerstats")]
        public async Task<IActionResult> GetPlayerStats()
        {
            try
            {
                var stats = await _sportsData.GetNFLPlayerSeasonStatsAsync();
                return Ok(stats);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(502, new { error = "Failed to fetch NFL player stats", detail = ex.Message });
            }
        }

        // get nfl players by team
        [HttpGet("teams/{teamKey}/players")]
        public async Task<IActionResult> GetPlayersByTeam(string teamKey)
        {
            try
            {
                var players = await _sportsData.GetNFLPlayersAsync();
                var filtered = players
                    .Where(p => (p.Team != null && p.Team.Equals(teamKey, StringComparison.OrdinalIgnoreCase)) ||
                                (p.CurrentTeam != null && p.CurrentTeam.Equals(teamKey, StringComparison.OrdinalIgnoreCase)))
                    .OrderBy(p => p.LastName)
                    .ToList();
                return Ok(filtered);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(502, new { error = "Failed to fetch NFL players", detail = ex.Message });
            }
        }

        // get nfl games by team
        [HttpGet("teams/{teamKey}/games")]
        public async Task<IActionResult> GetGamesByTeam(string teamKey)
        {
            try
            {
                var games = await _sportsData.GetNFLGamesAsync();
                var filtered = games
                    .Where(g => (g.HomeTeam != null && g.HomeTeam.Equals(teamKey, StringComparison.OrdinalIgnoreCase)) ||
                                (g.AwayTeam != null && g.AwayTeam.Equals(teamKey, StringComparison.OrdinalIgnoreCase)))
                    .OrderBy(g => g.Date)
                    .ToList();
                return Ok(filtered);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(502, new { error = "Failed to fetch NFL games", detail = ex.Message });
            }
        }

        [HttpGet("teams/{key}/detail")]
        public async Task<IActionResult> GetTeamDetail(string key)
        {
            try
            {
                var detail = await _sportsData.GetNFLTeamDetailAsync(key);
                if (detail is null) return NotFound(new { error = $"Team '{key}' not found" });
                return Ok(detail);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }
        }
    }
}

