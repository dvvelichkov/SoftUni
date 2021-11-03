using System;

namespace Fruit_Market
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double priceOfStrawberries = double.Parse(Console.ReadLine());
            double priceOfRaspberries = 0.5 * priceOfStrawberries;
            double priceOfOranges = 0.6 * priceOfRaspberries;
            double priceOfBananas = 0.2 * priceOfRaspberries;
            double quantityOfBananas = double.Parse(Console.ReadLine());
            double quantityOfOranges = double.Parse(Console.ReadLine());
            double quantityOfRaspberries = double.Parse(Console.ReadLine());
            double quantityOfStrawberries = double.Parse(Console.ReadLine());
            double sumNeeded = priceOfStrawberries * quantityOfStrawberries + priceOfBananas * quantityOfBananas + 
                priceOfOranges * quantityOfOranges + priceOfRaspberries * quantityOfRaspberries;
            Console.WriteLine(sumNeeded);

        }
    }
}
