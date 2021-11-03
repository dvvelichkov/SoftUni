using System;

namespace Toy_Shop
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double priceOfExcursion = double.Parse(Console.ReadLine());
            int countOfPuzzles = int.Parse(Console.ReadLine());
            int countOfTalkingDolls = int.Parse(Console.ReadLine());
            int countOfTeddyBears = int.Parse(Console.ReadLine());
            int countOfMinions = int.Parse(Console.ReadLine());
            int countOfToyTrucks = int.Parse(Console.ReadLine());
            const double puzzlePrice = 2.60;
            const double talkingDollPrice = 3;
            const double teddyBearPrice = 4.10;
            const double minionPrice = 8.20;
            const double toyTruckPrice = 2;
            int totalToysOrdered = countOfPuzzles + countOfTalkingDolls + countOfTeddyBears + countOfMinions + countOfToyTrucks;
            double totalSumOfOrder = (countOfPuzzles * puzzlePrice) + (countOfTalkingDolls * talkingDollPrice) + (countOfTeddyBears * teddyBearPrice)
                + (countOfMinions * minionPrice) + (countOfToyTrucks * toyTruckPrice);
            if (totalToysOrdered >= 50)
            {
                totalSumOfOrder = 0.75 * totalSumOfOrder;
            }
            double endSumEarned = 0.9 * totalSumOfOrder;
            double sumLeftForExcursion = Math.Abs(endSumEarned - priceOfExcursion);
            if (endSumEarned > priceOfExcursion)
            {
                Console.WriteLine($"Yes! {sumLeftForExcursion:f2} lv left.");
            }
            else if (endSumEarned < priceOfExcursion)
            {
                Console.WriteLine($"Not enough money! {sumLeftForExcursion:f2} lv needed.");
            }
        }
    }
}
