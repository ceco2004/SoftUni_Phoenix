using System;
using System.Text;

namespace Ex02._BookShop.Models
{
    public class Book
    {
        private const string notValidAuthor = "Author not valid!";
        private const string notValidTitle = "Title not valid!";
        private const string notValidPrice = "Price not valid!";

        private string title;
        private string author;
        private decimal price;

        public string Title { get => title; set => title = ValidateTitle(value); }
        public string Author { get => author; set => author = ValidateAuthor(value); }
        public virtual decimal Price { get => price; set => price = ValidatePrice(value); }

        public Book(string title, string author, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Type: {GetType().Name}");
            sb.AppendLine($"Title: {Title}");
            sb.AppendLine($"Author: {Author}");
            sb.AppendLine($"Price: {Price:f2}");

            return sb.ToString();
        }
        protected decimal ValidatePrice(decimal price)
        {
            if(price <= 0)
            {
                throw new ArgumentException(notValidPrice);
            }
            return price;
        }

        private string ValidateAuthor(string author)
        {
            string[] data = author.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            bool isInvalid = data.Length != 2 || char.IsDigit(data[0][0]) || char.IsDigit(data[1][0]);

            if (isInvalid)
            {
                throw new ArgumentException(notValidAuthor);
            }
            return author;
        }

        private string ValidateTitle(string title)
        {
            if(title.Length < 3)
            {
                throw new ArgumentException(notValidTitle);
            }
            return title;
        }
    }
}
