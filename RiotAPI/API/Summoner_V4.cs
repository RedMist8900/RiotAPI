using RiotAPI.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiotAPI.API
{
    public class Summoner_V4 : Api
    {
        public Summoner_V4(string region) : base(region)
        {
        }

        public SummonerDTO GetSummonerByName(string SummonerName)
        {
            string path = "summoner/v4/summoners/by-name/" + SummonerName;

            var response = GetHashCode(GetURI(path));
        }

    }
}
