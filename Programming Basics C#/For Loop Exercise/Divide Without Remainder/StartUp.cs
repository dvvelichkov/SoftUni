using System;

namespace Divide_Without_Remainder
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;

            double doubleConverter = 1;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num%2 == 0)
                {
                    p1 += 1;
                }
                if (num%3 == 0)
                {
                    p2 += 1;
                }
                if (num%4 == 0)
                {
                    p3 += 1;
                }
            }
            double p1Percentage = p1 * doubleConverter / n * 100;
            double p2Percentage = p2 * doubleConverter / n * 100;
            double p3Percentage = p3 * doubleConverter / n * 100;

            Console.WriteLine($"{p1Percentage:f2}%");
            Console.WriteLine($"{p2Percentage:f2}%");
            Console.WriteLine($"{p3Percentage:f2}%");
        }
    }
}
