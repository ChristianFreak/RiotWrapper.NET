using RiotWrapper.Static.Champions;
using RiotWrapper.Static.Items;
using RiotWrapper.Static.Maps;
using RiotWrapper.Static.Masteries;
using RiotWrapper.Static.Realms;
using RiotWrapper.Static.Runes;
using RiotWrapper.Static.SummonerSpells;
using System; 
using System.Collections.Generic;
using System.Net.Cache;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RiotWrapper.Static
{
    public class StaticApiCaller
    {
        private string Token { get; set; }

        public StaticApiCaller(string Token)
        {
            this.Token = Token;
        }

        public async Task<StaticChampionList> GetChampionsAsync(Region Reg, ChampionDataStyle? CData = null)
        {
            HttpContent Champions = await GetRequest(Reg.ToString(), DefineUrl("champions", CData.ToString()));
            return await Champions.ReadAsAsync<StaticChampionList>();
        }
        public async Task<StaticChampion> GetChampionAsync(Region Reg, int ChampionId, ChampionDataStyle? CData = null)
        {
            HttpContent Champion = await GetRequest(Reg.ToString(), DefineUrl("champions/" + ChampionId, CData.ToString()));
            return await Champion.ReadAsAsync<StaticChampion>();
        }

        public async Task<StaticItemList> GetItemsAsync(Region Reg, ItemDataStyle? IData = null)
        {
            HttpContent Items = await GetRequest(Reg.ToString(), DefineUrl("items", IData.ToString()));
            return await Items.ReadAsAsync<StaticItemList>();
        }
        public async Task<StaticItem> GetItemAsync(Region Reg, int Id, ItemDataStyle? IData = null)
        {
            HttpContent Item = await GetRequest(Reg.ToString(), DefineUrl("items/" + Id, IData.ToString()));
            return await Item.ReadAsAsync<StaticItem>();
        }

        public async Task<StaticRuneList> GetRunesAsync(Region Reg, RuneDataStyle? RData = null)
        {
            HttpContent Runes = await GetRequest(Reg.ToString(), DefineUrl("runes", RData.ToString()));
            return await Runes.ReadAsAsync<StaticRuneList>();
        }
        public async Task<StaticRune> GetRuneAsync(Region Reg, int Id, RuneDataStyle? RData = null)
        {
            HttpContent Rune = await GetRequest(Reg.ToString(), DefineUrl("runes/" + Id, RData.ToString()));
            return await Rune.ReadAsAsync<StaticRune>();
        }

        public async Task<StaticMasteryList> GetMasteriesAsync(Region Reg, MasteryDataStyle? MData = null)
        {
            HttpContent Masteries = await GetRequest(Reg.ToString(), DefineUrl("masteries", MData.ToString()));
            return await Masteries.ReadAsAsync<StaticMasteryList>();
        }
        public async Task<StaticMastery> GetMasteryAsync(Region Reg, int Id, MasteryDataStyle? MData = null)
        {
            HttpContent Mastery = await GetRequest(Reg.ToString(), DefineUrl("masteries/" + Id, MData.ToString()));
            return await Mastery.ReadAsAsync<StaticMastery>();
        }

        public async Task<StaticSummonerSpellList> GetSummonerSpellsAsync(Region Reg, SummonerSpellDataStyle? SData = null)
        {
            HttpContent SummonerSpells = await GetRequest(Reg.ToString(), DefineUrl("summoner-spells", SData.ToString()));
            return await SummonerSpells.ReadAsAsync<StaticSummonerSpellList>();
        }
        public async Task<StaticSummonerSpell> GetSummonerSpellAsync(Region Reg, int Id, SummonerSpellDataStyle? SData = null)
        {
            HttpContent SummonerSpell = await GetRequest(Reg.ToString(), DefineUrl("summoner-spells/" + Id, SData.ToString()));
            return await SummonerSpell.ReadAsAsync<StaticSummonerSpell>();
        }

        public async Task<List<string>> GetLanguageListAsync(Region Reg)
        {
            HttpContent LanguageList = await GetRequest(Reg.ToString(), DefineUrl("languages"));
            return await LanguageList.ReadAsAsync<List<string>>();
        }
        public async Task<List<string>> GetLanguageStringListAsync(Region Reg)
        {
            HttpContent LanguageStringList = await GetRequest(Reg.ToString(), DefineUrl("languages-strings"));
            return await LanguageStringList.ReadAsAsync<List<string>>();
        }

        public async Task<StaticMapData> GetMapsAsync(Region Reg)
        {
            HttpContent Maps = await GetRequest(Reg.ToString(), DefineUrl("maps"));
            return await Maps.ReadAsAsync<StaticMapData>();
        }
        public async Task<StaticRealm> GetRealmAsync(Region Reg)
        {
            HttpContent Realm = await GetRequest(Reg.ToString(), DefineUrl("realms"));
            return await Realm.ReadAsAsync<StaticRealm>();
        }
        public async Task<List<string>> GetVersionListAsync(Region Reg)
        {
            HttpContent Versions = await GetRequest(Reg.ToString(), DefineUrl("version"));
            return await Versions.ReadAsAsync<List<string>>();
        }

        private async Task<HttpContent> GetRequest(string Region, string Url)
        {
            using (HttpClient Client = new HttpClient(new WebRequestHandler()
            {
                UseProxy = false,
                CachePolicy = new RequestCachePolicy(RequestCacheLevel.CacheIfAvailable)
            }))
            {
                Client.BaseAddress = new Uri("https://" + Region.ToLower() + ".api.riotgames.com/api");
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Respone = await Client.GetAsync(Url);
                return Respone.Content;                           
            }
        }
        private string DefineUrl(string UrlExtension, string DataStyle = null)
        {
            string Url = "/lol/static-data/v3/" + UrlExtension + "?api_key=" + Token;
            if (DataStyle != null)
            {
                Url = Url + "&tags=" + DataStyle;
            }
            return Url;
        }
    }
}
