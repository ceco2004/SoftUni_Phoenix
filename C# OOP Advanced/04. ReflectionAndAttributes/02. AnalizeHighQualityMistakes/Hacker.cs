namespace _02._AnalizeHighQualityMistakes
{
    [Author("Ceco")]
    [Author("Mr.X")]
    public class Hacker
    {
        public string username = "securityGod82";
        private string password = "mySuperSecretPassw0rd";

        public string Password
        {
            get => this.password;
            set => this.password = value;
        }

        private int Id { get; set; }

        public double BankAccountBalance { get; private set; }

        [Author("Ceco")]
        [Author("Mr.X")]
        public void DownloadAllBankAccountsInTheWorld()
        {
        }

        [Author("Ceco")]
        [Author("Mr.X")]
        public static void SomeMethod()
        {

        }
    }

}
