using System;

namespace Half_Sum_Element
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > maxNum)
                {
                    maxNum = num;
                }
            }
            int sumWithoutMaxNum = sum - maxNum;
            if (maxNum == sumWithoutMaxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumWithoutMaxNum}");
            }
            else
            {
                int difference = Math.Abs(maxNum - sumWithoutMaxNum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {difference}");
            }
        }
    }
}
