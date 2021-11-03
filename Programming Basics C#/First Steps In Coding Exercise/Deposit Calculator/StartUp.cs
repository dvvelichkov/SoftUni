using System;

namespace Deposit_Calculator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double depositAmount = double.Parse(Console.ReadLine());
            int depositMaturityInMonths = int.Parse(Console.ReadLine());
            double annualInterestPercentage = double.Parse(Console.ReadLine());
            double interestAmountperYear = (depositAmount * annualInterestPercentage)/100;
            double interestAmountperMonth = interestAmountperYear / 12;
            double endSum = depositAmount + (depositMaturityInMonths * interestAmountperMonth);
            Console.WriteLine($"{endSum:f2}");
        }
    }
}
