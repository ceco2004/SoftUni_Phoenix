using Ex04._OnlineRadioDatabase.Models;
using System;
using System.Collections.Generic;

namespace Ex04._OnlineRadioDatabase
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();

            int numbersOfSongs = int.Parse(Console.ReadLine());


            for(int i = 0; i < numbersOfSongs; i++)
            {
                try
                {
                    AddSong(songs);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
            int totalSec = 0;
            songs.ForEach(s => totalSec += (int)s.Length.TotalSeconds);
            TimeSpan time = new TimeSpan(0, 0, totalSec);

            Console.WriteLine($"Song added: {songs.Count}");
            Console.WriteLine($"Playlist length: {time.Hours:d2}h {time.Minutes:d2}m {time.Seconds:d2}s");
        }

        private static void AddSong(List<Song> songs)
        {
            string[] data = Console.ReadLine().Split(";");
            string artistName = data[0];
            string songName = data[1];
            string length = data[2];

            Song song = new Song(artistName, songName, length);
            songs.Add(song);
            Console.WriteLine("Song added.");
        }
    }
}
