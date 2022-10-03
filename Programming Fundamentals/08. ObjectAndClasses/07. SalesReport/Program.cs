using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            SortedDictionary<string, List<Sales>> sales = new SortedDictionary<string, List<Sales>>();

            for(int i = 0; i < count; i++)
            {
                Sales sale = ReadSale();

                if(sales.ContainsKey(sale.Town) == false)
                {
                    sales[sale.Town] = new List<Sales>();
                }

                sales[sale.Town].Add(sale);
            }

            foreach(var town in sales)
            {
                Console.WriteLine($"{town.Key} -> {town.Value.Sum(x => x.Sum):f2}");
            }
        }

        static Sales ReadSale()
        {
            string[] data = Console.ReadLine().Split().ToArray();
            string town = data[0];
            string product = data[1];
            double price = double.Parse(data[2]);
            double quantity = double.Parse(data[3]);

            Sales sale = new Sales();
            sale.Town = town;
            sale.Product = product;
            sale.Price = price;
            sale.Quantity = quantity;

            sale.Calculate();

            return sale;
        }
    }

    

    class Sales
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public double Sum { get; private set; }

        public Sales() { }

        public void Calculate()
        {
            this.Sum = this.Price * this.Quantity;
        }
    }
}
