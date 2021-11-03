using System;

namespace Charity_Campaign
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int daysOfCampaign = int.Parse(Console.ReadLine());
            int countOfBakers = int.Parse(Console.ReadLine());
            int countOfCakes = int.Parse(Console.ReadLine());
            int countOfWaffles = int.Parse(Console.ReadLine());
            int countOfPancakes = int.Parse(Console.ReadLine());
            const double pricePerCake = 45;
            const double pricePerWaffle = 5.80;
            const double pricePerPancake = 3.20;
            double sumGatheredDaily = countOfBakers * (countOfCakes * pricePerCake + countOfWaffles * pricePerWaffle + countOfPancakes * pricePerPancake);
            double endSumGathered = 7*(sumGatheredDaily * daysOfCampaign)/8;
            Console.WriteLine(endSumGathered);
        }
    }
}
