using MVCSportsApp.Models.NFL;


//makes it easier to gather data on specific teams
namespace MVCSportsApp.Models.NFL
{
    public class NFLTeamDetails
    {
        public NFLTeam Team { get; set; } = new();
        public NFLStanding? Standing { get; set; }
        public List<NFLPlayer> Players { get; set; } = new();
        public List<NFLScheduleGame> Games { get; set; } = new();

    }
}
