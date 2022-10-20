using System;

namespace Ex04._OnlineRadioDatabase.Models.Exeptions
{
    public class InvalidSongSecondsException : Exception
    {
        public override string Message => "Song seconds should be between 0 and 59.";
     }
}
