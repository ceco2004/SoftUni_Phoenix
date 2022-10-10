using System;
using System.Collections.Generic;

namespace _03_ProductSHop
{
    class ProductSHop
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shopProductPrice = new SortedDictionary<string, Dictionary<string, double>>();

            string input = Console.ReadLine();

            while(input != "Revision")
            {
                string[] data = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = data[0];
                string product = data[1];
                double price = double.Parse(data[2]);

                if(shopProductPrice.ContainsKey(shop) == false)
                {
                    shopProductPrice[shop] = new Dictionary<string, double>();
                }

                shopProductPrice[shop][product] = price;

                input = Console.ReadLine();
            }

            foreach(var shop in shopProductPrice)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach(var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value:f2}");
                }
            }
        }
    }
}
