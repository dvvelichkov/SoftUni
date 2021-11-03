using System;

namespace Pet_Shop
{
    class StartUp
    {
        static void Main(string[] args)
        {
            const double priceOfDogFood = 2.50;
            const double priceOfOtherAnimalsFood = 4;
            int countOfDogs = int.Parse(Console.ReadLine());
            int countOfOtherAnimals = int.Parse(Console.ReadLine());
            double endSum = priceOfDogFood * countOfDogs + priceOfOtherAnimalsFood * countOfOtherAnimals;
            Console.WriteLine($"{endSum} lv.");
        }
    }
}
