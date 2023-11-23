using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Booking
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private ObservableCollection<Places> Places;

        public ObservableCollection<Places> places
        {
            get { return Places; }
            set
            {
                Places = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("places"));
            }
        }


        public MainViewModel()
        {
            places = new ObservableCollection<Places>();
            addData();
        }

        private void addData()
        {
            places.Add(new Places
            {

                id = 0,
                title = "The beautiful lake",
                country = "Norway",
                imgSource = "https://as2.ftcdn.net/v2/jpg/04/22/04/33/1000_F_422043308_OIsF1tLRNb8KJmqO880d86g9NPeKx80B.jpg"
            });
            places.Add(new Places
            {

                id = 0,
                title = "Snowy snow",
                country = "Nepal",
                imgSource = "https://www.nepalhikingteam.com/wp-content/uploads/2017/08/Everest-1024x683.jpg"
            });
            places.Add(new Places
            {

                id = 0,
                title = "Beach is to chill",
                country = "Malaysia",
                imgSource = "https://www.touropia.com/gfx/d/best-beaches-in-malaysia/sipadan_island.jpg"
            });
        }
    }
}
