using Newtonsoft.Json;
using RiotAPI.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiotAPI.API
{
    public class League_V4 : Api
    {
        public League_V4(string region) : base(region)
        {
        }

        public List<PositionDTO> GetPosition(string summonerId)
        {
            string path = "league/v4/entries/by-summoner/" + summonerId;

            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<List<PositionDTO>>(content);
            }
            else
            {
                return null;
            }
        }
    }
}
