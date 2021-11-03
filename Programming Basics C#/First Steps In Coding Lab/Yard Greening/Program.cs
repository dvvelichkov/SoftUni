using System;

namespace Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMeters = double.Parse(Console.ReadLine());
            const double pricePerSquareMeter = 7.61;
            double finalPrice = 0.82 * squareMeters * pricePerSquareMeter;
            double discount = 0.18 * squareMeters * pricePerSquareMeter;
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
