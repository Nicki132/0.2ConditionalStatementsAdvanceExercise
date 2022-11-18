using System;

namespace T04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());

            double price = 0.00;

            switch (season)
            {
                case "Spring":
                    price = 3000.00;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200.00;
                    break;
                case "Winter":
                    price = 2600.00;
                    break;
                default:
                    break;
            }
            if (fisherman <= 6)
            {
                price -= price * 0.10;
            }
            else if (fisherman <= 11)
            {
                price -= price * 0.15;
            }
            else
            {
                price -= price * 0.25;
            }
            if (fisherman % 2 == 0 && season != "Autumn")
            {
                price -= price * 0.05;
            }
            if (budget <= price)
            {
                Console.WriteLine($"Yes! You have {(budget-price):F2} leva left.");
            }
            else 
            {
                Console.WriteLine($"Not enough money! You need {(price-budget):F2} leva.");
            }
        }
    }
}
