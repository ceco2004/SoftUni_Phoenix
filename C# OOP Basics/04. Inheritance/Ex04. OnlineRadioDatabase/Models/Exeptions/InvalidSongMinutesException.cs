using System;

namespace Ex04._OnlineRadioDatabase.Models.Exeptions
{
    public class InvalidSongSeException : Exception
    {
        public override string Message => "Song minutes should be between 0 and 14.";
    }
}
