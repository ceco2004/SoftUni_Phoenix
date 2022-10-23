using _04._Telephony.Models.Interfaces;

namespace _04._Telephony.Models
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Browse(string url)
        {
            return $"Browsing: {url}";
        }

        public string Call(string number)
        {
            return $"Calling... {number}";
        }
    }
}
