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
            //var position = GetPosition(summoner);

            return new ViewModelProfile(summoner.Name, summoner.ProfileIconID, summoner.SummonerLevel, summoner.RevisionDate, summoner.AccountID, summoner.ID, summoner.PuuID);
        }

        //private SummonerDTO GetSummoner(SummonerDTO summoner)
        //{
        //    Summoner_V4 summoner_V4 = new Summoner_V4(Constants.Region);

        //    var summoner = summoner_V4.GetSummonerByName(summonerName);

        //    Constants.Summoner = summoner;

        //    return position ?? new PositionDTO();
        //}

        public void OpenMain()
        {
            MainWindow profile = new MainWindow();
            profile.Show();
        }
    }
}
