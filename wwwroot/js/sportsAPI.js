//This is the sports api. it will provide a collection of commonly used api calls


const NBA_TEAM = [
    {
        "id": 132,
        "key": "ATL",
        "name": "Atlanta Hawks",
        "logo": "https://media.api-sports.io/basketball/teams/132.png"
    },
    {
        "id": 133,
        "key": "BOS",
        "name": "Boston Celtics",
        "logo": "https://media.api-sports.io/basketball/teams/133.png"
    },
    {
        "id": 134,
        "key": "BKN",
        "name": "Brooklyn Nets",
        "logo": "https://media.api-sports.io/basketball/teams/134.png"
    },
    {
        "id": 135,
        "key": "CHA",
        "name": "Charlotte Hornets",
        "logo": "https://media.api-sports.io/basketball/teams/135.png"
    },
    {
        "id": 136,
        "key": "CHI",
        "name": "Chicago Bulls",
        "logo": "https://media.api-sports.io/basketball/teams/136.png"
    },
    {
        "id": 137,
        "key": "CLE",
        "name": "Cleveland Cavaliers",
        "logo": "https://media.api-sports.io/basketball/teams/137.png"
    },
    {
        "id": 138,
        "key": "DAL",
        "name": "Dallas Mavericks",
        "logo": "https://media.api-sports.io/basketball/teams/138.png"
    },
    {
        "id": 139,
        "key": "DEN",
        "name": "Denver Nuggets",
        "logo": "https://media.api-sports.io/basketball/teams/139.png"
    },
    {
        "id": 140,
        "key": "DET",
        "name": "Detroit Pistons",
        "logo": "https://media.api-sports.io/basketball/teams/140.png"
    },
    {
        "id": 141,
        "key": "GS",
        "name": "Golden State Warriors",
        "logo": "https://media.api-sports.io/basketball/teams/141.png"
    },
    {
        "id": 142,
        "key": "HOU",
        "name": "Houston Rockets",
        "logo": "https://media.api-sports.io/basketball/teams/142.png"
    },
    {
        "id": 143,
        "key": "IND",
        "name": "Indiana Pacers",
        "logo": "https://media.api-sports.io/basketball/teams/143.png"
    },
    {
        "id": 144,
        "key": "LAC",
        "name": "Los Angeles Clippers",
        "logo": "https://media.api-sports.io/basketball/teams/144.png"
    },
    {
        "id": 145,
        "key": "LAL",
        "name": "Los Angeles Lakers",
        "logo": "https://media.api-sports.io/basketball/teams/145.png"
    },
    {
        "id": 146,
        "key": "MEM",
        "name": "Memphis Grizzlies",
        "logo": "https://media.api-sports.io/basketball/teams/146.png"
    },
    {
        "id": 147,
        "key": "MIA",
        "name": "Miami Heat",
        "logo": "https://media.api-sports.io/basketball/teams/147.png"
    },
    {
        "id": 148,
        "key": "MIL",
        "name": "Milwaukee Bucks",
        "logo": "https://media.api-sports.io/basketball/teams/148.png"
    },
    {
        "id": 149,
        "key": "MIN",
        "name": "Minnesota Timberwolves",
        "logo": "https://media.api-sports.io/basketball/teams/149.png"
    },
    {
        "id": 150,
        "key": "NO",
        "name": "New Orleans Pelicans",
        "logo": "https://media.api-sports.io/basketball/teams/150.png"
    },
    {
        "id": 151,
        "key": "NY",
        "name": "New York Knicks",
        "logo": "https://media.api-sports.io/basketball/teams/151.png"
    },
    {
        "id": 152,
        "key": "OKC",
        "name": "Oklahoma City Thunder",
        "logo": "https://media.api-sports.io/basketball/teams/152.png"
    },
    {
        "id": 153,
        "key": "ORL",
        "name": "Orlando Magic",
        "logo": "https://media.api-sports.io/basketball/teams/153.png"
    },
    {
        "id": 154,
        "key": "PHI",
        "name": "Philadelphia 76ers",
        "logo": "https://media.api-sports.io/basketball/teams/154.png"
    },
    {
        "id": 155,
        "key": "PHO",
        "name": "Phoenix Suns",
        "logo": "https://media.api-sports.io/basketball/teams/155.png"
    },
    {
        "id": 156,
        "key": "POR",
        "name": "Portland Trail Blazers",
        "logo": "https://media.api-sports.io/basketball/teams/156.png"
    },
    {
        "id": 157,
        "key": "SAC",
        "name": "Sacramento Kings",
        "logo": "https://media.api-sports.io/basketball/teams/157.png"
    },
    {
        "id": 158,
        "key": "SA",
        "name": "San Antonio Spurs",
        "logo": "https://media.api-sports.io/basketball/teams/158.png"
    },
    {
        "id": 159,
        "key": "TOR",
        "name": "Toronto Raptors",
        "logo": "https://media.api-sports.io/basketball/teams/159.png"
    },
    {
        "id": 160,
        "key": "UTA",
        "name": "Utah Jazz",
        "logo": "https://media.api-sports.io/basketball/teams/160.png"
    },
    {
        "id": 161,
        "key": "WAS",
        "name": "Washington Wizards",
        "logo": "https://media.api-sports.io/basketball/teams/161.png"
    }
]
// NFL team data is not as consistent as the NBA, so we will hardcode the first 4 teams for now. We can add more later if needed
const NFL_TEAM = [
    { "id": 1, "key": "ARI", "name": "Arizona Cardinals", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/ari.png" },
    { "id": 2, "key": "ATL", "name": "Atlanta Falcons", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/atl.png" },
    { "id": 3, "key": "BAL", "name": "Baltimore Ravens", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/bal.png" },
    { "id": 4, "key": "BUF", "name": "Buffalo Bills", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/buf.png" },
    { "id": 5, "key": "CAR", "name": "Carolina Panthers", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/car.png" },
    { "id": 6, "key": "CHI", "name": "Chicago Bears", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/chi.png" },
    { "id": 7, "key": "CIN", "name": "Cincinnati Bengals", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/cin.png" },
    { "id": 8, "key": "CLE", "name": "Cleveland Browns", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/cle.png" },
    { "id": 9, "key": "DAL", "name": "Dallas Cowboys", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/dal.png" },
    { "id": 10, "key": "DEN", "name": "Denver Broncos", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/den.png" },
    { "id": 11, "key": "DET", "name": "Detroit Lions", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/det.png" },
    { "id": 12, "key": "GB", "name": "Green Bay Packers", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/gb.png" },
    { "id": 13, "key": "HOU", "name": "Houston Texans", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/hou.png" },
    { "id": 14, "key": "IND", "name": "Indianapolis Colts", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/ind.png" },
    { "id": 15, "key": "JAX", "name": "Jacksonville Jaguars", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/jax.png" },
    { "id": 16, "key": "KC", "name": "Kansas City Chiefs", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/kc.png" },
    { "id": 17, "key": "LV", "name": "Las Vegas Raiders", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/lv.png" },
    { "id": 18, "key": "LAC", "name": "Los Angeles Chargers", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/lac.png" },
    { "id": 19, "key": "LAR", "name": "Los Angeles Rams", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/lar.png" },
    { "id": 20, "key": "MIA", "name": "Miami Dolphins", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/mia.png" },
    { "id": 21, "key": "MIN", "name": "Minnesota Vikings", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/min.png" },
    { "id": 22, "key": "NE", "name": "New England Patriots", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/ne.png" },
    { "id": 23, "key": "NO", "name": "New Orleans Saints", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/no.png" },
    { "id": 24, "key": "NYG", "name": "New York Giants", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/nyg.png" },
    { "id": 25, "key": "NYJ", "name": "New York Jets", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/nyj.png" },
    { "id": 26, "key": "PHI", "name": "Philadelphia Eagles", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/phi.png" },
    { "id": 27, "key": "PIT", "name": "Pittsburgh Steelers", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/pit.png" },
    { "id": 28, "key": "SF", "name": "San Francisco 49ers", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/sf.png" },
    { "id": 29, "key": "SEA", "name": "Seattle Seahawks", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/sea.png" },
    { "id": 30, "key": "TB", "name": "Tampa Bay Buccaneers", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/tb.png" },
    { "id": 31, "key": "TEN", "name": "Tennessee Titans", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/ten.png" },
    { "id": 32, "key": "WAS", "name": "Washington Commanders", "logo": "https://a.espncdn.com/i/teamlogos/nfl/500/was.png" }
];

const SportsApi = (() => {

    

    async function fetchJson(url)
    {
        try {
            const response = await fetch(url);
            if (!response.ok) {
                console.error(`API error ouch ${response.status}: ${url}`);
                return [];
            }
            return await response.json();
        }
        catch (err) {
            console.error(`API fetch failed: ${url}`, err);
            return [];
        }

    }

    //NBA fetch requests
    const nba = {
        getTeams: function () {
            return fetchJson('/api/nba/teams');
        },

        getStandings: function () {
            return fetchJson('/api/nba/standings');
        },

        getGames: function () {
            return fetchJson('/api/nba/games');
        },

        getPLayers: function () {
            return fetchJson('/api/nba/players');
        },

        getPlayerStats: function () {
            return fetchJson('/api/nba/playerstats');
        },

        getTeamPlayers: function (key) {
            return fetchJson('/api/nba/teams/' + key + '/players');
        },

        getTeamGames: function (key) {
            return fetchJson('/api/nba/teams/' + key + '/games');
        },

        getTeamDetail: function (key) {
            return fetchJson('/api/nba/teams/' + key + '/detail');
        },

        getPlayer: function (playerId) {
            return fetchJson('/api/nba/players/' + playerId);
        },

        getGame: function (gameId) {
            return fetchJson('/api/nba/games/' + gameId);
        },

        searchPlayers: function (name) {
            return fetchJson('/api/nba/players/search?name=' + encodeURIComponent(name));
        }
    };

    //NFL Fetch data
    const nfl = {
        getTeams: function () {
            return fetchJson('/api/nfl/teams');
        },

        getStandings: function () {
            return fetchJson('/api/nfl/standings');
        },

        getGames: function () {
            return fetchJson('/api/nfl/games');
        },

        getPLayers: function () {
            return fetchJson('/api/nfl/players');
        },

        getPlayerStats: function () {
            return fetchJson('/api/nfl/playerstats');
        },

        getTeamPlayers: function (key) {
            return fetchJson('/api/nfl/teams/' + key + '/players');
        },

        getTeamGames: function (key) {
            return fetchJson('/api/nfl/teams/' + key + '/games');
        },

        getTeamDetail: function (key) {
            return fetchJson('/api/nfl/teams/' + key + '/detail');
        },

        getPlayer: function (playerId) {
            return fetchJson('/api/nfl/players/' + playerId);
        },

        getGame: function (gameKey) {
            return fetchJson('/api/nfl/games/' + gameKey);
        },

        searchPlayers: function (name) {
            return fetchJson('/api/nfl/players/search?name=' + encodeURIComponent(name));
        }
    };

    return { nba, nfl };
})()