using System;
using System.Security.Cryptography;

namespace Histogram
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            double doubleConverter = 1;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1++;
                }
                else if (200 <= num && num <= 399)
                {
                    p2++;
                }
                else if (400 <= num && num <= 599)
                {
                    p3++;
                }
                else if (600 <= num && num <= 799)
                {
                    p4++;
                }
                else if (num >= 800)
                {
                    p5++;
                }
            }
            double p1Percentage = p1 * doubleConverter / n * 100;
            double p2Percentage = p2 * doubleConverter / n * 100;
            double p3Percentage = p3 * doubleConverter / n * 100;
            double p4Percentage = p4 * doubleConverter / n * 100;
            double p5Percentage = p5 * doubleConverter / n * 100;

            Console.WriteLine($"{p1Percentage:f2}%");
            Console.WriteLine($"{p2Percentage:f2}%");
            Console.WriteLine($"{p3Percentage:f2}%");
            Console.WriteLine($"{p4Percentage:f2}%");
            Console.WriteLine($"{p5Percentage:f2}%");
        }
    }
}
