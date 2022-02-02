using RiotAPI.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiotAPI.View.ViewModel
{
    public class ViewModelProfile
    {
        public string SummonerName { get; private set; }
        public string Icon { get; private set; }
        public long Level { get; private set; }
        public string Tier { get; private set; }
        public string Rank { get; private set; }
        public string Emblem { get; private set; }
        public int Wins { get; private set; }
        public int Losses { get; private set; }

        public ViewModelProfile(string summonerName, int icon, long level, string tier, string rank, int wins, int losses)
        {
            SummonerName = summonerName;
            Icon = "http://opgg-static.akamaized.net/images/profile_icons/profileIcon" + icon + ".jpg";
            Level = level;
            Tier = tier;
            Rank = rank;
            Wins = wins;
            Losses = losses;
            string workingDirectory = Environment.CurrentDirectory;
            Emblem = System.IO.Directory.GetParent(workingDirectory).Parent.Parent.FullName + "/Assets/emblems/Emblem_" + tier + ".png";
            //Emblem = "C:/Users/niko341n/source/repos/RiotAPI/RiotAPI/Assets/emblems/Emblem_" + tier.ToLower() + ".png";
        }
    }
}
