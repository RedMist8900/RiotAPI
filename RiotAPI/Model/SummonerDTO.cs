using System;
using System.Collections.Generic;
using System.Text;

namespace RiotAPI.Model
{
    public class SummonerDTO
    {
        public string AccountID { get; set; }
        public int ProfileIconID { get; set; }
        public long RevisionDate { get; set; }
        public string Name { get; set; }
        public string ID { get; set; }
        public string PuuID { get; set; }
        public long SummonerLevel { get; set; }
    }
}
