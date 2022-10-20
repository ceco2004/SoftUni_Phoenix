using Ex04._OnlineRadioDatabase.Models.Exeptions;
using System;
using System.Linq;

namespace Ex04._OnlineRadioDatabase.Models
{
    public class Song
    {
        private string artistName;
        private string songName;

        public string ArtistName { get => artistName; set => artistName = ValidateArtist(value); }
        public string SongName { get => songName; set => songName = ValidateSong(value); }
        public TimeSpan Length { get; private set; }

        public Song(string artistName, string songName, string length)
        {
            ArtistName = artistName;
            SongName = songName;
            Length = ValidateTime(length);
        }

        private TimeSpan ValidateTime(string time)
        {
            int[] data = time
                .Split(":", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();


            if (data[1] > 59 || data[1] < 0)
            {
                throw new InvalidSongSecondsException();
            }

            if (data[0] > 14 || data[0] < 0)
            {
                throw new InvalidSongSeException();
            }


            return new TimeSpan(0, data[0], data[1]);
        }

        private string ValidateSong(string song)
        {
            if(song.Length < 3 || song.Length > 20)
            {
                throw new InvalidSongException();
            }
            return song;
        }

        private string ValidateArtist(string artist)
        {
            if(artist.Length < 3 || artist.Length > 20)
            {
                throw new InvalidArtistNameException();
            }
            return artist;
        }
    }
}
