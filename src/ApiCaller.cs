using RiotWrapper.Champion_Mastery_V3;
using RiotWrapper.Champion_V3;
using RiotWrapper.League_V3;
using RiotWrapper.Masteries_V3;
using RiotWrapper.Match_V3;
using RiotWrapper.Runes_V3;
using RiotWrapper.Spectator_V3;
using RiotWrapper.Status_V3;
using RiotWrapper.Summoner_V3;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using System.Net.Http;
using System.Net.Http.Headers;
using System.Linq;
using RiotWrapper.NET;

namespace RiotWrapper
{
    public class ApiCaller
    {
        private string Token { get; set; }
        private static RateLimiter Limiter { get; set; } = new RateLimiter();
        private static bool Startup { get; set; } = true;

        public ApiCaller(string Token)
        {
            this.Token = Token;
        }

        public async Task<List<ChampionMastery>> GetChampionMasteriesAsync(Region Reg, long SummonerId)
        {
            HttpContent ChampionMasteries = await GetRequest(Reg.ToString(), $"/lol/champion-mastery/v3/champion-masteries/by-summoner/{SummonerId}");
            return await ChampionMasteries.ReadAsAsync<List<ChampionMastery>>();
        }
        public async Task<ChampionMastery> GetChampionMasteryAsync(Region Reg, long SummonerId, long ChampionId)
        {
            HttpContent ChampionMastery = await GetRequest(Reg.ToString(), $"/lol/champion-mastery/v3/champion-masteries/by-summoner/{SummonerId}/by-champion/{ChampionId}");
            return await ChampionMastery.ReadAsAsync<ChampionMastery>();
        }
        public async Task<int> GetMasteryScoreAsync(Region Reg, long SummonerId)
        {
            HttpContent Score = await GetRequest(Reg.ToString(), $"/lol/champion-mastery/v3/scores/by-summoner/{SummonerId}");
            return await Score.ReadAsAsync<int>();
        }

        public async Task<List<Champion>> GetChampionsAsync(Region Reg)
        {
            HttpContent Champions = await GetRequest(Reg.ToString(), $"/lol/platform/v3/champions");
            return await Champions.ReadAsAsync<List<Champion>>();
        }
        public async Task<Champion>GetChampionAsync(Region Reg, long ChampionId)
        {
            HttpContent Champion = await GetRequest(Reg.ToString(), $"/lol/platform/v3/champions/{ChampionId}");
            return await Champion.ReadAsAsync<Champion>();
        }

        public async Task<LeagueList> GetChallengerLeaguesAsync(Region Reg, QueueType Que)
        {
            HttpContent ChallengerLeagues = await GetRequest(Reg.ToString(), $"/lol/league/v3/challengerleagues/by-queue/{Que.ToString()}");
            return await ChallengerLeagues.ReadAsAsync<LeagueList>();
        }
        public async Task<List<LeagueList>> GetLeaguesAsync(Region Reg, long SummonerId)
        {
            HttpContent Leagues = await GetRequest(Reg.ToString(), $"/lol/league/v3/leagues/by-summoner/{SummonerId}");
            return await Leagues.ReadAsAsync<List<LeagueList>>();
        }
        public async Task<LeagueList> GetMasterLeaguesAsync(Region Reg, QueueType Que)
        {
            HttpContent MasterLeagues = await GetRequest(Reg.ToString(), $"/lol/league/v3/masterleagues/by-queue/{Que.ToString()}");
            return await MasterLeagues.ReadAsAsync<LeagueList>();
        }
        public async Task<List<LeaguePosition>> GetPositionsAsync(Region Reg, long SummonerId)
        {
            HttpContent Positions = await GetRequest(Reg.ToString(), $"/lol/league/v3/positions/by-summoner/{SummonerId}");
            return await Positions.ReadAsAsync<List<LeaguePosition>>();
        }

        public async Task<ShardStatus> GetStatusAsync(Region Reg)
        {
            HttpContent Status = await GetRequest(Reg.ToString(), $"/lol/status/v3/shard-data");
            return await Status.ReadAsAsync<ShardStatus>();
        }

        public async Task<MasteryPages> GetMasteryPagesAsync(Region Reg, long SummonerId)
        {
            HttpContent Masteries = await GetRequest(Reg.ToString(), $"/lol/platform/v3/masteries/by-summoner/{SummonerId}");
            return await Masteries.ReadAsAsync<MasteryPages>();
        }

