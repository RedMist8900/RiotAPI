using RiotAPI.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiotAPI.View.ViewModel
{
    public class ViewModelProfile
    {
        public string SummonerName { get; private set; }
        public string ProfileIconId { get; private set; }
        public long SummonerLevel { get; private set; }
        public long RevisionDate { get; private set; }
        public string AccountId { get; private set; }
        public string Id { get; private set; }
        public string PuuID { get; private set; }

        public ViewModelProfile(string summonerName, int icon, long level, long revision, string accountid, string id, string puuid)
        {
            SummonerName = summonerName;
            ProfileIconId = "" + icon + "";
            SummonerLevel = level;
            RevisionDate = revision;
            Id = id;
            AccountId = accountid;
            PuuID = puuid;
        }
    }
}
