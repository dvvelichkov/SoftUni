using System;

namespace Birthday_party
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double rentForTheHall = double.Parse(Console.ReadLine());
            double priceOfCake = 0.2 * rentForTheHall;
            double priceOfDrinks = 0.55 * priceOfCake;
            double priceOfAnimator = rentForTheHall / 3;
            double endSumNeeded = rentForTheHall + priceOfCake + priceOfDrinks + priceOfAnimator;
            Console.WriteLine(endSumNeeded);
        }
    }
}
