using System;

namespace Ex06._CinemaTiketrs
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();

            int studentTickets = 0;
            int kidTickets = 0;
            int standartTickets = 0;

            while(movie != "Finish")
            {
                int availabePlaces = int.Parse(Console.ReadLine());
                double buyingPlaces = 0;

                while(availabePlaces > buyingPlaces)
                {
                    string ticket = Console.ReadLine();

                    if (ticket == "End")
                    {
                        break;
                    }

                    switch (ticket)
                    {
                        case "student": studentTickets++; break;
                        case "standard": standartTickets++; break;
                        case "kid": kidTickets++; break;
                    }

                   buyingPlaces++;
                }

                Console.WriteLine($"{movie} - {buyingPlaces / availabePlaces * 100:f2}% full.");


                movie = Console.ReadLine();
            }
            int totalTickets = standartTickets + studentTickets + kidTickets;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{1.0*studentTickets / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{1.0*standartTickets / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{1.0*kidTickets / totalTickets * 100:f2}% kids tickets.");
        }
    }
}
