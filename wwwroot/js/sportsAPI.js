//This is the sports api. it will provide a collection of commonly used api calls

const SportsApi = (() => {

    async function fetchJson(url)
    {
        try {
            const response = await fetch(url);
            if (!response.ok) {
                console.error('API error ouch ${response.status}: ${url}');
                return;
            }
            return await response.json();
        }
        catch (err) {
            console.error('API fetch failed: ${url}', err);
            return;
        }

    }

    //NBA fetch requests
    getTeams: function() {
        return fetchList('/api/nba/teams');
    }

    getStandings: function() {
        return fetchList('/api/nba/standings');
    }

    getGames: function() {
        return fetchList('/api/nba/games');
    }

    getPLayers: function() {
        return fetchList('/api/nba/players');
    }

    getPlayerStats: function() {
        return fetchList('/api/nba/playerstats');
    }

    getTeamPlayers: function(key) {
        return fetchList('/api/nba/teams/' + key + '/players');
    }

    getTeamGames: function(key) {
        return fetchList('/api/nba/teams/'+ key+ '/games');
    }

    //NFL Fetch data
    getTeams: function() {
        return fetchList('/api/nfl/teams');
    }

    getStandings: function() {
        return fetchList('/api/nfl/standings');
    }

    getGames: function() {
        return fetchList('/api/nfl/games');
    }

    getPLayers: function() {
        return fetchList('/api/nfl/players');
    }

    getPlayerStats: function() {
        return fetchList('/api/nfl/playerstats');
    }

    getTeamPlayers: function(key) {
        return fetchList('/api/nfl/teams/' + key + '/players');
    }

    getTeamGames: function(key) {
        return fetchList('/api/nfl/teams/' + key + '/games');
    }
})