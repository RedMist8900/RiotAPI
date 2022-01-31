using RiotAPI.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RiotAPI.View.ViewModel
{
    public class ViewModelMain : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new
                PropertyChangedEventArgs(propName));
            }
        }

        string region;
        public string Region
        {
            get { return region; }
            set { region = value; Constants.Region = value; RaisePropertyChanged("Region"); }
        }

        string summonerName;
        public string SummonerName
        {
            get { return summonerName; }
            set { summonerName = value; RaisePropertyChanged("SummonerName"); }
        }
    }
}
