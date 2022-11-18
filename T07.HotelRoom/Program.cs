using System;

namespace T07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = nights * 50;
                apartmentPrice = nights * 65;
                if (nights > 14)
                {
                    apartmentPrice = apartmentPrice - apartmentPrice * 0.10;
                    studioPrice = studioPrice - studioPrice * 0.30;
                }
                else if (nights > 7)
                {
                    studioPrice = studioPrice - studioPrice * 0.05;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = nights * 75.20;
                apartmentPrice = nights * 68.70;
                if (nights > 14)
                {
                    apartmentPrice = apartmentPrice - apartmentPrice * 0.10;
                    studioPrice = studioPrice - studioPrice * 0.20;
                }
            }
            else
            {
                studioPrice = nights * 76;
                apartmentPrice = nights * 77;
                if (nights > 14)
                {
                    apartmentPrice = apartmentPrice - apartmentPrice * 0.10;
                }
            }
            Console.WriteLine($"Apartment: {apartmentPrice:F2} lv.");
            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
        }
    }
}
