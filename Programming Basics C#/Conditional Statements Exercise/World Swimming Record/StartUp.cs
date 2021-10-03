using System;

namespace World_Swimming_Record
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double worldRecordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double secondsNeededForOneMeter = double.Parse(Console.ReadLine());
            double delayInSeconds = (Math.Floor(distanceInMeters / 15)) * (12.5);
            double totalTimeNeededbyIvan = (distanceInMeters * secondsNeededForOneMeter) + delayInSeconds;
            if (totalTimeNeededbyIvan < worldRecordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTimeNeededbyIvan:f2} seconds.");
            }
            else if (totalTimeNeededbyIvan >= worldRecordInSeconds)
            {
                Console.WriteLine($"No, he failed! He was {(totalTimeNeededbyIvan - worldRecordInSeconds):f2} seconds slower.");
            }
        }
    }
}