        public async Task<Match> GetMatchAsync(Region Reg, long MatchId)
        {
            HttpContent Match = await GetRequest(Reg.ToString(), $"/lol/match/v3/matches/{MatchId}");
            return await Match.ReadAsAsync<Match>();
        }
        public async Task<Matchlist> GetMatchlistAsync(Region Reg, long AccountId)
        {
            HttpContent Matchlist = await GetRequest(Reg.ToString(), $"/lol/match/v3/matchlists/by-account/{AccountId}");
            return await Matchlist.ReadAsAsync<Matchlist>();
        }
        public async Task<Matchlist> GetRecentMatchlistAsync(Region Reg, long AccountId)
        {
            HttpContent Matchlist = await GetRequest(Reg.ToString(), $"/lol/match/v3/matchlists/by-account/{AccountId}/recent");
            return await Matchlist.ReadAsAsync<Matchlist>();
        }
        public async Task<MatchTimeline> GetTimelineAsync(Region Reg, long MatchId)
        {
            HttpContent Timeline = await GetRequest(Reg.ToString(), $"/lol/match/v3/timelines/by-match/{MatchId}");
            return await Timeline.ReadAsAsync<MatchTimeline>();
        }
        public async Task<List<long>> GetMatchIDsAsync(Region Reg, string TournamentCode)
        {
            HttpContent MatchIDs = await GetRequest(Reg.ToString(), $"/lol/match/v3/matches/by-tournament-code/{TournamentCode}/ids");
            return await MatchIDs.ReadAsAsync<List<long>>();
        }
        public async Task<Match> GetMatchAsync(Region Reg, long MatchId, string TournamentCode)
        {
            HttpContent Match = await GetRequest(Reg.ToString(), $"/lol/match/v3/matches/{MatchId}/by-tournament-code/{TournamentCode}");
            return await Match.ReadAsAsync<Match>();
        }

        public async Task<RunePages> GetRunePagesAsync(Region Reg, long SummonerId)
        {
            HttpContent Runes = await GetRequest(Reg.ToString(), $"/lol/platform/v3/runes/by-summoner/{SummonerId}");
            return await Runes.ReadAsAsync<RunePages>();
        }

        public async Task<CurrentGameInfo> GetActiveGameAsync(Region Reg, long SummonerId)
        {
            HttpContent ActiveGame = await GetRequest(Reg.ToString(), $"/lol/spectator/v3/active-games/by-summoner/{SummonerId}");
            return await ActiveGame.ReadAsAsync<CurrentGameInfo>();
        }
        public async Task<FeaturedGames> GetFeaturedGamesAsync(Region Reg)
        {
            HttpContent FeaturedGames = await GetRequest(Reg.ToString(), $"/lol/spectator/v3/featured-games");
            return await FeaturedGames.ReadAsAsync<FeaturedGames>();
        }

        public async Task<Summoner> GetSummonerAsync(Region Reg, Id IdType, long Id)
        {
            HttpContent Summoner;
            if(IdType == RiotWrapper.Id.Summoner)
            {
                Summoner = await GetRequest(Reg.ToString(), $"/lol/summoner/v3/summoners/{Id}");
            }
            else
            {
                Summoner = await GetRequest(Reg.ToString(), $"/lol/summoner/v3/summoners/by-account/{Id}");
            }
            return await Summoner.ReadAsAsync<Summoner>();
        }
        public async Task<Summoner> GetSummonerAsync(Region Reg, string SummonerName)
        {
            HttpContent Summoner = await GetRequest(Reg.ToString(), $"/lol/summoner/v3/summoners/by-name/{SummonerName}");
            return await Summoner.ReadAsAsync<Summoner>();
        }

        private async Task<HttpContent> GetRequest(string Region, string UrlExtension)
        {
            if(Startup == false)
            {
                if(Limiter.CheckRateLimit())
                {
                    Startup = true;
                }
            }

            using (HttpClient Client = new HttpClient(new HttpClientHandler()
            {
                UseProxy = false
            }))
            {
                Client.BaseAddress = new Uri("https://" + Region.ToLower() + ".api.riotgames.com/api");
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                            
                HttpResponseMessage Respone = await Client.GetAsync($"{UrlExtension}?api_key={Token}");
                Console.WriteLine(Respone);

                var AppHeader = Respone.Headers.FirstOrDefault(x => x.Key == "X-App-Rate-Limit-Count");

                if (Startup)
                {
                    Limiter.InitializeAppStartupTime(AppHeader);
                    Startup = false;
                }
                else
                {
                    Limiter.AppRequests++;
                }
                return Respone.Content;
            }
        }
    }
}
