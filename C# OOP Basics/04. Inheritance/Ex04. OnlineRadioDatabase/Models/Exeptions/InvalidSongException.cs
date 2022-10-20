using System;

namespace Ex04._OnlineRadioDatabase.Models.Exeptions
{
    public class InvalidSongException : Exception
    {
        public override string Message => "Invalid song.";
    }
}
