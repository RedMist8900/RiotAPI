using System;
using System.Collections.Generic;
using System.Text;

namespace RiotAPI.Model
{
    public class PositionDTO
    {
        public string Tier { get; set; }
        public string Rank { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public string QueueType { get; set; }
        public int LeaguePoints { get; set; }
        public Boolean HotStreak { get; set; }
        public Boolean Veteran { get; set; }
        public Boolean FreshBlood { get; set; }
        public Boolean Inactive { get; set; }
    }
}
