using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main()
        {
            int hour = 13;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("Morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Afternoon");
            }
            else
            {
                Console.WriteLine("Evening");
            }

            bool isGoldCustomer = true;
            float price;

            if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            }

            Console.WriteLine(price);

            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("Autumn");
                    break;

                case Season.Summer:
                    Console.WriteLine("Summer");
                    break;

                case Season.Spring:
                case Season.Winter:
                    Console.WriteLine("Winter");
                    break;

                default:
                    Console.WriteLine("WHAT");
                    break;
            }
        }
    }
}
