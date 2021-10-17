using System;

namespace Godzilla_vs._Kong
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int numberOfBackgroundActorsCasted = int.Parse(Console.ReadLine());
            double priceOfPropsPerBackgroundActor = double.Parse(Console.ReadLine());
            double movieDecorPrice = 0.1 * movieBudget;
            double costsOfPropsBackgroundActors = numberOfBackgroundActorsCasted * priceOfPropsPerBackgroundActor;
            double discountOfPropsBackgroundActors = 0.1 * costsOfPropsBackgroundActors; 
            if (numberOfBackgroundActorsCasted > 150)
            {
                costsOfPropsBackgroundActors = costsOfPropsBackgroundActors - discountOfPropsBackgroundActors;
            }
            double totalMoneyNeeded = costsOfPropsBackgroundActors + movieDecorPrice;
            if (totalMoneyNeeded > movieBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(totalMoneyNeeded - movieBudget):f2} leva more.");
            }
            else if (totalMoneyNeeded <= movieBudget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(movieBudget - totalMoneyNeeded):f2} leva left.");
            }
        }
    }
}
