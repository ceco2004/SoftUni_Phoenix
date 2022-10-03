using System;

namespace Ex07._HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceApartment = 0;

            int studioDiscount = 0;
            int apartmentDiscount = 0;

            if(month == "May" || month == "October")
            {
                priceStudio = 50;
                priceApartment = 65;

                if(nights > 14)
                {
                    studioDiscount = 30;
                }
                else if(nights > 7)
                {
                    studioDiscount = 5;
                }
            }
            else if (month == "June" || month == "September")
            {
                priceStudio = 75.2;
                priceApartment = 68.7;

                if(nights > 14)
                {
                    studioDiscount = 20;
                }
            }
            else if (month == "July" || month == "August")
            {
                priceStudio =76;
                priceApartment = 77;
            }

            if(nights > 14)
            {
                apartmentDiscount = 10;
            }

            double priceStudioTotal = nights * priceStudio;
            double priceStudioWithDiscount = priceStudioTotal - priceStudioTotal * studioDiscount / 100;

            double priceApartmentTotal = nights * priceApartment;
            double priceApartmentWithDiscount = priceApartmentTotal - priceApartmentTotal * apartmentDiscount / 100;

            Console.WriteLine($"Apartment: {priceApartmentWithDiscount:f2} lv.");
            Console.WriteLine($"Studio: {priceStudioWithDiscount:f2} lv.");

        }
    }
}
