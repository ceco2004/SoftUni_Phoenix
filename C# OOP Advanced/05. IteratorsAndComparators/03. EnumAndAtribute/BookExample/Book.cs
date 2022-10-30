namespace _03._EnumAndAtribute.BookExample
{
    [Author("Ceco")]
    [Author("Pufi")]
    public class Book
    {
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public int Year { get; set; }
    }
}
