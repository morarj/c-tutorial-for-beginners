using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 10 && hour < 12)
            {
                Console.WriteLine("Good morning!");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Good afternoon!");
            }
            else
            {
                Console.WriteLine("Good night!");
            }

            bool isGoldCustomer = true;
            float price;

            price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);

            var season = Seasons.Autumn;

            switch (season)
            {
                case Seasons.Autumn:
                    Console.WriteLine("Its autumn!");
                    break;
                case Seasons.Winter:
                    Console.WriteLine("Its winter!");
                    break;
                default:
                    Console.WriteLine("No season!");
                    break;
            }

            switch (season)
            {
                case Seasons.Autumn:
                case Seasons.Winter:
                    Console.WriteLine("Promotion time!");
                    break;
                default:
                    Console.WriteLine("No promotion!");
                    break;
            }
        }
    }
}
