using RiotAPI.API;
using RiotAPI.Model;
using RiotAPI.Utils;
using RiotAPI.View.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiotAPI.Controller
{
    public class ControllerProfile
    {
        public object GetContext()
        {
            var summoner = Constants.Summoner;
            var position = GetPosition(summoner);

            return new ViewModelProfile(summoner.Name, summoner.ProfileIconID, summoner.SummonerLevel, position.Tier, position.Rank,
                position.Wins, position.Losses);
        }

        private PositionDTO GetPosition(SummonerDTO summoner)
        {
            League_V4 league = new League_V4(Constants.Region);

            var position = league.GetPosition(summoner.ID).Where(p => p.QueueType.Equals("RANKED_SOLO_5x5")).FirstOrDefault();

            Constants.Summoner = summoner;

            return position ?? new PositionDTO();
        }

        public void OpenMain()
        {
            MainWindow profile = new MainWindow();
            profile.Show();
        }
    }
}
