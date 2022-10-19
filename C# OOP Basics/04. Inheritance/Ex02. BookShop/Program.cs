using Ex02._BookShop.Models;
using System;

namespace Ex02._BookShop
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Hihi hi", "fdsfd fdfs", 100);

            GoldenEditionBook gb = new GoldenEditionBook("Hihi hi", "fdsfd fdfs", 100);
            
            Console.WriteLine(gb);
        }
    }
}
