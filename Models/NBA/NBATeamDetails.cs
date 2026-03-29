using MVCSportsApp.Models.NBA;
namespace MVCSportsApp.Models.NBA
{
    //makes it easier to gather data on specific teams
    public class NBATeamDetails
    {
        public NBATeam Team { get; set; } = new();
        public NBAStanding? Standing { get; set; }
        public List<NBAPlayer> Players { get; set; } = new();
        public List<NBAGame> Games { get; set; } = new();

    }
}
