using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_4
{
    class RadioDB
    {
        private string artistName;
        private string songName;
        private double minutes;
        private double seconds;
        static DateTime playlistLength = new DateTime();
        static int countAddedSongs = 0;

        public RadioDB(string artistName, string songName, int minutes, int seconds)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.Minutes = minutes;
            this.Seconds = seconds;

            countAddedSongs++;
            Console.WriteLine("Song added");
        }

        public string ArtistName
        {
            get
            { 
                return artistName; 
            }
            set 
            {
                if (value.Length < 3 || value.Length >= 20)
                    throw new Exception("Artist name should be between 3 and 20 symbols.");

                artistName = value;
            }
        }

        public string SongName
        {
            get
            { 
                return songName;
            }
            set
            {
                if (value.Length < 3 || value.Length >= 30)
                {
                    throw new Exception("Song name should be between 3 and 30 symbols.");
                }    

                songName = value;
            }
        }

        public double Minutes
        {
            get 
            { 
                return minutes;
            }
            set
            {
                if (value < 0 || value > 14)
                {
                    throw new Exception("Song minutes should be between 0 and 14.");
                }                    

                minutes = value;
                playlistLength = playlistLength.AddMinutes(minutes);
            }
        }

        public double Seconds
        {
            get
            {
                return seconds;
            }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new Exception("Song seconds should be between 0 and 59.");
                }

                seconds = value;
                playlistLength = playlistLength.AddSeconds(seconds);
            }
        }


        public static string getPlaylistLength()
        {
            return playlistLength.ToLongTimeString();
        }

        public static int getCountAddedSongs()
        {
            return countAddedSongs;
        }
    }
}
