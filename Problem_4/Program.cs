using System;
using System.Collections.Generic;

namespace Problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string artistName, songName;
            int minutes, seconds, count;

            Console.Write("Enter the number of songs: ");
            count = Convert.ToInt32(Console.ReadLine());

            List<RadioDB> radioDBs = new List<RadioDB>(count);

            for(int i = 0; i < count; i++)
            {
                Console.Write("Enter an artist name: ");
                artistName =Console.ReadLine();

                Console.Write("Enter a song name: ");
                songName = Console.ReadLine();

                Console.Write("Enter minutes: ");
                minutes = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter seconds: ");
                seconds = Convert.ToInt32(Console.ReadLine());

                radioDBs.Add(new RadioDB(artistName, songName, minutes, seconds));
            }

            Console.WriteLine(RadioDB.getCountAddedSongs());
            Console.WriteLine(RadioDB.getPlaylistLength());

        }
    }
}
