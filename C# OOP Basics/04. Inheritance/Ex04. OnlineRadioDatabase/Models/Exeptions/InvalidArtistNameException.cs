using System;

namespace Ex04._OnlineRadioDatabase.Models.Exeptions
{
    public class InvalidArtistNameException : Exception
    {
        public override string Message => "Artist name should be between 3 and 20 symbols.";
    }
}
