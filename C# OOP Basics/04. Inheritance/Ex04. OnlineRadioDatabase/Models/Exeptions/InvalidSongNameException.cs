using System;

namespace Ex04._OnlineRadioDatabase.Models.Exeptions
{
    public class InvalidSongNameException : Exception
    {
        public override string Message => "Song name should be between 3 and 30 symbols.";
    }
}
