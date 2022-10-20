using System;

namespace Ex04._OnlineRadioDatabase.Models.Exeptions
{
    public class InvalidSongLengthException :Exception
    {
        public override string Message => "Invalid song length.";
    }
}
